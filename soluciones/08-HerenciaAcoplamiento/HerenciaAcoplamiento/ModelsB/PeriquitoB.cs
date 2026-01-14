namespace HerenciaAcoplamiento.ModelsB;

public class PeriquitoB : PajaroB, IVolador {
    public void Volar() {
        Console.WriteLine("El periquito vuela.");
    }
}