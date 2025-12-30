namespace StarWarsBasico.Models;

/// <summary>
///     Interfaz que define el comportamiento de movimiento para droides en el universo de Star Wars.
///     Proporciona una propiedad para la velocidad y un método para realizar la acción de moverse.
/// </summary>
public interface IMovimiento {
    public int Velocity { get; set; }

    /// <summary>
    ///     Acción de moverse solo para droides tipo SW421.
    /// </summary>
    /// <returns>Si escapa o no</returns>
    public bool Move();
}