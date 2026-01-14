namespace HerenciaComposicion.HerenciaBuena;

public class Perro(string nombre = "Firulais") : Animal(nombre) {
    public override void HacerSonido() {
        Console.WriteLine($"{Nombre} está ladrando.");
    }
}