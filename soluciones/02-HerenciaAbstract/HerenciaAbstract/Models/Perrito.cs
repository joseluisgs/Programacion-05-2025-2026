namespace HerenciaAbstract.Models;
// Perrito hereda de Perro, que a su vez hereda de Animal
// Como perro ya ha implementado los métodos abstractos de Animal,
// Perrito no está obligado a implementarlos
// Es porque los hereda tal cual de Perro
public class Perrito: Perro {
    public int Peso { get; set; }
    public void Jugar() {
        // Base, nos permite acceder a los métodos y propiedades de la clase base
        base.Ladrar();
        Console.WriteLine("El perrito está jugando.");
        base.Dormir();
    }
}