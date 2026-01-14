namespace EquipoFutbol.Models;

/// <summary>
///     Representa una persona en el equipo de fútbol.
/// </summary>
public class Persona(string nombre, IRol rol) {
    public string Nombre { get; } = nombre;

    // Si dejo abierto el set, puedo cambiar el rol de la persona en tiempo de ejecución
    // Si lo pongo como private set, el rol solo se puede asignar en el constructor
    // Es decir, si es publico un entrenador puede ser jugador y viceversa
    // Es eso lo que queremos?
    public IRol Rol { get; set; } = rol; // private set; }

    public override string ToString() {
        return $"Persona(nombre='{Nombre}', rol={Rol})";
    }
}