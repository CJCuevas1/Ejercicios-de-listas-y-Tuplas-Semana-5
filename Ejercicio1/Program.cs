using System;
using System.Collections.Generic;

namespace CursoAsignaturas
{
    // Clase que representa un curso
    class Curso
    {
        // Lista de asignaturas
        private List<string> asignaturas;

        // Constructor
        public Curso()
        {
            asignaturas = new List<string>();

            // Agregamos las asignaturas
            asignaturas.Add("Matemáticas");
            asignaturas.Add("Física");
            asignaturas.Add("Química");
            asignaturas.Add("Historia");
            asignaturas.Add("Lengua");
        }

        // Método para mostrar las asignaturas
        public void MostrarAsignaturas()
        {
            Console.WriteLine("Asignaturas del curso:");

            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine("- " + asignatura);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el objeto curso
            Curso curso = new Curso();

            // Mostramos las asignaturas
            curso.MostrarAsignaturas();

            Console.ReadKey(); // Pausa la consola
        }
    }
}
