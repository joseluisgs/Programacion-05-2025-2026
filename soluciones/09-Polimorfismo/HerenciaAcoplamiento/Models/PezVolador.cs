namespace HerenciaAcoplamiento.Models;

public class PezVolador : INadador, IVolador {
    public void Nadar() {
        Console.WriteLine("El pez volador nada cerca de la superficie.");
    }

    public void Volar() {
        Console.WriteLine("El pez volador salta fuera del agua y planea por el aire.");
    }

    public void Burbujear() {
        Console.WriteLine("El pez volador burbujea en el agua.");
    }

    public void Aterrizar() {
        Console.WriteLine("El pez volador regresa al agua.");
    }
}