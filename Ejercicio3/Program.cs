using System;
using System.Collections.Generic;

namespace Ejercicio3
{
    class Curso
    {
        // Lista de asignaturas
        private List<string> asignaturas;

        // Lista de notas
        private List<double> notas;

        // Constructor
        public Curso()
        {
            asignaturas = new List<string>();
            notas = new List<double>();

            asignaturas.Add("Matemáticas");
            asignaturas.Add("Física");
            asignaturas.Add("Química");
            asignaturas.Add("Historia");
            asignaturas.Add("Lengua");
        }

        // Método para pedir las notas
        public void PedirNotas()
        {
            for (int i = 0; i < asignaturas.Count; i++)
            {
                Console.Write("Ingrese la nota de " + asignaturas[i] + ": ");
                double nota = Convert.ToDouble(Console.ReadLine());
                notas.Add(nota);
            }
        }

        // Método para mostrar las notas
        public void MostrarNotas()
        {
            Console.WriteLine("\nResultados:");

            for (int i = 0; i < asignaturas.Count; i++)
            {
                Console.WriteLine("En " + asignaturas[i] + " has sacado " + notas[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso();

            curso.PedirNotas();
            curso.MostrarNotas();

            Console.ReadKey();
        }
    }
}
