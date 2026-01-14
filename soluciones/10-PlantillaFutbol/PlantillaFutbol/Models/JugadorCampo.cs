namespace PlantillaFutbol.Models;

public class JugadorCampo : Jugador {
    public required int Velocidad { get; set; }
    public required int Resistencia { get; set; }
    public required int Destrezas { get; set; }

    public override void Entrenar() {
        Console.WriteLine("El jugador de campo está entrenando su velocidad, resistencia y destrezas.");
    }

    public void Correr() {
        Console.WriteLine("El jugador de campo está corriendo por el campo.");
    }
}