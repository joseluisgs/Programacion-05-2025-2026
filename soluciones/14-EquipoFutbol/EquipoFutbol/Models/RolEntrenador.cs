namespace EquipoFutbol.Models;
/// <summary>
/// Implementación del rol de entrenador en el equipo de fútbol.
/// </summary>
public class RolEntrenador : IEntrenador
{
    public void AlinearEquipo() => Console.WriteLine("Entrenador: Alineando equipo");
    public void Entrenar() => Console.WriteLine("Entrenador: Entrenando");
    public override string ToString() => " soy un Entrenador";
}
