namespace StarWarsBasico.Models;

public class RolSw421(int velocity) : IMovimiento {
    public int Velocity { get; set; } = velocity;

    public string Simbolo => "⚪";

    public bool Move() {
        WriteLine($"Droide Sw421 se mueve con velocidad {Velocity}");
        return new Random().Next(1, 101) <= Velocity;
    }
}