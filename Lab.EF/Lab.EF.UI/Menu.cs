using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    public class Menu
    {
        private static readonly int _cantEntidades = 11;
        public static void MenuPrincipal()
        {
            int seleccion;
            do
            {
                Console.WriteLine(
                    "Con que entidad desea interactuar:" +
                    "\n1- Categoria" +
                    "\n2- Cliente" +
                    "\n3- Demografia de Cliente" +
                    "\n4- Empleado" +
                    "\n5- Orden" +
                    "\n6- Detalles de orden" +
                    "\n7- Producto" +
                    "\n8- Region" +
                    "\n9- Transportista" +
                    "\n10- Proveedor" +
                    "\n11- Territorio" +
                    "\n0- Terminar Aplicacion");
                seleccion = LeerNumero(_cantEntidades);
                Console.WriteLine($"la seleccion fue {seleccion}");
            } while (seleccion != 0);



        }
        public static int LeerNumero(int max)
        {
            int aux;

            while ((!int.TryParse(Console.ReadLine(), out aux) || (aux > max || aux < 0)))
            {
                Console.WriteLine("Ingreso por teclado invalido, intente nuevamente");
            }

            return aux;
        }

    }
}
