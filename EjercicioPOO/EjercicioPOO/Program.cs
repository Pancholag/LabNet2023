using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICollection<TransportePublico> transportes = new List<TransportePublico>(10);

            Console.WriteLine("generando omnibuses");
            
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese la cantidad de pasajeros");
                transportes.Add(new Omnibus(int.Parse(Console.ReadLine())));   
            }

            Console.WriteLine("generando taxis");

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese la cantidad de pasajeros");
                transportes.Add(new Taxi(int.Parse(Console.ReadLine())));
            }

            foreach (var item in transportes)
            {
                item.InformarCantidadPasajeros();
            }

            Console.ReadLine();
        }
    }
}
