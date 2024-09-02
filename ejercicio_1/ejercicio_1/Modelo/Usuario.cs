using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1.Modelo
{
    class Usuario
    {
        private string nombre;
        private int iD;
        private bool registrado;

        public string Nombre { get => nombre; set => nombre = value; }
        public int ID { get => iD; set => iD = value; }
        public bool Registrado { get => registrado; set => registrado = value; }

        public Usuario(string nombre, int id)
        {
            Nombre = nombre;
            ID = id;
            Registrado = false;
        }

        public void Registrar()
        {
            Registrado = true;
            Console.WriteLine($"{Nombre} ha sido registrado.");
        }

        public void ConsultarLibrosDisponibles(List<Libro> libros)
        {
            foreach (var libro in libros)
            {
                if (libro.ConsultarDisponibilidad())
                {
                    Console.WriteLine($"{libro.Titulo} está disponible.");
                }
            }
        }

        public void PedirLibro(Libro libro)
        {
            if (Registrado)
            {
                libro.PedirPrestado();
            }
            else
            {
                Console.WriteLine($"{Nombre} no está registrado y no puede pedir prestado libros.");
            }
        }
    }
}
