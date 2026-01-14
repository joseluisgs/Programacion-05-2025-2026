using StarWarsBasico.Models;

namespace StarWarsBasico.Factories;

/// <summary>
///     Factory para crear droides aleatorios.
/// </summary>
public static class DroidFactory {
    public static IRol GetRandomRol() {
        var random = new Random().Next(1, 5);
        return random switch {
            1 => new RolSw348(new Random().Next(9, 13)),
            2 => new RolSw447(new Random().Next(5, 11)),
            3 => new RolSw421(new Random().Next(10, 31)),
            _ => new RolSw6969(7, 20)
        };
    }

    /// <summary>
    ///     Crea un droide aleatorio basado en probabilidades predefinidas.
    /// </summary>
    /// <returns>Un droide aleatorio.</returns>
    public static Droid RandomDroid() {
        var random = new Random().Next(1, 101);
        return random switch {
            <= 20 => new Droid(50, new RolSw348(new Random().Next(9, 13))),
            <= 60 => new Droid(100, new RolSw447(new Random().Next(5, 11))),
            <= 80 => new Droid(new Random().Next(100, 151), new RolSw421(new Random().Next(10, 31))),
            _ => new Droid(200, new RolSw6969(7, 20))
        };
    }
}