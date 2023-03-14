using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    internal class MenuCategories : MenuEntidadBase
    {
        private CategoriesLogic _categoriesLogic = new CategoriesLogic();

        public override void VerTodos()
        {
            foreach (Category c in _categoriesLogic.GetAll())
            {
                Console.WriteLine($"Nombre: {c.CategoryName} ID: {c.CategoryID}");
            }
        }
        public override void Agregar()
        {
            Category category = new Category();

            Console.WriteLine("Agregar una categoria");
            category.CategoryID = _categoriesLogic.GenerateId();
            category.CategoryName = Utilities.LeerTexto();

            _categoriesLogic.Add(category);
        }
        public override void Remover()
        {
            Console.WriteLine("Ingrese el ID de la categoria a Remover");
            var str = int.Parse(Console.ReadLine());

            _categoriesLogic.Remove(str);
        }
        public override void Modificar()
        {
            Console.WriteLine("Ingrese el ID de la categoria a Modificar");
            var category = _categoriesLogic.Find(Utilities.LeerNumero(int.MaxValue));

            Console.WriteLine(category);
        }
        public override void VerDetalle()
        {
            throw new NotImplementedException();
        }
    }
}
