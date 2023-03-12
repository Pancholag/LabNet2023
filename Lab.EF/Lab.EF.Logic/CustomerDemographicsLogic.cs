using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal class CustomerDemographicsLogic : BaseLogic
    {
        public IEnumerable<CustomerDemographic> GetAll()
        {
            return _northWindContext.CustomerDemographics.ToList();
        }
    }
}
