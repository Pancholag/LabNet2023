using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    public abstract class MenuEntidadBase
    {
        public static int cantMetodos = 5;
        public abstract void VerTodos();
        public abstract void VerDetalle();
        public abstract void Agregar();
        public abstract void Remover();
        public abstract void Modificar();
        public void Ejecutar()
        {
            int seleccion;
            do
            {
                Console.WriteLine(
                    "Que desea hacer:" +
                    "\n1- Ver todos los registros" +
                    "\n2- Ver detalle de un registro" +
                    "\n3- Agregar un registro" +
                    "\n4- Remover un registro" +
                    "\n5- Modificar un registro" +
                    "\n0- Salir");
                seleccion = Utilities.LeerNumero(MenuEntidadBase.cantMetodos);

                switch (seleccion)
                {
                    case 1:
                        VerTodos();
                        break;
                    case 2:
                        VerDetalle();
                        break;
                    case 3:
                        Agregar();
                        break;
                    case 4:
                        Remover();
                        break;
                    case 5:
                        Modificar();
                        break;
                }
            } while (seleccion != 0);
        }
    }
}
