namespace HerenciaAcoplamiento.Models;

public class Periquito : Pajaro, IVolador {
    public void Volar() {
        Console.WriteLine("El periquito vuela.");
    }

    public void Piar() {
        Console.WriteLine("El periquito pía.");
    }
}