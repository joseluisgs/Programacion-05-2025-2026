namespace EquipoFutbol.Models;

/// <summary>
///     Representa un portero en el equipo de fútbol. Hereda de Jugador.
/// </summary>
public class Portero(string nombre, int dorsal) : Jugador(nombre, new RolPortero(dorsal)) {
    /// <summary>
    ///     Obtiene el rol actual como IRolPortero.
    /// </summary>
    public IRolPortero Role => (IRolPortero)Rol;

    /// <summary>
    ///     Realiza la acción de parar el balón.
    /// </summary>
    public void Parar() {
        ((IRolPortero)Rol).Parar();
    }

    /// <summary>
    ///     Permite cambiar el rol del portero.
    /// </summary>
    public override void CambiarRol(IRolJugador nuevoRol) {
        base.CambiarRol(nuevoRol);
    }
}