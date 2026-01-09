## 💥 Star Wars: Misión en Prog-JL Avanzada, El Desafío del Sith Lord JoseLuisGS

**Tecnología del Sistema:** **C\# y .NET**

**Hace mucho tiempo, en una galaxia muy, ¡muy lejana [...] 🚀**

**UNA GALAXIA DIVIDIDA\!** Después de obtener la victoria en la Batalla de Geonosis, el ejército de droides del Sith Lord JoseLuisGS ha tomado el control de las principales rutas del hiperespacio del Código Limpio...

... La República busca a un joven Padawan programador que pueda ajustar el sistema de apuntado de las naves **X-wing T-65B** en **C\# y .NET**. Debes programar con **POO básica y avanzada** (clases, *enums*, *records* o *structs*, *herencia*, *interfaces* y *polimorfismo*). ¡Usa tu mente, o serás arrojado a la excepción del lado oscuro del Null\!

-----

## ⚙️ Especificación Funcional del Sistema Avanzado (C\# / .NET)

El sistema se basa en la simulación de combate en la **Cuadrícula de Acción**.

### 1\. Inicialización y Entorno de Batalla 🗺️

El sistema debe llamarse **antidroides** (simulando el ejecutable de .NET) y recibir los parámetros por línea de comandos o solicitarlos manualmente si son incorrectos o inválidos.

| Parámetro         | Comando          | Rango de Valores             | Descripción                                                    |
| :---------------- | :--------------- | :--------------------------- | :------------------------------------------------------------- |
| **Num Columnas**  | `<num_columnas>` | $\ge 5$ y $\le 9$ (Entero)   | Define el tamaño de la cuadrícula cuadrada (Filas = Columnas). |
| **Num Droides**   | `<num_droides>`  | $\ge 5$ y $\le 30$ (Entero)  | Cantidad inicial y total de droides a generar.                 |
| **Tiempo Máximo** | `<tiempo>`       | $\ge 1$ y $\le 3$ (Segundos) | Duración máxima de la simulación.                              |

  * **Llamada de Comando (C\# / .NET):**
    El sistema debe esperar la llamada de la siguiente manera, que es la forma estándar de invocar un ejecutable de .NET:

    ```bash
    > antidroides.exe <num_columnas> <num_droides> <tiempo>
    ```

    **Alternativamente**, si se usa el comando de ejecución directa de .NET:

    ```bash
    > dotnet run -- <num_columnas> <num_droides> <tiempo>
    ```

  * **Validación:** Si los argumentos no son correctos (número o valor fuera de rango), se deberán pedir los tres parámetros **manualmente** una vez iniciado el sistema.

### 2\. Definición de Unidades (Clases y Tipos) 🤖

Se requiere la siguiente estructuración de datos:

  * **`Coordenada`**: Almacena la ubicación $(X, Y)$ del droide.
  * **`TipoDroide`** Clasifica a los enemigos, respetando las nuevas probabilidades de aparición:
      * `SW348` (20% de aparición)
      * `SW447` (40% de aparición)
      * `SW421` (20% de aparición)
      * `SW6969` (20% de aparición) **(Nuevo Droide Avanzado)**
  * **`Droide`:** Unidad enemiga. Debe manejar su estado, lógica de defensa y nuevas capacidades.
      * Tipo, Energía Actual, Energía Máxima, Posición y las propiedades necesarias para la defensa individual (e.g., Velocidad, Defensa Personal, Escudo).
      * **Generación de Energía Máxima:**
          * **SW348:** 50 puntos.
          * **SW447:** 100 puntos.
          * **SW421:** Valor aleatorio entre 100 y 150 puntos.
          * **SW6969:** 200 puntos.

### 3\. El Ciclo de Combate (Clase `SimuladorBatalla`) 💥

La clase principal `SimuladorBatalla` gestiona la lógica del juego.

#### A. Disparo y Daño (Sistema X-Wing) 🎯

El sistema escanea una posición aleatoria y dispara:

  * **Frecuencia de Disparo:** Cada **100 milisegundos**.
  * **Contadores:** Se incrementa **`DisparosRealizados`** y si hay droide, **`Aciertos`**.
  * **Daño Base:** 25 puntos.
  * **Disparo Crítico:** El **15%** de las veces, el daño base es de **50 puntos**.

#### B. Mecanismos de Defensa del Droide (Mitigación Avanzada) 🛡️

El droide mitiga el daño bruto según su tipo, aplicando la lógica de defensa avanzada:

1.  **Droide SW447 (Escudo Deflector):** Reduce el efecto del ataque en una cantidad aleatoria entre **5 y 10 puntos**.
2.  **Droide SW348 (Defensa Personal):** Tiene un valor de defensa entre **9 y 12** (aleatorio al crearse). El daño final aplicado es el **mínimo** entre el Daño Bruto (después de crítico si aplica) y el valor de su Defensa.
3.  **Droide SW421 (Alta Velocidad):** Tiene un valor de velocidad entre **10 y 30** (aleatorio al crearse). La posibilidad de **esquivar** (no recibir daño) es igual al porcentaje de su velocidad.
4.  **Droide SW6969 (Híbrido de Diseño Avanzado):** Este droide combina dos mecanismos:
      * Actúa como **SW348**, pero con una defensa fija de **7 puntos**.
      * Actúa como **SW421**, pero con una velocidad máxima de **20 puntos**.
      * **Bonus (a considerar en el futuro):** El droide tiene un 30% de posibilidades de explotar.

#### C. Movimiento de la Horda 🔄

  * **Frecuencia:** Cada **300 milisegundos**, todos los droides activos cambian de posición a una nueva coordenada aleatoria válida dentro de la cuadrícula.

#### D. Destrucción de la Unidad 💀

  * Un droide es destruido cuando su `EnergiaActual` es $\le 0$.
  * El droide debe ser eliminado de la cuadrícula y se debe incrementar el contador **`DroidesDestruidos`**.

### 4\. Reporte Final y Documentación 📜

La simulación termina cuando se alcanza el `Tiempo Máximo` o si todos los droides son destruidos.

1.  **Resumen de Batalla:**
      * Número de droides iniciales.
      * Número de droides finales (restantes).
      * Cantidad de disparos realizados.
      * Cantidad de droides muertos.
      * **Porcentaje de acierto** ($\frac{\text{Aciertos}}{\text{Disparos Realizados}} \times 100$).
2.  **Registro de la Horda:**
      * Lista de **todos** los droides que aparecieron en la simulación, ordenados de **mayor a menor** según su **Energía Restante**.

<!-- end list -->

  * **Documentación Esencial:** El código debe estar **perfectamente documentado** con **comentarios XML** para que se pueda generar la documentación en formato **HTML**, una práctica estándar en C\#.

-----

**Las armas no ganan batallas. Tu mente, poderosa ella es.”**
**-- Yoda. Maestro DAW de la orden Jedi de Luke Skywalker** ✨
