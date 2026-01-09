namespace HerenciaBase.Models;

public class Vehiculo {
    public Vehiculo(string marca) {
        Marca = marca;
        Console.WriteLine("Constructor Vehiculo");
    }

    public string Marca { get; set; }

    public virtual void Arrancar() {
        Console.WriteLine("Vehículo arrancando genéricamente.");
    }
}