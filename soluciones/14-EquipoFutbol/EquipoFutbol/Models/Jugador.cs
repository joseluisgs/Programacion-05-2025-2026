namespace EquipoFutbol.Models;

/// <summary>
///     Representa un jugador en el equipo de fútbol. Hereda de Persona.
/// </summary>
public abstract class Jugador(string nombre, IRolJugador role) : Persona(nombre, role) {
    /// <summary>
    ///     Permite cambiar el rol del jugador.
    /// </summary>
    public virtual void CambiarRol(IRolJugador nuevoRol) {
        Rol = nuevoRol;
    }
}