
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

            // Solicitar el tamaño inicial
            int cantidad = LeerEntero("Ingrese el tamaño inicial del arreglo: ", 1);

            int[] numeros = new int[cantidad];

            // Llenar el arreglo
            Console.WriteLine("\nIngrese los valores del arreglo:");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = LeerEntero($"Posicion [{i}]: ", 0);
            }

            Console.WriteLine("\nArreglo original:");
            MostrarArreglo(numeros);

            // Solicitar el nuevo tamaño
            int nuevoTamano = LeerEntero(
                "\nIngrese el nuevo tamaño del arreglo: ", 1);

            // Redimensionar el arreglo
            Array.Resize(ref numeros, nuevoTamano);

            // Solicitar valores para las nuevas posiciones
            if (nuevoTamano > cantidad)
            {
                Console.WriteLine("\nIngrese los valores de las nuevas posiciones:");

                for (int i = cantidad; i < nuevoTamano; i++)
                {
                    numeros[i] = LeerEntero($"Posicion [{i}]: ", 0);
                }
            }

            Console.WriteLine("\nArreglo final:");
            MostrarArreglo(numeros);

            Console.WriteLine("\nTamaño final: " + numeros.Length);
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }

        // Metodo para mostrar los elementos
        static void MostrarArreglo(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Posicion [{i}]: {arreglo[i]}");
            }
        }

        // Metodo para validar numeros enteros
        static int LeerEntero(string mensaje, int minimo)
        {
            int valor;

            while (true)
            {
                Console.Write(mensaje);

                if (int.TryParse(Console.ReadLine(), out valor) && valor >= minimo)
                {
                    return valor;
                }

                Console.WriteLine($"Ingrese un numero entero mayor o igual a {minimo}.");
            }
        }
    }
}
