using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    public class Utilities
    {
        public static int LeerNumero(int max)
        {
            int aux;

            while ((!int.TryParse(Console.ReadLine(), out aux) || (aux > max || aux < 0)))
            {
                Console.WriteLine("Ingreso por teclado invalido, ingrese una de las opciones");
            }

            return aux;
        }
        public static string LeerTexto()
        {
            string res;
            do
            {
                res = Console.ReadLine();
            }while (res == "");

            return res;
        }
    }
}
