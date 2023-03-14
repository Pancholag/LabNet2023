using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
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
