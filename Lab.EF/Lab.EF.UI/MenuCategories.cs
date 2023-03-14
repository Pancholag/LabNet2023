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
        private IABMLogic<Category,int> _categoriesLogic = new CategoriesLogic();

        public override void VerTodos()
        {
            Console.WriteLine("** Mostrando categorias **");
            foreach (Category c in _categoriesLogic.GetAll())
            {
                Console.WriteLine($"Nombre: {c.CategoryName} ID: {c.CategoryID}");
            }
            Console.ReadKey();
        }
        public override void Agregar()
        {
            Category category = new Category();

            Console.WriteLine("Agregar una categoria");
            /*category.CategoryID = _categoriesLogic.GenerateId();*/
            category.CategoryName = Utilities.LeerTexto();
            _categoriesLogic.Add(category);
            Console.WriteLine($"Categoria {category.CategoryName} agregada con exito");
            Console.ReadKey();
        }
        public override void Remover()
        {
            Console.WriteLine("Ingrese el ID de la categoria a Remover");
            var category = _categoriesLogic.Remove(Utilities.LeerNumero());
            Console.WriteLine($"Categoria {category.CategoryName} ha sido removida con exito");
            Console.ReadKey();
        }
        public override void Modificar()
        {
            Console.WriteLine("Ingrese el ID de la categoria a Modificar");
            var category = Buscar();
            Console.WriteLine("Categoria a modificar:\n" + category);
            Console.WriteLine("Ingrese nuevo nombre de categoria o ingrese 0 para salir:");
            string str = Utilities.LeerTexto();
            if (str != "0")
            {
                category.CategoryName = str;
                _categoriesLogic.Update(category);
                Console.WriteLine($"Categoria {str} modificada con exito");
                Console.ReadKey();
            }
        }
        public override void VerDetalle()
        {
            Console.WriteLine("Ingrese el ID de la categoria a consultar:");
            var category = Buscar();
            Console.WriteLine(category);
            Console.ReadKey();
        }
        private Category Buscar()
        {
            var id = Utilities.LeerNumero();
            var category = _categoriesLogic.Find(id);
            return category;
        }
    }
}
