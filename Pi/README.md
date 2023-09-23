# Estimación de Pi mediante el Método de Montecarlo en C#

Este es un programa simple en C# que utiliza el método de Montecarlo para estimar el valor de Pi. El método consiste en generar puntos aleatorios dentro de un cuadrado y contar cuántos de esos puntos caen dentro de un círculo inscrito en el cuadrado. Cuantos más puntos se lancen, más precisa será la estimación de Pi.

## Cómo usar el programa

1. Compila y ejecuta el programa.

2. Aparecerá un mensaje en la consola que te pedirá que presiones "Enter" para estimar Pi o "q" para salir del programa.

3. Si presionas "Enter", el programa te pedirá ingresar el número de puntos a lanzar para la estimación. Cuanto mayor sea este número, más precisa será la estimación.

4. Después de ingresar el número de puntos, el programa calculará una estimación de Pi y la mostrará en la consola.

5. Puedes repetir los pasos 4-6 para realizar múltiples estimaciones o presionar "q" en cualquier momento para salir del programa.

## Entendiendo el código

El código se divide en dos funciones principales:

- `Main()`: Esta función contiene el bucle principal del programa. Muestra mensajes al usuario, recopila la entrada y llama a la función 
  `EstimarPi()` para calcular las estimaciones de Pi.

- `EstimarPi(int numeroPuntos)`: Esta función realiza el cálculo real de la estimación de Pi utilizando el método de Montecarlo.
   Genera puntos aleatorios, verifica si caen dentro del círculo y devuelve la estimación de Pi.

## Licencia

Este proyecto está bajo la Licencia de dios.

---

¡Disfruta estimando Pi con el Método de Montecarlo en C#!, Si tienes alguna pregunta o sugerencia, no dudes en contactar al autor del proyecto Jedidiel Toto Garcia.
