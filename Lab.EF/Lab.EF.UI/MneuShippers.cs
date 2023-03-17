using Lab.LINQ.Entities;
using Lab.LINQ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LINQ.UI
{

    public class MenuShippers : MenuEntidadBase
    {
        private IAbmLogic<Shipper,int> _shippersLogic = new ShippersLogic();

        public override void VerTodos()
        {
            Console.WriteLine("** Mostrando Transportistas **");
            foreach (var s in _shippersLogic.GetAll())
            {
                Console.WriteLine($"Nombre de compania: {s.CompanyName} ID: {s.ShipperID}");
            }
            Console.ReadKey();
        }
        public override void Agregar()
        {
            Shipper shipper = new Shipper();

            Console.WriteLine("Agregando un Transportista" +
                "\n Ingrese el nombre de la compania de transporte:");
            shipper.CompanyName = Utilities.LeerTexto();

            _shippersLogic.Add(shipper);
            Console.WriteLine($"Transportista {shipper.CompanyName} agregado con exito");
            Console.ReadKey();
        }
        public override void Remover()
        {
            Console.WriteLine("Ingrese el ID del transportista a Remover");
            var c = _shippersLogic.Remove(Utilities.LeerNumero());
            Console.WriteLine($"Transportista {c.CompanyName} ha sido removido con exito");
            Console.ReadKey();
        }
        public override void Modificar()
        {
            Console.WriteLine("Ingrese el ID del transportista a Modificar");
            var shipper = Buscar();
            Console.WriteLine("Transportista a modificar:\n" + shipper);
            Console.WriteLine("Ingrese nuevo nombre de transportista o ingrese 0 para salir:");
            string str = Utilities.LeerTexto();
            if (str != "0")
            {
                shipper.CompanyName = str;
                _shippersLogic.Update(shipper);
                Console.WriteLine($"Transportista {str} modificado con exito");
                Console.ReadKey();
            }
        }
        public override void VerDetalle()
        {
            Console.WriteLine("Ingrese el ID del transportista a consultar:");
            var shipper = Buscar();
            Console.WriteLine(shipper);
            Console.ReadKey();
        }
        private Shipper Buscar()
        {
            var id = Utilities.LeerNumero();
            var shipper = _shippersLogic.Find(id);
            if (shipper == null)
                throw new ArgumentException($"Transportista con el id {id} no encontrado");
            return shipper;
        }
    }
}

