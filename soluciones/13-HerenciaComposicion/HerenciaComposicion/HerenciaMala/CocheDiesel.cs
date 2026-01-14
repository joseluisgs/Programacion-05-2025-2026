namespace HerenciaComposicion.HerenciaMala;

public class CocheDiesel(string matricula) : Coche(matricula) {
    public void ArrancarMotor() {
        Console.WriteLine($"El coche con matrícula {Matricula} ha arrancado su motor diesel.");
    }
}