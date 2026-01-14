namespace HerenciaAcoplamiento.Models;

public class Pinguino : Pajaro, INadador {
    public void Nadar() {
        Console.WriteLine("El pinguino nada.");
    }

    public void Patinar() {
        Console.WriteLine("El pinguino patina en el hielo.");
    }
}