namespace InterfacesHerenciaMultiple.Models;

// public class CocheCeroEmision : IElectrico, IMotor {
public class CocheCeroEmision : IMotorElectrico {
    public void EncenderMotor() {
        Console.WriteLine("Encendiendo motor de cero emisión...");
    }

    public void ApagarMotor() {
        Console.WriteLine("Apagando motor de cero emisión...");
    }

    public void CargarBateria() {
        Console.WriteLine("Cargando batería del coche de cero emisión...");
    }

    public void DescargarBateria() {
        Console.WriteLine("Descargando batería del coche de cero emisión...");
    }

    public void Explotar() {
        Console.WriteLine("¡El coche de cero emisión ha explotado!");
    }
}