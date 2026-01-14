namespace EquipoFutbol.Models;
/// <summary>
/// Representa el rol de centrocampista en el equipo de fútbol.
/// </summary>
public interface IRolCentrocampista : IRolJugador
{
    /// <summary>
    /// Realiza la acción de distribuir el balón.
    /// </summary>
    void Distribuir();
}
