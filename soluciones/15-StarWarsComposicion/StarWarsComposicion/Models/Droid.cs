namespace StarWarsBasico.Models;

/// <summary>
///     Representa un droide en el universo de Star Wars.
/// </summary>
public class Droid {
    private static int _nextId = 1;

    protected readonly DateTime CreatedAt = DateTime.Now;

    /// <summary>
    ///     Constructor que inicializa el ID del droide y establece la energía máxima.
    /// </summary>
    /// <param name="maxEnergy">Energía Máxima</param>
    /// <param name="rol">Rol</param>
    public Droid(int maxEnergy, IRol rol) {
        MaxEnergy = maxEnergy;
        Rol = rol;
        Id = _nextId++;
    }

    public virtual string Simbolo => Rol.Simbolo;

    protected int Id { get; }


    public int MaxEnergy {
        get => field >= 0 ? field : 0;
        set => field = value >= 0 ? value : 0;
    }

    public IRol Rol { get; set; }

    public bool IsAlive => MaxEnergy > 0;

    public override string ToString() {
        return Rol switch {
            RolSw348 rolSw348 =>
                $"Droid-{Rol.GetType().Name}({Simbolo}  id={Id}, maxEnergy={MaxEnergy}, defense={rolSw348.Defense}, createdAt={CreatedAt.ToString("O", Configuration.Culture)})",
            RolSw447 rolSw447 =>
                $"Droid-{Rol.GetType().Name}({Simbolo}  id={Id}, maxEnergy={MaxEnergy}, shield={rolSw447.Shield}, createdAt={CreatedAt.ToString("O", Configuration.Culture)})",
            RolSw421 rolSw421 =>
                $"Droid-{Rol.GetType().Name}({Simbolo}  id={Id}, maxEnergy={MaxEnergy}, speed={rolSw421.Velocity}, createdAt={CreatedAt.ToString("O", Configuration.Culture)})",
            RolSw6969 rolSw6969 =>
                $"Droid-{Rol.GetType().Name}({Simbolo}  id={Id}, maxEnergy={MaxEnergy}, defense={rolSw6969.Defense}, velocity={rolSw6969.Velocity} createdAt={CreatedAt.ToString("O", Configuration.Culture)})",
            _ =>
                $"Droid-{Rol.GetType().Name}({Simbolo}  id={Id}, maxEnergy={MaxEnergy}, createdAt={CreatedAt.ToString("O", Configuration.Culture)})"
        };
    }
}