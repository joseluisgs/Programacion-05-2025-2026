## Cuestionario: Programación Avanzada Orientada a Objetos en C\# (50 Preguntas)

- [Cuestionario: Programación Avanzada Orientada a Objetos en C# (50 Preguntas)](#cuestionario-programación-avanzada-orientada-a-objetos-en-c-50-preguntas)
  - [Herencia y Fundamentos](#herencia-y-fundamentos)
  - [Modificadores de Acceso y Herencia](#modificadores-de-acceso-y-herencia)
  - [Tipo `object` y Clases Abstractas](#tipo-object-y-clases-abstractas)
  - [Uso de `base` y Orden de Inicialización](#uso-de-base-y-orden-de-inicialización)
  - [Jerarquía Sellada](#jerarquía-sellada)
  - [Tipos de Datos Especiales (`struct`, `class`, `record`)](#tipos-de-datos-especiales-struct-class-record)
  - [Interfaces](#interfaces)
  - [Polimorfismo](#polimorfismo)
  - [Herencia vs. Composición](#herencia-vs-composición)
  - [Principios SOLID](#principios-solid)


### Herencia y Fundamentos

**1. ¿Qué concepto fundamental permite crear nuevas clases a partir de una clase existente, obteniendo sus miembros y pudiendo modificar su comportamiento?**
A. Polimorfismo
B. Encapsulación
C. Herencia
D. Composición

**2. En el contexto de la herencia, ¿cómo se denomina a la clase de la que se hereda?**
A. Clase derivada
B. Subclase
C. Clase base
D. Clase anidada

**3. ¿Qué tipo de herencia soporta C# para clases, donde una clase derivada solo puede heredar de una única clase base?**
A. Herencia múltiple
B. Herencia de interfaz
C. Herencia simple
D. Herencia compleja

**4. ¿Cuál es el principal objetivo de la herencia en lenguajes orientados a objetos?**
A. Asegurar que todos los campos sean privados.
B. Evitar la instanciación de clases base.
C. Reutilizar código y organizar el programa de manera lógica y extensible.
D. Implementar el principio de Inversión de Dependencias.

**5. ¿Qué tipo de relación se recomienda modelar con la herencia?**
A. Tiene un (HAS-A)
B. Es un (IS-A)
C. Depende de (DEPENDS-ON)
D. Se implementa como (IMPLEMENTS)

**6. ¿Qué problema de diseño surge en la herencia múltiple (no soportada por clases en C#) y se caracteriza por la ambigüedad al heredar de dos clases que a su vez heredan de una misma clase?**
A. El problema de la rigidez
B. El problema del acoplamiento fuerte
C. El problema del objeto gigante
D. El problema de la ambigüedad del diamante

### Modificadores de Acceso y Herencia

**7. En C#, ¿qué modificador de acceso permite que un miembro sea accesible desde cualquier parte?**
A. `private`
B. `protected`
C. `internal`
D. `public`

**8. Si un miembro de una clase es declarado con el modificador `private`, ¿desde dónde puede ser accedido?**
A. Desde cualquier clase del mismo ensamblado.
B. Desde la clase actual y sus derivadas.
C. Solo desde la clase actual.
D. Desde cualquier parte del programa.

**9. El modificador `protected` permite acceder a un miembro desde:**
A. Solo la clase base.
B. Solo las clases derivadas.
C. La clase actual y sus derivadas.
D. La clase actual y el mismo ensamblado.

**10. ¿Qué modificador se utiliza para indicar que una clase o método no tiene implementación en la clase base y debe ser implementado obligatoriamente en las clases derivadas?**
A. `virtual`
B. `override`
C. `sealed`
D. `abstract`

**11. ¿Qué modificador de herencia permite que un método de la clase base pueda ser sobrescrito en las clases derivadas?**
A. `abstract`
B. `virtual`
C. `new`
D. `protected`

**12. Si una clase derivada desea redefinir el comportamiento de un método `virtual` o `abstract` heredado, ¿qué modificador debe usar?**
A. `new`
B. `sealed`
C. `override`
D. `protected`

**13. ¿Cuál es la función principal del modificador `sealed` aplicado a una clase?**
A. Indicar que la clase es abstracta.
B. Permitir que la clase pueda ser sobrescrita.
C. Impedir que la clase sea heredada.
D. Ocultar los miembros de la clase base.

**14. En el contexto de la herencia, si se utiliza el modificador `new` en un método de la clase derivada, ¿qué acción se realiza?**
A. Sobrescribe el método de la clase base.
B. Extiende el método de la clase base.
C. Oculta el miembro de la base, creando uno nuevo con el mismo nombre.
D. Hace que el método sea abstracto.

### Tipo `object` y Clases Abstractas

**15. En C#, ¿de qué única clase base derivan directa o indirectamente todos los tipos (propios y del sistema)?**
A. `Type`
B. `System`
C. `object`
D. `BaseClass`

**16. ¿Qué función de la clase `object` permite obtener una representación textual de un objeto?**
A. `GetHashCode()`
B. `GetType()`
C. `Equals()`
D. `ToString()`

**17. ¿Qué característica fundamental tienen las clases declaradas como `abstract`?**
A. Deben ser selladas (`sealed`).
B. Pueden tener constructores, pero no campos.
C. No se pueden instanciar directamente.
D. No pueden heredar de otras clases.

### Uso de `base` y Orden de Inicialización

**18. La palabra clave `base` permite acceder a los miembros de la clase base desde la clase derivada. ¿Cuál de las siguientes es una de sus utilidades principales?**
A. Definir un nuevo constructor sin invocar el de la base.
B. Declarar un método abstracto.
C. Invocar explícitamente el constructor de la clase base.
D. Ocultar un miembro de la clase base.

**19. Según el orden de ejecución de la inicialización en la herencia, ¿qué sucede inmediatamente después de inicializar los campos y propiedades de la clase base?**
A. Se ejecuta el constructor de la clase derivada.
B. Se inicializan los campos de la clase derivada.
C. Se ejecuta el constructor de la clase base.
D. Se llama al método sobrescrito.

**20. ¿Qué elemento se ejecuta antes que el constructor correspondiente en el proceso de inicialización de un objeto?**
A. Los métodos virtuales.
B. Los inicializadores en declaración de campos.
C. Las propiedades estáticas.
D. Los métodos abstractos.

**21. Si una clase derivada sobrescribe una propiedad virtual heredada, ¿qué valor prevalece finalmente?**
A. El valor definido en la clase base.
B. El valor definido en la clase base antes de la ejecución del constructor.
C. El valor que prevalece es el de la derivada.
D. El valor que prevalece es el que se defina en el constructor primario.

### Jerarquía Sellada

**22. ¿Qué modificador se utiliza en las subclases para implementar una jerarquía sellada, impidiendo la creación de nuevos tipos fuera de los previstos?**
A. `abstract`
B. `virtual`
C. `sealed`
D. `private`

**23. ¿Para qué se emplea el patrón de Jerarquía Sellada en C#?**
A. Para permitir herencia ilimitada de una clase base.
B. Para definir un conjunto cerrado y controlado de tipos derivados a partir de una clase base.
C. Para forzar la instanciación directa de la clase base.
D. Para aplicar el principio de Abierto/Cerrado mediante herencia.

**24. Una de las ventajas de la jerarquía sellada es que permite el manejo exhaustivo. ¿A qué estructura del lenguaje se aplica esta característica mediante *pattern matching*?**
A. Ciclos `for`
B. Bloques `try-catch`
C. Expresiones `switch`
D. Funciones de extensión

### Tipos de Datos Especiales (`struct`, `class`, `record`)

**25. El tipo `class` en C# es un tipo de:**
A. Valor, y no permite herencia.
B. Referencia, y no permite herencia.
C. Referencia, y permite herencia.
D. Valor, y permite herencia.

**26. El tipo `struct` en C# se almacena típicamente en la pila (*stack*). ¿Qué característica de herencia lo define?**
A. Permite herencia simple.
B. Permite herencia múltiple.
C. No permite herencia.
D. Es la clase base de todos los tipos.

**27. ¿Qué tipo de dato está diseñado en C# principalmente para manejar datos inmutables y proporciona igualdad basada en valores?**
A. `struct`
B. `class`
C. `object`
D. `record`

### Interfaces

**28. ¿Qué es esencialmente una `interface` en C#?**
A. Una clase abstracta que puede contener campos.
B. Un tipo de valor que no permite herencia.
C. Un contrato que define miembros, pero no su implementación (en general).
D. Un objeto que se puede instanciar directamente.

**29. En las interfaces, ¿qué tipo de miembro no pueden contener?**
A. Métodos
B. Propiedades
C. Campos
D. Indexadores

**30. ¿Cuál es el modificador de acceso por defecto (implícito) de los miembros definidos en una interfaz?**
A. `protected`
B. `private`
C. `internal`
D. `public`

**31. ¿Qué característica de diseño permite una clase que implementa varias interfaces?**
A. Herencia simple de clases.
B. Polimorfismo múltiple.
C. El patrón God Object.
D. Acoplamiento fuerte.

**32. A partir de C# 8, ¿qué se puede proporcionar opcionalmente en una interfaz que no era posible anteriormente?**
A. Campos de instancia.
B. Implementaciones por defecto para métodos y propiedades.
C. Constructores.
D. Modificadores de acceso `private`.

**33. Si se declara una variable de tipo interfaz, ¿qué ventaja fundamental ofrece en términos de diseño de código?**
A. Permite usar constructores de la interfaz.
B. Permite programar por contratos y desacoplar el código.
C. Asegura la herencia simple.
D. Previene el uso de polimorfismo.

**34. Cuando una clase implementa dos interfaces que declaran el mismo método con la misma firma, ¿qué técnica se puede utilizar para resolver la ambigüedad y seleccionar qué implementación invocar, especialmente si tienen métodos por defecto distintos?**
A. Usar el modificador `new`.
B. Implementación explícita y alias de interface.
C. Declarar el método como `virtual`.
D. Usar composición.

### Polimorfismo

**35. ¿Qué concepto permite que diferentes clases respondan de manera distinta a la misma interfaz o método?**
A. Encapsulamiento
B. Abstracción
C. Delegación
D. Polimorfismo

**36. En el polimorfismo, ¿qué factor determina el método que se ejecuta en tiempo de ejecución?**
A. El tipo de la referencia utilizada.
B. El tipo del parámetro de entrada.
C. El tipo real del objeto, no el tipo de la referencia.
D. El método definido en el constructor base.

**37. ¿Cuál es la estructura interna utilizada por el entorno de ejecución para resolver el método correcto en tiempo de ejecución en el polimorfismo?**
A. Tabla de punteros (*Pointer table*).
B. Tabla de métodos virtuales (`vtable`).
C. Árbol de sintaxis abstracta (AST).
D. Diccionario de clases.

**38. Cuando se trabaja con polimorfismo, ¿por qué es necesario a veces realizar un *cast* (conversión) de una referencia de un tipo base a un tipo derivado específico?**
A. Para acceder a los miembros definidos únicamente en la clase derivada.
B. Para evitar que el método sea sobrescrito.
C. Para invocar el constructor de la clase base.
D. Para aplicar la inversión de dependencias.

**39. ¿Qué operador se utiliza en C# para intentar una conversión segura a un tipo derivado y devuelve `null` en lugar de lanzar una excepción si la conversión falla?**
A. `is`
B. `cast`
C. `as`
D. `typeof`

**40. ¿Qué operador permite comprobar si un objeto es de un tipo específico antes de realizar una conversión, y que desde C# 7 puede usarse con *pattern matching*?**
A. `as`
B. `new`
C. `this`
D. `is`

### Herencia vs. Composición

**41. ¿Qué mecanismo de reutilización de código se utiliza para modelar una relación de “parte”, donde una clase contiene o utiliza instancias de otras clases para funcionalidad interna?**
A. Herencia (IS-A)
B. Delegación (DELEGATES)
C. Composición (HAS-A)
D. Sobrescritura (OVERRIDE)

**42. Una de las principales desventajas de la herencia que puede llevar a que sea considerada un anti-patrón es:**
A. El desacoplamiento fuerte entre clases.
B. El acoplamiento fuerte; si la base cambia, puede romper muchas derivadas.
C. La violación del principio de segregación de interfaces.
D. La facilidad de cambiar comportamientos en tiempo de ejecución.

**43. ¿Cuál es una ventaja clave de la composición sobre la herencia?**
A. Fomenta jerarquías profundas.
B. Permite un mayor acoplamiento.
C. Promueve la flexibilidad y el desacoplamiento al utilizar interfaces.
D. Siempre se traduce en menos código de "pegado".

**44. En el diseño orientado a objetos moderno, ¿qué principio se recomienda seguir generalmente, especialmente si no hay una relación clara "Es un" (IS-A)?**
A. Prefiere herencia a composición.
B. Prefiere la composición a la herencia.
C. Utiliza siempre clases abstractas.
D. Utiliza siempre métodos virtuales.

### Principios SOLID

**45. ¿A qué principio SOLID corresponde la letra 'S'?**
A. Sustitución de Liskov
B. Segregación de Interfaces
C. Single Responsibility Principle (Responsabilidad Única)
D. Inversión de Dependencias

**46. Según el Principio de Responsabilidad Única (SRP), una clase debe tener:**
A. Una sola línea de código.
B. Una sola razón para cambiar.
C. Un solo método público.
D. Un solo constructor.

**47. El Principio Abierto/Cerrado (OCP) establece que las entidades de software deben estar:**
A. Abiertas para modificación y cerradas para extensión.
B. Cerradas para modificación y abiertas para uso.
C. Abiertas para extensión pero cerradas para modificación.
D. Cerradas para extensión y cerradas para modificación.

**48. El Principio de Sustitución de Liskov (LSP) garantiza que:**
A. Una clase no puede heredar de otra.
B. Las clases base no deben tener métodos virtuales.
C. Un subtipo debe poder sustituir a su tipo base sin alterar el funcionamiento.
D. Todas las clases deben implementar múltiples interfaces.

**49. Si se diseña una jerarquía donde una subclase no puede comportarse como su clase base (por ejemplo, un pingüino que hereda de un pájaro pero no puede volar), ¿qué principio SOLID se está violando?**
A. SRP
B. OCP
C. LSP
D. ISP

**50. ¿A qué principio SOLID se refiere la recomendación de usar interfaces pequeñas y especializadas en lugar de una interfaz grande y generalista?**
A. Single Responsibility Principle (SRP)
B. Dependency Inversion Principle (DIP)
C. Interface Segregation Principle (ISP)
D. Open/Closed Principle (OCP)