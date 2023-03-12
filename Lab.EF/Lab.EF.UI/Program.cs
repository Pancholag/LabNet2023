using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*VerClientes();
            Console.WriteLine();
            AgregarCliente();

            Console.ReadKey();
            Console.WriteLine();
            VerClientes();*/
            
            RemoverCliente();

            Console.WriteLine();
            Console.ReadKey();

            VerClientes();

            Console.ReadKey();
        }

        public static void VerClientes()
        {
            CustomerLogic customersLogic = new CustomerLogic();

            foreach (Customer c in customersLogic.GetAll())
            {
                Console.WriteLine(c.CompanyName);
            }
        }

        public static void AgregarCliente() 
        {
            CustomerLogic customersLogic = new CustomerLogic();
            Customer customers = new Customer();

            Console.WriteLine("Agregar un cliente");

            //Datos no relevantes reciven un string vacio como placeholder
            customers.CompanyName = Console.ReadLine();
            customers.CustomerID = customers.CompanyName;
            customers.ContactName = "";
            customers.ContactTitle = "";
            customers.Address = "";
            customers.City = "";
            customers.Region = "";
            customers.PostalCode = "";
            customers.Country = "";
            customers.Phone = "";
            customers.Fax = "";

            customersLogic.AddCustomer(customers);
            
        }

        public static void RemoverCliente()
        {
            Console.WriteLine("Ingrese el nombre del cliente a Remover");
            var str = Console.ReadLine();
            CustomerLogic customersLogic = new CustomerLogic();
            customersLogic.RemoveCustomer(str);
        }
    }
}
