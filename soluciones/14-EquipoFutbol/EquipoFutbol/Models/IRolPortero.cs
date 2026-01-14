namespace EquipoFutbol.Models;
/// <summary>
/// Representa el rol de portero en el equipo de fútbol.
/// </summary>
public interface IRolPortero : IRolJugador
{
    /// <summary>
    /// Realiza la acción de parar el balón.
    /// </summary>
    void Parar();
}
