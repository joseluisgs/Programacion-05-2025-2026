namespace PlantillaFutbol.Models;

public class Portero : Jugador {
    public required int Reflejos { get; set; }

    public override void Entrenar() {
        Console.WriteLine("El portero está entrenando sus reflejos y habilidades de parada.");
    }

    public void Atajar() {
        Console.WriteLine("El portero está atajando un disparo.");
    }
}