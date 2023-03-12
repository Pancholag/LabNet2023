using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal class EmployeesLogic : BaseLogic
    {
        public IEnumerable<Employee> GetAll()
        {
            return _northWindContext.Employees.ToList();
        }
    }
}
