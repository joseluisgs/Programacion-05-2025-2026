namespace PlantillaFutbol.Models;

public class Entrenador : Persona, IEntrenar {
    public required int Experiencia { get; set; }

    public virtual void Entrenar() {
        Console.WriteLine("Entrenador entrenando al equipo y dirigiendo la táctica...");
    }

    public void AjustarEstrategia(Jugador jugador) {
        Console.WriteLine($"El entrenador está ajustando la estrategia para el jugador con dorsal {jugador.Dorsal}.");
    }
}