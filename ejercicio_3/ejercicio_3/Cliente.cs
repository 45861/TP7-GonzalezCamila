using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Cliente
    {
        private string nombre;
        private string DireccionEnvio;
        private string CorreoElectronico;
        
        public string Nombre { get => nombre; set => nombre = value; }
        public string DireccionEnvio1 { get => DireccionEnvio; set => DireccionEnvio = value; }
        public string CorreoElectronico1 { get => CorreoElectronico; set => CorreoElectronico = value; }

        public void MostrarInformacion()
        {
            Console.WriteLine("Cliente: " + Nombre);
            Console.WriteLine("Direcion de envio: " + DireccionEnvio);
            Console.WriteLine("Correo Electronico: " + CorreoElectronico);
        }
 
    }
}
