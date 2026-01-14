namespace StarWarsBasico.Models;

/// <summary>
///     Informe de la simulación del combate espacial.
/// </summary>
public record Report(
    int MapSize,
    int NumberOfEnemies,
    int TimeMax,
    int NumberOfShots,
    int NumberOfHits,
    double Performance,
    int NumberOfLeftEnemies,
    int NumberOfDeadEnemies,
    Droid[] OrderedEnemiesByEnergy
);