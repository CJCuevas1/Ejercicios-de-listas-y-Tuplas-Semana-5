using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    class Curso
    {
        // Lista de asignaturas
        private List<string> asignaturas;

        // Constructor
        public Curso()
        {
            asignaturas = new List<string>();

            asignaturas.Add("Matemáticas");
            asignaturas.Add("Física");
            asignaturas.Add("Química");
            asignaturas.Add("Historia");
            asignaturas.Add("Lengua");
        }

        // Método para mostrar el mensaje
        public void MostrarAsignaturas()
        {
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine("Yo estudio " + asignatura);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Curso curso = new Curso();
            curso.MostrarAsignaturas();

            Console.ReadKey();
        }
    }
}
