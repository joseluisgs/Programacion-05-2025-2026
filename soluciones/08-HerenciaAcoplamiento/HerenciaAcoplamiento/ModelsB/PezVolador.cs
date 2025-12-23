namespace HerenciaAcoplamiento.ModelsB;

public class PezVolador : INadador, IVolador {
    public void Nadar() {
        Console.WriteLine("El pez volador nada cerca de la superficie.");
    }

    public void Volar() {
        Console.WriteLine("El pez volador salta fuera del agua y planea por el aire.");
    }
}