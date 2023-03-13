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
        private CategoriesLogic categoriesLogic;

        public MenuCategories()
        {
            categoriesLogic = new CategoriesLogic();
        }

        public override void Ver()
        {
            foreach (Category c in categoriesLogic.GetAll())
            {
                Console.WriteLine(c.CategoryName);
            }
        }
        public override void Agregar()
        {
            Category category = new Category();
            Console.WriteLine("Agregar una categoria");

            var aux = categoriesLogic.GenerateId();
            category.CategoryID = aux;
            category.CategoryName = Console.ReadLine();

            categoriesLogic.Add(category);

        }
        public override void Remover()
        {
            Console.WriteLine("Ingrese el ID de la categoria a Remover");
            var str = int.Parse(Console.ReadLine());

            categoriesLogic.Remove(str);
        }
        public override void Modificar()
        {
            Console.WriteLine("Ingrese el ID de la categoria a Modificar");
            var category = categoriesLogic.Find(int.Parse(Console.ReadLine()));

            Console.WriteLine(category);
        }
    }
}
