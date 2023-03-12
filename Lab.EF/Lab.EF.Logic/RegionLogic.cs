using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal class RegionLogic : BaseLogic
    {
        public IEnumerable<Region> GetAll()
        {
            return _northWindContext.Region.ToList();
        }
    }
}
