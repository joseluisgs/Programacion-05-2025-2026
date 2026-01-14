namespace EquipoFutbol.Models;
/// <summary>
/// Representa el rol de entrenador en el equipo de fútbol.
/// </summary>
public interface IEntrenador : IRol
{
    /// <summary>
    /// Realiza la acción de alinear el equipo.
    /// </summary>
    void AlinearEquipo();
}
