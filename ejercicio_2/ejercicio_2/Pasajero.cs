using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Pasajero
    {
        private string Nombre;
        private string numero_pasaporte;
        private string Nacionalidad;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Numero_pasaporte { get => numero_pasaporte; set => numero_pasaporte = value; }
        public string Nacionalidad1 { get => Nacionalidad; set => Nacionalidad = value; }

        public void MostrarInformacionPasajero()
        {
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("Pasaporte" + Numero_pasaporte);
            Console.WriteLine("Nacionalidad" + Nacionalidad); 
        }

    }
}
