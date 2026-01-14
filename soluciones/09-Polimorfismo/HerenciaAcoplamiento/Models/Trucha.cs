namespace HerenciaAcoplamiento.Models;

public class Trucha : INadador {
    public void Nadar() {
        Console.WriteLine("La trucha nada feliz.");
    }

    public void Saltar() {
        Console.WriteLine("La trucha salta fuera del agua.");
    }
}