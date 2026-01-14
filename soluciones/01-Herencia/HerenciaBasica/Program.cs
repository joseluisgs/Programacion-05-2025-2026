// See https://aka.ms/new-console-template for more information

using HerenciaBasica.Models;

Console.WriteLine("Hola Herencia en C#!");

var a = new Animal { Nombre = "Bobby" };
a.Comer();
var p = new Perro { Nombre = "Rex", Edad = 3 };
p.Comer(); // Se ejecuta el método heredado de Animal
p.Ladrar(); // Se ejecuta el método específico de Perro
// Por lo tanto, se demuestra que p es un Perro y también un Animal
// Es decir, es polimórfico

if (p is Animal)
    Console.WriteLine($"{p.Nombre} es un Animal.");
if (p is Perro)
    Console.WriteLine($"{p.Nombre} es un Perro.");
if (p is object)
    Console.WriteLine($"{p.Nombre} es un objeto.");
else
    Console.WriteLine($"{p.Nombre} es un tipo desconocido.");

//
Animal animalPerro = new Perro { Nombre = "Max", Edad = 2 };
animalPerro.Comer(); // Método heredado de Animal
//animalPerro.Ladrar(); // Error de compilación: Animal no tiene el método

if (animalPerro is Perro perroCasted) perroCasted.Ladrar(); // Ahora podemos llamar a Ladrar después del casting

object obj = new Perro { Nombre = "Firulais", Edad = 4 };
if (obj is Animal animalFromObj) {
    animalFromObj.Comer(); // Método heredado de Animal
    if (animalFromObj is Perro perroFromObj)
        perroFromObj.Ladrar(); // Ahora podemos llamar a Ladrar después del casting
}

p.Mover();