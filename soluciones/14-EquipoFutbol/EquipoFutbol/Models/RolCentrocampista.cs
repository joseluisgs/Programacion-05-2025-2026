namespace EquipoFutbol.Models;

/// <summary>
///     Implementación del rol de centrocampista en el equipo de fútbol.
/// </summary>
public class RolCentrocampista(int dorsal = 1) : IRolCentrocampista {
    public int Dorsal { get; } = dorsal;

    public void Distribuir() {
        Console.WriteLine("Centrocampista: Distribuyendo");
    }

    public void Entrenar() {
        Console.WriteLine("Centrocampista: Entrenando");
    }

    public override string ToString() {
        return $" soy un Centrocampista con dorsal {Dorsal}";
    }
}