namespace EquipoFutbol.Models;
/// <summary>
/// Representa un rol de jugador en el equipo de fútbol.
/// </summary>
public interface IRolJugador : IRol
{
    /// <summary>
    /// Número de dorsal del jugador.
    /// </summary>
    int Dorsal { get; }
}
