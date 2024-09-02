using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Vuelo
    {
        private string Numero;
        private DateTime Fecha_salida;
        private string Destino;
        private decimal Precio;
        private List<Pasajero> Pasajeros;

        public string Numero1 { get => Numero; set => Numero = value; }
        public DateTime Fecha_salida1 { get => Fecha_salida; set => Fecha_salida = value; }
        public string Destino1 { get => Destino; set => Destino = value; }
        public decimal Precio1 { get => Precio; set => Precio = value; }
        internal List<Pasajero> Pasajeros1 { get => Pasajeros; set => Pasajeros = value; }

        public void MostrarInformacionVuelo()
        {
            Console.WriteLine("Numero de vuelo" + Numero);
            Console.WriteLine("Fecha de salida: " + Fecha_salida);
            Console.WriteLine("Destino: " + Destino);
            Console.WriteLine("Precio" + Precio);
            Console.WriteLine("Lista de psajeros: ");

        }

    }
}
