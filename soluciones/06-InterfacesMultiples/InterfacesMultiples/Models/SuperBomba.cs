namespace InterfacesMultiples.Models;

public class SuperBomba: IDinamita, INuclear {
    public void EncenderMecha() {
        Console.WriteLine("Encendiendo mecha de superbomba");
    }
    public void Radiacion() {
        Console.WriteLine("Radiación de superbomba");
    }

    public void Explotar() {
        // Puedo delegar a una implementación específica
        // Por ejemplo dinamita
        // ((IDinamita)this).Explotar();
        // O nuclear
        // ((INuclear)this).Explotar();
        // O hacer ambas cosas
        // ((IDinamita)this).Explotar();
        // ((INuclear)this).Explotar();
        // o pasar de ellas y hacer mi propia lógica
        Console.WriteLine("Explosión de superbomba");
    }
}