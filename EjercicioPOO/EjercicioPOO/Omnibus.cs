using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros) : base(pasajeros)
        {
        }

        public override void avanzar()
        {
            Console.WriteLine("Soy un omnibus avanzando");
        }

        public override void detenerse()
        {
            Console.WriteLine("Soy un omnibus deteniendome");
        }
    }
}
