using StarWarsBasico.Models;

namespace StarWarsBasico.Factories;

/// <summary>
///     Factory para crear droides aleatorios.
/// </summary>
public static class DroidFactory {
    /// <summary>
    ///     Crea un droide aleatorio basado en probabilidades predefinidas.
    /// </summary>
    public static Droid RandomDroid() {
        var random = new Random().Next(1, 101);
        return random switch {
            <= 30 => new Droid(50, Droid.DroidType.Sw348, new Random().Next(9, 13), null, null),
            <= 80 => new Droid(100, Droid.DroidType.Sw447, null, new Random().Next(5, 11), null),
            _ => new Droid(new Random().Next(100, 151), Droid.DroidType.Sw421, null, null, new Random().Next(10, 31))
        };
    }
}