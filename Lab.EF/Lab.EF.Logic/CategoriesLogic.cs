using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic , IAbmLogic<Category, int>
    {
        public CategoriesLogic() { }
        public CategoriesLogic(NorthwindContext context)
        {
            _northWindContext = context;
        }

        public IEnumerable<Category> GetAll()
        {
            List<Category> list = _northWindContext.Categories.ToList();
            if (list.Count == 0)
                throw new ArgumentException("No hay categorias en la base de datos");
            return list;
        }

        public void Add(Category item)
        {
            if (_northWindContext.Categories
                .FirstOrDefault(c => c.CategoryName == item.CategoryName) != null)
                throw new ArgumentException("Categoria ya registrada");
            if (item.CategoryName.Length > 15)
            {
                throw new ArgumentException("Nombre mayor a 15 caracteres");
            }
            _northWindContext.Categories.Add(item);
            _northWindContext.SaveChangesAsync();
        }

        public Category Remove(int id)
        {
            Category c = Find(id);
            _northWindContext.Categories.Remove(c);
            _northWindContext.SaveChangesAsync();
            return c;
        }

        public Category Find(int id)
        {
            var category = _northWindContext.Categories.FirstOrDefault(c => c.CategoryID == id);
            if (category == null)
                throw new ArgumentException($"Categoria con el id {id} no encontrada");
            return category;
        }

        public void Update(Category item)
        {
            var itemToUpdate = Find(item.CategoryID);
            if (item.CategoryName.Length > 15)
            {
                throw new ArgumentException("Nombre mayor a 15 caracteres");
            }

            itemToUpdate.CategoryName = item.CategoryName;
            itemToUpdate.Description = item.Description;
            _northWindContext.SaveChanges();
        }
    }
}
