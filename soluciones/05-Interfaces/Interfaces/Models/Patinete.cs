namespace Interfaces.Models;

public class Patinete : Cacharro, IElectrico, IVehiculo {
    public void Recargar() {
        Console.WriteLine("Recargando patinete...");
    }

    public void Arrancar() {
        Console.WriteLine("Arrancando patinete...");
    }

    public void Parar() {
        Console.WriteLine("Parando patinete...");
    }

    public static bool Crear() {
        return true;
        // Implementación del método estático
    }
}