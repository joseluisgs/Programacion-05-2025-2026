namespace HerenciaAcoplamiento.Models;

public abstract class PajaroA {
    public required string Nombre { get; set; }
    public required string Dieta { get; set; }
    public virtual void Volar() {
        Console.WriteLine("El pajaro está volando");
    }
    
    public virtual void Comer() {
        Console.WriteLine($"El pajaro está comiendo {Dieta}");
    }
}