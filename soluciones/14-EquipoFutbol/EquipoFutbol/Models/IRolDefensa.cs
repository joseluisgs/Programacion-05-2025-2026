namespace EquipoFutbol.Models;
/// <summary>
/// Representa el rol de defensa en el equipo de fútbol.
/// </summary>
public interface IRolDefensa : IRolJugador
{
    /// <summary>
    /// Realiza la acción de defender.
    /// </summary>
    void Defender();
}
