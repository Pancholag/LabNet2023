using Lab.EF.Entities;
using Lab.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LINQ.Logic
{
    public class MethodSyntax : BaseQuery, IQuerys
    {
        public Customer Ejercicio1()
        {
            return northwindContext.Customers.FirstOrDefault();
        }

        public IEnumerable<Product> Ejercicio2()
        {
            return northwindContext.Products.Where(p => p.UnitsInStock == 0);
        }

        public IEnumerable<Product> Ejercicio3()
        {
            return northwindContext.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
        }

        public IEnumerable<Customer> Ejercicio4()
        {
            return northwindContext.Customers.Where(c => c.Region == "WA");
        }

        public Product Ejercicio5()
        {
            return northwindContext.Products.FirstOrDefault(p => p.ProductID == 789);
        }

        public IEnumerable<string> Ejercicio6()
        {
            return northwindContext.Customers.Select(c => c.CompanyName);
        }

        public IEnumerable<CustomerOrderDTO> Ejercicio7()
        {
            return northwindContext.Customers.Join(northwindContext.Orders,
                c => c.CustomerID,
                o => o.CustomerID,
                (c, o) => new CustomerOrderDTO 
                {
                    CustomerCompanyName = c.CompanyName,
                    CustomerRegionName = c.Region,
                    OrderID = o.OrderID,
                    OrderDate = o.OrderDate
                }).Where(d => d.CustomerRegionName == "WA" && d.OrderDate > new DateTime(1997,1,1))
                .OrderBy(d => d.CustomerCompanyName);
        }

        public IEnumerable<Customer> Ejercicio8()
        {
            return northwindContext.Customers.Where(c => c.Region == "WA").Take(3);
        }

        public IEnumerable<Product> Ejercicio9()
        {
            return northwindContext.Products.OrderBy(p => p.ProductName);
        }

        public IEnumerable<Product> Ejercicio10()
        {
            return northwindContext.Products.OrderByDescending(p => p.UnitsInStock);
        }

        public IEnumerable<Category> Ejercicio11()
        {
            return northwindContext.Categories.Where(c => c.Products.Any());
        }

        public Product Ejercicio12()
        {
            return northwindContext.Products.First();
        }

        public IEnumerable<CustomerDTO> Ejercicio13()
        {
            return northwindContext.Customers.Select(c => new CustomerDTO 
                {
                    ContactName = c.ContactName,
                    CantOrdenes = c.Orders.Count,
                });
        }
    }
}
