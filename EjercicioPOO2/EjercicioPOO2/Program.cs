using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExcepcionDivision();

            try
            {
                Division();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try 
            {
                Logic.ExceptionThrower();
            }
            catch (TypedDataSetGeneratorException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }

            try
            {
                Logic.TeaPotThrower();
            }
            catch (IAmATeaPotException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Lee un numero ingresado por consola
        /// </summary>
        /// <returns>Numero ingresado</returns>
        /// <exception cref="FormatException"></exception>
        static int LeerNumero() 
        {
            int num;
            
            Console.WriteLine("Ingrese un numero:");
            if (!int.TryParse(Console.ReadLine(), out num))
                throw new FormatException("Seguro Ingreso una letra o no ingreso nada!");
            
            return num;
        }

        static void ExcepcionDivision()
        {
            int num = 0;

            try
            {
                num = LeerNumero();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                num = num / 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("division realizada");
            }
        }

        /// <summary>
        /// intenta realizar una division
        /// </summary>
        /// <exception cref="DivideByZeroException"></exception>
        static void Division() 
        {
            var dividendo = LeerNumero();
            var divisor = LeerNumero();

            if (divisor == 0) 
            {
                throw new DivideByZeroException("Solo Chuck Norris divide por cero!");
            }

            Console.WriteLine(dividendo/divisor);
        }
    
    }
}
