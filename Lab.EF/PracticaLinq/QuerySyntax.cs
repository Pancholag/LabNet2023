using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLinq
{
    internal class QuerySyntax : BaseQuery, IQuerys
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

        public void Ejercicio4()
        {
            throw new NotImplementedException();
        }

        public void Ejercicio5()
        {
            throw new NotImplementedException();
        }

        public void Ejercicio6()
        {
            throw new NotImplementedException();
        }

        public void Ejercicio7()
        {
            throw new NotImplementedException();
        }

        public void Ejercicio8()
        {
            throw new NotImplementedException();
        }

        public void Ejercicio9()
        {
            throw new NotImplementedException();
        }
        public void Ejercicio10()
        {
            throw new NotImplementedException();
        }

        public void Ejercicio11()
        {
            throw new NotImplementedException();
        }

        public void Ejercicio12()
        {
            throw new NotImplementedException();
        }

        public void Ejercicio13()
        {
            throw new NotImplementedException();
        }
    }
}
