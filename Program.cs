
using System;

namespace ProgramaMemoriaEstatica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("       MEMORIA ESTATICA");
            Console.WriteLine("==================================");

            // Crear un arreglo inicial de 3 posiciones
            int[] numeros = new int[3];

            // Almacenar valores
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;

            Console.WriteLine("\nArreglo original:");
            MostrarArreglo(numeros);

            // Redimensionar el arreglo a 5 posiciones
            Array.Resize(ref numeros, 5);

            // Agregar nuevos valores
            numeros[3] = 40;
            numeros[4] = 50;

            Console.WriteLine("\nArreglo redimensionado:");
            MostrarArreglo(numeros);

            Console.WriteLine("\nCantidad de elementos: " + numeros.Length);

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }

        // Metodo para mostrar los elementos del arreglo
        static void MostrarArreglo(int[] arreglo)
        {
            foreach (int numero in arreglo)
            {
                Console.WriteLine(numero);
            }
        }
    }
}

