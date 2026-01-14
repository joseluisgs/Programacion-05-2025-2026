namespace HerenciaComposicion.HerenciaBuena;

public class Gato(string nombre = "Michi") : Animal(nombre) {
    public override void HacerSonido() {
        base.HacerSonido();
        Console.WriteLine($"{Nombre} está maullando.");
    }
}