using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aux = 2;

            IQuerys m = null;

            if (aux == 1)
            {
                 m = new MethodSyntax();
            }
            else
            {
                m = new QuerySyntax();
            }
            
            Console.WriteLine(m.Ejercicio1().CompanyName);
            Console.ReadKey();
            
            foreach (var p in m.Ejercicio2())
            {
                Console.WriteLine(p.ProductName);
            }
            Console.ReadKey();

            foreach (var p in m.Ejercicio3())
            {
                Console.WriteLine(p.ProductName);
            }
            Console.ReadKey();

        }
    }
}
