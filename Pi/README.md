# Estimaci�n de Pi mediante el M�todo de Montecarlo en C#

Este es un programa simple en C# que utiliza el m�todo de Montecarlo para estimar el valor de Pi. El m�todo consiste en generar puntos aleatorios dentro de un cuadrado y contar cu�ntos de esos puntos caen dentro de un c�rculo inscrito en el cuadrado. Cuantos m�s puntos se lancen, m�s precisa ser� la estimaci�n de Pi.

## C�mo usar el programa

1. Compila y ejecuta el programa.

2. Aparecer� un mensaje en la consola que te pedir� que presiones "Enter" para estimar Pi o "q" para salir del programa.

3. Si presionas "Enter", el programa te pedir� ingresar el n�mero de puntos a lanzar para la estimaci�n. Cuanto mayor sea este n�mero, m�s precisa ser� la estimaci�n.

4. Despu�s de ingresar el n�mero de puntos, el programa calcular� una estimaci�n de Pi y la mostrar� en la consola.

5. Puedes repetir los pasos 4-6 para realizar m�ltiples estimaciones o presionar "q" en cualquier momento para salir del programa.

## Entendiendo el c�digo

El c�digo se divide en dos funciones principales:

- `Main()`: Esta funci�n contiene el bucle principal del programa. Muestra mensajes al usuario, recopila la entrada y llama a la funci�n 
  `EstimarPi()` para calcular las estimaciones de Pi.

- `EstimarPi(int numeroPuntos)`: Esta funci�n realiza el c�lculo real de la estimaci�n de Pi utilizando el m�todo de Montecarlo.
   Genera puntos aleatorios, verifica si caen dentro del c�rculo y devuelve la estimaci�n de Pi.

## Licencia

Este proyecto est� bajo la Licencia de dios.

---

�Disfruta estimando Pi con el M�todo de Montecarlo en C#!, Si tienes alguna pregunta o sugerencia, no dudes en contactar al autor del proyecto Jedidiel Toto Garcia.
