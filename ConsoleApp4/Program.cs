using ConsoleApp4.clientes;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using ConsoleApp4.clientes;
//using PersonaRRHH = ConsoleApp4.rrhh;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Program programa = new Program();

            // ejercicio #2
            string[] productos = new string[3];
            productos[0] = "cocacola";
            productos[1] = "fanta";
            productos[2] = "sprite";

            Console.WriteLine(productos[0]);
            Console.WriteLine(productos[1]);
            Console.WriteLine(productos[2]);

            var productoLista = new List<string>();
            productoLista.Add("cocacola");
            productoLista.Add("fanta");
            productoLista.Add("sprite");

            Console.WriteLine(productoLista[0]);
            Console.WriteLine(productoLista[1]);
            Console.WriteLine(productoLista[2]);

            // ejercicio 3
            Libro libro = new Libro();

            Libro libro1 = new Libro();
            libro1.titulo = "Harry Potter";
            libro1.autor = "JKR";
            libro1.precio = 50000;

            Libro libro2 = new Libro { titulo = "Harry Potter", autor = "JKR", precio = 50000 };

            Console.WriteLine(libro1.titulo);
            Console.WriteLine(libro1.autor);
            Console.WriteLine(libro1.precio);


            // ejercicio #4
            
            var venta1 = new Venta { region = "East", vendedor = "Jones", item = "Pencil", cantidad = 95, precioUnitario = 1.99 };
            
            var venta2 = new Venta { region = "Central", vendedor = "Kivell", item = "Binder", cantidad = 50, precioUnitario = 19.99 };
            var venta3 = new Venta { region = "East", vendedor = "Jones", item = "Pencil", cantidad = 95, precioUnitario = 1.99 };

            // Ejercicio #5
            //E02387	Emily Davis	Sr. Manger	IT
            var emp1 = new Empleado();
            emp1.eeid = "E02387";
            emp1.nombreCompleto = "Emily Davis";
            emp1.rol = "Sr. Manger";
            emp1.departamento = "IT";
            Console.WriteLine("-----Ejercicio #5---------");
            Console.WriteLine(emp1.eeid);
            Console.WriteLine(emp1.nombreCompleto);
            Console.WriteLine(emp1.rol);
            Console.WriteLine(emp1.departamento);


            // Ejercicio persona
            //var cliente1 = new Persona();
            //var empleado = new PersonaRRHH.Persona();

            // Ejercicio proveedor
            var proveedor1 = new Proveedor();

    

            Console.ReadKey();
        }
    }
}
