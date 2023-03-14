using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{

    public class MenuShippers : MenuEntidadBase
    {
        private ShippersLogic _shippersLogic = new ShippersLogic();

        public override void VerTodos()
        {
            foreach (var s in _shippersLogic.GetAll())
            {
                Console.WriteLine($"Nombre de compania: {s.CompanyName} ID: {s.ShipperID}");
            }
        }
        public override void Agregar()
        {
            Shipper shipper = new Shipper();

            Console.WriteLine("Agregando un cliente" +
                "\n Ingrese el nombre de la compania:");
            shipper.CompanyName = Utilities.LeerTexto();

            _shippersLogic.Add(shipper);
            Console.WriteLine($"Guardando compania {shipper.CompanyName}");
        }
        public override void Remover()
        {
            Console.WriteLine("Ingrese el ID del cliente a Remover");
            _shippersLogic.Remove(Utilities.LeerNumero(int.MaxValue));
        }
        public override void Modificar()
        {
            Console.WriteLine("Ingrese el ID del cliente a Modificar");
            var customer = _shippersLogic.Find(Utilities.LeerNumero(int.MaxValue));

            Console.WriteLine(customer);
        }
        public override void VerDetalle()
        {
            Console.WriteLine("Ingrese el ID del transportista a consultar:");
            var id = Utilities.LeerNumero(int.MaxValue);
            var aux = _shippersLogic.Find(id);
            if (aux == null)
                throw new ArgumentException($"Transportista con el id {id} no encontrado");
            Console.WriteLine(aux);
        }
    }
}

