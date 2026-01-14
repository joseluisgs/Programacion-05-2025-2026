namespace Interfaces.Models;

public abstract class VehiculoAbstract {
    public abstract void Arrancar();

    public abstract void Parar();

    // A veces las interfaces ofrecen implementaciones por defecto
    public virtual void Revisar() {
        Console.WriteLine("Revisando el vehículo...");
    }

    // Obligas a la clase a tener este método estático
    // static abstract bool Crear();
}