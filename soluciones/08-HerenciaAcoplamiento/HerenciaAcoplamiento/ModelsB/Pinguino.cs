namespace HerenciaAcoplamiento.ModelsB;

public class PinguinoB : PajaroB, INadador {
    public void Nadar() {
        Console.WriteLine("El pinguino nada.");
    }
}