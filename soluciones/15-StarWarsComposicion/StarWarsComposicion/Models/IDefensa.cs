namespace StarWarsBasico.Models;

/// <summary>
///     Interfaz que define el comportamiento de defensa para droides en el universo de Star Wars.
///     Específicamente, proporciona una propiedad para el nivel de defensa y un método para calcular el daño recibido
///     después de aplicar la defensa.
/// </summary>
public interface IDefensa : IRol {
    public int Defense { get; set; }

    /// <summary>
    ///     Calcula el daño recibido por el droide después de aplicar la defensa.
    /// </summary>
    /// <param name="damage">El daño recibido por el droide.</param>
    /// <returns>El daño recibido después de aplicar la defensa.</returns>
    public int Defend(int damage);
}