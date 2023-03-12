using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal class SuppliersLogic : BaseLogic
    {
        public IEnumerable<Supplier> GetAll()
        {
            return _northWindContext.Suppliers.ToList();
        }
    }
}
