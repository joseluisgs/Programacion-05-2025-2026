

## 💥 Star Wars: Misión en Prog-JL, El Desafío del Sith Lord JoseLuisGS

**Hace mucho tiempo, en una galaxia muy, ¡muy lejana [...] 🚀**

**UNA GALAXIA DIVIDIDA\!** Después de obtener la victoria en la Batalla de Geonosis, el ejército de droides del del Sith Lord JoseLuisGS ha tomado el control de las principales rutas del hiperespacio del Código Limpio...

... La República busca a un joven Padawan programador que pueda ajustar el sistema de apuntado de las naves **X-wing T-65B** en **C\# y .NET**. Debes programar con **POO básica** (clases, *enums*, *records* o *structs*). ¡Usa tu mente, o serás arrojado a la excepción del lado oscuro del Null\!

-----

## ⚙️ Especificación Funcional del Sistema (C\# / .NET)

El sistema se basa en la simulación de combate en la **Cuadrícula de Acción**.

### 1\. Inicialización y Entorno de Batalla 🗺️

El sistema debe llamarse **antidroides** (simulando el ejecutable de .NET) y recibir los parámetros por línea de comandos o solicitarlos manualmente si son incorrectos o inválidos.

| Parámetro         | Comando          | Rango de Valores             | Descripción                                                    |
| :---------------- | :--------------- | :--------------------------- | :------------------------------------------------------------- |
| **Num Columnas**  | `<num_columnas>` | $\ge 5$ y $\le 9$ (Entero)   | Define el tamaño de la cuadrícula cuadrada (Filas = Columnas). |
| **Num Droides**   | `<num_droides>`  | $\ge 5$ y $\le 30$ (Entero)  | Cantidad inicial y total de droides a generar.                 |
| **Tiempo Máximo** | `<tiempo>`       | $\ge 1$ y $\le 3$ (Segundos) | Duración máxima de la simulación.                              |

  * **Llamada de Comando (C\# / .NET):**
    El sistema debe esperar la llamada de la siguiente manera:
    ```bash
    > antidroides <num_columnas> <num_droides> <tiempo>
    ```
  * **Validación:** Si los argumentos no son correctos (número o valor fuera de rango), se deberán pedir los tres parámetros **manualmente** una vez iniciado el sistema.

### 2\. Definición de Unidades (Clases y Tipos) 🤖

Se requiere la siguiente estructuración de datos:

  * **`Coordenada`**: Almacena la ubicación $(X, Y)$ del droide.
  * **`TipoDroide`** Clasifica a los enemigos:
      * `SW348` (30% de aparición)
      * `SW447` (50% de aparición)
      * `SW421` (20% de aparición)
  * **`Droide`:** Unidad enemiga. Debe manejar su estado y lógica de defensa.
      * Tipo, Energía Actual, Energía Máxima, Posición y las propiedades necesarias para la defensa individual (e.g., Velocidad, Defensa Personal).
      * **Generación de Energía Máxima:**
          * **SW348:** 50 puntos.
          * **SW447:** 100 puntos.
          * **SW421:** Valor aleatorio entre 100 y 150 puntos.

### 3\. El Ciclo de Combate (Clase `SimuladorBatalla`) 💥

La clase principal `SimuladorBatalla` gestiona la lógica del juego.

#### A. Disparo y Daño (Sistema X-Wing) 🎯

El sistema escanea una posición aleatoria y dispara:

  * **Frecuencia de Disparo:** Cada **100 milisegundos**.
  * **Contadores:** Se incrementa **`DisparosRealizados`**.
  * **Acierto:** Si hay un droide en la posición escaneada, se incrementa **`Aciertos`**.
  * **Daño Base:** 25 puntos.
  * **Disparo Crítico:** El **15%** de las veces, el daño base es de **50 puntos**.

#### B. Mecanismos de Defensa del Droide (Mitigación) 🛡️

El droide mitiga el daño bruto según su tipo:

1.  **Droide SW447 (Escudo Deflector):** Reduce el efecto del ataque en una cantidad aleatoria entre **5 y 10 puntos**.
2.  **Droide SW348 (Defensa Personal):** Tiene un valor de defensa entre **9 y 12** (aleatorio al crearse). El daño final es el **mínimo** entre el Daño Bruto y el valor de su Defensa.
3.  **Droide SW421 (Alta Velocidad):** Tiene un valor de velocidad entre **10 y 30** (aleatorio al crearse). La posibilidad de **esquivar** (recibir 0 daño) es igual al porcentaje de su velocidad.

#### C. Movimiento de la Horda 🔄

  * **Frecuencia:** Cada **300 milisegundos**, todos los droides activos cambian de posición a una nueva coordenada aleatoria válida dentro de la cuadrícula.

#### D. Destrucción de la Unidad 💀

  * Un droide es destruido cuando su `EnergiaActual` es $\le 0$.
  * El droide debe ser eliminado de la cuadrícula y se debe incrementar el contador **`DroidesDestruidos`**.

### 4\. Reporte Final (Documentación y Conclusión) 📜

Al terminar la simulación (por tiempo o por destrucción total), se debe mostrar un informe:

1.  **Resumen de Batalla:**
      * Número de droides iniciales.
      * Número de droides finales (restantes).
      * Cantidad de disparos realizados.
      * Cantidad de droides muertos.
      * **Porcentaje de acierto** ($\frac{\text{Aciertos}}{\text{Disparos Realizados}} \times 100$).
2.  **Registro de la Horda:**
      * Lista de **todos** los droides que aparecieron en la simulación, ordenados de **mayor a menor** según su **Energía Restante**.

<!-- end list -->

  * **Documentación:** El código debe estar documentado con comentarios XML para que se pueda generar la documentación en formato **HTML**.

-----

**Las armas no ganan batallas. Tu mente, poderosa ella es.”**
**-- Yoda. Maestro DAW de la orden Jedi de Luke Skywalker** ✨