namespace StarWarsBasico.Models;

/// <summary>
///     Clase que representa un Droid de Star Wars 6969.
/// </summary>
/// <param name="maxEnergy">Energía Máxima</param>
/// <param name="defense">Defensa</param>
/// <param name="velocity">Velocidad de Escape</param>
public sealed class Sw6969(int maxEnergy, int defense, int velocity) : Droid(maxEnergy), IDefensa, IMovimiento {
    public override string Simbolo => "🛸";

    public int Defense { get; set; } = defense;

    /// <summary>
    ///     Acción de defenderse solo para droides tipo SW348.
    /// </summary>
    /// <param name="damage">Daño que recibirá</param>
    /// <returns>Daño final</returns>
    public int Defend(int damage) {
        Console.WriteLine($"Droide Sw6969-{Id} trata de defenderse con defensa: {Defense}");
        return Math.Min(damage, Defense);
    }

    public int Velocity { get; set; } = velocity;

    /// <summary>
    ///     Acción de moverse solo para droides tipo SW421.
    /// </summary>
    /// <returns>Si escapa o no</returns>
    public bool Move() {
        Console.WriteLine($"Droide Sw6969-{Id} se mueve con velocidad {Velocity}");
        return new Random().Next(1, 101) <= Velocity;
    }

    /// <summary>
    ///     Acción de explotar solo para droides tipo SW6969.
    /// </summary>
    public void Explode() {
        var random = new Random().Next(1, 101);
        if (random <= 30) {
            Console.WriteLine($"Droide 6969-{Id} explota");
            MaxEnergy = 0;
        }
        else {
            Console.WriteLine($"Droide 6969-{Id} no explota");
        }
    }

    public override string ToString() {
        return
            $"Droid-SW6969({Simbolo}  id={Id}, maxEnergy={MaxEnergy}, defense={Defense}, velocity={Velocity} createdAt={CreatedAt.ToString("O", Configuration.Culture)})";
    }
}