using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICollection<TransportePublico> transportes = new List<TransportePublico>(10);

            GenerarOmnibuses(transportes);
            GenerarTaxis(transportes);
            MostrarPasajeros(transportes);

            Console.ReadLine();
        }

        static public void GenerarOmnibuses(ICollection<TransportePublico> transportes)
        {
            Console.WriteLine("generando omnibuses (max 30 pasajeros)");

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese la cantidad de pasajeros");
                transportes.Add(new Omnibus(LeerNumeroMenorA(30)));
            }
        }

        private static void GenerarTaxis(ICollection<TransportePublico> transportes)
        {
            Console.WriteLine("generando taxis (max 4 pasajeros)");

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese la cantidad de pasajeros");
                transportes.Add(new Taxi(LeerNumeroMenorA(4)));
            }
        }
        
        private static void MostrarPasajeros(ICollection<TransportePublico> transportes)
        {
            Console.WriteLine("mostrando cantidad de pasajeros de los transportes");

            foreach (var item in transportes)
            {
                item.InformarCantidadPasajeros();
            }
        }

        static public int LeerNumeroMenorA(int numero) 
        {
            int aux = int.Parse(Console.ReadLine());


            while (aux < 0 || aux >= numero)
            {
                Console.WriteLine($"ingrese un numero entre 0 y {numero}");
                aux = int.Parse(Console.ReadLine());
            } 

            return aux;
        }
    }
}
