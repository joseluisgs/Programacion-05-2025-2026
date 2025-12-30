namespace StarWarsBasico.Models;

/// <summary>
///     Representa un droide en el universo de Star Wars.
/// </summary>
public abstract class Droid {
    private static int _nextId = 1;

    protected readonly DateTime CreatedAt = DateTime.Now;

    /// <summary>
    ///     Constructor que inicializa el ID del droide y establece la energía máxima.
    /// </summary>
    /// <param name="maxEnergy">Energía Máxima</param>
    protected Droid(int maxEnergy) {
        MaxEnergy = maxEnergy;
        Id = _nextId++;
    }

    public virtual string Simbolo => "❓";

    protected int Id { get; }


    public int MaxEnergy {
        get => field >= 0 ? field : 0;
        set => field = value >= 0 ? value : 0;
    }

    public bool IsAlive => MaxEnergy > 0;
}