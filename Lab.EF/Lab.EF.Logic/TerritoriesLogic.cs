using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal class TerritoriesLogic : BaseLogic
    {
        public IEnumerable<Territory> GetAll()
        {
            return _northWindContext.Territories.ToList();
        }
    }
}
