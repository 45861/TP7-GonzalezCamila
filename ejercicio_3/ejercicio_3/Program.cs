using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
            /* 3. Una tienda en linea desea desarrollar un sistema para gestionar sus productos y pedidos. Cada producto
             * tiene un nombre, precio, descripcion y cantidad en stock. Los pedidos incluyen un odentificador de pedidos, 
             * fecha de pedidos, cliente y el precio total del pedido. Los clientes tienen un nombre, direccion de envio y 
             * direccion de correo electronico. Diseña un programa que permita agregar productos, gestionar el stock, y procesar
             * pedidos, Identificar los objetivos, atributos y metodoss necesarrios para este sistema.*/ 
        {
            Producto producto1 = new Producto();
            producto1.Nombre = "Laptop";
            producto1.Precio = 1500.00m;
            producto1.Descripcion1 = "Laptop de alta gama";
            producto1.CantidadEnStock1 = 10;
            producto1.MostrarInformacion(); 
            Console.WriteLine("---------------------------------------------------"); 

            Producto producto2 = new Producto();
            producto2.Nombre = "Smartphone";
            producto2.Precio = 800.00m;
            producto2.Descripcion1 = "Smartphone de última generación";
            producto2.CantidadEnStock1 = 20;
            producto2.MostrarInformacion();
            Console.WriteLine("---------------------------------------------------");

            Cliente cliente1 = new Cliente();
            cliente1.Nombre = "Juan Perez";
            cliente1.DireccionEnvio1 = "Calle Falsa 123";
            cliente1.CorreoElectronico1 = "juan@example.com";
            cliente1.MostrarInformacion();
            Console.WriteLine("---------------------------------------------------");

            Pedido pedido1 = new Pedido();
            pedido1.IdentificadorPedido1 = 1;
            pedido1.FechaPedido1 = DateTime.Now;
            pedido1.Cliente1 = cliente1;
            pedido1.MostrarInformacion(); 

            Console.ReadKey(); 

        }
    }

}
    

