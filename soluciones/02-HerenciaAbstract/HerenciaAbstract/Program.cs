// See https://aka.ms/new-console-template for more information

// Una clase abstracta es una clase que no puede ser instanciada directamente
// Sirve como base para otras clases que heredan de ella
// Puede contener métodos abstractos (sin implementación) y métodos concretos (con implementación)

using HerenciaAbstract.Models;

// var a = new Animal(); // Error: Animal es una clase abstracta y no puede ser instanciada
Perro perro = new Perro { Nombre = "Max", Edad = 5 };
perro.Comer(); // Método concreto heredado de Animal
perro.Mover(); // Método sobrescrito en Perro
perro.Ladrar(); // Método específico de Perro
perro.Dormir(); // Método sobrescrito en Perro que es obligatorio implementar de Animal

Perrito perrito = new Perrito { Nombre = "Chiquito", Edad = 1 };
perrito.Comer(); // Método concreto heredado de Animal
perrito.Mover(); // Método sobrescrito en Perro
perrito.Ladrar(); // Método específico de Perro
perrito.Dormir(); // Método sobrescrito en Perro
perrito.Jugar(); // Método específico de Perrito