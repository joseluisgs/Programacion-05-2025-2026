namespace StarWarsBasico.Models;

public class RolSw348(int defensa) : IDefensa {
    public string Simbolo => "🔴";


    public int Defense { get; set; } = defensa;

    /// <summary>
    ///     Acción de defenderse solo para droides tipo SW348.
    /// </summary>
    /// <param name="damage">Daño que recibirá</param>
    /// <returns>Daño final</returns>
    public int Defend(int damage) {
        WriteLine($"Droide Sw348 trata de defenderse con defensa: {Defense}");
        return Math.Min(damage, Defense);
    }
}