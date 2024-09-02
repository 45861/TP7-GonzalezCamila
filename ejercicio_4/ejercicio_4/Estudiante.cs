using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    class Estudiante
    {
        private string nombre;
        private int numeroMatricula;
        private int añoCursado;

        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroMatricula { get => numeroMatricula; set => numeroMatricula = value; }
        public int AñoCursado { get => añoCursado; set => añoCursado = value; }

        public Estudiante(string nombre, int numeroMatricula, int añoCursado)
        {
            Nombre = nombre;
            NumeroMatricula = numeroMatricula;
            AñoCursado = añoCursado;
        }

        public void Inscribirse(Curso curso)
        {
            curso.InscribirEstudiante(this);
        }

        public void Desinscribirse(Curso curso)
        {
            curso.DesinscribirEstudiante(this);
        }
    }
}
