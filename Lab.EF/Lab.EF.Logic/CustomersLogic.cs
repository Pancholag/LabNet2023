using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CustomerLogic : BaseLogic
    {
        public IEnumerable<Customer> GetAll()
        {
            return _northWindContext.Customers.ToList();
        }

        public void AddCustomer(Customer customer) 
        {
            _northWindContext.Customers.Add(customer);
            _northWindContext.SaveChangesAsync();
        }

        public void RemoveCustomer(String customerId)
        {
            Customer c = _northWindContext.Customers.Find(customerId);
            _northWindContext.Customers.Remove(c);
            _northWindContext.SaveChangesAsync();
        }
    }
}
