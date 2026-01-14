
## Preguntas de Investigación y Desarrollo (I+D)

- [Preguntas de Investigación y Desarrollo (I+D)](#preguntas-de-investigación-y-desarrollo-id)
  - [1. Herencia: Ocultación (*new*) vs. Sobrescritura (*override*)](#1-herencia-ocultación-new-vs-sobrescritura-override)
  - [2. Jerarquía Sellada y Manejo Exhaustivo](#2-jerarquía-sellada-y-manejo-exhaustivo)
  - [3. Conflicto de Interfaces con Implementación por Defecto](#3-conflicto-de-interfaces-con-implementación-por-defecto)
  - [4. La Cadena de Inicialización en Herencia](#4-la-cadena-de-inicialización-en-herencia)
  - [5. Polimorfismo, *vtable* y Ligadura Dinámica](#5-polimorfismo-vtable-y-ligadura-dinámica)
  - [6. Diseño: Herencia vs. Composición (Acoplamiento Fuerte)](#6-diseño-herencia-vs-composición-acoplamiento-fuerte)
  - [7. Principio de Sustitución de Liskov (LSP) y Segregación de Interfaces (ISP)](#7-principio-de-sustitución-de-liskov-lsp-y-segregación-de-interfaces-isp)
  - [8. Diferencias de Igualdad en Tipos Especiales (`class`, `record`)](#8-diferencias-de-igualdad-en-tipos-especiales-class-record)
  - [9. Principio de Inversión de Dependencias (DIP)](#9-principio-de-inversión-de-dependencias-dip)
  - [10. Principio Abierto/Cerrado (OCP) y Diseño Extensible](#10-principio-abiertocerrado-ocp-y-diseño-extensible)


### 1. Herencia: Ocultación (*new*) vs. Sobrescritura (*override*)

**Tarea de Investigación y Prueba:**
Investigue la diferencia fundamental entre utilizar el modificador `new` (ocultación) y el modificador `override` (sobrescritura) al redefinir un método de una clase base que es declarado como `virtual`.

**Cree un experimento de código:**

1.  Defina una clase base con un método `virtual`.
2.  Cree una clase derivada que sobrescriba el método usando `override`.
3.  Cree otra clase derivada que oculte el método usando `new`.
4.  Cree una colección (`[]`) de referencias del tipo base que contenga instancias de ambas derivadas.
5.  Itere sobre la colección e invoque el método.

**Análisis requerido:**
Explique detalladamente qué método se ejecuta en cada caso (ocultación vs. sobrescritura) y por qué. ¿Por qué las fuentes desaconsejan fuertemente el uso de `new` salvo en "casos muy concretos" y cómo su uso rompe el polimorfismo esperado en tiempo de ejecución?

### 2. Jerarquía Sellada y Manejo Exhaustivo

**Tarea de Investigación y Prueba:**
Implemente una "Jerarquía Sellada" como patrón de diseño para modelar un dominio con un conjunto fijo y controlado de tipos derivados. Utilice el ejemplo de la fuente (Vehículos, estados, resultados de operaciones, etc.).

**Cree un experimento de código:**

1.  Defina la clase base y las subclases selladas (`sealed`).
2.  Implemente una expresión `switch` que utilice *pattern matching* sobre el tipo base para ejecutar lógica específica para cada subclase.

**Análisis requerido:**
Demuestre cómo la jerarquía sellada, combinada con el *pattern matching* en C\#, asegura el **control exhaustivo**. ¿Qué sucede si se intenta añadir una nueva subclase *sellada* a la jerarquía, pero se olvida actualizar el `switch` que maneja el tipo? Justifique cómo este patrón mejora la seguridad y mantenibilidad del código al proporcionar advertencias de compilación para casos no manejados.

### 3. Conflicto de Interfaces con Implementación por Defecto

**Tarea de Investigación y Prueba:**
A partir de C\# 8, las interfaces pueden proporcionar implementaciones por defecto para sus miembros.

**Cree un experimento de código:**

1.  Defina dos interfaces diferentes que declaren **el mismo método** con la misma firma, pero con implementaciones por defecto distintas (siguiendo el "Caso 2" de conflicto).
2.  Cree una clase que implemente ambas interfaces.
3.  Intente llamar al método desde una referencia del tipo de la clase.

**Análisis requerido:**
Explique por qué el compilador produce un error de ambigüedad si se intenta llamar al método sin especificación. Demuestre la solución utilizando la "Implementación explícita y alias de interface". Describa las implicaciones que tiene la implementación explícita en la forma en que se debe invocar ese método (es decir, la necesidad de un *cast* o alias de interface).

### 4. La Cadena de Inicialización en Herencia

**Tarea de Investigación y Prueba:**
Diseñe un conjunto de clases que demuestren el orden exacto de inicialización en una jerarquía de herencia.

**Cree un experimento de código:**

1.  Defina una clase base y una clase derivada.
2.  Utilice `Console.WriteLine` en los inicializadores de campos y en los cuerpos de los constructores de ambas clases.
3.  Experimente sobrescribiendo una propiedad `virtual` en la clase derivada que es utilizada durante la inicialización de la clase base.

**Análisis requerido:**
Describa y justifique la secuencia de ejecución (clase base antes que clase derivada, inicializadores de campos antes que constructor). Especifique qué valor prevalece cuando una propiedad virtual es sobrescrita en la derivada: ¿el valor asignado por el inicializador de la base o el valor asignado o modificado en la derivada?.

### 5. Polimorfismo, *vtable* y Ligadura Dinámica

**Tarea de Investigación y Prueba:**
Profundice en la mecánica interna del polimorfismo en C\#.

**Investigación requerida:**
Investigue el papel de la **Tabla de Métodos Virtuales** (*vtable*) en el entorno de ejecución (CLR). Explique cómo se utiliza la *vtable* para garantizar que, **en tiempo de ejecución**, el método ejecutado corresponde al **tipo real del objeto**, y no al tipo de la referencia (Clase Base o Interfaz). ¿Cómo se relaciona la necesidad de la palabra clave `virtual` en la clase base con la construcción de esta tabla de métodos?

### 6. Diseño: Herencia vs. Composición (Acoplamiento Fuerte)

**Tarea de Investigación y Prueba:**
Analice la afirmación: "La composición es generalmente preferible a la herencia en el diseño moderno".

**Cree un experimento de código:**

1.  Diseñe una estructura donde el uso forzado de herencia para modelar una relación "Tiene un" (`HAS-A`) lleva a un "acoplamiento fuerte" o a la "herencia inapropiada" (ejemplo: hacer que una clase `Coche` herede de `Motor`).
2.  Refactorice la solución aplicando el patrón de **Composición** utilizando interfaces para el `Motor` (siguiendo la recomendación de "preferir la composición a la herencia").

**Análisis requerido:**
Justifique por qué el diseño original con herencia generaba un acoplamiento fuerte y cómo la solución basada en composición e interfaces mitigó este riesgo. Describa cómo la composición facilita la prueba unitaria y el cambio de comportamientos en tiempo de ejecución.

### 7. Principio de Sustitución de Liskov (LSP) y Segregación de Interfaces (ISP)

**Tarea de Investigación y Prueba:**
Investigue el Principio de Sustitución de Liskov (LSP) y cómo su violación compromete la robustez del código.

**Cree un experimento de código:**

1.  Implemente el ejemplo de violación del LSP utilizando la jerarquía `Pajaro` y `Pinguino`. Muestre cómo el subtipo (`Pinguino`) rompe la expectativa de la clase base (`Pajaro`).
2.  Refactorice la solución aplicando el LSP y el Principio de Segregación de Interfaces (ISP).

**Análisis requerido:**
Explique cómo el uso de interfaces pequeñas y especializadas (ISP) permite que cada clase implemente únicamente el comportamiento que necesita, resolviendo la violación del LSP al separar las capacidades de "volar" y "nadar".

### 8. Diferencias de Igualdad en Tipos Especiales (`class`, `record`)

**Tarea de Investigación y Prueba:**
C\# ofrece tres tipos principales para estructuras de datos: `class`, `struct`, y `record`.

**Investigación y Prueba requerida:**
Compare las diferencias clave de estos tres tipos respecto a la herencia, el almacenamiento (Heap vs. Stack) y la inmutabilidad. Desarrolle código para demostrar experimentalmente la diferencia en cómo se maneja la **igualdad** (`Equals()` o `==`) entre dos instancias con los mismos valores:

1.  Una instancia de `class` (tipo de referencia).
2.  Una instancia de `record` (tipo de referencia diseñado para igualdad basada en valores).

**Análisis requerido:**
Explique por qué los `record` son ideales para datos inmutables y cómo su igualdad por valor simplifica su uso en colecciones o comparaciones de estado.

### 9. Principio de Inversión de Dependencias (DIP)

**Tarea de Investigación y Prueba:**
El Principio de Inversión de Dependencias (DIP) establece que las clases deben depender de abstracciones (interfaces), no de implementaciones concretas.

**Cree un experimento de código:**

1.  Cree una clase de "alto nivel" (por ejemplo, `ProcesadorDePedidos`) que, en un diseño inicial (MALO), dependa directamente de una clase de "bajo nivel" concreta (ejemplo: `DatabaseServiceMSSQL`).
2.  Refactorice la clase de alto nivel para que dependa de una interfaz (`IDatabaseService`). Inyecte la implementación concreta (el servicio SQL) a través del constructor (Inyección de Dependencias).

**Análisis requerido:**
Justifique cómo el diseño refactorizado cumple el DIP. Explique cómo esta inversión de la dependencia (de concreto a abstracto) facilita las pruebas unitarias y permite cambiar o evolucionar el sistema de persistencia (ej. de SQL a NoSQL) sin modificar el código del `ProcesadorDePedidos`.

### 10. Principio Abierto/Cerrado (OCP) y Diseño Extensible

**Tarea de Investigación y Prueba:**
El Principio Abierto/Cerrado (OCP) exige que el código esté abierto para la extensión, pero cerrado para la modificación.

**Cree un experimento de código:**

1.  Implemente la solución *MAL diseñada* de cálculo de área (donde se utiliza un `switch` para manejar tipos de figuras geométricas), demostrando cómo la adición de una nueva figura requiere modificar el método de cálculo existente, violando el OCP.
2.  Refactorice la solución utilizando una interfaz (`IFigura`) o una clase base abstracta y el polimorfismo.

**Análisis requerido:**
Demuestre cómo la refactorización cumple el OCP: la adición de una nueva figura solo requiere crear una nueva clase que implemente la interfaz/herede de la base, dejando el código del método de cálculo **cerrado para modificación**. Explique por qué el polimorfismo es la clave para implementar el OCP.