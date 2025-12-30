namespace HerenciaAcoplamiento.Models;

public interface IVolador {
    public void Volar();

    public void Aterrizar() {
        Console.WriteLine("El objeto con IVolador está aterrizando.");
    }
}