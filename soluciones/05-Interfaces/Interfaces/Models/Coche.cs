namespace Interfaces.Models;

public class Coche : IVehiculo, IElectrico {
    public void Recargar() {
        Console.WriteLine("Recargando el coche eléctrico...");
    }

    public void Arrancar() {
        Console.WriteLine("El coche arranca");
    }

    public void Parar() {
        Console.WriteLine("El coche para");
    }

    // Si no implementas este método, coge la implementación por defecto de la interfaz
    // Si se implementa, se sobreescribe la implementación por defecto
    public void Revisar() {
        Console.WriteLine("Revisando el coche...");
    }

    public static bool Crear() {
        return true;
        // Implementación del método estático
    }
}