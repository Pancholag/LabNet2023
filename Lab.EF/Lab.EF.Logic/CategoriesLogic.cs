using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic , IABMLogic<Category, int>
    {
        public IEnumerable<Category> GetAll()
        {
            return _northWindContext.Categories.ToList();
        }
        public void Add(Category item)
        {
            _northWindContext.Categories.Add(item);
            _northWindContext.SaveChangesAsync();
        }
        public void Remove(int id)
        {
            Category c = Find(id);
            _northWindContext.Categories.Remove(c);
            _northWindContext.SaveChangesAsync();
        }
        public Category Find(int id)
        {
            return _northWindContext.Categories.FirstOrDefault(c => c.CategoryID == id);
        }
        public void Update(Category item)
        {
            var itemToUpdate = _northWindContext.Categories.FirstOrDefault(p => p.CategoryID == item.CategoryID);
            itemToUpdate.CategoryName = item.CategoryName;
            _northWindContext.SaveChanges();
        }
        public int GenerateId() 
        {
            int id = 0;

            foreach (var s in GetAll())
            {
                if (s.CategoryID >= id)
                    id = s.CategoryID + 1;
            }

            return id;
        }
    }
}
