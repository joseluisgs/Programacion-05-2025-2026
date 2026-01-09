using PlantillaFutbol.Models;

namespace PlantillaFutbol.Factories;

public static class PlantillaFactory {
    public enum EntrenadorTipo {
        Entrenador,
        EntrenadorDePorteros
    }

    private static readonly string[] Jugadores = { "Jugador 1", "Jugador 2", "Jugador 3", "Jugador 4", "Jugador 5" };
    private static readonly string[] Porteros = { "Portero 1", "Portero 2" };
    private static readonly string[] Entrenadores = { "Entrenador 1", "Entrenador 2" };
    private static readonly string[] EntrenadoresPorteros = { "Entrenador de Porteros 1" };

    public static JugadorCampo GetRandomJugador() {
        var random = new Random();
        var index = random.Next(Jugadores.Length);
        return new JugadorCampo {
            NombreCompleto = Jugadores[index],
            Edad = random.Next(18, 40),
            Velocidad = random.Next(50, 100),
            Resistencia = random.Next(50, 100),
            Destrezas = random.Next(50, 100),
            Dorsal = random.Next(1, 99)
        };
    }

    public static Portero GetRandomPortero() {
        var random = new Random();
        var index = random.Next(Porteros.Length);
        return new Portero {
            NombreCompleto = Porteros[index],
            Edad = random.Next(18, 40),
            Reflejos = random.Next(50, 100),
            Dorsal = random.Next(1, 99)
        };
    }

    public static Entrenador GetRandomEntrenador(EntrenadorTipo entrenadorTipo) {
        var random = new Random();
        var index = random.Next(Entrenadores.Length);
        switch (entrenadorTipo) {
            case EntrenadorTipo.Entrenador:
                return new Entrenador {
                    NombreCompleto = Entrenadores[index],
                    Edad = random.Next(30, 60),
                    Experiencia = random.Next(1, 40)
                };
            case EntrenadorTipo.EntrenadorDePorteros:
                index = random.Next(EntrenadoresPorteros.Length);
                return new EntrenadorPorteros {
                    NombreCompleto = EntrenadoresPorteros[index],
                    Edad = random.Next(30, 60),
                    Experiencia = random.Next(1, 40),
                    Especializacion = random.Next(1, 10)
                };
            default:
                throw new ArgumentOutOfRangeException(nameof(entrenadorTipo), entrenadorTipo, null);
        }
    }
}