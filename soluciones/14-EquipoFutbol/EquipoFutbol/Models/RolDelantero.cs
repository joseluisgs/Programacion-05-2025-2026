namespace EquipoFutbol.Models;

/// <summary>
///     Implementación del rol de delantero en el equipo de fútbol.
/// </summary>
public class RolDelantero(int dorsal = 1) : IRolDelantero {
    public int Dorsal { get; } = dorsal;

    public void Marcar() {
        Console.WriteLine("Delantero: Marcando");
    }

    public void Entrenar() {
        Console.WriteLine("Delantero: Entrenando");
    }

    public override string ToString() {
        return $" soy un Delantero con dorsal {Dorsal}";
    }
}