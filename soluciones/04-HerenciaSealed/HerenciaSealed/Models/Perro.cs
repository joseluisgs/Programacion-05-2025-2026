namespace HerenciaSealed.Models;

// La clase Perro está sellada (sealed), por lo que no se puede heredar de ella
public sealed class Perro : Animal {
    public int Edad { get; set; }

    public void Ladrar() {
        Console.WriteLine("Guau guau!");
    }

    // Gracias a override, se sobrescribe el comportamiento del método Mover de la clase base
    public override void Mover() {
        Console.WriteLine("El perro corre.");
    }

    // No debería redefinir el método Comer, pero si lo hace, se oculta el método de la clase base
    // Se deben marcar como virtuales los métodos en la clase base para permitir su sobrescritura con override
    /*public void Comer() {
        Console.WriteLine($"{Nombre} está comiendo croquetas.");
    }*/
    
    public void Dormir() {
        Console.WriteLine("El perro duerme en su cama.");
    }
}