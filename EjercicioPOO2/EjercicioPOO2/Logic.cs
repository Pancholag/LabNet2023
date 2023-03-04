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
            throw new TypedDataSetGeneratorException("Excepcion con el nombre mas largo que vi");
        }

        public static void TeaPotThrower()
        {
            throw new IAmATeaPotException();
        }
    }
}
