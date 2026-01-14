namespace HerenciaSealed.Models;

// Clase base abstracta
public abstract class Vehiculo { }

// Subclases selladas que representan cada tipo concreto
internal sealed class Coche : Vehiculo {
    public Coche(string marca) {
        Marca = marca;
    }

    public string Marca { get; }
}

internal sealed class Camion : Vehiculo {
    public Camion(int capacidadCargaKg) {
        CapacidadCargaKg = capacidadCargaKg;
    }

    public int CapacidadCargaKg { get; }
}

internal sealed class Moto : Vehiculo {
    public Moto(int cilindrada) {
        Cilindrada = cilindrada;
    }

    public int Cilindrada { get; }
}