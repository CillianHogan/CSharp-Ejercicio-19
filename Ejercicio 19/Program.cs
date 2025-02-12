using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un generador de números aleatorios
            Random random = new Random();

            // Generamos un número entre 1 y 100
            int numeroAleatorio = random.Next(1, 101);

            // Variables para controlar el juego
            int intento = 0; // Número que introduce el usuario
            int intentosTotales = 0; // Contador de intentos
            int intentosMaximos = 10; // Límite de intentos permitidos

            Console.WriteLine("Adivina el número entre el 1 y el 100. Tienes 10 intentos para lograrlo");

            do
            {
                // Si el usuario alcanza el número máximo de intentos, termina el juego
                if (intentosTotales >= intentosMaximos)
                {
                    Console.WriteLine($"Has alcanzado el límite de {intentosMaximos} totales, el número era {numeroAleatorio}");
                    break;
                }

                // Pedimos al usuario que introduzca un número
                Console.Write("Introduce tu número: ");

                // Validamos que el usuario ingrese un número válido
                if (!int.TryParse(Console.ReadLine(), out intento))
                {
                    Console.WriteLine("Error: Ingresa un número válido.");
                    continue; // Volver al inicio del bucle sin contar este intento
                }

                intentosTotales++; // Contador de intentos por parte del usuario

                // Comprobamos si el número es mayor, menor o igual al número aleatorio
                if (intento > numeroAleatorio)
                {
                    Console.WriteLine("El número es menor");
                }
                else if (intento < numeroAleatorio)
                {
                    Console.WriteLine("El número es mayor");
                }
                else
                {
                    // Si el usuario acierta, mostramos un mensaje de felicitación con el número de intentos usados
                    Console.WriteLine($"!Felicidades¡ Has acertado en {intentosTotales} intentos.");
                }
            } while (intento != numeroAleatorio); // El bucle se repite hasta que el usuario acierte

        }
    }
}
