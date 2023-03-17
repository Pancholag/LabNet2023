using Lab.EF.Entities;
using Lab.LINQ.Data;
using Lab.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LINQ.Logic
{
    public interface IQuerys
    {
        Customer Ejercicio1();
        IEnumerable<Product> Ejercicio2();
        IEnumerable<Product> Ejercicio3();
        IEnumerable<Customer> Ejercicio4();
        Product Ejercicio5();
        IEnumerable<string> Ejercicio6();
        IEnumerable<CustomerOrderDTO> Ejercicio7();
        IEnumerable<Customer> Ejercicio8();
        IEnumerable<Product> Ejercicio9();
        IEnumerable<Product> Ejercicio10();
        IEnumerable<Category> Ejercicio11();
        Product Ejercicio12();
        IEnumerable<CustomerDTO> Ejercicio13();

    }
}
