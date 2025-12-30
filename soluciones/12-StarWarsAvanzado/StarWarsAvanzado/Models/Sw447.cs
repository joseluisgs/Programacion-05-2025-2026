namespace StarWarsBasico.Models;

/// <summary>
///     Clase que representa un Droid de Star Wars 447.
/// </summary>
/// <param name="maxEnergy">Energía Máxima</param>
/// <param name="shield">Nivel del Escudo de Defensa</param>
public sealed class Sw447(int maxEnergy, int shield) : Droid(maxEnergy), IEscudo {
    public override string Simbolo => "🔵";
    public int Shield { get; } = shield;


    /// <summary>
    ///     Usa el escudo para mitigar el daño recibido.
    /// </summary>
    /// <param name="damage">Daño que recibirá</param>
    /// <returns>Daño final</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public int UsingShield(int damage) {
        Console.WriteLine($"Droide Sw447-{Id} usa su escudo: {Shield}");
        return Shield > damage ? 0 : damage - Shield;
    }

    public override string ToString() {
        return
            $"Droid-Sw447({Simbolo}  id={Id}, maxEnergy={MaxEnergy}, shield={Shield}, createdAt={CreatedAt.ToString("O", Configuration.Culture)})";
    }
}