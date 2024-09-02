
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
            /* Una universidad desea crearun sistema para la gestion de cursos y estudiantes. Cada curso tiene un codigo, nombre, profesor y la
             * materia que dicta. Los estudiantes tienen un nombre, numero de matricula y el año de cursado. El sistema debe permitir la 
             inscripcion y desincripcion de estudiantes en cursos, asi como la visualizacion de la lista de estudiantes porcurso. Identifica los objetos,
             atributos y metodos necesarios para implementar este sistema. */
        {
            // Crear algunos cursos
            Curso curso1 = new Curso("CS101", "Introducción a la Programación", "Prof. García", "Programación");
            Curso curso2 = new Curso("CS102", "Estructuras de Datos", "Prof. López", "Programación");

            // Crear algunos estudiantes
            Estudiante estudiante1 = new Estudiante("Ana Gómez", 12345, 2024);
            Estudiante estudiante2 = new Estudiante("Carlos Pérez", 12346, 2024);

            // Inscribir estudiantes en cursos
            estudiante1.Inscribirse(curso1);
            estudiante2.Inscribirse(curso1);
            estudiante1.Inscribirse(curso2);

            // Visualizar estudiantes en cursos
            curso1.VisualizarEstudiantes();
            curso2.VisualizarEstudiantes();

            // Desinscribir estudiante de un curso
            estudiante1.Desinscribirse(curso1);

            // Visualizar estudiantes en cursos después de la desinscripción
            curso1.VisualizarEstudiantes();

            Console.ReadKey();
        }
    }

    }

