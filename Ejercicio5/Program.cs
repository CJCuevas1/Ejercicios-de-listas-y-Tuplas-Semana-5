using System;
using System.Collections.Generic;

namespace Ejercicio5
{
    class Numeros
    {
        private List<int> numeros;

        public Numeros()
        {
            numeros = new List<int>();

            // Guardamos los números del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                numeros.Add(i);
            }
        }

        // Método para mostrar los números en orden inverso
        public void MostrarInverso()
        {
            for (int i = numeros.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.Write(numeros[i]);
                }
                else
                {
                    Console.Write(numeros[i] + ", ");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Numeros numeros = new Numeros();
            numeros.MostrarInverso();

            Console.ReadKey();
        }
    }
}
