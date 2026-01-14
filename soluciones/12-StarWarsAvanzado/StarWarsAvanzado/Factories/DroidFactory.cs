using StarWarsBasico.Models;

namespace StarWarsBasico.Factories;

/// <summary>
///     Factory para crear droides aleatorios.
/// </summary>
public static class DroidFactory {
    /// <summary>
    ///     Crea un droide aleatorio basado en probabilidades predefinidas.
    /// </summary>
    /// <returns>Un droide aleatorio.</returns>
    public static Droid RandomDroid() {
        var random = new Random().Next(1, 101);
        return random switch {
            <= 20 => new Sw348(50, new Random().Next(9, 13)),
            <= 60 => new Sw447(100, new Random().Next(5, 11)),
            <= 80 => new Sw421(new Random().Next(100, 151), new Random().Next(10, 31)),
            _ => new Sw6969(200, 7, 20)
        };
    }
}