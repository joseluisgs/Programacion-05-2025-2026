namespace StarWarsBasico.Models;

public class RolSw447(int shield) : IEscudo {
    public int Shield { get; } = shield;

    public string Simbolo => "🔵";

    public int UsingShield(int damage) {
        WriteLine($"Droide Sw447 usa su escudo: {Shield}");
        return Shield > damage ? 0 : damage - Shield;
    }
}