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
            <= 30 => new Sw348(50, new Random().Next(9, 13)),
            <= 80 => new Sw447(100, new Random().Next(5, 11)),
            _ => new Sw421(new Random().Next(100, 151), new Random().Next(10, 31))
        };
    }
}