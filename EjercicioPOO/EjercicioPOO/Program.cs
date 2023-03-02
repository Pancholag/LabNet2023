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

            Console.WriteLine("generando omnibuses (max 30 pasajeros)");
            
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese la cantidad de pasajeros");
                transportes.Add(new Omnibus(LeerNumeroMenorA(30)));   
            }

            Console.WriteLine("generando taxis (max 4 pasajeros)");

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese la cantidad de pasajeros");
                transportes.Add(new Taxi(LeerNumeroMenorA(4)));
            }

            Console.WriteLine("mostrando cantidad de pasajeros de los transportes");

            foreach (var item in transportes)
            {
                item.InformarCantidadPasajeros();
            }

            Console.ReadLine();
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
