// See https://aka.ms/new-console-template for more information


using System.Text;
using StarWarsBasico;
using StarWarsBasico.Models;
using StarWarsBasico.Services;

Title = "Star Wars: El desafío de los Sith de DAW";
OutputEncoding = Encoding.UTF8;
Clear();

Main(args);

WriteLine("\n👋 Presiona una tecla para salir...");
ReadKey();
return;

void Main(string[] args) {
    WriteLine("----------------------------------------------------");
    WriteLine(" ⭐ Star Wars: El desafío de los Sith de DAW ⭐");
    WriteLine("----------------------------------------------------");
    WriteLine();
    WriteLine("¡Qué la fuerza te acompañe en esta aventura espacial!");
    WriteLine();
    WriteLine("\nPulse una tecla para iniciar la simulación...");
    ReadKey();


    Configuration.ParseArguments(args);

    var strikeService = new StrikeShipService(
        Configuration.MapSize,
        Configuration.NumberOfEnemies,
        Configuration.Time
    );
    strikeService.Simulate();
    WriteLine();
    PrintReport(strikeService.Report);
}

void PrintReport(Report report) {
    WriteLine("Tamaño del Mapa: " + report.MapSize);
    WriteLine("Tiempo de simulación: " + report.TimeMax);
    WriteLine("Número de enemigos: " + report.NumberOfEnemies);
    WriteLine("Número de disparos: " + report.NumberOfShots);
    WriteLine("Número de aciertos: " + report.NumberOfHits);
    WriteLine("Rendimiento: " + report.Performance);
    WriteLine("Número de enemigos restantes: " + report.NumberOfLeftEnemies);
    WriteLine("Número de enemigos muertos: " + report.NumberOfDeadEnemies);
    WriteLine("Enemigos:");
    for (var i = 0; i < report.OrderedEnemiesByEnergy.Length; i++)
        WriteLine($"Enemigo {i + 1}: {report.OrderedEnemiesByEnergy[i]}");
    WriteLine();
}