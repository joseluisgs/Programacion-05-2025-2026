namespace StarWarsBasico.Models;

public class RolSw6969(int defense, int velocity) : IDefensa, IMovimiento {
    public int Defense { get; set; } = defense;

    public string Simbolo => "🛸";


    public int Defend(int damage) {
        WriteLine($"Droide Sw6969 trata de defenderse con defensa: {Defense}");
        return Math.Min(damage, Defense);
    }


    public int Velocity { get; set; } = velocity;

    /// <summary>
    ///     Acción de moverse solo para droides tipo SW421.
    /// </summary>
    /// <returns>Si escapa o no</returns>
    public bool Move() {
        WriteLine($"Droide Sw6969 se mueve con velocidad {Velocity}");
        return new Random().Next(1, 101) <= Velocity;
    }

    /// <summary>
    ///     Acción de explotar solo para droides tipo SW6969.
    /// </summary>
    public bool Explode() {
        var random = new Random().Next(1, 101);
        if (random <= 30) {
            WriteLine("Droide 6969 explota");
            return true;
        }

        WriteLine("Droide 6969 no explota");
        return false;
    }
}