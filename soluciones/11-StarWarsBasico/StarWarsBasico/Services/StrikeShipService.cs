using StarWarsBasico.Factories;
using StarWarsBasico.Models;

namespace StarWarsBasico.Services;

/// <summary>
///     Servicio principal para la simulación del ataque a la nave enemiga.
/// </summary>
public class StrikeShipService {
    private readonly Droid[] _enemies;
    private readonly Droid?[,] _map;
    private readonly int _mapSize; // Esta vez por constructor de la clase
    private readonly int _numberOfEnemies; // Esta vez por constructor de la clase
    private readonly int _timeMax; // Esta vez por constructor de la clase
    private int _numberOfHits;
    private int _numberOfShots;

    /// <summary>
    ///     Constructor del servicio de ataque a la nave enemiga.
    /// </summary>
    /// <param name="mapSize">Mapa del espacio</param>
    /// <param name="numberOfEnemies">Número de enemigos</param>
    /// <param name="timeMax">Tiempo máximo</param>
    public StrikeShipService(int mapSize, int numberOfEnemies, int timeMax) {
        _mapSize = mapSize;
        _numberOfEnemies = numberOfEnemies;
        _timeMax = timeMax;
        _map = new Droid?[mapSize, mapSize];
        _enemies = new Droid[numberOfEnemies];
        for (var i = 0; i < numberOfEnemies; i++)
            _enemies[i] = DroidFactory.RandomDroid();
    }

    private int LeftEnemies => _numberOfEnemies - DeadEnemies;
    private int DeadEnemies => GetTotalDeadEnemies();
    private double Performance => GetTotalPerformance();

    /// <summary>
    ///     Obtiene el reporte final de la simulación.
    /// </summary>
    public Report Report =>
        new(
            _mapSize,
            _numberOfEnemies,
            _timeMax,
            _numberOfShots,
            _numberOfHits,
            Performance,
            LeftEnemies,
            DeadEnemies,
            OrderEnemies()
        );

    /// <summary>
    ///     Simula el ataque de los droides a la nave enemiga.
    /// </summary>
    public void Simulate() {
        var time = 0;
        PlaceEnemies();
        PrintMap();
        var rnd = new Random();

        while (LeftEnemies > 0 && time < _timeMax * 1000) {
            Console.WriteLine($"Tiempo: {time}");
            Console.WriteLine($"Enemigos: {LeftEnemies}");

            if (time % 300 == 0) {
                Console.WriteLine("Enemigos se reubican en el espacio...");
                PlaceEnemies();
            }

            Thread.Sleep(100);
            time += 100;

            var shotValue = GiveMeAShot();
            _numberOfShots++;

            var row = rnd.Next(0, _mapSize);
            var col = rnd.Next(0, _mapSize);

            if (_map[row, col] is { } enemy) {
                Console.WriteLine($"Tiene un enemigo en: {row + 1}, {col + 1}");
                _numberOfHits++;
                var effectiveDamage = 0;
                Console.WriteLine("Enemy before atack: " + enemy);

                switch (enemy.Type) {
                    case Droid.DroidType.Sw348:
                        Console.WriteLine("El enemigo está intentando defenderse...");
                        effectiveDamage = enemy.Defend(shotValue);
                        break;
                    case Droid.DroidType.Sw447:
                        Console.WriteLine($"El enemigo esta usando su escudo: {enemy.Shield}");
                        effectiveDamage = enemy.UsingShield(shotValue);
                        break;
                    case Droid.DroidType.Sw421: {
                        if (!enemy.Move()) {
                            Console.WriteLine("El enemigo no ha podido escapar.");
                            effectiveDamage = shotValue;
                        }

                        break;
                    }
                }

                enemy.MaxEnergy -= effectiveDamage;
                Console.WriteLine($"Daño efectivo: {effectiveDamage}");
                Console.WriteLine("Estado del enemigo tras el ataque: " + enemy);
            }
            else {
                Console.WriteLine("¡Disparo en el vacío!");
            }

            PrintMap();
        }
    }

    /// <summary>
    ///     Obtiene el valor del disparo, pudiendo ser crítico o normal.
    /// </summary>
    /// <returns>Valor del disparo</returns>
    private int GiveMeAShot() {
        if (new Random().Next(0, 101) <= 15) {
            Console.WriteLine("¡Has conseguido un disparo crítico!");
            return 50;
        }

        Console.WriteLine("Disparo normal.");
        return 25;
    }

    /// <summary>
    ///     Coloca los enemigos aleatoriamente en el mapa.
    /// </summary>
    private void PlaceEnemies() {
        // Limpiar el mapa
        for (var row = 0; row < _mapSize; row++)
            for (var col = 0; col < _mapSize; col++)
                _map[row, col] = null;

        var maxEnemiesToStored = Math.Min(_mapSize * _mapSize, LeftEnemies);
        int storedEnemies = 0, enemiesIndex = 0;
        var rnd = new Random();
        // Añadir enemigos al mapa hasta alcanzar el máximo permitido o hasta que todos hayan sido almacenados
        while (storedEnemies < maxEnemiesToStored) {
            while (enemiesIndex < _enemies.Length && !_enemies[enemiesIndex].IsAlive)
                enemiesIndex++;
            var isStored = false;
            do {
                var row = rnd.Next(0, _mapSize);
                var col = rnd.Next(0, _mapSize);
                if (_map[row, col] == null) {
                    _map[row, col] = _enemies[enemiesIndex];
                    storedEnemies++;
                    isStored = true;
                    enemiesIndex++;
                }
            } while (!isStored);
        }
    }

    /// <summary>
    ///     Obtiene el total de enemigos muertos.
    /// </summary>
    /// <returns>Número de enemigos muertos</returns>
    private int GetTotalDeadEnemies() {
        var count = 0;
        foreach (var t in _enemies)
            if (!t.IsAlive)
                count++;

        return count;
    }

    /// <summary>
    ///     Obtiene el rendimiento total del ataque.
    /// </summary>
    /// <returns>Rendimiento total en porcentaje</returns>
    private double GetTotalPerformance() {
        if (_numberOfShots == 0) return 0.0;
        var result = (double)_numberOfHits / _numberOfShots * 100;
        return Math.Round(result, 2);
    }

    /// <summary>
    ///     Ordena los enemigos por su energía máxima en orden descendente.
    /// </summary>
    private Droid[] OrderEnemies() {
        // Copio el array para no modificar el original
        var copy = new Droid[_enemies.Length];
        Array.Copy(_enemies, copy, _enemies.Length);
        // Ordenar el array de enemigos por energía máxima en orden descendente
        for (var i = 0; i < copy.Length - 1; i++)
            for (var j = 0; j < copy.Length - i - 1; j++)
                if (copy[j].MaxEnergy < copy[j + 1].MaxEnergy)
                    (copy[j], copy[j + 1]) = (copy[j + 1], copy[j]);

        return copy;
    }

    /// <summary>
    ///     Imprime el mapa actual con los droides.
    /// </summary>
    private void PrintMap() {
        for (var row = 0; row < _mapSize; row++) {
            for (var col = 0; col < _mapSize; col++) {
                var droid = _map[row, col];
                string cell;
                if (droid == null)
                    cell = "[      ]"; // 6 espacios dentro
                else
                    cell = $"[  {droid.Color}  ]"; // 2 espacios antes/después emoji
                Console.Write(cell);
            }

            Console.WriteLine();
        }
    }
}