using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    public class Menu
    {
        private static readonly int _cantEntidades = 2;
        public static void MenuPrincipal()
        {
            MenuEntidadBase menu = null;
            int seleccion;
            do
            {
                Console.WriteLine(
                    "Con que entidad desea interactuar:" +
                    "\n1- Categoria" +
                    "\n2- Transportista" +
                    "\n0- Terminar Aplicacion");
                seleccion = Utilities.LeerNumero(_cantEntidades);

                switch (seleccion)
                {
                    case 1:
                        menu = new MenuCategories();
                        break;
                    case 2:
                        menu = new MenuShippers();
                        break;
                }

                if (menu != null)
                {
                    try
                    {
                        menu.Ejecutar();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

            } while (seleccion != 0);
        }
    }
}
