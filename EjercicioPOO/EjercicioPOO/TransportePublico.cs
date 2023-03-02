using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal abstract class TransportePublico : ICantidadPasajeros
    {
        private int _pasajeros;

        public TransportePublico(int pasajeros) 
        {
            _pasajeros = pasajeros;
        }

        public abstract void Avanzar();
        public abstract void Detenerse();

        public void InformarCantidadPasajeros()
        {
            Console.WriteLine($"LLevo {_pasajeros} pasajero/s");
        }
    }
}
