namespace EquipoFutbol.Models;

/// <summary>
///     Implementación del rol de defensa en el equipo de fútbol.
/// </summary>
public class RolDefensa(int dorsal = 1) : IRolDefensa {
    public int Dorsal { get; } = dorsal;

    public void Defender() {
        Console.WriteLine("Defensa: Defendiendo");
    }

    public void Entrenar() {
        Console.WriteLine("Defensa: Entrenando");
    }

    public override string ToString() {
        return $" soy un Defensa con dorsal {Dorsal}";
    }
}