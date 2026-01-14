using HerenciaAcoplamiento.Models;

namespace HerenciaAcoplamiento.ModelsA;

public class PinguinoA: PajaroA {
    public override void Volar() {
        throw new NotImplementedException("El pinguino no puede volar.");
    }
}