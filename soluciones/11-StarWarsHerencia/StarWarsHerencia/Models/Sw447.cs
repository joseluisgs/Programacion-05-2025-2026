namespace StarWarsBasico.Models;

/// <summary>
///     Clase que representa un Droid de Star Wars 447.
/// </summary>
/// <param name="maxEnergy">Energía Máxima</param>
/// <param name="shield">Nivel del Escudo de Defensa</param>
public sealed class Sw447(int maxEnergy, int shield) : Droid(maxEnergy) {
    public int Shield { get; } = shield;

    public override string Color => "🔵";

    public override string ToString() {
        return
            $"Droid({Color}  id={Id}, maxEnergy={MaxEnergy}, shield={Shield}, createdAt={CreatedAt.ToString("O", Configuration.Culture)})";
    }


    /// <summary>
    ///     Usa el escudo para mitigar el daño recibido.
    /// </summary>
    /// <param name="damage">Daño que recibirá</param>
    /// <returns>Daño final</returns>
    public int UsingShield(int damage) {
        return Shield > damage ? 0 : damage - Shield;
    }
}