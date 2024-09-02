using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1.Modelo
{
    class Prestamo
    {
        private Usuario usuario;
        private Libro libro;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;

        internal Usuario Usuario { get => usuario; set => usuario = value; }
        internal Libro Libro { get => libro; set => libro = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }

        public Prestamo(Usuario usuario, Libro libro)
        {
            Usuario = usuario;
            Libro = libro;
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = FechaPrestamo.AddDays(14); // Asumimos un período de préstamo de 14 días
        }

        public void RegistrarPrestamo()
        {
            Console.WriteLine($"Préstamo registrado: {Libro.Titulo} prestado a {Usuario.Nombre} el {FechaPrestamo.ToShortDateString()}.");
        }

        public void EnviarRecordatorio()
        {
            if ((FechaDevolucion - DateTime.Now).TotalDays <= 3)
            {
                Console.WriteLine($"Recordatorio: {Usuario.Nombre}, por favor devuelve {Libro.Titulo} antes del {FechaDevolucion.ToShortDateString()}.");
            }
        }

    }
}
