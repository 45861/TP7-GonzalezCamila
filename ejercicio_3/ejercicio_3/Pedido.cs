using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Pedido
    {
        private int IdentificadorPedido;
        private DateTime FechaPedido;
        private Cliente Cliente;
        private Decimal precioTotal;
        private List<Producto> ListaProductos;

        public int IdentificadorPedido1 { get => IdentificadorPedido; set => IdentificadorPedido = value; }
        public DateTime FechaPedido1 { get => FechaPedido; set => FechaPedido = value; }
        internal Cliente Cliente1 { get => Cliente; set => Cliente = value; }
        public decimal PrecioTotal { get => precioTotal; set => precioTotal = value; }
        internal List<Producto> ListaProductos1 { get => ListaProductos; set => ListaProductos = value; }

      
        public void MostrarInformacion()
        {
            Console.WriteLine("Precio id: " + IdentificadorPedido);
            Console.WriteLine("Fecha: " + FechaPedido);
            Console.WriteLine("Cliente: " + Cliente.Nombre);
            Console.WriteLine("Precio total: " + PrecioTotal);

            /*Console.WriteLine("Productos en el pedido: ");
            foreach (var producto in ListaProductos)
            {
                producto.MostrarInformacion(); 
            }*/
        }
    }
}
