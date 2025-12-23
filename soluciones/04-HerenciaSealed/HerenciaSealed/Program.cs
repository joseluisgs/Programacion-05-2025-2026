// See https://aka.ms/new-console-template for more information

using HerenciaSealed.Models;

var vehiculo1 = new Coche("Toyota");
var vehiculo2 = new VehiculoB.CamionB(5000);

void DescribeVehiculo(Vehiculo v) {
    switch (v) {
        case Coche c:
            Console.WriteLine($"Coche de marca: {c.Marca}");
            break;
        case Camion ca:
            Console.WriteLine($"Camión con capacidad de {ca.CapacidadCargaKg} kg");
            break;
        case Moto m:
            Console.WriteLine($"Moto de cilindrada {m.Cilindrada} cc");
            break;
        default:
            throw new InvalidOperationException("Tipo de vehículo desconocido");
    }
}

void DescribeVehiculoB(VehiculoB v) {
    switch (v) {
        case VehiculoB.CocheB c:
            Console.WriteLine($"Coche de marca: {c.Marca}");
            break;
        case VehiculoB.CamionB ca:
            Console.WriteLine($"Camión con capacidad de {ca.CapacidadCargaKg} kg");
            break;
        case VehiculoB.MotoB m:
            Console.WriteLine($"Moto de cilindrada {m.Cilindrada} cc");
            break;
        default:
            throw new InvalidOperationException("Tipo de vehículo desconocido");
    }
}