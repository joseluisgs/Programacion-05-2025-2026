namespace HerenciaBase.Models;

public class Coche : Vehiculo {
    // Llama explícitamente al constructor de la base
    public Coche(string marca, string modelo) : base(marca) {
        Modelo = modelo;
        Console.WriteLine("Constructor Coche");
    }

    public string Modelo { get; set; }

    public override void Arrancar() {
        Console.WriteLine("El coche arranca");
    }
}