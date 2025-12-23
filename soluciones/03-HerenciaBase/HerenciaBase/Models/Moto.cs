namespace HerenciaBase.Models;

// / Llama explícitamente al constructor de la base
public class Moto(string marca, string tipo) : Vehiculo(marca) {
    public string Cilindrada { get; set; }


    // Muchas veces es útil llamar al método de la clase base
    // Y ampliarlo con funcionalidad específica
    public override void Arrancar() {
        base.Arrancar();
        Console.WriteLine("La moto arranca");
    }
}