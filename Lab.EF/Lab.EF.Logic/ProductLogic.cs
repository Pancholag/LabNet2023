using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ProductLogic : BaseLogic
    {
        public IEnumerable<Product> GetAll()
        {
            return _northWindContext.Products.ToList();
        }
    }
}
