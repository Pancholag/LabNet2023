using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO2
{
    public class Logic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="TypedDataSetGeneratorException"></exception>
        public static void ExceptionThrower() 
        {
            Console.WriteLine("Escriba un mensaje personalizado o vea el mensaje por defecto");

            var mensaje = Console.ReadLine();

            if (mensaje != "")
                throw new TypedDataSetGeneratorException(mensaje);

            throw new TypedDataSetGeneratorException();
        }

        public static void TeaPotThrower()
        {
            Console.WriteLine("Lanzando \"I am a tea pot exception\" ");

            throw new IAmATeaPotException();
        }
    }
}
