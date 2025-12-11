namespace PlantillaFutbol.Models;

public class EntrenadorPorteros : Entrenador {
    public required int Especializacion { get; set; }


    public override void Entrenar() {
        Console.WriteLine("Entrenador de porteros entrenando a los porteros...");
    }

    public void Especializar(Portero portero) {
        Console.WriteLine($"El entrenador de porteros está especializando al portero con reflejos {portero.Reflejos}.");
    }
}