// See https://aka.ms/new-console-template for more information


// Uso como tipo (TIPADO), lo veremos más adelante

using Interfaces.Models;

var miCoche = new Coche();
miCoche.Arrancar(); // "El coche arranca"
miCoche.Parar(); // "El coche para"


IVehiculo miVehiculo = new Coche();
miVehiculo.Arrancar(); // "El coche arranca"
miVehiculo.Parar(); // "El coche para"

IElectrico miElectrico = new Coche();
miElectrico.Recargar(); // "Recargando el coche eléctrico..."