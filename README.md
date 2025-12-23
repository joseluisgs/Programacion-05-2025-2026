# Programación - 05 Programación Avanzada Orientada a Objetos

Tema 05 Programación Avanzada Orientada a Objetos. 1DAW. Curso 2025-2026

![imagen](https://raw.githubusercontent.com/joseluisgs/Programacion-00-2022-2023/master/images/programacion.png)

- [Programación - 05 Programación Avanzada Orientada a Objetos](#programación---05-programación-avanzada-orientada-a-objetos)
  - [Contenido en Youtube](#contenido-en-youtube)
  - [1. Herencia en C#](#1-herencia-en-c)
    - [¿Qué es la herencia?](#qué-es-la-herencia)
      - [Ejemplo didáctico](#ejemplo-didáctico)
      - [Ejemplo avanzado](#ejemplo-avanzado)
  - [2. Modificadores de acceso y de herencia](#2-modificadores-de-acceso-y-de-herencia)
    - [Acceso](#acceso)
    - [De herencia](#de-herencia)
      - [Ejemplo](#ejemplo)
  - [3. El tipo `object` en C#](#3-el-tipo-object-en-c)
    - [¿Por qué es importante el tipo `object`?](#por-qué-es-importante-el-tipo-object)
      - [Ejemplo:](#ejemplo-1)
  - [4. Clases abstractas y métodos abstractos](#4-clases-abstractas-y-métodos-abstractos)
  - [5. Métodos virtuales y redefinición](#5-métodos-virtuales-y-redefinición)
      - [Ocultación con `new` (NO es sobrescritura)](#ocultación-con-new-no-es-sobrescritura)
  - [6. Uso de `base` en Herencia: constructores, métodos, propiedades e inicializadores](#6-uso-de-base-en-herencia-constructores-métodos-propiedades-e-inicializadores)
    - [6.1. Invocando el constructor de la clase base con `base`](#61-invocando-el-constructor-de-la-clase-base-con-base)
    - [6.2. Extendiendo y reutilizando métodos y propiedades heredados con `base`](#62-extendiendo-y-reutilizando-métodos-y-propiedades-heredados-con-base)
    - [6.3. Sobrescribir propiedades virtuales y acceder a la base](#63-sobrescribir-propiedades-virtuales-y-acceder-a-la-base)
    - [6.4. Orden de inicialización de campos y constructores](#64-orden-de-inicialización-de-campos-y-constructores)
    - [6.5. Modificando inicializadores en la derivada](#65-modificando-inicializadores-en-la-derivada)
    - [6.6. Orden de ejecución de inicializadores y constructores en herencia](#66-orden-de-ejecución-de-inicializadores-y-constructores-en-herencia)
    - [Resumen didáctico](#resumen-didáctico)
  - [7. Jerarquía Sellada](#7-jerarquía-sellada)
    - [7.1 ¿Qué es una jerarquía sellada?](#71-qué-es-una-jerarquía-sellada)
    - [7.2 ¿Para qué se usa este patrón?](#72-para-qué-se-usa-este-patrón)
    - [7.3 Ejemplo: Modelando Tipos de Vehículos con una Jerarquía Sellada](#73-ejemplo-modelando-tipos-de-vehículos-con-una-jerarquía-sellada)
    - [7.4 Manejo exhaustivo con `switch` y pattern matching](#74-manejo-exhaustivo-con-switch-y-pattern-matching)
      - [1. Clases Separadas (`internal sealed`)](#1-clases-separadas-internal-sealed)
      - [2. Clases Anidadas (*Inner*)](#2-clases-anidadas-inner)
  - [8. Tipos especiales: struct, class, record](#8-tipos-especiales-struct-class-record)
      - [Ejemplo](#ejemplo-2)
  - [9. Interfaces](#9-interfaces)
    - [9.1. Definición y propósito](#91-definición-y-propósito)
    - [9.2. Ejemplo básico de interface y uso como tipo](#92-ejemplo-básico-de-interface-y-uso-como-tipo)
    - [9.3. Implementación de múltiples interfaces](#93-implementación-de-múltiples-interfaces)
    - [9.4. Herencia múltiple de interfaces](#94-herencia-múltiple-de-interfaces)
    - [9.5. Métodos y propiedades por defecto en interfaces](#95-métodos-y-propiedades-por-defecto-en-interfaces)
    - [9.6. Uso de interfaces para tipar](#96-uso-de-interfaces-para-tipar)
    - [9.7. ¿Qué ocurre si dos interfaces declaran el mismo método?](#97-qué-ocurre-si-dos-interfaces-declaran-el-mismo-método)
      - [Caso 1: Conflicto, **misma firma**, sin implementación por defecto](#caso-1-conflicto-misma-firma-sin-implementación-por-defecto)
      - [Caso 2: **Firma igual, métodos por defecto distintos**](#caso-2-firma-igual-métodos-por-defecto-distintos)
      - [Solución: Implementación explícita y alias de interface](#solución-implementación-explícita-y-alias-de-interface)
    - [9.8. Uso de Herencia e Interfaces juntos](#98-uso-de-herencia-e-interfaces-juntos)
    - [9.9. Resumen de ventajas y mejores prácticas](#99-resumen-de-ventajas-y-mejores-prácticas)
  - [10. Polimorfismo](#10-polimorfismo)
    - [10.1 Polimorfismo por herencia](#101-polimorfismo-por-herencia)
    - [10.2 Polimorfismo con interfaces](#102-polimorfismo-con-interfaces)
    - [10.3 Casting y comprobación de tipos para polimorfismo seguro](#103-casting-y-comprobación-de-tipos-para-polimorfismo-seguro)
      - [Casting explícito](#casting-explícito)
      - [Casting seguro `as`](#casting-seguro-as)
    - [Comprobación de tipos con `is` y pattern matching](#comprobación-de-tipos-con-is-y-pattern-matching)
    - [10.4 Polimorfismo en Colecciones y Métodos](#104-polimorfismo-en-colecciones-y-métodos)
  - [11. Herencia vs Composición](#11-herencia-vs-composición)
    - [11.1. Conceptos fundamentales](#111-conceptos-fundamentales)
      - [Herencia (`IS-A` o "Es un")](#herencia-is-a-o-es-un)
      - [Composición (`HAS-A` o "Tiene un")](#composición-has-a-o-tiene-un)
    - [11.2. Pros y contras de la Herencia](#112-pros-y-contras-de-la-herencia)
    - [11.3. Pros y contras de la Composición](#113-pros-y-contras-de-la-composición)
    - [11.4. ¿Por qué la composición suele ser preferible en el diseño moderno?](#114-por-qué-la-composición-suele-ser-preferible-en-el-diseño-moderno)
      - [Herencia puede ser un antipatrón cuando:](#herencia-puede-ser-un-antipatrón-cuando)
    - [11.5. Ejemplo comparativo y con interfaces](#115-ejemplo-comparativo-y-con-interfaces)
      - [Ejemplo de herencia (IS-A):](#ejemplo-de-herencia-is-a)
      - [Ejemplo de composición (HAS-A):](#ejemplo-de-composición-has-a)
    - [11.6. Relación entre composición e interfaces](#116-relación-entre-composición-e-interfaces)
  - [12. Principios SOLID (explicaciones y ejemplos reales)](#12-principios-solid-explicaciones-y-ejemplos-reales)
    - [S - Single Responsibility Principle (Responsabilidad Única)](#s---single-responsibility-principle-responsabilidad-única)
    - [O - Open/Closed Principle (Abierto/Cerrado)](#o---openclosed-principle-abiertocerrado)
    - [L - Liskov Substitution Principle (Sustitución de Liskov)](#l---liskov-substitution-principle-sustitución-de-liskov)
    - [I - Interface Segregation Principle (Segregación de Interfaces)](#i---interface-segregation-principle-segregación-de-interfaces)
    - [D - Dependency Inversion Principle (Inversión de dependencias)](#d---dependency-inversion-principle-inversión-de-dependencias)
    - [Resumen y guía didáctica](#resumen-y-guía-didáctica)
    - [Ejemplo completo aplicando SOLID](#ejemplo-completo-aplicando-solid)
  - [13. Referencias y paso de parámetros (`ref` vs `out` vs `in`)](#13-referencias-y-paso-de-parámetros-ref-vs-out-vs-in)
  - [13.1. Comportamiento sin modificadores (Paso por valor)](#131-comportamiento-sin-modificadores-paso-por-valor)
  - [13.2. El modificador `ref` (Entrada y Salida)](#132-el-modificador-ref-entrada-y-salida)
  - [13.3. El modificador `out` (Salida Pura)](#133-el-modificador-out-salida-pura)
  - [13.4. El modificador `in` (Solo Lectura / Rendimiento)](#134-el-modificador-in-solo-lectura--rendimiento)
  - [13.5. Resumen y Buenas Prácticas: La Tabla Definitiva](#135-resumen-y-buenas-prácticas-la-tabla-definitiva)
    - [Tabla de Comportamiento y Permisos](#tabla-de-comportamiento-y-permisos)
    - [Guía de decisión rápida (Buenas Prácticas)](#guía-de-decisión-rápida-buenas-prácticas)
  - [13.6. Ejemplos Completos de Código](#136-ejemplos-completos-de-código)
    - [Caso 1: Optimización de Structs con `in`](#caso-1-optimización-de-structs-con-in)
    - [Caso 2: Clases - La trampa del `new` (Ref vs Normal)](#caso-2-clases---la-trampa-del-new-ref-vs-normal)
    - [Caso 3: Arrays y `out` (La fábrica de datos)](#caso-3-arrays-y-out-la-fábrica-de-datos)
  - [14. Resumen](#14-resumen)
  - [Enlaces útiles y bibliografía](#enlaces-útiles-y-bibliografía)
  - [Autor](#autor)
    - [Contacto](#contacto)
  - [Licencia de uso](#licencia-de-uso)


## Contenido en Youtube

- [Podcast](https://youtu.be/oNJT87uSuHI)
- [Resumen](https://youtu.be/-RKbWFykFX4)
- [Herencia](https://youtu.be/jYFNH3jeD0g)
- [Interfaces](https://youtu.be/KVCVNVBw9AI)
- [Polimorfismo](https://youtu.be/1zSUaBudbWQ)
- [Herencia vs Composición](https://youtu.be/YEDWx6_1aEc)
- [SOLID](https://youtu.be/FAkQnp-HkhI)
- [Lista de Reproducción](https://www.youtube.com/watch?v=wKCdgacEr4Q&list=PLGIH-7eZDbVw6q2AdcAUe2r6YxJYBkfCi)


---

## 1. Herencia en C#

### ¿Qué es la herencia?

La herencia permite crear nuevas clases a partir de una clase existente, obteniendo sus campos, propiedades y métodos, y pudiendo ampliar o modificar su comportamiento.

Las clases se agrupan en una **jerarquía**:
- **Clase base** (superclase): de la que se hereda.
- **Clase derivada** (subclase): que hereda y puede ampliar o modificar.

El objetivo es reutilizar código y organizar el programa de manera lógica y extensible.


En los lenguajes orientados a objetos, la herencia es un pilar fundamental que permite la creación de nuevas clases basadas en clases existentes. Esto facilita la reutilización de código, la organización lógica y la extensibilidad del software. Además tenemos varios tipos de herencia según los lenguajes de programación:

- **Herencia simple:** Una clase derivada hereda de una sola clase base. (C#, Java)
- **Herencia múltiple:** Una clase derivada hereda de múltiples clases base. (C++). C# no soporta herencia múltiple de clases, pero sí permite implementar múltiples interfaces.

Cada tipo de herencia tiene sus pros y contras, y la elección depende del diseño y los requisitos del software.

- **Herencia simple:**  
  - *Ventajas:* Simplicidad, menor complejidad, fácil de entender y mantener.  
  - *Desventajas:* Menos flexible, puede requerir más clases para representar relaciones complejas.
- **Herencia múltiple:**  
  - *Ventajas:* Mayor flexibilidad, permite combinar comportamientos de múltiples clases.  
  - *Desventajas:* Mayor complejidad, problemas como la "ambigüedad del diamante", difícil de mantener.

El **uso adecuado de la herencia** es crucial para un buen diseño orientado a objetos. Se recomienda usarla cuando existe una relación "es un" clara entre la clase base y la derivada, y evitarla cuando la composición (relación "tiene un") es más apropiada.

**El problema de la ambigüedad del diamante:** Es un problema que surge en la herencia múltiple cuando una clase derivada hereda de dos clases base que a su vez heredan de una misma clase base. Esto puede causar ambigüedad sobre qué versión de un método o propiedad debe utilizar la clase derivada. ¿Cómo se resuelve? Cada lenguaje tiene sus propias reglas y mecanismos para manejar este problema, como el uso de interfaces en C# o la especificación explícita de la clase base en C++, en Python se resuelve automáticamente mediante el algoritmo C3 Linearization (MRO, Method Resolution Order).


#### Ejemplo didáctico

```csharp
public class Animal
{
    public string Nombre { get; set; }
    public void Comer() => Console.WriteLine($"{Nombre} está comiendo.");
}

public class Perro : Animal
{
    public void Ladrar() => Console.WriteLine("Guau guau!");
}
```

El `Perro` puede acceder y usar los métodos de la clase base `Animal`.

#### Ejemplo avanzado

```csharp
public class Animal
{
    public string Nombre { get; set; }
    public virtual void Mover() => Console.WriteLine("Animal se mueve.");
}

public class Ave : Animal
{
    public override void Mover() => Console.WriteLine($"{Nombre} vuela.");
}

public class Pez : Animal
{
    public override void Mover() => Console.WriteLine($"{Nombre} nada.");
}
```

En este ejemplo, el método `Mover` tiene un comportamiento diferente dependiendo de la subclase.

---

## 2. Modificadores de acceso y de herencia

### Acceso

- **public:** Accesible desde cualquier parte.
- **private:** Solo desde la clase actual.
- **protected:** Desde la clase actual y sus derivadas.
- **internal:** Solo dentro del mismo ensamblado.
- **protected internal / private protected:** Combinaciones avanzadas.

### De herencia

- **abstract:** Indica que una clase/método no tiene implementación en la clase base y debe ser implementado en las derivadas.
- **virtual:** Permite que el método pueda ser sobrescrito en las derivadas.
- **override:** Redefine un método virtual/abstracto.
- **sealed:** Impide que una clase o método sea heredado o sobrescrito.
- **new:** Oculta el miembro de la base, creando uno nuevo con el mismo nombre (no sobrescribe realmente).

#### Ejemplo

```csharp
// Clase base abstracta, no se puede instanciar. Sirve como base.
public abstract class Figura
{
    public abstract double Area();
}

// Clase derivada que implementa el método abstracto, se puede instanciar y se puede heredar.
public class Circulo : Figura
{
    private double radio;
    public Circulo(double r) { radio = r; }
    public override double Area() => Math.PI * radio * radio;
}

// Clase sellada que no se puede heredar. Se usa como ejemplo de clase final de la jerarquía.
public sealed class Cuadrado : Figura
{
    private double lado;
    public Cuadrado(double l) { lado = l; }
    public override double Area() => lado * lado;
}
```

---

## 3. El tipo `object` en C#
La **programación orientada a objetos** es el paradigma principal de C#, donde el código se organiza mediante objetos que combinan estado y comportamiento.  
En C#, **absolutamente todos los tipos, tanto propios como del sistema, derivan directa o indirectamente de una única clase base llamada `object`**, que se encuentra en el espacio de nombres `System`.

### ¿Por qué es importante el tipo `object`?

- Todos los tipos heredan por defecto de `object`.  
- Métodos clave como `ToString()`, `Equals()`, `GetHashCode()`, `GetType()` están definidos en `object`.
- Permite el polimorfismo universal y facilita la interoperabilidad y la colección de objetos heterogéneos. Es decir, todo objeto puede ser tratado como un `object` y luego convertido de nuevo a su tipo original si es necesario. Lo veremos más adelante.

#### Ejemplo:

```csharp
object o = new Coche("Seat", "Ibiza", "Rojo");
// Podemos almacenar cualquier tipo en una variable object
Console.WriteLine(o.ToString()); // Llama al método ToString() de Coche
```
---

## 4. Clases abstractas y métodos abstractos

- No se pueden instanciar. Es decir, no puedes crear objetos directamente de una clase abstracta.
- Sirven como base para otras clases.
- Pueden tener métodos abstractos (sin implementación), lo que obliga a las clases derivadas a implementarlos.

```csharp
public abstract class Vehiculo
{
    public string Marca { get; set; }
    public abstract void Arrancar();
}

public class Coche : Vehiculo
{
    public override void Arrancar()
    {
        Console.WriteLine($"{Marca}: Arrancando el coche...");
    }
}
```

**Contraejemplo:** Intentar instanciar una clase abstracta:

```csharp
Vehiculo v = new Vehiculo(); // Error: no se puede instanciar una clase abstracta
```

---

## 5. Métodos virtuales y redefinición

Los **métodos virtuales** permiten definir un comportamiento que puede ser sobrescrito mediante el modificador `override`. ¿Por qué es útil? Porque permite que las clases derivadas personalicen el comportamiento heredado. ¿Qué pasa si un método no es virtual? No se puede sobrescribir y se mantiene el comportamiento de la clase base, si queremos un comportamiento diferente, debemos usar ocultación con `new`.

```csharp
public class Animal
{
    public virtual void HacerSonido() => Console.WriteLine("El animal hace un sonido");
    public void Dormir() => Console.WriteLine("El animal está durmiendo");
}

public class Vaca : Animal
{
    public override void HacerSonido() => Console.WriteLine("Muuuu");
}
```

#### Ocultación con `new` (NO es sobrescritura)

Lo que hace `new` es crear un nuevo método en la clase derivada que oculta el de la clase base, pero no lo sobrescribe. Esto puede llevar a confusión y errores si no se usa con cuidado.

```csharp
public class Padre
{
    public void Mensaje() => Console.WriteLine("Padre");
}
public class Hijo : Padre
{
    public new void Mensaje() => Console.WriteLine("Hijo");
}
```

**Nunca se recomienda usar `new` salvo para casos muy concretos.**

Históricamente, el override debía devolver exactamente el mismo tipo que el método base. Desde hace poco (C# 9, pero vital ahora), se permite devolver un tipo más derivado.

```csharp
public class Animal {
    public virtual Animal Clonar() => new Animal();
}

public class Perro : Animal {
    // Antes daba error, tenías que devolver 'Animal'. 
    // Ahora puedes devolver 'Perro' siendo fiel a la herencia.
    public override Perro Clonar() => new Perro(); 
}  

```


## 6. Uso de `base` en Herencia: constructores, métodos, propiedades e inicializadores

En la programación orientada a objetos en C#, el mecanismo de herencia permite que una clase derive de otra y herede su estado (campos y propiedades) y comportamiento (métodos). La clave para gestionar correctamente la herencia y la ampliación o reutilización de funcionalidad es saber cómo funciona la palabra clave `base` y la inicialización de objetos.

**La palabra clave `base`**:
- Permite acceder a miembros (métodos, propiedades y constructores) de la clase base desde la clase derivada.
- Es útil para invocar explícitamente el constructor de la base cuando creamos una instancia de una clase derivada.
- Es empleada en métodos sobrescritos para llamar al método de la base, si se quiere ampliar y no reemplazar el comportamiento original.
- Permite acceder a propiedades heredadas, incluso si son sobrescritas con `override` en la clase derivada.

**Inicialización en herencia**:
Cuando creamos una instancia de una clase derivada, el proceso de inicialización se realiza de la siguiente forma:
1. Se inicializan los campos y propiedades de la clase base.
2. Se ejecuta el constructor de la clase base.
3. Se inicializan los campos y propiedades de la clase derivada.
4. Se ejecuta el constructor de la clase derivada.

Este orden garantiza que el objeto empieza inicializando la parte más general y acaba con la parte más específica.  
El uso correcto de inicializadores, constructores y la palabra clave `base` ayuda a crear objetos consistentes, robustos y fácilmente ampliables.

---

### 6.1. Invocando el constructor de la clase base con `base`

```csharp
public class Vehiculo
{
    public string Marca;
    public Vehiculo(string marca)
    {
        Marca = marca;
        Console.WriteLine("Constructor Vehiculo");
    }
}

public class Coche : Vehiculo
{
    public string Modelo;
    public Coche(string marca, string modelo)
        : base(marca) // Llama explícitamente al constructor de la base
    {
        Modelo = modelo;
        Console.WriteLine("Constructor Coche");
    }
}

// Uso:
Coche coche = new Coche("Volkswagen", "Golf");
// Salida:
// Constructor Vehiculo
// Constructor Coche
```

Además gracias al constrctor primario de C# podemos simplificarlo aún más:

```csharp
// El parámetro 'marca' se pasa directamente al constructor de Vehiculo
public class Coche(string marca) : Vehiculo(marca)
{ 
    public string Modelo { get; set; }
}

// Uso:
Coche coche = new Coche("Toyota");
Console.WriteLine(coche.Marca); // Toyota

```

---

### 6.2. Extendiendo y reutilizando métodos y propiedades heredados con `base`

```csharp
public class Vehiculo
{
    public virtual void Arrancar()
    {
        Console.WriteLine("Vehículo arrancando genéricamente.");
    }
}

public class Moto : Vehiculo
{
    public override void Arrancar()
    {
        base.Arrancar(); // Llama al método de la base
        Console.WriteLine("La moto acelera tras arrancar.");
    }
}

// Uso:
Moto moto = new Moto();
moto.Arrancar();
// Salida:
// Vehículo arrancando genéricamente.
// La moto acelera tras arrancar.
```

---

### 6.3. Sobrescribir propiedades virtuales y acceder a la base

```csharp
public class Electrodomestico
{
    public string Marca { get; set; } = "Sin marca";
    public virtual string Descripcion => $"Electrodoméstico de marca {Marca}";
}

public class Lavadora : Electrodomestico
{
    public string TipoCarga { get; set; } = "Frontal";
    public override string Descripcion =>
        base.Descripcion + $", tipo de carga: {TipoCarga}";
}

// Uso:
Lavadora lavadora = new Lavadora { Marca = "Bosch", TipoCarga = "Superior" };
Console.WriteLine(lavadora.Descripcion);
// Salida:
// Electrodoméstico de marca Bosch, tipo de carga: Superior
```

---

### 6.4. Orden de inicialización de campos y constructores

```csharp
public class Animal
{
    public string Especie = "Desconocida"; // Inicializador de campo
    public Animal()
    {
        Console.WriteLine($"Animal: Constructor ejecutado. Especie: {Especie}");
    }
}

public class Perro : Animal
{
    public string Raza = "Sin raza";       // Inicializador de campo
    public Perro()
    {
        Console.WriteLine($"Perro: Constructor ejecutado. Raza: {Raza}");
    }
}

// Uso:
Perro perro = new Perro();
Console.WriteLine($"Especie: {perro.Especie}");
Console.WriteLine($"Raza: {perro.Raza}");
```

**Salida esperada:**
```
Animal: Constructor ejecutado. Especie: Desconocida
Perro: Constructor ejecutado. Raza: Sin raza
Especie: Desconocida
Raza: Sin raza
```

---

### 6.5. Modificando inicializadores en la derivada

Si en la derivada sobrescribes una propiedad virtual, o simplemente modificas el valor en el constructor, el valor final es el de la derivada:

```csharp
public class Vehiculo
{
    public virtual int Ruedas { get; set; } = 4;
    public Vehiculo() { }
}

public class Moto : Vehiculo
{
    public override int Ruedas { get; set; } = 2;
    public Moto() { }
}

// Uso:
Moto motosport = new Moto();
Console.WriteLine($"La moto tiene ruedas: {motosport.Ruedas}"); // 2
```

---

### 6.6. Orden de ejecución de inicializadores y constructores en herencia

```csharp
public class Dispositivo
{
    public string Nombre = "Desconocido";
    public Dispositivo()
    {
        Console.WriteLine("Dispositivo: constructor ejecutado");
    }
}

public class Tablet : Dispositivo
{
    public string SistemaOperativo = "Android";
    public Tablet()
    {
        Console.WriteLine("Tablet: constructor ejecutado");
    }
}

// Uso:
Tablet tabla = new Tablet();
Console.WriteLine($"Nombre: {tabla.Nombre}, SO: {tabla.SistemaOperativo}");
```
**Salida:**
```
Dispositivo: constructor ejecutado
Tablet: constructor ejecutado
Nombre: Desconocido, SO: Android
```

---

### Resumen didáctico

- El uso de `base` permite controlar y ampliar el comportamiento heredado correctamente.
- Los inicializadores en declaración se ejecutan antes que el constructor correspondiente.
- Los constructores siempre siguen la cadena de herencia: primero el de la base, luego los de la derivada.
- Si sobrescribes una propiedad virtual, el valor que prevalece es el de la derivada.
- Usar `Console.WriteLine` en inicializadores y constructores te ayuda a entender y depurar el orden de ejecución.

---
## 7. Jerarquía Sellada

### 7.1 ¿Qué es una jerarquía sellada?

Una **jerarquía sellada** en C# es una estructura de clases diseñada para definir un conjunto cerrado y controlado de tipos derivados a partir de una clase base. Utilizando el modificador `sealed` en las subclases, se impide la creación de nuevos tipos fuera de los originalmente previstos por el diseñador del sistema.

### 7.2 ¿Para qué se usa este patrón?

Este patrón se emplea cuando:
- Deseas garantizar que sólo existan ciertos tipos derivados de una clase, evitando la extensión accidental o malintencionada por otros desarrolladores.
- Necesitas modelar un dominio donde los casos posibles deben estar totalmente enumerados. Por ejemplo: tipos de estados, categorías de objetos, tipos de errores, distintos resultados de operaciones, etc.
- Quieres asegurar el **control exhaustivo** en flujos de trabajo como `switch` por tipos, de modo que cada posible variante esté definida y manejada explícitamente en el código.
- Mejoras la seguridad y mantenibilidad, ya que si se añade un nuevo caso, el compilador y las herramientas de análisis pueden avisarte en los puntos relevantes para actualizar el manejo del nuevo tipo.
- Permites escribir código robusto, predecible y fácil de mantener, sin sorpresas por ampliaciones inesperadas.

**En resumen:**  
Las jerarquías selladas son ideales para diseñar sistemas donde la lista de variantes o especializaciones es fija o controlada desde el diseño.

---

### 7.3 Ejemplo: Modelando Tipos de Vehículos con una Jerarquía Sellada

Supongamos que en la gestión de la flota de una empresa sólo existen tres tipos de vehículos: coches, camiones y motos. Queremos evitar que puedan crearse otros tipos distintos. Para ello, usamos una clase base `Vehiculo` y subclases selladas. Además usamos `internal` para limitar la visibilidad al ensamblado actual:

```csharp
// Clase base abstracta pública. Solo el tipo base es visible externamente.
public abstract class Vehiculo { }

// Subclases selladas (sealed) e internas. Son los tipos concretos y ocultos.

internal sealed class Coche : Vehiculo
{
    public string Marca { get; }
    public Coche(string marca) => Marca = marca;
}

internal sealed class Camion : Vehiculo
{
    public int CapacidadCargaKg { get; }
    public Camion(int capacidadCargaKg) => CapacidadCargaKg = capacidadCargaKg;
}

internal sealed class Moto : Vehiculo
{
    public int Cilindrada { get; }
    public Moto(int cilindrada) => Cilindrada = cilindrada;
}
```

Esta estructura asegura que `Vehiculo` sólo puede ser extendido por las tres subclases previstas. Nadie podrá heredar de `Coche`, `Camion` o `Moto`, ni crear variantes adicionales.

---

### 7.4 Manejo exhaustivo con `switch` y pattern matching

Gracias a esta jerarquía cerrada, puedes implementar funciones que respondan a cada tipo concreto de vehículo, asegurando un tratamiento seguro y exhaustivo:

```csharp

// 1. Instanciación de los tipos internos
Vehiculo coche = new Coche("Nissan");
Vehiculo camion = new Camion(9500);
Vehiculo moto = new Moto(750);

// 2. Uso de la expresión switch para el procesamiento
Console.WriteLine(ObtenerDetalle(coche));
Console.WriteLine(ObtenerDetalle(camion));
Console.WriteLine(ObtenerDetalle(moto));


// Función estática para procesar los vehículos
string ObtenerDetalle(Vehiculo vehiculo) 
{
    // La expresión switch utiliza Pattern Matching sobre los tipos internos.
    return vehiculo switch
    {
        // Caso Coche: Desestructura y usa la propiedad Marca.
        Coche c => $"Coche: Marca {c.Marca}.",
        
        // Caso Camion: Desestructura y usa la propiedad CapacidadCargaKg.
        Camion ca => $"Camión: {ca.CapacidadCargaKg} Kg de carga máxima.",
        
        // Caso Moto: Desestructura y usa la propiedad Cilindrada.
        Moto m => $"Moto: {m.Cilindrada} cc de cilindrada.",

        // Patrón de descarte (_): Maneja cualquier otro tipo derivado de Vehiculo 
        // que pudiera existir pero no fue listado.
        _ => "Tipo de vehículo desconocido."
    };
}
```

Otras delas formas de hacerlo, es usando inner class con internal 
```csharp
public abstract class vehiculo
{
    internal sealed class Coche : vehiculo { }
    internal sealed class Camion : vehiculo { }
    internal sealed class Moto : vehiculo { }
}

Vehiculo v = new Vehiculo.Coche();
Vehiculo v2 = new Vehiculo.Camion();
Vehiculo v3 = new Vehiculo.Moto();

string ObtenerDetalle(Vehiculo vehiculo) => vehiculo switch
{
    Vehiculo.Coche c => "Es un coche",
    Vehiculo.Camion ca => "Es un camión",
    Vehiculo.Moto m => "Es una moto",
    _ => "Tipo desconocido"
};
```

#### 1\. Clases Separadas (`internal sealed`)

  * **Sintaxis de uso (dentro del ensamblado):**
    ```csharp
    Vehiculo v = new Coche("Ford");
    ```
  * **Ventajas:**
      * **Limpieza:** Sintaxis de uso más directa y limpia (`Coche` en lugar de `Vehiculo.Coche`).
      * **Organización:** Mantiene la clase base enfocada en la abstracción y separa las implementaciones concretas.
  * **Desventajas:**
      * La relación de dominio acotado es menos **visual** que si estuvieran anidadas.

#### 2\. Clases Anidadas (*Inner*)

  * **Sintaxis de uso (dentro del ensamblado):**
    ```csharp
    Vehiculo v = new Vehiculo.Coche("Ford");
    ```
  * **Ventajas:**
      * **Encapsulación Visual:** La relación de que `Coche`, `Camion` y `Moto` solo existen como parte del dominio de `Vehiculo` es **explícita y fuerte**.
      * **Agrupación:** Garantiza que las implementaciones concretas nunca se separen de la clase base, ya que están físicamente definidas dentro de ella.
  * **Desventajas:**
      * **Sintaxis Verbosa:** El uso y la referencia a las clases concretas siempre requiere el prefijo `Vehiculo.`


**Recomendación**
Si estás tratando de imitar la **exhaustividad y acotación** de los *Sealed Types* de Java o los *Discriminated Unions* de F\#, la opción de clases **anidadas (`inner`)** puede ser ligeramente preferible. Hace que la conexión entre la base y las implementaciones sea **más obvia** y refuerza visualmente que estas implementaciones concretas están inseparablemente atadas a la clase abstracta.

Ambos enfoques (`internal sealed` separadas o `internal sealed` anidadas) cumplen el objetivo de acotar el dominio y funcionan perfectamente con la expresión `switch` de C\#.

--

**Observaciones finales:**
- En C#, las subclases selladas pueden estar en diferentes archivos, pero para claridad se recomienda agruparlas.
- Este patrón es muy útil para modelar cualquier dominio con variantes cerradas: tipos de documentos, estados de UI, resultados de validación, etc.

---

## 8. Tipos especiales: struct, class, record

C# ofrece varios tipos para definir estructuras de datos con diferentes características:
  - `class`: Tipo de referencia, permite herencia, puede ser mutable o inmutable.
  - `struct`: Tipo de valor, no permite herencia, generalmente mutable pero puede ser inmutable.
  - `record`: Tipo de referencia, diseñado para datos inmutables, permite herencia y proporciona igualdad basada en valores.

Debes tener en cuenta las diferencias clave:

| Tipo     | Herencia | Inmutabilidad | Almacenamiento | Uso típico               |
| -------- | -------- | ------------- | -------------- | ------------------------ |
| `class`  | Sí       | Opcional      | Heap           | Objetos completados      |
| `struct` | No       | Opcional      | Stack (valor)  | Pequeños datos           |
| `record` | Sí       | Por defecto   | Heap           | Objetos inmutables/Datos |

#### Ejemplo

```csharp
public record Persona(string Nombre, int Edad);
// Igualdad automática, ideal para datos transfer (DTO)

public struct Punto
{
    public int X, Y;
    public Punto(int x, int y) { X = x; Y = y; }
}

public class Coche
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public Coche(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
}

```
---

## 9. Interfaces

### 9.1. Definición y propósito

Una **interface** en C# es un contrato que define **métodos**, **propiedades**, **eventos** o **indexadores**, pero no su implementación (al menos hasta C# 7.x). Una clase o struct que implementa una interface debe proporcionar una implementación para todos los miembros definidos en la interface (salvo que la interface ofrezca implementación por defecto a partir de C# 8).

Se puede decir que una interface es un conjunto de reglas que una clase debe seguir si decide "firmar" ese contrato y estar de acuerdo con él y obligarse a cumplirlo.

a su vez, es un mecanismo fundamental para lograr **abstracción**, **polimorfismo múltiple** y **desacoplamiento** en el diseño de software, y para simular la herencia múltiple en C#.

- **Las interfaces permiten:**
  - Definir “lo que algo puede hacer” sin establecer cómo lo hace.
  - El polimorfismo múltiple: una clase puede implementar varias interfaces, heredando comportamientos de distintos "contratos". Lo que no es posible con la herencia de clases.
  - La programación orientada a interfaces en vez de a clases: tu código depende de contratos, no de implementaciones concretas.
  - Tipar variables y colecciones, facilitando la reutilización y pruebas unitarias.
  - Puede obligar a una clase a implementar un método estático (como un operador + o un Crear()).

---

### 9.2. Ejemplo básico de interface y uso como tipo

- Al contrario que una clase, una interface no puede contener campos ni constructores.
- Los miembros de una interface son **públicos por defecto** y no pueden tener modificadores de acceso.
- Una interface no puede ser instanciada directamente.
- Una clase implementa una interface usando el operador `:` y debe implementar todos sus miembros.
- Los métodos de una interfaz no necesitan ser marcados con `virtual` o `abstract`. Esto es implícito.
- Una clase puede implementar múltiples interfaces separándolas con comas.
- Las interfaces pueden heredar de otras interfaces y permiten herencia múltiple entre interfaces.
- La implementaciones de métodos en la clase de una interfaz no tiene que usar `override`, ya que no hay implementación previa.
- **Sirven como tipos**: puedes declarar variables, parámetros o colecciones de tipo interface.

```csharp
public interface IVehiculo
{
    void Arrancar();
    void Parar();
    // Obligas a la clase a tener este método estático
    static abstract bool Crear();
}

public class Coche : IVehiculo
{
    public void Arrancar() => Console.WriteLine("El coche arranca");
    public void Parar() => Console.WriteLine("El coche para");
    public static bool Crear() => true; // Implementación del método estático
}


Vehiculo vehiculo = new Coche();
vehiculo.Arrancar(); // "El coche arranca"
vehiculo.Parar();    // "El coche para"
Vehiculo.Crear();  // true

// Uso como tipo (TIPADO), lo veremos más adelante
IVehiculo miVehiculo = new Coche();
miVehiculo.Arrancar(); // "El coche arranca"
miVehiculo.Parar();    // "El coche para"
```
**Nota:**  
Aunque la variable es de tipo `IVehiculo`, la llamada a los métodos invoca la implementación de la clase concreta (`Coche`). Así puedes intercambiar clases fácilmente.

---

### 9.3. Implementación de múltiples interfaces

Una clase puede implementar varias interfaces:

```csharp
public interface IElectric
{
    void Recargar();
}

public class CocheElectrico : IVehiculo, IElectric
{
    public void Arrancar()   => Console.WriteLine("Arranca el coche eléctrico");
    public void Parar()      => Console.WriteLine("Para el coche eléctrico");
    public void Recargar()   => Console.WriteLine("Recarga...");
}
```
Esto permite mezclar distintos "contratos" en una misma clase.

---

### 9.4. Herencia múltiple de interfaces
Una interface puede heredar de múltiples interfaces:

```csharp
public interface IVehiculoTerrestre
{
    void Conducir();
}
public interface IVehiculoAereo
{
    void Volar();
}

public interface IVehiculoHibrido : IVehiculoTerrestre, IVehiculoAereo
{
    void CambiarModo();
}

public class AvionCoche : IVehiculoHibrido
{
    public void Conducir() => Console.WriteLine("Conduciendo en tierra");
    public void Volar()    => Console.WriteLine("Volando en el aire");
    public void CambiarModo() => Console.WriteLine("Cambiando modo entre tierra y aire");
}
```
---


### 9.5. Métodos y propiedades por defecto en interfaces

Desde C#, se pueden proporcionar implementaciones por defecto para métodos y propiedades en interfaces.  
Esto significa que si una clase no implementa explícitamente ese método, usará la versión por defecto de la interface (pero **puede** sobrescribirla si lo desea).

```csharp
public interface IVehiculo
{
    void Arrancar();
    void Parar()
    {
        Console.WriteLine("Parando de forma genérica (por defecto)");
    }
}

public class Patinete : IVehiculo
{
    public void Arrancar() => Console.WriteLine("El patinete arranca");
    // Parar() no implementado: usará el de IVehiculo
}

Patinete p = new Patinete();
p.Arrancar(); // "El patinete arranca"
p.Parar();    // "Parando de forma genérica (por defecto)"
```

---

### 9.6. Uso de interfaces para tipar

Una de las ventajas más poderosas de las interfaces en C# es poder usarlas como **tipo de variables, listas o argumentos**, para desacoplar tu código:
```csharp
public interface IAnimal
{
    void HacerSonido();
}

public class Perro : IAnimal
{
    public void HacerSonido() => Console.WriteLine("Guau guau");
}

public class Gato : IAnimal
{
    public void HacerSonido() => Console.WriteLine("Miau miau");
}

public void HacerSonarAnimal(IAnimal animal)
{
    animal.HacerSonido();
}

Animal[] animales = { new Perro(), new Gato() };

foreach (IAnimal a in animales)
{
    HacerSonarAnimal(a); // Polimorfismo: cada animal suena diferente
}
```

Esto hace que tu código sea flexible, ampliable y fácil de mantener o testear.

---

### 9.7. ¿Qué ocurre si dos interfaces declaran el mismo método?

#### Caso 1: Conflicto, **misma firma**, sin implementación por defecto

```csharp
public interface IZumbador
{
    void Arrancar();
}
public interface IVehiculo
{
    void Arrancar();
}

public class Coche : IVehiculo, IZumbador
{
    // Una sola implementación: sirve a ambas interfaces
    public void Arrancar() => Console.WriteLine("Arranca según ambos contratos");
}
```
*El método implementado sirve para las dos interfaces porque la firma es igual.*

#### Caso 2: **Firma igual, métodos por defecto distintos**

```csharp
public interface IA
{
    void Muestra() => Console.WriteLine("Muestra IA");
}
public interface IB
{
    void Muestra() => Console.WriteLine("Muestra IB");
}

public class Demo : IA, IB
{
    // No se implementa Muestra aquí
}

Demo d = new Demo();
// d.Muestra(); // Error, ambigüedad
```
**Esto produce ambigüedad:**  
- Si llamas a `d.Muestra()`, el compilador da error pues no sabe cuál coger.
- Puedes **usar alias explícito** para seleccionar qué implementación quieres invocar.

#### Solución: Implementación explícita y alias de interface

```csharp
public class Demo : IA, IB
{
    void IA.Muestra() => Console.WriteLine("Muestra IA (alias)");
    void IB.Muestra() => Console.WriteLine("Muestra IB (alias)");
}

Demo d = new Demo();
((IA)d).Muestra(); // "Muestra IA (alias)"
((IB)d).Muestra(); // "Muestra IB (alias)"
```
**Nota:**  
- Las implementaciones explícitas sólo pueden ser llamadas mediante conversión al interface correspondiente.

---

### 9.8. Uso de Herencia e Interfaces juntos
Cuando una clase hereda de otra y además implementa interfaces, la jerarquía se vuelve más compleja pero también más flexible y debemos conocer las reglas, asi como su sistema de resolución de métodos. ¿Qué se suele poner primero después de los dos puntos (`:`)? Siempre la clase base primero (herencia simple), luego las interfaces (implementación múltiple).

```csharp
public class Vehiculo
{
    public virtual void Arrancar() => Console.WriteLine("Vehículo arrancando");
}

public interface IZumbador
{
    void Arrancar();
}

public class Coche : Vehiculo, IZumbador
{
    public override void Arrancar() => Console.WriteLine("Coche arrancando");
    // Implementación de IZumbador no es necesaria si la firma coincide
}
```

¿Qué pasa si hay una ambigüedad entre la clase base y la interface? La clase base tiene prioridad o las dos tiene una implementación por defecto distinta? Se puede usar alias explícito para resolverlo.

```csharp
public interface IA
{
    void Muestra() => Console.WriteLine("Muestra IA");
}
public class Base
{
    public virtual void Muestra() => Console.WriteLine("Muestra Base");
}

public class Derivada : Base, IA
{
    // No se implementa Muestra aquí
}
Derivada d = new Derivada();
d.Muestra(); // "Muestra Base" (la clase base tiene prioridad)
```
// Si quieres llamar a la versión de IA, debes usar alias explícito:
```csharp
((IA)d).Muestra(); // "Muestra IA"
```
---

### 9.9. Resumen de ventajas y mejores prácticas

- Las interfaces permiten una programación orientada a contratos.
- Facilitan el polimorfismo y el desacoplamiento del código.
- Permiten usar métodos por defecto para mantener la compatibilidad hacia atrás y evolucionar APIs.
- Si dos interfaces tienen métodos con la misma firma, se puede usar una única implementación (si no hay conflicto de implementación por defecto) o alias con implementación explícita.
- ¡Se usan para "tipar" variables, colecciones y argumentos, permitiendo máxima flexibilidad!

---

## 10. Polimorfismo

El **polimorfismo** permite que diferentes clases respondan de manera distinta a la misma interfaz o método. Esto se logra principalmente mediante la herencia y las interfaces. ¿Por qué es útil? Porque permite escribir código más flexible y reutilizable.

De esta manera **en tiempo de ejecución, el método que se ejecuta depende del tipo real del objeto, no del tipo de la referencia**.

Es decir, puedes tener una variable de tipo base o interface que apunte a objetos de diferentes clases derivadas, y al llamar a un método, se ejecutará la versión correspondiente a la clase real del objeto.

Una de las ventajas es poder tener colecciones y/o métodos que trabajen con tipos más generales, y el comportamiento específico se determina en tiempo de ejecución.

¿Por qué funciona? Pues en tiempo de ejecución se resuelve el método correcto mediante una tabla de métodos virtuales (vtable) que asocia cada clase con sus implementaciones y con ello se consigue el comportamiento polimórfico.

Diferencia entre sobrecarga (compile-time) y polimorfismo (run-time):
- **Sobrecarga de métodos:** Mismo nombre, diferentes parámetros. Resuelto en tiempo de compilación.
- **Polimorfismo:** Mismo método, diferentes implementaciones. Resuelto en tiempo de ejecución.

La herencia se resuelve en tiempo de compilación, pero el polimorfismo en tiempo de ejecución. Es decir se hereda siempre de arriba abajo, es jerárquica (va bajando por el árbol). Si necesito saber quien tiene un método o propiedad, subo por el arboil hasta encontrarlo.

La ligadura dinámica (dynamic binding) es el mecanismo que permite que la llamada a un método se resuelva en tiempo de ejecución, basándose en el tipo real del objeto. ¿Cómo funciona? Cuando se llama a un método virtual, el sistema busca en la vtable del objeto para encontrar la implementación correcta según su tipo real. Es decir recorre el árbol de herencia para encontrar la implementación más específica (de abajo a arriba, va subiendo).

### 10.1 Polimorfismo por herencia

```csharp
class Animal
{
    public virtual void HacerSonido() => Console.WriteLine("El animal hace un sonido");
}

class Vaca : Animal
{
    public override void HacerSonido() => Console.WriteLine("Muuuu");
}

class Perro : Animal
{
    public override void HacerSonido() => Console.WriteLine("Guau guau");
}

class Gato : Animal
{
    public override void HacerSonido() => Console.WriteLine("Miau miau");
}


Animal[] animales = {
    new Vaca(), new Perro(), new Gato()
};

foreach (Animal a in animales)
{
    a.HacerSonido(); // Cada animal ejecuta su propio método, dependiendo de su tipo real (Vaca, Perro, Gato)
}
```

### 10.2 Polimorfismo con interfaces

```csharp
public interface IPintable
{
    void Pintar();
}

public class Coche : IPintable
{
    public void Pintar() => Console.WriteLine("Pintando coche");
}
public class Casa : IPintable
{
    public void Pintar() => Console.WriteLine("Pintando casa");
}

IPintable[] objetos = {
    new Coche(),
    new Casa()
};

foreach (IPintable obj in objetos)
{
    obj.Pintar(); // Cada objeto ejecuta su propio método Pintar
}
```

---

### 10.3 Casting y comprobación de tipos para polimorfismo seguro

A la hora de trabajar con polimorfismo, a veces es necesario convertir (cast) una referencia de un tipo base o interface a un tipo derivado específico para acceder a miembros particulares de la clase derivada. ¿Por qué? Porque el tipo base o interface no conoce esos miembros específicos. Si trabajamos con un enfoque "general" necesitamos asegurarnos de que el objeto realmente es del tipo esperado antes de hacer el cast, para evitar errores en tiempo de ejecución.

#### Casting explícito

```csharp
class Vehiculo { 
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
}

class Coche : Vehiculo
{
    public string Color { get; set; }
    public Coche(string marca, string modelo, string color)
        : base(marca, modelo)
    {
        Color = color;
    }
    public void Arrancar() => Console.WriteLine("Coche arrancado");
}

Vehiculo v = new Coche("Seat", "Ibiza", "Rojo");

// V que es? Es un Vehiculo, pero en realidad es un Coche, pero como Vehiculo no tiene Arrancar(), como lo hacemos?
Coche c = (Coche)v; // Funciona si v es realmente un Coche y si no lanza InvalidCastException
c.Arrancar(); // "Coche arrancado"
```

#### Casting seguro `as`
Este operador intenta convertir y si no puede, devuelve `null` en vez de lanzar excepción. Es útil para evitar errores en tiempo de ejecución. A su vez permite comprobar si la conversión fue exitosa.

```csharp
Vehiculo v = new Moto("Ducati", "Monster", "Negro");
Coche c = v as Coche;
if (c != null)
    c.Arrancar();
else
    Console.WriteLine("El vehículo no es un coche");
```

### Comprobación de tipos con `is` y pattern matching
El operador `is` permite comprobar si un objeto es de un tipo específico antes de hacer un cast. Desde C# 7, se puede usar junto con pattern matching para simplificar el código.

```csharp
if (v is Moto m)
{
    m.Arrancar();
}
```

**Pattern Matching en C# 14** (patrones de tipo, de propiedades...)
Nos permite hacer comprobaciones más complejas y específicas de tipos, por ejemplo comprobar si un objeto es de un tipo concreto y además cumple ciertas condiciones en sus propiedades.

```csharp
// Estamos comprobando si v es un Coche y además su Color es "Rojo"
if (v is Coche { Color: "Rojo" })
{
    Console.WriteLine("¡Este coche es rojo!");
}
```

**Contraejemplo:**  
Nunca hacer un cast directo si no sabes el tipo real:

```csharp
Coche c = (Coche)v; // Si v no es Coche, lanza InvalidCastException
```

---
### 10.4 Polimorfismo en Colecciones y Métodos
Siempre que trabajes con colecciones o métodos que acepten tipos base o interfaces, el polimorfismo te permitirá manejar distintos tipos derivados sin cambiar el código. Para empezar siempre define la colección con el tipo base o interface, de esta manera puedes añadir cualquier objeto que implemente esa interface o herede de esa clase base.

Luego usa polimorfismo para llamar a los métodos adecuados en tiempo de ejecución usando el tipo real del objeto y usando un casting seguro si es necesario.

```csharp
interface IForma
{
    double Area();
}

class Circulo : IForma
{
    public double Radio { get; set; }
    public Circulo(double radio) => Radio = radio;
    public double Area() => Math.PI * Radio * Radio;
}

class Rectangulo : IForma
{
    public double Ancho { get; set; }
    public double Alto { get; set; }
    public Rectangulo(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }
    public double Area() => Ancho * Alto;
    public double Perimetro() => 2 * (Ancho + Alto);
}

IForma[] formas = {
    new Circulo(5),
    new Rectangulo(4, 6)
};

foreach (IForma forma in formas)
{
    Console.WriteLine($"Área: {forma.Area()}"); // Cada forma calcula su área según su tipo real
    if (forma is Rectangulo r)
    {
        Console.WriteLine($"Perímetro: {r.Perimetro()}"); // Accedemos a Perímetro sólo si es Rectángulo
    }
}
```

## 11. Herencia vs Composición

### 11.1. Conceptos fundamentales

**Herencia** y **Composición** son los dos principales mecanismos para organizar y reutilizar código en la programación orientada a objetos.  
Ambos tienen propósitos distintos y diferentes implicaciones en el mantenimiento, evolución y robustez de tus aplicaciones.

#### Herencia (`IS-A` o "Es un")

- Una clase *hereda* de otra, adquiriendo sus métodos y propiedades.
- Se utiliza para modelar una relación de “tipo”, donde la subclase es una versión especial de la clase base.
- Ejemplo típico: Un `Perro` hereda de `Animal` porque un perro **es** un animal.

#### Composición (`HAS-A` o "Tiene un")

- Una clase *contiene* instancias de otras clases.
- Se utiliza para modelar relaciones de “parte”, donde una clase contiene o utiliza otra como funcionalidad interna.
- Ejemplo típico: Un `Coche` tiene un `Motor`, no es un motor, sino que utiliza uno para funcionar.

---

### 11.2. Pros y contras de la Herencia

**Ventajas:**
- Fomenta la **reutilización de código**: las subclases pueden usar o sobrescribir métodos y propiedades de la base.
- Permite **polimorfismo**: puedes trabajar con objetos de la clase base y ejecutar métodos sobrescritos de las derivadas.
- Organiza el código en jerarquías lógicas y facilita la extensión de comportamientos.

**Desventajas (y por qué puede ser un anti-patrón):**
- **Acoplamiento fuerte**: las subclases dependen internamente de la implementación de la clase base. Si algo cambia en la base, puede romper muchas derivadas.
- Puede llevar a **jerarquías poco flexibles y difíciles de mantener**, sobre todo si la herencia se utiliza demasiado y sin criterio claro.
- **Frágil para evolución**: pequeño cambio en la base, grandes problemas en toda la jerarquía.
- **Herencia inapropiada**: si la relación no es realmente un IS-A y se fuerza la herencia, tendrás métodos o propiedades sin sentido en la subclase (por ejemplo, hacer que un `Auto` herede de `Motor`).
- **Violación del principio de sustitución de Liskov** si la subclase no puede comportarse como la base (por diseño o por lógica de negocio).
- Añade **complejidad innecesaria** y puede producir el anti-patrón conocido como **God Object** o **jerarquía profunda**.

---

### 11.3. Pros y contras de la Composición

**Ventajas:**
- **Desacoplamiento**: las clases utilizan otras clases por sus interfaces, pueden cambiar fácilmente la implementación.
- Promueve la **flexibilidad y extensibilidad**: puedes componer objetos complejos a partir de objetos más simples.
- Facilita la **prueba unitaria y la reutilización**.
- Es base fundamental de la **inyección de dependencias**: puedes inyectar distintos objetos que cumplan la misma interface sin modificar la clase principal.
- Permite **cambiar comportamientos en tiempo de ejecución** de forma muy sencilla.

**Desventajas:**
- A veces requiere **más código de "pegado"** (constructores, setters).
- Si no se implementa bien, puede llevar a objetos muy fragmentados y difíciles de manejar.
- La lógica para establecer las relaciones entre componentes suele ser responsabilidad de otro módulo o patrón (como el **dependency injection container**).

---

### 11.4. ¿Por qué la composición suele ser preferible en el diseño moderno?

Actualmente, la composición es el patrón recomendado por la mayoría de expertos en diseño OO por:
- Su flexibilidad, desacoplamiento y extensibilidad.
- Facilita el uso de **principios SOLID**, especialmente el principio de inversión de dependencias.
- Permite cambiar e inyectar colaboradores fácilmente mediante **interfaces**, favoreciendo la evolución y el testeo.

#### Herencia puede ser un antipatrón cuando:
- Se utiliza para reutilizar código “rápido”, en vez de definir una verdadera relación IS-A.
- Se crean jerarquías profundas y arduas de mantener.
- Las subclases se ven obligadas a heredar métodos o propiedades que no tienen sentido para su dominio.

**Regla de oro:**  
“Prefiere composición a herencia”, sobre todo cuando no existe una relación clara y real de tipo entre clases.

---

### 11.5. Ejemplo comparativo y con interfaces

#### Ejemplo de herencia (IS-A):

```csharp
public class Animal
{
    public virtual void HacerSonido() => Console.WriteLine("Sonido genérico");
}

public class Perro : Animal
{
    public override void HacerSonido() => Console.WriteLine("Guau guau!");
}
```

-----------
#### Ejemplo de composición (HAS-A):

```csharp
public class Motor
{
    public void Encender() => Console.WriteLine("Motor encendido");
}
public class Coche
{
    private Motor motor;
    public Coche(Motor motor)
    {
        this.motor = motor; // Inyección de dependencia
    }
    public void Arrancar() => motor.Encender();
}
```
Así, `Coche` puede recibir **distintos motores** con el mismo tipo (por ejemplo, a través de una interface):

```csharp
public interface IMotor
{
    void Encender();
}

public class MotorGasolina : IMotor
{
    public void Encender() => Console.WriteLine("Motor gasolina encendido");
}

public class MotorElectrico : IMotor
{
    public void Encender() => Console.WriteLine("Motor eléctrico encendido");
}

public class Coche
{
    private IMotor motor;
    public Coche(IMotor motor)
    {
        this.motor = motor; // Inyección de dependencia por interface
    }
    public void Arrancar() => motor.Encender();
}
```

```csharp
Coche coche1 = new Coche(new MotorGasolina());
Coche coche2 = new Coche(new MotorElectrico());
coche1.Arrancar(); // Motor gasolina encendido
coche2.Arrancar(); // Motor eléctrico encendido
```
Esto hace al `Coche` **totalmente desacoplado** de la implementación concreta del motor.

---

### 11.6. Relación entre composición e interfaces

- Las interfaces permiten abstraer el comportamiento de los componentes, haciendo que la composición sea aún más poderosa.
- Es la base de muchos patrones de diseño (como **Strategy**, **Decorator** o **Adapter**).
- La combinación de interfaces y composición permite construir aplicaciones modulares y fácilmente extensibles.

---

**Conclusión:**  
La herencia es útil para organizar y reutilizar código, pero en exceso genera mantenibilidad reducida y acoplamiento elevado, y puede convertirse en un anti-patrón.  
La composición y el uso de interfaces permiten programar por contratos, desacoplar dependencias e implementar aplicaciones modernas, flexibles y robustas.



---

## 12. Principios SOLID (explicaciones y ejemplos reales)

Los principios **SOLID** son la base del diseño profesional en programación orientada a objetos. Aplicarlos te ayuda a crear sistemas **robustos**, **mantenibles**, **flexibles** y **escalables**.  
SOLID es un acrónimo de:
- **S**: Single Responsibility Principle (Responsabilidad Única)
- **O**: Open/Closed Principle (Abierto/Cerrado)
- **L**: Liskov Substitution Principle (Sustitución de Liskov)
- **I**: Interface Segregation Principle (Segregación de Interfaces)
- **D**: Dependency Inversion Principle (Inversión de Dependencias)

---

### S - Single Responsibility Principle (Responsabilidad Única)

**Teoría:**  
Cada clase debe tener **una sola razón para cambiar**, es decir, debe encargarse de una única responsabilidad dentro del sistema. Si una clase gestiona más de un motivo de cambio, será más difícil de mantener y extender.

**Ejemplo MAL diseñado (violando SRP):**

```csharp
public class Reporte
{
    public void Generar()
    {
        Console.WriteLine("Reporte generado");
    }
    public void Imprimir()
    {
        Console.WriteLine("Reporte impreso");
    }
}
```
> Aquí, la clase `Reporte` genera e imprime el reporte – **dos responsabilidades**.

**Ejemplo BIEN diseñado (aplicando SRP):**

```csharp
public class Reporte
{
    public void Generar()
    {
        Console.WriteLine("Reporte generado");
    }
}

public class Impresora
{
    public void Imprimir(Reporte reporte)
    {
        Console.WriteLine("Imprimiendo reporte...");
    }
}
```
> Ahora cada clase tiene UNA responsabilidad. `Reporte` solo genera, `Impresora` solo imprime. 

---

### O - Open/Closed Principle (Abierto/Cerrado)

**Teoría:**  
Las entidades (clases, módulos, funciones) deben estar **abiertas para extensión** pero **cerradas para modificación**. Cuando añades nuevos comportamientos, lo haces **extendiendo** (heredando, agregando), no cambiando el código existente.

**Ejemplo MAL diseñado:**

```csharp
public class CalculadoraDeAreas
{
    public double AreaTotal(object[] figuras)
    {
        double area = 0;
        foreach (var figura in figuras)
        {
            if (figura is Circulo c)
                area += Math.PI * c.Radio * c.Radio;
            else if (figura is Cuadrado cu)
                area += cu.Lado * cu.Lado;
        }
        return area;
    }
}
```
> Cada vez que se añade una nueva figura, hay que modificar el método: **violación OCP**.

**Ejemplo BIEN diseñado:**

```csharp
public abstract class Forma
{
    public abstract double Area();
}

public class Circulo : Forma
{
    public double Radio { get; set; }
    public override double Area()
    {
        double a = Math.PI * Radio * Radio;
        Console.WriteLine($"Área círculo: {a}");
        return a;
    }
}

public class Cuadrado : Forma
{
    public double Lado { get; set; }
    public override double Area()
    {
        double a = Lado * Lado;
        Console.WriteLine($"Área cuadrado: {a}");
        return a;
    }
}

// Uso
Forma[] formas = { new Circulo { Radio = 2 }, new Cuadrado { Lado = 3 } };
double areaTotal = formas.Sum(f => f.Area());
Console.WriteLine($"Área total: {areaTotal}");

```
> Ahora puedes añadir nuevas figuras **sin modificar** la clase de cálculo. Esta está **abierta para extensión** pero **cerrada para modificación**.

---

### L - Liskov Substitution Principle (Sustitución de Liskov)

**Teoría:**  
Si una clase B es una subclase de A, entonces deberías poder sustituir A por B **sin alterar el funcionamiento** del programa.  
Nunca crees una subclase que **rompa las expectativas** del comportamiento de la clase base. Si no puedes garantizar esto, probablemente la herencia no es adecuada o el diseño debe ser revisado.

**Ejemplo que VIOLA Liskov:**

```csharp
public class Pajaro
{
    public virtual void Volar()
    {
        Console.WriteLine("El pájaro vuela");
    }
}

public class Pinguino : Pajaro
{
    public override void Volar()
    {
        throw new NotSupportedException("El pingüino no vuela");
    }
}

// Uso, Es decir, Se debería sustituir Pajaro por Pinguino, pero no funciona no cumple Liskov
Pajaro p = new Pinguino();
try
{
    p.Volar(); // Excepción inesperada
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
```
> ¡Un Pinguino no se puede comportar como un Pajaro!  
> Hay que replantear el diseño, quizás con interfaces que separen capacidades.

**Solución con interfaces (aplicando Liskov):**

```csharp
public interface IPajaro { }
public interface IPajaroVolador : IPajaro
{
    void Volar();
}

public class Aguila : IPajaroVolador
{
    public void Volar() => Console.WriteLine("El águila vuela");
}

public class Pinguino : IPajaro
{
    public void Nadar() => Console.WriteLine("El pingüino nada");
}

// Ahora verás que no hay violación de Liskov
IPajaroVolador pajaroVolador = new Aguila();
pajaroVolador.Volar(); // Funciona perfectamente, donde se espera un IPajaroVolador se usa un Aguila y no hay violación.

```

---

### I - Interface Segregation Principle (Segregación de Interfaces)

**Teoría:**  
Ninguna clase debe verse obligada a implementar métodos que no necesita. Es mejor usar **interfaces pequeñas y especializadas** que una grande y generalista.

**MAL diseño (violando ISP):**

```csharp
public interface IMultifuncion
{
    void Imprimir();
    void Escanear();
}

public class ImpresoraSimple : IMultifuncion
{
    public void Imprimir() => Console.WriteLine("Imprimiendo");
    public void Escanear()
    {
        throw new NotSupportedException("No puede escanear");
    }
}
```

**BIEN diseñado (aplicando ISP):**

```csharp
public interface IImpresora
{
    void Imprimir();
}
public interface IEscaner
{
    void Escanear();
}

public class Impresora : IImpresora
{
    public void Imprimir() => Console.WriteLine("Imprimiendo documento");
}
public class Multifuncion : IImpresora, IEscaner
{
    public void Imprimir() => Console.WriteLine("Imprimiendo");
    public void Escanear() => Console.WriteLine("Escaneando");
}

var impresora = new Impresora();
impresora.Imprimir(); // "Imprimiendo documento"
var multifuncion = new Multifuncion();
multifuncion.Imprimir(); // "Imprimiendo"
multifuncion.Escanear(); // "Escaneando"

```
> Ahora cada clase implementa **únicamente** lo que necesita.

---

### D - Dependency Inversion Principle (Inversión de dependencias)

**Teoría:**  
Las clases **no deben depender de implementaciones concretas**, sino de abstracciones (interfaces). Esto permite **facilitar cambios, testear y desacoplar** el sistema.

**MAL diseño (violación DIP):**

```csharp
public class MotorGasolina
{
    public void Encender() => Console.WriteLine("Motor gasolina encendido");
}
public class Automovil
{
    private MotorGasolina motor = new MotorGasolina(); // Acoplamiento fuerte, porque se hace dentro y no puedes cambiatr el tipo!!!
    public void Arrancar() => motor.Encender();
}
```
> No puedes cambiar el tipo de motor sin modificar el código de `Automovil`. Usa interfaces para desacoplar y por cumplir DIP (Dependency Inversion Principle por construcción).

**BIEN diseñado (aplicando DIP):**

```csharp
public interface IMotor
{
    void Encender();
}
public class MotorGasolina : IMotor
{
    public void Encender() => Console.WriteLine("Motor gasolina encendido");
}
public class MotorElectrico : IMotor
{
    public void Encender() => Console.WriteLine("Motor eléctrico encendido");
}
public class Automovil
{
    private IMotor motor;
    public Automovil(IMotor motor)
    {
        this.motor = motor;
    }
    public void Arrancar() => motor.Encender();
}
// Uso:
Automovil auto1 = new Automovil(new MotorGasolina());
Automovil auto2 = new Automovil(new MotorElectrico());
auto1.Arrancar(); // Motor gasolina encendido
auto2.Arrancar(); // Motor eléctrico encendido
```
> Ahora puedes cambiar la dependencia **sin tocar ni una línea** en la clase `Automovil`. Inyectas la dependencia por el constructor y además usas una interface para desacoplar y polimorfismo. Aplicas inyección de dependencias.

---

### Resumen y guía didáctica

**Aplicar SOLID en tu diseño OO te permite:**
- Escribir código mantanible y flexible.
- Facilitar la prueba unitaria y la evolución.
- Desacoplar módulos y funciones, facilitando la extensión futura.
- Evitar anti-patrones como el God Object, la jerarquía profunda, la rigidez o la duplicación de lógica.

**Recuerda:**  
- **SRP**: Una clase = Una responsabilidad.  
- **OCP**: El código se extiende, NO se modifica.  
- **LSP**: Los subtipos se pueden usar donde se espera la clase base.  
- **ISP**: Interfaces pequeñas y funcionales.  
- **DIP**: Depender siempre de abstracciones (interfaces).


### Ejemplo completo aplicando SOLID

```csharp
public interface INotificador
{
    void Notificar(string mensaje);
}

public class EmailNotificador : INotificador
{
    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando email: {mensaje}");
    }
}

public class SMSNotificador : INotificador
{
    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando SMS: {mensaje}");
    }
}

public class Usuario
{
    private readonly INotificador notificador;

    public Usuario(INotificador notificador)
    {
        this.notificador = notificador;
    }

    public void Registrar(string nombre)
    {
        // Lógica de registro...
        notificador.Notificar($"Usuario {nombre} registrado exitosamente.");
    }
}

public class UsuarioConModificacionDeNotificador
{
    private INotificador notificador;

    public UsuarioConModificacionDeNotificador(INotificador notificador)
    {
        this.notificador = notificador;
    }

    public void CambiarNotificador(INotificador nuevoNotificador)
    {
        this.notificador = nuevoNotificador;
    }

    public void Registrar(string nombre)
    {
        // Lógica de registro...
        notificador.Notificar($"Usuario {nombre} registrado exitosamente.");
    }
}

// Uso
INotificador emailNotificador = new EmailNotificador();
Usuario usuario = new Usuario(emailNotificador);
usuario.Registrar("Juan Pérez");

UserioConModificacionDeNotificador usuario2 = new UsuarioConModificacionDeNotificador(emailNotificador);
usuario2.Registrar("Ana Gómez");
usuario2.CambiarNotificador(new SMSNotificador());
usuario2.Registrar("Ana Gómez");

```

Analisis de los principios SOLID aplicados:
- **SRP**: `Usuario` solo se encarga de la lógica de registro, `EmailNotificador` y `SMSNotificador` solo de notificar. Cada clase tiene una única responsabilidad.
- **OCP**: Puedes añadir nuevos tipos de notificadores sin modificar `Usuario`. Esto cumple el principio abierto/cerrado ya que `Usuario` está cerrado para modificaciones pero abierto para extensiones.
- - **LSP**: Cualquier implementación de `INotificador` puede ser usada en lugar de otra sin alterar el comportamiento esperado de `Usuario`. Esto cumple el principio de sustitución de Liskov y asegura que las clases derivadas pueden sustituir a la base sin problemas.
- **ISP**: `INotificador` es una interfaz pequeña y específica. Las clases que la implementan no están obligadas a implementar métodos que no necesitan. Se puede tener múltiples interfaces si es necesario.
- **DIP**: `Usuario` depende de la abstracción `INotificador`, no de implementaciones concretas. Esto permite cambiar el tipo de notificador sin modificar `Usuario`. De hecho puedes inyectar cualquier implementación de `INotificador`, ver el caso de `UsuarioConModificacionDeNotificador` que permite cambiar el notificador en tiempo de ejecución.


**En conclusión, dominar SOLID es el primer paso hacia el diseño profesional de aplicaciones orientadas a objetos.**


---

## 13. Referencias y paso de parámetros (`ref` vs `out` vs `in`)

Antes de terminar, es importante entender cómo se pasan los parámetros en C# y cuando usamos referencias o valores: clases, estructuras, tipos primitivos o arrays.

Debemos recordar que en C# los tipos se dividen en dos grandes categorías:
- **Tipos por valor**: incluyen tipos primitivos (int, float, bool, etc.) y estructuras (struct). Estos tipos almacenan directamente sus datos y cuando se pasan como parámetros a métodos, se pasa una copia del valor. Se almacenan en la pila (stack).
- **Tipos por referencia**: incluyen clases (class), arrays y cadenas (string). Estos tipos almacenan una referencia (dirección de memoria) al objeto real. Cuando se pasan como parámetros, se pasa una copia de la referencia, no del objeto en sí. Se almacenan en el montón (heap).


---

## 13.1. Comportamiento sin modificadores (Paso por valor)

Es lo que ocurre cuando declaramos una función normal: `void MiFuncion(int numero, int[] array)`.

* **Con Structs y tipos de datos simples (`int`, `bool`):** Se crea una **COPIA** independiente, no relacionada.
* *Efecto:* Si cambias el valor dentro, fuera **no pasa nada**. Es decir, es como hacer una fotocopia del papel y trabajar sobre ella, por mucho que la modifiques, el original sigue igual.

```csharp
void ModificarValor(int numero) {
    numero = 99; // Cambio local, no afecta fuera
}

int x = 5;
ModificarValor(x);
Console.WriteLine(x); // Imprime 5, no 99
```

* **Con Clases y Arrays:** Se pasa una **COPIA DE LA DIRECCIÓN**.
* *Efecto A:* Puedes entrar a la casa y cambiar los muebles (modificar `array[0]` o `objeto.Propiedad`). **Esto SÍ afecta fuera.**
  
```csharp
void ModificarArray(int[] numeros) {
    numeros[0] = 99; // Cambia el contenido del array original
}

int[] arr = { 1, 2, 3 };
ModificarArray(arr);
Console.WriteLine(arr[0]); // Imprime 99
```

* *Efecto B:* NO puedes cambiar la casa por otra (hacer `new`). Si haces `new`, solo cambias tu copia local de la dirección. **Esto NO afecta fuera.**

```csharp
void ReasignarArray(int[] numeros) {
    numeros = new int[5]; // Cambia la referencia local, no afecta fuera, No se ve fuera
}

int[] arr = { 1, 2, 3 };
ReasignarArray(arr);
Console.WriteLine(arr.Length); // Imprime 3, no 5
```

---

## 13.2. El modificador `ref` (Entrada y Salida)

Usamos `ref` cuando queremos romper las reglas anteriores y conectar la variable de dentro con la de fuera permanentemente.

| Tipo de Dato              | ¿Qué permite `ref`?                                          | Ejemplo Mental                                                                                |
| ------------------------- | ------------------------------------------------------------ | --------------------------------------------------------------------------------------------- |
| **Structs y tipos de datos simples** (int, bool...) | Permite modificar el valor original. Sin `ref` no se podría. | "Te doy acceso a mi hoja de papel original para que borres y escribas."                       |
| **Clase / Array**         | Permite hacer un **`new`** (reasignar) y que afecte fuera.   | "Te doy las llaves de mi casa y permiso para que **mudemos a mi familia a otra casa nueva**." |

**Ejemplo: Array con y sin `ref`**

```csharp
// 1. SIN ref: Puedo cambiar datos, pero NO reasignar
void ModificarVariables(int numero) {
    numero = 50;           // ❌ NO se ve fuera (copia local)
}

void ModificarDatos(int[] numeros) {
    numeros[0] = 99;       // ✅ Se ve fuera (cambio mueble)
    numeros = new int[5];  // ❌ NO se ve fuera (cambio casa localmente)
}

// 2. CON ref: Puedo cambiar datos Y reasignar
void ModificarVariablesRef(ref int numero) {
    numero = 50;           // ✅ Se ve fuera (modifica original)
}

void ReasignarArray(ref int[] numeros) {
    numeros = new int[] { 100, 200 }; // ✅ El array original de fuera AHORA ES ESTE
}


var arr = new int[] { 1, 2, 3 };
ModificarDatos(arr);
Console.WriteLine(arr[0]); // Imprime 99 (cambio mueble sí se ve)
Console.WriteLine(arr.Length); // Imprime 3 (cambio casa no se ve)
int val = 10;
ModificarVariables(val);
Console.WriteLine(val); // Imprime 10 (no se ve el cambio)

ReasignarArray(ref arr););
Console.WriteLine(arr.Length); // Imprime 2 (cambio casa sí se ve)
ModificarVariablesRef(ref val);
Console.WriteLine(val); // Imprime 50 (cambio sí se ve)
```

---

## 13.3. El modificador `out` (Salida Pura)

Funciona técnicamente igual que `ref`, pero con una **obligación de seguridad**: la función **debe** crear el dato. No sirve de nada que ya tenga valores, estás **obligado** a asignarlo dentro por todos "los caminos" posibles.

* **Structs o tipos de datos simples:** Se usa para devolver valores calculados (ej. `TryParse`).
* **Clases/Arrays:** Se usa para que la función sea una "fábrica" que cree el objeto por ti.

> **Diferencia Clave con `ref`:** En `ref`, el objeto ya existe antes de entrar. En `out`, el objeto se "fabrica" dentro.

```csharp
// Ejemplo con Struct / Tipo simple
void ObtenerValor(out int numero, out bool exito) {
    var res = new Random().Next(0, 2);
    if (res == 1) {
        numero = 42;
        exito = true;
    } else {
        numero = 0;
        exito = false;
    }
}

// Da igual el valor que se les asignen porque se van a sobrescribir
int valor;
bool resultado;
ObtenerValor(out valor, out resultado);
Console.WriteLine($"Valor: {valor}, Éxito: {resultado}"); // Imprime Valor: 42, Éxito: True o Valor: 0, Éxito: False
```

---

## 13.4. El modificador `in` (Solo Lectura / Rendimiento)

Con `in` indicamos que el parámetro se pasa por referencia (no se copia) pero **no se puede modificar** dentro de la función. Es una forma de optimizar el rendimiento cuando pasamos estructuras o arrays grandes sin permitir cambios accidentales. Es decir, **es una referencia "de solo lectura"**.

¿Por qué usamos `in` por ejemplo en Structs grandes? Porque copiar estructuras grandes (en el paso por valor, que es el paso por defecto) puede ser costoso en rendimiento. Al usar `in`, evitamos la copia (hacemos un paso por referencia) y mejoramos la eficiencia, pero garantizamos que el dato original no se modificará (está bloqueado).

| Tipo de Dato      | Objetivo Principal                           | Comportamiento                                                                     |
| ----------------- | -------------------------------------------- | ---------------------------------------------------------------------------------- |
| **Struct**        | **Rendimiento.** Evita copiar datos grandes. | Pasa la referencia pero **bloquea** cualquier modificación. Es un "candado total". |
| **Clase / Array** | **Seguridad (Intención).**                   | Impide hacer `new` (reasignar). <br>                                               |

<br>⚠️ **¡OJO!** No impide modificar los datos internos (`array[0] = 5` sigue funcionando). |

> **Nota para expertos:** En una Clase o Array, `in` solo protege la variable (la flecha), no el contenido del objeto. En un Struct, protege todo.

```csharp
struct Punto { public int X, Y; }
class Circulo { public Punto Centro; public double Radio; }

void MoverPunto(in Punto p) {
    // p.X = 10; // ❌ ERROR DE COMPILACIÓN: No se puede modificar un struct 'in'
    Console.WriteLine($"Punto en ({p.X}, {p.Y})");
}

void ReasignarCirculo(in Circulo c) {
    // c = new Circulo(); // ❌ ERROR DE COMPILACIÓN: No se puede reasignar un 'in'
    c.Centro.X = 10; // ✅ Esto SÍ se permite, porque modificamos el contenido, no la referencia
}

Punto pt = new Punto { X = 1, Y = 2 };
MoverPunto(in pt); // Imprime Punto en (1, 2)
Circulo cir = new Circulo { Centro = new Punto { X = 0, Y = 0 }, Radio = 5 };
ReasignarCirculo(in cir);
Console.WriteLine($"Centro del círculo: ({cir.Centro.X}, {cir.Centro.Y})"); // Imprime Centro del círculo: (10, 0)
```
---

## 13.5. Resumen y Buenas Prácticas: La Tabla Definitiva

Para no equivocarnos nunca, debemos hacernos dos preguntas antes de elegir un modificador:

1. **¿Qué tipo de dato estoy pasando?** (¿Es un struct/int/bool o es una clase/array?)
2. **¿Qué quiero hacer con él?** (¿Solo leer, modificar sus datos internos o reinicializarlo con un `new`?)

### Tabla de Comportamiento y Permisos

| Tipo de Dato      | Modificador | ¿Copia al pasar? | ¿Cambia datos internos? | ¿Permite `new`?      | Uso recomendado                   |
| ----------------- | ----------- | ---------------- | ----------------------- | -------------------- | --------------------------------- |
| **Struct / Int**  | (Ninguno)   | **SÍ**           | Solo local              | No afecta fuera      | Valores simples (int, bool).      |
| **Struct / Int**  | **ref**     | No               | **SÍ** (Original)       | **SÍ** (Original)    | Swaps o contadores.               |
| **Struct / Int**  | **in**      | No               | **NO** (Error)          | **NO** (Error)       | Optimizar structs grandes.        |
|                   |             |                  |                         |                      |                                   |
| **Clase / Array** | (Ninguno)   | No (Copia ref)   | **SÍ** (Original)       | No afecta fuera      | **Uso estándar (90%)**.           |
| **Clase / Array** | **ref**     | No               | **SÍ** (Original)       | **SÍ** (Original)    | Para redimensionar o `new`.       |
| **Clase / Array** | **out**     | No               | **SÍ**                  | **SÍ** (Obligatorio) | Fábricas/Creación de objetos.     |
| **Clase / Array** | **in**      | No               | **SÍ** (¡Cuidado!)      | **NO** (Error)       | Marcar intención de no reasignar. |

---

### Guía de decisión rápida (Buenas Prácticas)

Para saber qué usar, sigue este orden lógico:

1. **Por defecto, no uses nada.** C# ya gestiona las clases y arrays por referencia de forma eficiente. Solo usa modificadores si tienes un motivo concreto.
2. **Usa `out`** solo cuando necesites que una función devuelva más de un resultado (ej. el resultado de una operación y un mensaje de error).
3. **Usa `ref`** en dos casos muy específicos:
* Si quieres que un `int`, `bool` o `struct` cambie su valor real fuera.
* Si quieres que un objeto o array sea **reemplazado por uno nuevo** (`new`) y que fuera se enteren.
4. **Usa `in`** principalmente para **rendimiento en structs**. Si tienes una estructura con muchos campos que pasas miles de veces por segundo, `in` evitará que el procesador pierda tiempo haciendo copias. En clases, su beneficio es meramente informativo para decir "no voy a reasignar esta variable".

---

## 13.6. Ejemplos Completos de Código

A continuación, analizamos tres escenarios clave donde la elección del modificador cambia totalmente el resultado.

### Caso 1: Optimización de Structs con `in`

Aquí el objetivo es **rendimiento**. Al usar `in`, evitamos copiar los datos, pero a cambio perdemos la capacidad de escribir.

```csharp
struct CoordenadaGPS 
{ 
    public double Latitud, Longitud, Altitud; 
    // Imagina que aquí hay muchos más datos...
}

// ✅ CORRECTO: Usamos 'in' para leer rápido sin copiar
void CalcularDistancia(in CoordenadaGPS p) 
{
    // Podemos leer
    Console.WriteLine($"Lat: {p.Latitud}"); 

    // p.Latitud = 40.0; // ❌ ERROR: 'in' pone un candado a toda la estructura.
}

```

### Caso 2: Clases - La trampa del `new` (Ref vs Normal)

Este es el error más común. Recordad la analogía: *Sin ref puedo cambiar los muebles de la casa, pero no puedo mudarme a otra casa.*

```csharp
class Alumno { public string Nombre; }

// ❌ INTENTO FALLIDO (Paso por valor de referencia)
void IntentarCrearAlumno(Alumno a) 
{
    a.Nombre = "Ana";       // ✅ Esto SÍ cambia el nombre del objeto original
    a = new Alumno();       // ❌ Esto crea un alumno nuevo SOLO dentro de la función
    a.Nombre = "Pedro";     // ❌ Modificamos el nuevo alumno, el original sigue siendo "Ana"
}

// ✅ FORMA CORRECTA (Uso de ref)
void CrearAlumnoReal(ref Alumno a) 
{
    a = new Alumno();       // ✅ Al usar ref, la variable de fuera apunta a este nuevo objeto
    a.Nombre = "Maria";     // ✅ El cambio persiste
}

// Uso:
Alumno miAlumno = new Alumno { Nombre = "Juan" };

IntentarCrearAlumno(miAlumno);
Console.WriteLine(miAlumno.Nombre); // Imprime "Ana" (El new se perdió, pero el cambio de nombre no)

CrearAlumnoReal(ref miAlumno);
Console.WriteLine(miAlumno.Nombre); // Imprime "Maria" (El objeto ha sido sustituido)

```

### Caso 3: Arrays y `out` (La fábrica de datos)

Usamos `out` cuando la función es la encargada de **crear** el array desde cero.

```csharp
// Función que "fabrica" un array de números pares
void GenerarPares(int cantidad, out int[] lista) 
{
    // Con 'out', C# nos OBLIGA a asignar la variable antes de salir
    // No importa si 'lista' tenía datos antes, aquí nace de nuevo.
    lista = new int[cantidad];
    
    for (int i = 0; i < cantidad; i++) 
    {
        lista[i] = i * 2;
    }
}

// Uso:
int[] misNumeros; // No hace falta ni inicializarlo con = null
GenerarPares(5, out misNumeros);
// misNumeros ahora es { 0, 2, 4, 6, 8 }

```

---

## 14. Resumen

- La herencia es un mecanismo potente, pero debe usarse con sentido común y siempre preferir composición cuando sea posible.
- El tipo `object` como raíz de todo permite uniformidad y potencia el polimorfismo.
- Las interfaces definen contratos y permiten polimorfismo múltiple.
- El polimorfismo permite la flexibilidad y la extensión del comportamiento.
- C# ofrece modificadores amplios para controlar el acceso y la herencia.
- El uso correcto de casting y comprobación asegura que tu código sea seguro.
- Los principios SOLID deben estar presentes en el diseño desde el inicio.




## Enlaces útiles y bibliografía

- [Herencia en C# (Microsoft Docs)](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/tutorials/inheritance)
- [Polimorfismo en C# (Microsoft Docs)](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/object-oriented/polymorphism)
- [Documentación oficial de C#](https://learn.microsoft.com/es-es/dotnet/csharp/)
- [SOLID Principles in C# (en inglés)](https://web.archive.org/web/20240325171535/https://www.dotnettricks.com/learn/designpatterns/solid-principles)

---


## Autor

Codificado con :sparkling_heart: por [José Luis González Sánchez](https://twitter.com/JoseLuisGS_)

[![Twitter](https://img.shields.io/twitter/follow/JoseLuisGS_?style=social)](https://twitter.com/JoseLuisGS_)
[![GitHub](https://img.shields.io/github/followers/joseluisgs?style=social)](https://github.com/joseluisgs)
[![GitHub](https://img.shields.io/github/stars/joseluisgs?style=social)](https://github.com/joseluisgs)

### Contacto

<p>
  Cualquier cosa que necesites házmelo saber por si puedo ayudarte 💬.
</p>
<p>
 <a href="https://joseluisgs.dev" target="_blank">
        <img src="https://joseluisgs.github.io/img/favicon.png" 
    height="30">
    </a>  &nbsp;&nbsp;
    <a href="https://github.com/joseluisgs" target="_blank">
        <img src="https://distreau.com/github.svg" 
    height="30">
    </a> &nbsp;&nbsp;
        <a href="https://twitter.com/JoseLuisGS_" target="_blank">
        <img src="https://i.imgur.com/U4Uiaef.png" 
    height="30">
    </a> &nbsp;&nbsp;
    <a href="https://www.linkedin.com/in/joseluisgonsan" target="_blank">
        <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/LinkedIn_logo_initials.png/768px-LinkedIn_logo_initials.png" 
    height="30">
    </a>  &nbsp;&nbsp;
    <a href="https://g.dev/joseluisgs" target="_blank">
        <img loading="lazy" src="https://googlediscovery.com/wp-content/uploads/google-developers.png" 
    height="30">
    </a>  &nbsp;&nbsp;
<a href="https://www.youtube.com/@joseluisgs" target="_blank">
        <img loading="lazy" src="https://upload.wikimedia.org/wikipedia/commons/e/ef/Youtube_logo.png" 
    height="30">
    </a>  
</p>

## Licencia de uso

Este repositorio y todo su contenido está licenciado bajo licencia **Creative Commons**, si desea saber más, vea
la [LICENSE](https://joseluisgs.dev/docs/license/). Por favor si compartes, usas o modificas este proyecto cita a su
autor, y usa las mismas condiciones para su uso docente, formativo o educativo y no comercial.

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Licencia de Creative Commons" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br /><span xmlns:dct="http://purl.org/dc/terms/" property="dct:title">
JoseLuisGS</span>
by <a xmlns:cc="http://creativecommons.org/ns#" href="https://joseluisgs.dev/" property="cc:attributionName" rel="cc:attributionURL">
José Luis González Sánchez</a> is licensed under
a <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons
Reconocimiento-NoComercial-CompartirIgual 4.0 Internacional License</a>.<br />Creado a partir de la obra
en <a xmlns:dct="http://purl.org/dc/terms/" href="https://github.com/joseluisgs" rel="dct:source">https://github.com/joseluisgs</a>.