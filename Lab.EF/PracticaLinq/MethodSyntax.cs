using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLinq
{
    internal class MethodSyntax : BaseQuery, IQuerys
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
