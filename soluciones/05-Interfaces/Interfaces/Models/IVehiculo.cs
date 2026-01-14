namespace Interfaces.Models;

public interface IVehiculo {
    void Arrancar();

    void Parar();

    // A veces las interfaces ofrecen implementaciones por defecto
    void Revisar() {
        Console.WriteLine("Revisando el vehículo...");
    }

    // Obligas a la clase a tener este método estático
    static abstract bool Crear();
}