namespace StarWarsBasico.Models;

/// <summary>
///     Clase que representa un Droid de Star Wars 348.
/// </summary>
/// <param name="maxEnergy">Energía Máxima</param>
/// <param name="defense">Nivel de Defensa</param>
public sealed class Sw348(int maxEnergy, int defense) : Droid(maxEnergy), IDefensa {
    public override string Simbolo => "🔴";


    public int Defense { get; set; } = defense;

    /// <summary>
    ///     Acción de defenderse solo para droides tipo SW348.
    /// </summary>
    /// <param name="damage">Daño que recibirá</param>
    /// <returns>Daño final</returns>
    public int Defend(int damage) {
        Console.WriteLine($"Droide Sw348-{Id} trata de defenderse con defensa: {Defense}");
        return Math.Min(damage, Defense);
    }

    public override string ToString() {
        return
            $"Droid-Sw348({Simbolo}  id={Id}, maxEnergy={MaxEnergy}, defense={Defense}, createdAt={CreatedAt.ToString("O", Configuration.Culture)})";
    }
}