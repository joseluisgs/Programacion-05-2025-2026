namespace StarWarsBasico.Models;

/// <summary>
///     Representa un droide en el universo de Star Wars.
/// Debemos usar nulos porque no todos los droides tienen todas las propiedades.
/// </summary>
public class Droid {
    /// <summary>
    ///     Tipos de droides disponibles.
    /// </summary>
    public enum DroidType {
        Sw348,
        Sw447,
        Sw421
    }

    private static int _nextId = 1;

    private readonly DateTime _createdAt = DateTime.Now;

    public Droid(int maxEnergy, DroidType type, int? defense, int? shield, int? velocity) {
        MaxEnergy = maxEnergy;
        Type = type;
        Defense = defense;
        Shield = shield;
        Velocity = velocity;
        Id = _nextId++;
    }

    public int Id { get; init; }

    public int? Defense { get; set; }

    public int MaxEnergy {
        get => field >= 0 ? field : 0;
        set => field = value >= 0 ? value : 0;
    }

    public int? Shield { get; set; }
    public DroidType Type { get; set; }
    public int? Velocity { get; set; }

    public string Color =>
        Type switch {
            DroidType.Sw348 => "🔴",
            DroidType.Sw447 => "🔵",
            DroidType.Sw421 => "⚪",
            _ => "❓"
        };

    public bool IsAlive => MaxEnergy > 0;

    public override string ToString() {
        return
            $"Droid(id={Id}, maxEnergy={MaxEnergy}, type={Type}, defense={Defense}, shield={Shield}, velocity={Velocity}, createdAt={_createdAt.ToString("O", Configuration.Culture)})";
    }

    /// <summary>
    ///     Acción de usar escudo solo para droides tipo SW447.
    /// </summary>
    /// <param name="damage">Daño que recibirá</param>
    /// <returns>Daño final</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public int UsingShield(int damage) {
        if (Type != DroidType.Sw447 || !Shield.HasValue)
            throw new InvalidOperationException("Este tipo de droide no puede usar escudo");
        return Shield.Value > damage ? 0 : damage - Shield.Value;
    }

    /// <summary>
    ///     Acción de defenderse solo para droides tipo SW348.
    /// </summary>
    /// <param name="damage">Daño que recibirá</param>
    /// <returns>Daño final</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public int Defend(int damage) {
        if (Type != DroidType.Sw348 || !Defense.HasValue)
            throw new InvalidOperationException("Este tipo de droide no puede defenderse");
        Console.WriteLine($"Enemigo trata de defenderse con defensa: {Defense.Value}");
        return Math.Min(damage, Defense.Value);
    }

    /// <summary>
    ///     Acción de moverse solo para droides tipo SW421.
    /// </summary>
    /// <returns>Si escapa o no</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public bool Move() {
        if (Type != DroidType.Sw421 || !Velocity.HasValue)
            throw new InvalidOperationException("Este tipo de droide no puede moverse");
        Console.WriteLine($"Este droide se mueve con velocidad {Velocity.Value}");
        return new Random().Next(1, 101) <= Velocity.Value;
    }
}