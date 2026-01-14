namespace EquipoFutbol.Models;
/// <summary>
/// Representa el rol de delantero en el equipo de fútbol.
/// </summary>
public interface IRolDelantero : IRolJugador
{
    /// <summary>
    /// Realiza la acción de marcar gol.
    /// </summary>
    void Marcar();
}
