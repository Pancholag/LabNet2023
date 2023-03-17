using Lab.EF.Entities;
using Lab.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LINQ.Logic
{
    public class QuerySyntax : BaseQuery, IQuerys
    {
        public Customer Ejercicio1()
        {
            return (from customer in northwindContext.Customers
                    select customer).First();
        }

        public IEnumerable<Product> Ejercicio2()
        {
            return (from product in northwindContext.Products
                    where product.UnitsInStock == 0
                    select product);
        }

        public IEnumerable<Product> Ejercicio3()
        {
            return (from product in northwindContext.Products
                    where product.UnitsInStock > 0 && product.UnitPrice > 3
                    select product);
        }

        public IEnumerable<Customer> Ejercicio4()
        {
            return (from c in northwindContext.Customers
                    where c.Region == "WA"
                    select c);
        }

        public Product Ejercicio5()
        {
            return (from p in northwindContext.Products
                    where p.ProductID == 789
                    select p).FirstOrDefault();
        }

        public IEnumerable<string> Ejercicio6()
        {
            return (from c in northwindContext.Customers
                    select c.CompanyName);
        }

        public IEnumerable<CustomerOrderDTO> Ejercicio7()
        {            
            return (from c in northwindContext.Customers
                    join o in northwindContext.Orders on c.CustomerID equals o.CustomerID
                    where c.Region == "WA" && o.OrderDate > new DateTime(1997,1,1)
                    orderby c.CompanyName
                    select new CustomerOrderDTO 
                    {
                        CustomerCompanyName = c.CompanyName,
                        CustomerRegionName = c.Region,
                        OrderID = o.OrderID,
                        OrderDate = o.OrderDate,
                    });
        }

        public IEnumerable<Customer> Ejercicio8()
        {
            return (from c in northwindContext.Customers
                    where c.Region == "WA"
                    select c).Take(3);
        }

        public IEnumerable<Product> Ejercicio9()
        {
            return (from p in northwindContext.Products
                    orderby p.ProductName
                    select p);
        }
        public IEnumerable<Product> Ejercicio10()
        {
            return (from p in northwindContext.Products
                    orderby p.UnitsInStock descending
                    select p);
        }

        public IEnumerable<Category> Ejercicio11()
        {
            return (from c in northwindContext.Categories
                    where c.Products.Any()
                    select c);
        }

        public Product Ejercicio12()
        {
            return (from p in northwindContext.Products
                    select p).First();
        }

        public IEnumerable<CustomerDTO> Ejercicio13()
        {
            return (from c in northwindContext.Customers
                    select new CustomerDTO 
                        {
                        ContactName = c.ContactName,
                        CantOrdenes = c.Orders.Count,
                        });
        }
    }
}
