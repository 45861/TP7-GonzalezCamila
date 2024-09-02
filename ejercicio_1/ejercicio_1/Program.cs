using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio_1.Modelo; 

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
            /* Una biblioteca digital ofrece una amplia variedad de libros a sus usuarios registrados.
             * Los usuarios pueden buscar libros, leer descripciones, ver la disponibilidad y, si estan registrados, pueden pedir prestado los libros.
             Los libros  pueden estar disponibles en formato digital o fisico. Cada vez que un usuario pide prestado un libro, se registra la fecha de 
             prestamo y la fecha de devolucion previa. Ademas, la biblioteca tiene un sistema para enviar recordatorios a los usuarios
             cuando se acerca la fecha de devolucion de un libro*/
        {
            
         
        
                // Crear algunos libros
                Libro libro1 = new Libro("El Quijote", "Miguel de Cervantes", "Editorial A", "C001");
                Libro libro2 = new Libro("1984", "George Orwell", "Editorial B", "C002");

                // Crear un usuario
                Usuario usuario1 = new Usuario("Juan Pérez", 1);

                // Registrar el usuario
                usuario1.Registrar();

                // Consultar libros disponibles
                List<Libro> libros = new List<Libro> { libro1, libro2 };
                usuario1.ConsultarLibrosDisponibles(libros);

                // Pedir prestado un libro
                usuario1.PedirLibro(libro1);

                // Crear un préstamo
                Prestamo prestamo1 = new Prestamo(usuario1, libro1);
                prestamo1.RegistrarPrestamo();

                // Enviar recordatorio
                prestamo1.EnviarRecordatorio();
            
            Console.ReadKey();
        }
    }
}
