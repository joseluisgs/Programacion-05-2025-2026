namespace EquipoFutbol.Models;

/// <summary>
///     Implementación del rol de portero en el equipo de fútbol.
/// </summary>
public class RolPortero(int dorsal = 1) : IRolPortero {
    public int Dorsal { get; } = dorsal;

    public void Parar() {
        Console.WriteLine("Portero: Parando");
    }

    public void Entrenar() {
        Console.WriteLine("Portero: Entrenando");
    }

    public override string ToString() {
        return $" soy un Portero con dorsal {Dorsal}";
    }
}