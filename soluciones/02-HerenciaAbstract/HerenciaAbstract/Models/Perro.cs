namespace HerenciaAbstract.Models;

public class Perro : Animal {
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
    
    // Debemos sobrescribir el método abstracto Dormir que es abstraído en la clase base Animal
    public override void Dormir() {
        Console.WriteLine("El perro duerme en su cama.");
    }

    
}