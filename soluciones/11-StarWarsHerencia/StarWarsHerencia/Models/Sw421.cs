namespace StarWarsBasico.Models;

/// <summary>
///     Clase que representa un Droid de Star Wars 421.
/// </summary>
/// <param name="maxEnergy">Energía Máxima</param>
/// <param name="velocity">Velocidad de Escape</param>
public sealed class Sw421(int maxEnergy, int velocity) : Droid(maxEnergy) {
    public int Velocity { get; set; } = velocity;
    public override string Color => "⚪";

    public override string ToString() {
        return
            $"Droid({Color}  id={Id}, maxEnergy={MaxEnergy}, velocity={Velocity}, createdAt={CreatedAt.ToString("O", Configuration.Culture)})";
    } 

    /// <summary>
    ///     Acción de moverse solo para droides tipo SW421.
    /// </summary>
    /// <returns>Si escapa o no</returns>
    public bool Move() {
        Console.WriteLine($"Este droide se mueve con velocidad {Velocity}");
        return new Random().Next(1, 101) <= Velocity;
    }
}