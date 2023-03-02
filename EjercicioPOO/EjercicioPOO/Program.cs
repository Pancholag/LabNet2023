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

            Random r;
            int offset = 5;

            Console.WriteLine("generando omnibuses");
            
            for (var i = 0; i < 5; i++)
            {
                r = new Random(i);
                //Console.WriteLine(r.Next(0, 30));
                transportes.Add(new Omnibus(r.Next(0, 30)));   
            }

            Console.WriteLine("generando taxis");

            for (var i = 0; i < 5; i++)
            {
                r = new Random(i + offset);
                //Console.WriteLine(r.Next(0, 4));
                transportes.Add(new Taxi(r.Next(0, 4)));
            }

            foreach (var item in transportes)
            {
                item.InformarCantidadPasajeros();
            }

            Console.ReadLine();
        }
    }
}
