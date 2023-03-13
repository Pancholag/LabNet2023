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
        private ShippersLogic shippersLogic = new ShippersLogic();

        public override void Ver()
        {
            foreach (var c in shippersLogic.GetAll())
            {
                Console.WriteLine(c.CompanyName);
            }
        }
        public override void Agregar()
        {
            Shipper shipper = new Shipper();

            Console.WriteLine("Agregar un cliente");

            shipper.CompanyName = Console.ReadLine();
            shipper.ShipperID = shippersLogic.GenerateId();

            shippersLogic.Add(shipper);

        }
        public override void Remover()
        {
            Console.WriteLine("Ingrese el ID del cliente a Remover");
            int id;
            int.TryParse(Console.ReadLine(), out id);

            shippersLogic.Remove(id);
        }
        public override void Modificar()
        {
            Console.WriteLine("Ingrese el ID del cliente a Modificar");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            var customer = shippersLogic.Find(id);

            Console.WriteLine(customer);
        }
    }
}

