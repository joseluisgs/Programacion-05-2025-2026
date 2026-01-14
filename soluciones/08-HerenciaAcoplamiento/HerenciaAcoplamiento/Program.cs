// See https://aka.ms/new-console-template for more information

using HerenciaAcoplamiento.ModelsA;
using HerenciaAcoplamiento.ModelsB;

var periquitoA = new PeriquitoA { Nombre = "Piolin", Dieta = "Semillas" };
periquitoA.Volar();
periquitoA.Comer();
var pinguinoA = new PinguinoA { Nombre = "Pingu", Dieta = "Pescado" };
pinguinoA.Comer();
// pinguinoA.Volar();  // Esto no es posible porque los pingüinos no vuelan


var periquitoB = new PeriquitoB { Nombre = "Piolin", Dieta = "Semillas" };
periquitoB.Volar();
periquitoB.Comer();
var pinguinoB = new PinguinoB { Nombre = "Pingu", Dieta = "Pescado" };
pinguinoB.Comer();
// pinguinoB.Volar(); // Ahora es error de compilación, ya que PinguinoB no tiene el método Volar
pinguinoB.Nadar();