using System;


class Program
{
    static void Main()
    {
        while (true) // Se inicia un bucle infinito.
        {
            Console.ForegroundColor = ConsoleColor.Blue; // aqui agrego el color de texto en amarillo.
            Console.WriteLine("**************************************************");

            Console.WriteLine("Presiona Enter para estimar Pi o 'Q' para salir: "); // Muestro un mensaje en la consola.

            Console.WriteLine("**************************************************");
            var entrada = Console.ReadLine(); // Lee la entrada del usuario y la almacena en la variable "entrada".

            if (entrada == "Q") // Comprueba si el usuario ha ingresado "Q" para salir del programa.
            {
                break; // Salimos del bucle si se ingresa "Q".
            }

            if (entrada == "") // Comprobamos si se ha presionado Enter (entrada vacía).
            {
                Console.WriteLine("**************************************************");
                Console.Write("Ingresa el número de puntos a lanzar, un número mayor a 10 cifras manda error: "); // Función que pide al usuario que ingrese el número de puntos a lanzar.

                if (int.TryParse(Console.ReadLine(), out int numeroPuntos)) // Leemos el número de puntos y lo convertimos a un entero.
                {
                    int puntosDentroCirculo;
                    int puntosFueraCirculo;
                    double resultado = EsPi(numeroPuntos, out puntosDentroCirculo, out puntosFueraCirculo); // Llamamos a la función EsPi y almacenamos el resultado en la variable "resultado".

                    Console.WriteLine("**************************************************");
                    Console.WriteLine($"Cantidad de puntos dentro del círculo: {puntosDentroCirculo}"); // Mostramos la cantidad de puntos dentro del círculo.
                    Console.WriteLine("**************************************************");
                    Console.WriteLine($"Cantidad de puntos fuera del círculo: {puntosFueraCirculo}"); // Mostramos la cantidad de puntos fuera del círculo.
                    Console.WriteLine("**************************************************");
                    Console.WriteLine($"Valor estimado de Pi: {resultado}"); // Mostramos el resultado estimado de Pi.
                    Console.WriteLine("**************************************************");
                }
                else
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("Número de puntos no válido. Intenta de nuevo."); // Si la entrada no es válida, muestra un mensaje de error.
                    Console.WriteLine("**************************************************");
                }
            }
        }
    }

    static double EsPi(int numeroPuntos, out int puntosDentroCirculo, out int puntosFueraCirculo)
    {
        Random random = new Random(); // Creo una instancia de la clase Random para generar números aleatorios.
        puntosDentroCirculo = 0; // Inicializo una variable para contar los puntos que caen dentro del círculo.
        puntosFueraCirculo = 0; // Inicializo una variable para contar los puntos que caen fuera del círculo.

        for (int i = 0; i < numeroPuntos; i++) // Esta línea inicia un bucle para generar puntos aleatorios.
        {
            double x = random.NextDouble(); // Se genera una coordenada x aleatoria entre 0 y 1.
            double y = random.NextDouble(); // Se genera una coordenada y aleatoria entre 0 y 1.
            double distancia = Math.Sqrt(x * x + y * y); // Se calcula la distancia desde el punto al origen.

            if (distancia <= 1) // Comprobamos si el punto cae dentro del círculo.
            {
                puntosDentroCirculo++; // Incrementa si el punto está dentro del círculo.
            }
            else
            {
                puntosFueraCirculo++; // Incrementa si el punto está fuera del círculo.
            }
        }

        return (double)puntosDentroCirculo / numeroPuntos * 4; // Se calcula y devuelve la estimación de Pi.
    }
}

