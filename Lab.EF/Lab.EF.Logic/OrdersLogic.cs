using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal class OrdersLogic : BaseLogic
    {
        public IEnumerable<Order> GetAll()
        {
            return _northWindContext.Orders.ToList();
        }
    }
}
