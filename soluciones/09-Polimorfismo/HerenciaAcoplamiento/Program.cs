// See https://aka.ms/new-console-template for more information

using HerenciaAcoplamiento.Models;

var periquito = new Periquito { Nombre = "Piolin", Dieta = "Semillas" };
periquito.Volar();
periquito.Comer();
var pinguino = new Pinguino { Nombre = "Pingu", Dieta = "Pescado" };
pinguino.Comer();
// pinguinoB.Volar(); // Ahora es error de compilación, ya que PinguinoB no tiene el método Volar
pinguino.Nadar();

var pezVolador = new PezVolador();
pezVolador.Nadar();
pezVolador.Volar();

var trucha = new Trucha();
trucha.Nadar();
trucha.Saltar();


// podemos tipar el parámetro como la interfaz INadador
// INadador n1 = new Periquito(); // // Esto causará un error de compilación ya que Periquito no implementa INadador
INadador n2 = new Pinguino { Nombre = "Pingu", Dieta = "Camarones" };
n2.Nadar();
var p2 = (Pajaro)n2; // Cast explícito de INadador a Pajaro
p2.Comer();
// Cuidado con los casting que como no son verificados en tiempo de compilación pueden causar errores en tiempo de ejecución
// INadador n3 = (INadador)new Periquito(); // Esto compilará pero fallará en tiempo de ejecución 
// La excepción lanzada será InvalidCastException

var p3 = n2 as Pajaro; // Uso de 'as' para intentar el cast, devuelve null si falla
if (p3 != null)
    p3.Comer();
else
    Console.WriteLine("El cast falló, n2 no es un Pajaro.");

// Mejor usar is para verificar antes de castear
if (n2 is Pajaro p4)
    p4.Comer();
else
    Console.WriteLine("n2 no es un Pajaro.");


Perro c = new Cachorro();
c.Ladrar();


// Array de todos los objetos
var animales = new object[] { periquito, pinguino, pezVolador, trucha };

// Usar patrones de coincidencia para llamar a los métodos específicos de cada interfaz
foreach (var animal in animales) {
    //Cuando tenemos object debemos verificar cada tipo
    if (animal is IVolador volador) {
        volador.Volar();
        volador.Aterrizar();
    }

    if (animal is INadador nadador)
        nadador.Nadar();
    if (animal is Pajaro pajaro)
        pajaro.Comer();
}

// Array de solo pajaros
var peces = new Pajaro[] { pinguino, periquito };
foreach (var pez in peces) {
    pez.Comer(); // Método común de la clase base Pajaro
    if (pez is IVolador volador)
        volador.Volar();
}

// Array de solo nadadores
var nadadores = new INadador[] { pinguino, pezVolador, trucha };
foreach (var nadador in nadadores) {
    nadador.Nadar(); // Método común de la interfaz INadador
    if (nadador is Pajaro pajaro)
        pajaro.Comer();
}

// Array de solo voladores
var voladores = new IVolador[] { periquito, pezVolador };
foreach (var volador in voladores) {
    volador.Volar(); // Método común de la interfaz IVolador
    if (volador is Pajaro pajaro)
        pajaro.Comer();
}

Nadar(trucha);
//Nadar(periquito); // Esto causará un error de compilación ya que Periquito no implementa INadador

// Lo importante es que tenemos garantizado que el objeto pasado tiene el método Nadar
var sorpresa = GenerarVolador();
sorpresa.Volar();

// ---
// Puedo definir un método que acepte cualquier INadador
void Nadar(INadador nadador) {
    nadador.Nadar();
}

// También puedo definir un método que acepte cualquier IVolador
IVolador GenerarVolador() {
    var random = new Random();
    if (random.Next(2) == 0)
        return new Periquito { Nombre = "Volador1", Dieta = "Semillas" };
    return new PezVolador();
}