namespace HerenciaSealed.Models;

// Clase base abstracta
public abstract class VehiculoB {
// Subclases selladas que representan cada tipo concreto
    internal sealed class CocheB : VehiculoB {
        public CocheB(string marca) {
            Marca = marca;
        }

        public string Marca { get; }
    }

    internal sealed class CamionB : VehiculoB {
        public CamionB(int capacidadCargaKg) {
            CapacidadCargaKg = capacidadCargaKg;
        }

        public int CapacidadCargaKg { get; }
    }

    internal sealed class MotoB : VehiculoB {
        public MotoB(int cilindrada) {
            Cilindrada = cilindrada;
        }

        public int Cilindrada { get; }
    }
}