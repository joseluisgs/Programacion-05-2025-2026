namespace StarWarsBasico.Models;

/// <summary>
///     Clase que representa un Droid de Star Wars 348.
/// </summary>
/// <param name="maxEnergy">Energía Máxima</param>
/// <param name="defense">Nivel de Defensa</param>
public sealed class Sw348(int maxEnergy, int defense) : Droid(maxEnergy) {
    public int Defense { get; } = defense;

    public override string Color => "🔴";

    public override string ToString() {
        return
            $"Droid({Color}  id={Id}, maxEnergy={MaxEnergy}, defense={Defense}, createdAt={CreatedAt.ToString("O", Configuration.Culture)})";
    }


    /// <summary>
    ///     Acción de defenderse solo para droides tipo SW348.
    /// </summary>
    /// <param name="damage">Daño que recibirá</param>
    /// <returns>Daño final</returns>
    public int Defend(int damage) {
        Console.WriteLine($"Enemigo trata de defenderse con defensa: {Defense}");
        return Math.Min(damage, Defense);
    }
}