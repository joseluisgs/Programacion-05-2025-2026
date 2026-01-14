// See https://aka.ms/new-console-template for more information


using System.Text;
using StarWarsBasico;
using StarWarsBasico.Models;
using StarWarsBasico.Services;

Console.Title = "Star Wars: El desafío de los Sith de DAW";
Console.OutputEncoding = Encoding.UTF8;
Console.Clear();

Main(args);

Console.WriteLine("\n👋 Presiona una tecla para salir...");
Console.ReadKey();
return;

void Main(string[] args) {
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine(" ⭐ Star Wars: El desafío de los Sith de DAW ⭐");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("¡Qué la fuerza te acompañe en esta aventura espacial!");
    Console.WriteLine();
    Console.WriteLine("\nPulse una tecla para iniciar la simulación...");
    Console.ReadKey();


    Configuration.ParseArguments(args);

    var strikeService = new StrikeShipService(
        Configuration.MapSize,
        Configuration.NumberOfEnemies,
        Configuration.Time
    );
    strikeService.Simulate();
    Console.WriteLine();
    PrintReport(strikeService.Report);
}

void PrintReport(Report report) {
    Console.WriteLine("Tamaño del Mapa: " + report.MapSize);
    Console.WriteLine("Tiempo de simulación: " + report.TimeMax);
    Console.WriteLine("Número de enemigos: " + report.NumberOfEnemies);
    Console.WriteLine("Número de disparos: " + report.NumberOfShots);
    Console.WriteLine("Número de aciertos: " + report.NumberOfHits);
    Console.WriteLine("Rendimiento: " + report.Performance);
    Console.WriteLine("Número de enemigos restantes: " + report.NumberOfLeftEnemies);
    Console.WriteLine("Número de enemigos muertos: " + report.NumberOfDeadEnemies);
    Console.WriteLine("Enemigos:");
    for (var i = 0; i < report.OrderedEnemiesByEnergy.Length; i++)
        Console.WriteLine($"Enemigo {i + 1}: {report.OrderedEnemiesByEnergy[i]}");
    Console.WriteLine();
}