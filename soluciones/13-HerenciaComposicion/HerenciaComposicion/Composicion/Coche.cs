namespace HerenciaComposicion.Composicion;

// Inyección de dependencia por interface
public class Coche(IMotor motor) {
    public void Arrancar() {
        motor.Encender();
    }
}