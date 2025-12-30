namespace HerenciaAbstract.Models;

public abstract class Animal {
    public string Nombre { get; set; }

    // Los métodos virtuales pueden ser sobrescritos en las clases derivadas
    public virtual void Mover() {
        Console.WriteLine("Animal se mueve.");
    }

    public void Comer() {
        Console.WriteLine($"{Nombre} está comiendo.");
    }
    
    // Los métodos abstractos deben ser implementados en las clases derivadas
    public abstract void Dormir();
    
}