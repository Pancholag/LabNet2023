using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal class Order_DetaislLogic : BaseLogic
    {
        public IEnumerable<Order_Details> GetAll()
        {
            return _northWindContext.Order_Details.ToList();
        }
    }
}
