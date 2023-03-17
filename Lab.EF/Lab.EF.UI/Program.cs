using Lab.LINQ.Entities;
using Lab.LINQ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LINQ.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la aplicacion de manejo de NorthWind Data Base");

            Menu.MenuPrincipal();

            Console.WriteLine("Hasta la proxima");
            Console.ReadKey();
        }
    }
}
