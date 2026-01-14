namespace HerenciaComposicion.HerenciaBuena;

public abstract class Animal(string nombre) {
    public string Nombre { get; set; } = nombre;

    public void Comer() {
        Console.WriteLine($"{Nombre} está comiendo.");
    }

    public void Dormir() {
        Console.WriteLine($"{Nombre} está durmiendo.");
    }

    public virtual void HacerSonido() {
        Console.WriteLine($"{Nombre} está haciendo un sonido genérico.");
    }
}