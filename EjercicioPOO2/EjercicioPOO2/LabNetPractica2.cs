using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO2
{
    internal class LabNetPractica2
    {
        /// <summary>
        /// Lee un numero ingresado por consola
        /// </summary>
        /// <returns>Numero ingresado</returns>
        /// <exception cref="FormatException"></exception>
        public static double LeerNumero()
        {
            double num;

            Console.WriteLine("Ingrese un numero:");
            if (!double.TryParse(Console.ReadLine(), out num))
                throw new FormatException("Seguro Ingreso una letra o no ingreso nada!");

            return num;
        }

        public static void ExcepcionDivision()
        {
            double num = 0;

            try
            {
                num = LeerNumero();

                Console.WriteLine($"Dividiendo {num} / 0");

            try
            {
                num = num / 0;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Mensaje de la interrupcion:\n -{e.Message}");
            }
            finally
            {
                Console.WriteLine("Operacion intentada");
            }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// intenta realizar una division
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        public static void Division()
        {
            var dividendo = LeerNumero();
            var divisor = LeerNumero();

            if (divisor == 0)
            {
                throw new DivideByZeroException("Solo Chuck Norris divide por cero!");
            }

            Console.WriteLine($"Dividiendo {dividendo} / {divisor}");
            Console.WriteLine(dividendo / divisor);
        }
    }
}
