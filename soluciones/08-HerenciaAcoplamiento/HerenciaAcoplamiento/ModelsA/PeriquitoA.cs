using HerenciaAcoplamiento.Models;

namespace HerenciaAcoplamiento.ModelsA;

public class PeriquitoA : PajaroA {
    public override void Volar() {
        Console.WriteLine("El periquito está volando.");
    }
}