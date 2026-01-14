namespace PlantillaFutbol.Models;

public abstract class Jugador : Persona, IEntrenar {
    public required int Dorsal { get; set; }

    public virtual void Entrenar() {
        Console.WriteLine("El jugador está entrenando para mejorar sus habilidades.");
    }

    public void Jugar() {
        Console.WriteLine("El jugador está jugando en el campo.");
    }
}