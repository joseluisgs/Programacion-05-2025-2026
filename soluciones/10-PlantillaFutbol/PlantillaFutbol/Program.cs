// See https://aka.ms/new-console-template for more information

using PlantillaFutbol.Factories;
using PlantillaFutbol.Models;

Console.WriteLine("Hola Plantilla de Fútbol!");


// Puedo usar Persona porque Entrenador hereda de Persona
Persona persona = new Entrenador { NombreCompleto = "Entrenador 01", Edad = 40, Experiencia = 30 };
// Puedo usar IEntrenar porque Entrenador implementa IEntrenar
IEntrenar entrenadorSecundario = new Entrenador { NombreCompleto = "Entrenador 02", Edad = 50, Experiencia = 25 };
// Puedo usar Entrenador porque Entrenador de Porteros hereda de Entrenador
Entrenador entrenadorPorteros = new EntrenadorPorteros
    { NombreCompleto = "Entrenador de Porteros 01", Edad = 45, Experiencia = 20, Especializacion = 5 };

// Puedo usar Jugador, porque Portero hereda de Jugador
Jugador portero = new Portero { NombreCompleto = "Portero 01", Edad = 30, Dorsal = 1, Reflejos = 90 };
Jugador jugador1 = new JugadorCampo
    { NombreCompleto = "Jugador 01", Edad = 28, Dorsal = 10, Velocidad = 85, Resistencia = 80, Destrezas = 88 };

// Puedo usar IEntrenar porque JugadorCampo implementa IEntrenar
IEntrenar jugador2 = new JugadorCampo
    { NombreCompleto = "Jugador 02", Edad = 26, Dorsal = 11, Velocidad = 82, Resistencia = 78, Destrezas = 86 };

var plantilla = new[] { persona, entrenadorPorteros, portero, jugador1 };

foreach (var jugador in plantilla) {
    Console.WriteLine($"Nombre: {jugador.NombreCompleto}, Edad: {jugador.Edad}");

    if (jugador is IEntrenar entrenador) entrenador.Entrenar();

    switch (jugador) {
        case JugadorCampo jugadorCampo:
            Console.WriteLine(
                $"Dorsal: {jugadorCampo.Dorsal}, Velocidad: {jugadorCampo.Velocidad}, Resistencia: {jugadorCampo.Resistencia}, Destrezas: {jugadorCampo.Destrezas}");
            break;
        case Portero porteroJugador:
            Console.WriteLine($"Dorsal: {porteroJugador.Dorsal}, Reflejos: {porteroJugador.Reflejos}");
            break;
    }

    var entrenadorGeneral = PlantillaFactory.GetRandomEntrenador(PlantillaFactory.EntrenadorTipo.Entrenador);
    entrenadorGeneral.AjustarEstrategia((Jugador)jugador);
    // Debemos hacer un casteo para poder usar el método Especializar
    var entrenadorDePorteros =
        PlantillaFactory.GetRandomEntrenador(PlantillaFactory.EntrenadorTipo
            .EntrenadorDePorteros); // O poner as EntrenadorPorteros
    // Entonces el if es con != null si usas as EntrenadorPorteros
    // Mejor usar siempre casting seguros con is
    if (jugador is Portero porteroAEspecializar &&
        entrenadorDePorteros is EntrenadorPorteros entrenadorPorterosQueEntrena)
        entrenadorPorterosQueEntrena.Especializar(porteroAEspecializar);

    var jugadorCampo02 = PlantillaFactory.GetRandomJugador();
    jugadorCampo02.Correr();

    var portero02 = PlantillaFactory.GetRandomPortero();
    portero02.Atajar();
}