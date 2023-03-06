using EjercicioPOO2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO2
{
    public class Menu
    {
       
        public static void MenuPrincipal() 
        {
            int ejercicio;
            bool leido = true;

            do
            {
                
                if (leido)
                {
                    Console.WriteLine("Que ejrcicio desea ver en funcionamiento:\n" +
                        "1- Manejo de excepcion en division por cero\n" +
                        "2- Manejo de excepcion en division\n" +
                        "3- Ver mensaje y tipo de una excepcion\n" +
                        "4- Ver mensaje y tipo de una excepcion personalizada\n" +
                        "0 o  vacio- Terminar aplicacion");
                }
                Console.WriteLine("\nIngrese el numero de ejercicio:");
                leido = int.TryParse(Console.ReadLine(), out ejercicio);
                switch (ejercicio)
                {
                    case 0:
                        Console.WriteLine("Hasta la proxima");
                        break;

                    case 1:
                        Ejercicio1();
                        Wait();
                        break;

                    case 2:
                        Ejercicio2();
                        Wait();
                        break;

                    case 3:
                        Ejercicio3();
                        Wait();
                        break;

                    case 4:
                        Ejercicio4();
                        Wait();
                        break;

                    default:
                        Console.WriteLine("No se ha ingresado un numero valido");
                        Console.WriteLine();
                        break;
                }

                
            } while (ejercicio != 0);
        }

        private static void Wait() 
        {
            Console.ReadKey();
            Console.WriteLine();
        }

        private static void Ejercicio1() 
        {
            LabNetPractica2.ExcepcionDivision();
        }

        private static void Ejercicio2() 
        {
            try
            {
                LabNetPractica2.Division();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Ejercicio3()
        {
            try
            {
                Logic.ExceptionThrower();
            }
            catch (TypedDataSetGeneratorException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }
        }

        private static void Ejercicio4()
        {
            try
            {
                Logic.TeaPotThrower();
            }
            catch (IAmATeaPotException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());
            }
        }







    }
}
