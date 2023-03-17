using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.LINQ.Logic;

namespace Lab.LINQ.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;
            IQuerys m = null;

            do
            {
                Console.WriteLine("Ingrese una opcion: " +
                    "\n1- Ejecucion con method syntax" +
                    "\ncualquier numero- Ejecucion con query syntax" +
                    "\n(ambas ejecuciones devuelven los mismos resultados)");
            } while (!
            int.TryParse(Console.ReadLine(), out aux));


            if (aux == 1)
            {
                 m = new MethodSyntax();
            }
            else
            {
                m = new QuerySyntax();
            }

            Console.WriteLine("Ejecutando ejercicio 1");
            Console.WriteLine(m.Ejercicio1().CompanyName);
            Console.ReadKey();

            Console.WriteLine("Ejecutando ejercicio 2");
            foreach (var p in m.Ejercicio2())
            {
                Console.WriteLine(p.ProductName);
            }
            Console.ReadKey();

            Console.WriteLine("Ejecutando ejercicio 3");
            foreach (var p in m.Ejercicio3())
            {
                Console.WriteLine(p.ProductName);
            }
            Console.ReadKey();

            Console.WriteLine("Ejecutando ejercicio 4");
            foreach (var c in m.Ejercicio4())
            {
                Console.WriteLine(c.ContactName);
            }
            Console.ReadKey();

            Console.WriteLine("Ejecutando ejercicio 5");
            Console.WriteLine(m.Ejercicio5() == null ? "el valor es null" : "valor encontrado");
            Console.ReadKey();

            Console.WriteLine("Ejecutando ejercicio 6");
            foreach (var c in m.Ejercicio6())
            {
                Console.WriteLine($"{c.ToUpper()} - {c.ToLower()}");
            }
            Console.ReadKey();

            Console.WriteLine("Ejecutando ejercicio 7");
            foreach (var d in m.Ejercicio7())
            {
                Console.WriteLine($"{d.CustomerCompanyName} - {d.OrderID}");
            }
            Console.ReadKey();

            Console.WriteLine("Ejecutando ejercicio 8");
            foreach (var c in m.Ejercicio8())
            {
                Console.WriteLine(c.ContactName);
            }
            Console.ReadKey();

            Console.WriteLine("Ejecutando ejercicio 9");
            foreach (var p in m.Ejercicio9())
            {
                Console.WriteLine(p.ProductName);
            }
            Console.ReadKey();

            Console.WriteLine("Ejecutando ejercicio 10");
            foreach (var p in m.Ejercicio10())
            {
                Console.WriteLine(p.UnitsInStock);
            }
            Console.ReadKey();

            Console.WriteLine("Ejecutando ejercicio 11");
            foreach (var c in m.Ejercicio11())
            {
                Console.WriteLine(c.CategoryName);
            }
            Console.ReadKey();

            Console.WriteLine("Ejecutando ejercicio 12");
            Console.WriteLine(m.Ejercicio12().ProductName);
            Console.ReadKey();

            Console.WriteLine("Ejecutando ejercicio 13");
            foreach (var c in m.Ejercicio13())
            {
                Console.WriteLine($"{c.ContactName} - {c.CantOrdenes}");
            }
            Console.ReadKey();
        }
    }
}
