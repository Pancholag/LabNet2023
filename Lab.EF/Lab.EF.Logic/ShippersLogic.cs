using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal class ShippersLogic : BaseLogic
    {
        public IEnumerable<Shipper> GetAll()
        {
            return _northWindContext.Shippers.ToList();
        }
    }
}
