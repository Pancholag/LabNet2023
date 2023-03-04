using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO2
{
    [Serializable]
    internal class IAmATeaPotException : Exception
    {
        private static readonly string _message = "Excepcion basada en el codigo de respuesta 418 de HTTP";
        public IAmATeaPotException() : base(_message) { }
        public IAmATeaPotException(String message) : base(message) { }
        public IAmATeaPotException(String message, Exception inner) : base(message, inner) { }
    }
}
