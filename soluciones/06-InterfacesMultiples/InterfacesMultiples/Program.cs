// See https://aka.ms/new-console-template for more information

using InterfacesMultiples.Models;

var bombaNuclear = new BombaNuclear();
var superBomba = new SuperBomba();
superBomba.Explotar();


// Ejemplo de polimorfismo con interfaces
INuclear[] bombasNucleares = [
    new BombaNuclear(),
    new SuperBomba()
];

foreach (var bomba in bombasNucleares) {
    bomba.Explotar();
}