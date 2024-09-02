using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
            /* Una tienda en linea desea desarrollar un sistema para gestionar sus productos y pedidods. Cada producto tiene un nombre, precio,
             * descripcion y capacidad en stock. Los peididos incluyen un indicador de pedido, fecha de peddido, cliente y el precio total
             del pedido. Los clientes tienen un nombre, direcion de envio y direccion de correo electronico. diseña un programa que permita agregar 
             productos, gestionar el stock,  y procesar pedidos. Identificar los objetos. atributos y metodos necesarios para este sistema.*/
        {
            Vuelo vuelo1 = new Vuelo();
            vuelo1.Numero1 = "AA1234";
            vuelo1.Fecha_salida1 = new DateTime(2024, 6, 20, 14, 30, 0);
            vuelo1.Destino1 = " new york ";
            vuelo1.Precio1 = 500.00m;
            vuelo1.MostrarInformacionVuelo();
            Console.WriteLine("--------------------------------------------------------------------");

            Pasajero pasajero1 = new Pasajero(); 
            pasajero1.Nombre1 = "Juan Perez";
            pasajero1.Numero_pasaporte = "A12345678";
            pasajero1.Nacionalidad1 = "Mexicano";
            pasajero1.MostrarInformacionPasajero();
            Console.WriteLine("--------------------------------------------------------------------");
            Pasajero pasajero2 = new Pasajero();
            pasajero2.Nombre1 = "Maria Perez";
            pasajero2.Numero_pasaporte = "B98765432";
            pasajero2.Nacionalidad1 = "Argentina";
            pasajero2.MostrarInformacionPasajero();
            Console.WriteLine("--------------------------------------------------------------------");
            

            Console.ReadKey(); 

        }
    }
}
