﻿using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    public class MenuCustomers : MenuEntidadBase
    {
        public override void Ver()
        {
            CustomerLogic customerLogic = new CustomerLogic();

            foreach (Customer c in customerLogic.GetAll())
            {
                Console.WriteLine(c.CompanyName);
            }
        }
        public override void Agregar()
        {
            CustomerLogic customerLogic = new CustomerLogic();
            Customer customer = new Customer();

            Console.WriteLine("Agregar un cliente");

            //Datos no relevantes reciven un string vacio como placeholder
            customer.CompanyName = Console.ReadLine();
            customer.CustomerID = customer.CompanyName;
            customer.ContactName = "";
            customer.ContactTitle = "";
            customer.Address = "";
            customer.City = "";
            customer.Region = "";
            customer.PostalCode = "";
            customer.Country = "";
            customer.Phone = "";
            customer.Fax = "";

            customerLogic.AddCustomer(customer);

        }
        public override void Remover()
        {
            CustomerLogic customerLogic = new CustomerLogic();

            Console.WriteLine("Ingrese el ID del cliente a Remover");
            var str = Console.ReadLine();

            customerLogic.RemoveCustomer(str);
        }
        public override void Modificar()
        {
            CustomerLogic customerLogic = new CustomerLogic();

            Console.WriteLine("Ingrese el ID del cliente a Modificar");
            var customer = customerLogic.BuscarCliente(Console.ReadLine());

            Console.WriteLine(customer);
        }
    }
}
