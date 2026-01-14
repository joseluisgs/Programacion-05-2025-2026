namespace HerenciaComposicion.HerenciaBuena;

public class Capibara(string nombre = "Capi") : Animal(nombre) {
    public override void HacerSonido() {
        Console.WriteLine($"{Nombre} está haciendo un sonido de capibara.");
    }
}