using EquipoFutbol.Models;

// Creamos un rol de entrenador
var rolEntrenador = new RolEntrenador(); // Instancia de la clase RolEntrenador que implementa IEntrenador
var p1 = new Persona("Jose", rolEntrenador); // Creamos una persona con el rol de entrenador
Console.WriteLine(p1); // Mostramos la información de la persona
((RolEntrenador)p1.Rol).Entrenar(); // Llamamos al método Entrenar del rol actual de la persona

// Creamos un rol de defensa
var rolDefensa = new RolDefensa(2); // Instancia de la clase RolDefensa que implementa IRolDefensa
var p2 = new Persona("Luis", rolDefensa); // Creamos una persona con el rol de defensa
Console.WriteLine(p2); // Mostramos la información de la persona
((RolDefensa)p2.Rol).Defender(); // Llamamos al método Defender del rol actual de la persona

// Cambiamos los roles de las personas
p1.Rol = rolDefensa; // Ahora p1 tiene el rol de defensa
p2.Rol = rolEntrenador; // Ahora p2 tiene el rol de entrenador

Console.WriteLine(p1); // Mostramos la información actualizada de p1
Console.WriteLine(p2); // Mostramos la información actualizada de p2
((RolDefensa)p1.Rol).Defender(); // p1 puede defender porque su rol es RolDefensa
((RolEntrenador)p2.Rol).Entrenar(); // p2 puede entrenar porque su rol es RolEntrenador

// Creamos un portero
var portero = new Portero("Pepe", 13); // Instancia de Portero, que hereda de Jugador y Persona
Console.WriteLine(portero); // Mostramos la información del portero
portero.Role.Parar(); // El portero puede parar porque su rol es IRolPortero
portero.Role.Entrenar(); // El portero puede entrenar porque IRolPortero hereda de IRol

// Ejemplo de cambio de rol en un jugador
var delantero = new RolDelantero(9); // Instancia de RolDelantero
var jugador = new Portero("Juan", 1); // Creamos un portero
Console.WriteLine($"Antes del cambio: {jugador}"); // Mostramos el jugador antes del cambio de rol
jugador.CambiarRol(delantero); // Cambiamos el rol del portero a delantero usando el método virtual
Console.WriteLine($"Después del cambio: {jugador}"); // Mostramos el jugador después del cambio de rol
