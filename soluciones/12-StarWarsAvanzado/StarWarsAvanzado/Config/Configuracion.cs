using System.Globalization;

namespace StarWarsBasico;

/// <summary>
///     Clase de configuración del juego.
/// </summary>
public static class Configuration {
    public static CultureInfo Culture = new("es-ES");
    public static int MapSize { get; private set; }
    public static int NumberOfEnemies { get; private set; }
    public static int Time { get; private set; }

    /// <summary>
    ///     Parsea y valida los argumentos de la línea de comandos.
    /// </summary>
    public static void ParseArguments(string[] args) {
        if (args.Length != 3) ShowError();
        int mapSize = int.TryParse(args[0], out mapSize) ? mapSize : -1;
        int numEnemies = int.TryParse(args[1], out numEnemies) ? numEnemies : -1;
        int time = int.TryParse(args[2], out time) ? time : -1;
        if (!(mapSize >= 5 && mapSize <= 9) ||
            !(numEnemies >= 5 && numEnemies <= 30) ||
            !(time >= 1 && time <= 3))
            ShowError();
        MapSize = mapSize;
        NumberOfEnemies = numEnemies;
        Time = time;
    }

    /// <summary>
    ///     Muestra un mensaje de error y termina la ejecución.
    /// </summary>
    private static void ShowError() {
        Console.WriteLine("Error: Parámetros inválidos.");
        Console.WriteLine("Uso: dotnet run <mapSize> <numberOfEnemies> <time>");
        Console.WriteLine("Example: dotnet run 5 15 3");
        Environment.Exit(-1);
    }
}