namespace HerenciaAcoplamiento.ModelsB;

public abstract class PajaroB {
    public required string Nombre { get; set; }
    public required string Dieta { get; set; }

    public virtual void Comer() {
        Console.WriteLine($"El pajaro está comiendo {Dieta}");
    }
}