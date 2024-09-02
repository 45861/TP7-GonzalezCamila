using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1.Modelo
{
    class Libro
    {


        private string titulo;
        private string autor;
        private string editorial;
        private string codigo; // Código único para identificar el libro
        private bool disponible;

        // CONSTRUCTOR: darle valor a los objetos cuando se los invoca tiene que ser publico para tener acceso en el 
        // lleva el mismo nombre de la clase, puede o no llevar parametros 
        // se los diferencias en el numero de parametros 
        // no retornan nada no son bool ni retornan un string

        public Libro(string titulo, string autor, string editorial, string codigo)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            Codigo = codigo;
            Disponible = true;
        }

        public bool ConsultarDisponibilidad()
        {
            return Disponible;
        }

        public void PedirPrestado()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine($"{Titulo} ha sido prestado.");
            }
            else
            {
                Console.WriteLine($"{Titulo} no está disponible.");
            }



            //formas de escribir los set y get
            /*
            public string Autor { get; set; }
            public string Autor { get => autor; set => autor = value; }
            */

        }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
    }
    }



    
