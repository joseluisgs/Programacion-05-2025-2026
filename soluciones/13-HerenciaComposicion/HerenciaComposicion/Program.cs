// See https://aka.ms/new-console-template for more information

using HerenciaComposicion.Composicion;
using HerenciaComposicion.HerenciaBuena;

Console.WriteLine("Hola, Herencia y Composición!");

var perro = new Perro();
var gato = new Gato();
var capibara = new Capibara();

perro.HacerSonido(); // Firulais está ladrando.
gato.HacerSonido(); // Michi está maullando.
capibara.HacerSonido(); // Capi está haciendo un sonido de capibara


var coche1 = new Coche(new MotorGasolina());
var coche2 = new Coche(new MotorElectrico());
coche1.Arrancar(); // Motor gasolina encendido
coche2.Arrancar(); // Motor eléctrico encendido