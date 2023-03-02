using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Taxi : TransportePublico 
    {
        public Taxi(int pasajeros) : base(pasajeros)
        {
        }

        public override void Avanzar()
        {
            Console.WriteLine("Soy un taxi avanzando");
        }

        public override void Detenerse()
        {
            Console.WriteLine("Soy un taxi deteniendome");
        }
    }
}
