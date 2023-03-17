﻿using Lab.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LINQ.UI
{
    public static class Menu
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
                    menu.Ejecutar();
                    menu = null;
                }

                Console.Clear();
            } while (seleccion != 0);
        }
    }
}
