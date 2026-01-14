## Ejercicios de Programación Avanzada Orientada a Objetos (POO)

- [Ejercicios de Programación Avanzada Orientada a Objetos (POO)](#ejercicios-de-programación-avanzada-orientada-a-objetos-poo)
  - [Herencia](#herencia)
    - [1. Mundo animal.](#1-mundo-animal)
    - [2. Vehículos.](#2-vehículos)
    - [3. Ítems de biblioteca.](#3-ítems-de-biblioteca)
    - [4. Currantes.](#4-currantes)
    - [5. Cuentas bancarias.](#5-cuentas-bancarias)
  - [Clases abstractas e interfaces](#clases-abstractas-e-interfaces)
    - [6. Animales.](#6-animales)
    - [7. Currando otra vez.](#7-currando-otra-vez)
  - [Polimorfismo](#polimorfismo)
    - [8. Animales.](#8-animales)
    - [9. Biblioteca.](#9-biblioteca)
- [Ejercicios Adicionales para Investigación y Práctica Avanzada](#ejercicios-adicionales-para-investigación-y-práctica-avanzada)
  - [10. Aplicación del Principio Abierto/Cerrado (OCP)](#10-aplicación-del-principio-abiertocerrado-ocp)
  - [11. Composición y Diseño Desacoplado (DIP)](#11-composición-y-diseño-desacoplado-dip)
  - [12. Jerarquía Sellada con Registros (`record`)](#12-jerarquía-sellada-con-registros-record)


### Herencia

#### 1. Mundo animal.
Vamos a realizar una estructura de clases en la que queden reflejados los dos tipos de animales domésticos principales: perros y gatos.

**Requisitos Comunes:**
Todos los animales deben tener un nombre, una raza, un peso y un color.

**Métodos Comunes:**
Los métodos `vacunar`, `comer` y `dormir` son comunes para todos los animales.

**Especializaciones y Polimorfismo:**
Los métodos `hacerRuido` y `hacerCaso` serán sobreescritos en las especializaciones:
*   **Perros:** `hacerRuido` será un ladrido. `hacerCaso` será un método *boolean* que devolverá *true* el 90% de las veces. Tendrán un método particular: `sacarPaseo`.
*   **Gatos:** `hacerRuido` será un maullido. `hacerCaso` será un 5% de las veces. Tendrán un método particular: `toserBolaPelo`.

#### 2. Vehículos.
Usando como base la clase realizada en el ejercicio anterior, renuómbrala como `Vehículo`. Se deben definir tres tipos de vehículos: turismos, camiones y motocicletas.

**Especializaciones:**
*   **Turismos:** Interesa saber: número de plazas y el método propio `tipodeUso` (profesional o particular).
*   **Camiones:** Atributo peso máximo autorizado y el método `esMercanciaPeligrosa` (tipo *boolean*).
*   **Motos:** Atributo cilindrada y el método `necesitaCarnet` (tipo *boolean*; a partir de 125 CC necesita carnet).

#### 3. Ítems de biblioteca.
Debemos definir la clase `Ficha` diseñada para manipular objetos de una biblioteca (libros, revistas, DVD, etc.).

**Clase Base (`Ficha`):**
Todos estos objetos pueden tener en común un número que los identifique y un título. La clase debe contener esa información y los métodos para manejarla.

**Clases Derivadas:**
*   **Libro:** Tendrá las características de `Ficha` más autor y editorial.
*   **Revistas:** Tendrán información particular como: número de la revista y año de publicación.
*   **DVD:** Necesitarán saber: director, año y tipo (“película”, “documental”, etc...).

Define la clase base y clases derivadas necesarias, así como los métodos que creas convenientes.

#### 4. Currantes.
Tenemos tres tipos de trabajadores en nuestra empresa: Fijos, PorHoras y AComisión.

**Clase Base (`Trabajador`):**
Podría interesar hacer una clase general `Trabajador` que sirva de base para los tres tipos, ya que existen atributos comunes (nombre, apellidos).

**Clases Derivadas y Atributos Específicos:**
*   **Fijos:** nombre, apellidos y sueldo.
*   **PorHoras:** nombre, apellidos, horas, sueldohora.
*   **AComision:** nombre, apellidos, ventas y porcentaje.

Crea las clases que creas necesarias.

#### 5. Cuentas bancarias.
Heredando de una clase "cuenta" (realizada en ejercicios anteriores), vamos a crear dos nuevas clases derivadas: `CuentaAhorro` y `CuentaCorriente`.

**Clases Derivadas y Requisitos:**
*   **CuentaAhorro:** Tienen una cuota de mantenimiento y un interés anual. Se deben implementar métodos que permitan saber el saldo nuevo si aplicamos ese interés y que resten al saldo la cuota de mantenimiento cuando sea necesario.
*   **CuentaCorriente:** Nos permite hacer transacciones y movimientos de cuenta (por ejemplo domiciliaciones). Tenemos que manejar la siguiente información: porcentaje cobrado por transacción, el número de transacciones y las transacciones en sí (día, mes y año de la transacción, concepto e importe). Para esta última clase, quizás haga falta definir una nueva clase `Transacción`.

### Clases abstractas e interfaces

#### 6. Animales.
Sobre el ejercicio de animales domésticos (Ejercicio 1), realiza las siguientes variaciones:

**Requisitos de Abstracción:**
Los métodos `comer`, `dormir` y `hacerRuido` deben ser obligatorios para cualquier nuevo animal doméstico que se añada,.

**Experimentación:**
Crea la clase `Elefante` que herede de la anterior y que incluya los métodos obligatorios (el elefante barrita).

**Análisis de Diseño:**
Realiza el ejercicio en dos supuestos:
1.  La clase `Animal` no se instancie nunca (usa clases abstractas).
2.  La clase `Animal` sí se pueda instanciar (usa métodos virtuales).

#### 7. Currando otra vez.
Para el ejercicio cuatro (Currantes), diseña el método `calculaSalario` que será obligatorio para cualquier currante que se añada.

**Nuevo Tipo y Abstracción:**
Incluye un nuevo tipo de currante: `Becario`, que debe implementar `calculaSalario` (devolverá 100, siempre),.

**Análisis de Diseño y Atributos Comunes:**
Diseña el ejercicio en el supuesto de que haga falta instanciar la clase base y en el supuesto que no. En cualquier caso, los currantes `PorHoras` y `Becarios` tendrán un valor común: `TIEMPO`.

### Polimorfismo

#### 8. Animales.
Usando la estructura de clases de animales domésticos (Ejercicio 1 y 6), vamos a diseñar una simulación de un parque.

**Simulación:**
En este parque, dividido en sectores, solo cabe un animal doméstico por sector.
*   Cada 10 segundos aparece un animal nuevo que se sitúa en una posición libre del parque; si no hubiera, el animal se va,.
*   Cada 2 segundos los animales del parque hacen algunas de las acciones habituales: `comer`, `dormir` o `hacerRuido`, al azar.
*   Cada 15 segundos un animal cambia de posición a otra adyacente. Si no hay hueco libre no se mueve.
*   Cada 20 segundos alguno de los animales abandona el parque con una probabilidad del 50%.

#### 9. Biblioteca.
Define la estructura necesaria que permita manejar los datos de una biblioteca. En dicha biblioteca tendremos libros, DVD’s y revistas (tal y como se definieron en el ejercicio 3).

**Diseño de Menú:**
Diseña el siguiente menú para interactuar con la colección de ítems,:
1.  Añadir ítem (preguntará qué tipo de ítem es y lo añadirá con sus datos a la biblioteca).
2.  Buscar ítem.
3.  Eliminar ítem.
4.  Listado de la biblioteca.
5.  Salir.

***

## Ejercicios Adicionales para Investigación y Práctica Avanzada

Los siguientes ejercicios están diseñados para complementar la práctica de los conceptos de Herencia, Interfaces, Polimorfismo, Composición y Principios SOLID (como se describe en las fuentes,,).

### 10. Aplicación del Principio Abierto/Cerrado (OCP)
El Principio Abierto/Cerrado (OCP) establece que las entidades de software deben estar abiertas para extensión, pero cerradas para modificación.

**Tarea:**
Modele un sistema de cálculo de impuestos donde la lógica de la clase principal (`CalculadoraImpuestos`) no deba modificarse cuando se añada un nuevo tipo de impuesto.

**Implementación Requerida:**
1.  Defina una interfaz `IImpuesto` que contenga el método `CalcularImpuesto()`.
2.  Implemente dos clases concretas: `ImpuestoIVA` e `ImpuestoIRPF`, que implementen la interfaz.
3.  Cree la clase `CalculadoraImpuestos` con un método `CalcularTotal(IImpuesto impuesto, decimal baseImponible)`.
4.  Demuestre que al agregar un tercer tipo de impuesto (`ImpuestoEcologico`), solo necesita crear una nueva clase derivada sin modificar `CalculadoraImpuestos`.

**Análisis:**
Explique cómo el uso del polimorfismo y las interfaces permite a la `CalculadoraImpuestos` estar cerrada a modificaciones, satisfaciendo el OCP.

### 11. Composición y Diseño Desacoplado (DIP)

La composición es generalmente preferible a la herencia para modelar una relación "Tiene un" (`HAS-A`), ya que reduce el acoplamiento fuerte y facilita el Principio de Inversión de Dependencias (DIP),.

**Tarea:**
Diseñe un sistema de mensajería donde la clase de alto nivel (`GestorNotificaciones`) no dependa de implementaciones concretas de bajo nivel.

**Implementación Requerida:**
1.  Defina una interfaz `IMensajero` (la abstracción).
2.  Implemente dos clases concretas de mensajería: `MensajeroEmail` y `MensajeroSMS` (las implementaciones concretas).
3.  Cree la clase `GestorNotificaciones` (el módulo de alto nivel). Asegúrese de que reciba la implementación de `IMensajero` a través del constructor (Inyección de Dependencias).
4.  Muestre cómo se puede cambiar el tipo de mensajería utilizado por `GestorNotificaciones` en tiempo de ejecución (inyectando Email o SMS) sin modificar la lógica interna del gestor.

**Análisis:**
Justifique cómo el uso de interfaces y la inyección por composición cumple con el DIP, ya que el módulo de alto nivel depende de una abstracción (`IMensajero`) y no de detalles concretos,.

### 12. Jerarquía Sellada con Registros (`record`)

C# soporta la Jerarquía Sellada para definir un conjunto cerrado de tipos derivados, y los tipos `record` son ideales para modelar datos inmutables y proporcionar igualdad basada en valores.

**Tarea:**
Modele los posibles resultados de una operación de API utilizando una Jerarquía Sellada, aprovechando los `record` para definir los estados de datos inmutables.

**Implementación Requerida:**
1.  Defina una clase base abstracta (`ResultadoOperacion`).
2.  Defina las siguientes clases derivadas utilizando el tipo `record` y marcándolas como `sealed`,:
    *   `Exito` (contiene el resultado o datos).
    *   `Error` (contiene un mensaje de error y un código de estado).
    *   `NoEncontrado`.
3.  Implemente una función que devuelva un `ResultadoOperacion` genérico.
4.  Utilice una expresión `switch` con *pattern matching* para consumir el resultado de la operación.

**Análisis:**
Explique cómo esta combinación de `sealed` y `record` asegura el **control exhaustivo**. Si se intentara añadir un nuevo tipo de resultado (`Timeout`) y se olvidara actualizar el `switch`, ¿qué beneficio de seguridad proporciona la jerarquía sellada al compilador?