namespace StarWarsBasico.Models;

/// <summary>
///     Interfaz que define el comportamiento de un escudo para droides en el universo de Star Wars.
///     Proporciona una propiedad para el nivel del escudo y un método para usar el escudo para mitigar el daño recibido.
/// </summary>
public interface IEscudo : IRol {
    public int Shield { get; }

    /// <summary>
    ///     Usa el escudo para mitigar el daño recibido.
    /// </summary>
    /// <param name="damage">Daño que recibirá</param>
    /// <returns>Daño final</returns>
    public int UsingShield(int damage);
}