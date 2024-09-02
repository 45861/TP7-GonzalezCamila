using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    class Curso
    {
        private string codigo;
        private string nombre;
        private string profesor;
        private string materia;
        private List<Estudiante> Estudiantes;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Profesor { get => profesor; set => profesor = value; }
        public string Materia { get => materia; set => materia = value; }
        internal List<Estudiante> Estudiantes1 { get => Estudiantes; set => Estudiantes = value; }

        public Curso(string codigo, string nombre, string profesor, string materia)
        {
            Codigo = codigo;
            Nombre = nombre;
            Profesor = profesor;
            Materia = materia;
            Estudiantes1 = new List<Estudiante>();
        }

        public void InscribirEstudiante(Estudiante estudiante)
        {
            Estudiantes1.Add(estudiante);
            Console.WriteLine($"{estudiante.Nombre} ha sido inscrito en el curso {Nombre}.");
        }

        public void DesinscribirEstudiante(Estudiante estudiante)
        {
            Estudiantes1.Remove(estudiante);
            Console.WriteLine($"{estudiante.Nombre} ha sido desinscrito del curso {Nombre}.");
        }

        public void VisualizarEstudiantes()
        {
            Console.WriteLine($"Estudiantes en el curso {Nombre}:");
            foreach (var estudiante in Estudiantes1)
            {
                Console.WriteLine($"- {estudiante.Nombre}");
            }

        }
    }
}
    
