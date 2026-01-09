using System;
using System.Collections.Generic;

namespace Ejercicio4
{
    class Loteria
    {
        private List<int> numeros;

        public Loteria()
        {
            numeros = new List<int>();
        }

        // Método para pedir los números
        public void PedirNumeros()
        {
            Console.WriteLine("Ingrese 6 números ganadores de la lotería:");

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                int numero = Convert.ToInt32(Console.ReadLine());
                numeros.Add(numero);
            }
        }

        // Método para ordenar los números
        public void OrdenarNumeros()
        {
            numeros.Sort();
        }

        // Método para mostrar los números
        public void MostrarNumeros()
        {
            Console.WriteLine("\nNúmeros ordenados de menor a mayor:");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Loteria loteria = new Loteria();

            loteria.PedirNumeros();
            loteria.OrdenarNumeros();
            loteria.MostrarNumeros();

            Console.ReadKey();
        }
    }
}
