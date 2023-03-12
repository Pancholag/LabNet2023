using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal class CategoriesLogic : BaseLogic
    {
        public IEnumerable<Categorie> GetAll()
        {
            return _northWindContext.Categories.ToList();
        }
    }
}
