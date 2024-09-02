using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Producto
    {
        private string nombre;
        private decimal precio;
        private string Descripcion;
        public int CantidadEnStock;

        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int CantidadEnStock1 { get => CantidadEnStock; set => CantidadEnStock = value; }

        public void MostrarInformacion()
        {
            Console.WriteLine("Producto: " + Nombre);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Descripcion: " + Descripcion1);
            Console.WriteLine("Cantidad en stock: " + CantidadEnStock);
        }
    }
}
