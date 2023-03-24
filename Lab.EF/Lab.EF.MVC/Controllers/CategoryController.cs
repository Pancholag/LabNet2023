using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class CategoryController : Controller
    {
        readonly CategoriesLogic categoriesLogic = new CategoriesLogic();
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                List<CategoriesViewModel> ret = categoriesLogic.GetAll().Select(p => new CategoriesViewModel
                {
                    CategoryID = p.CategoryID,
                    CategoryName = p.CategoryName,
                    Description = p.Description
                }).ToList();

                return View(ret);
            }
            catch (Exception e)
            {
                return RedirectToAction("Index","Error",new { e.Message });
            }
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoriesViewModel categoriesViewModel)
        {
            try
            {
                Category category = new Category
                { 
                    CategoryName = categoriesViewModel.CategoryName,
                    Description= categoriesViewModel.Description
                };

                categoriesLogic.Add(category);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { e.Message });
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                Category c = categoriesLogic.Find(id);

                CategoriesViewModel ret = new CategoriesViewModel
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    Description = c.Description
                };

                return View(ret);
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { e.Message });
            }
        }
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                categoriesLogic.Remove(id);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { e.Message });
            }
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            try
            {
                Category c = categoriesLogic.Find(id);

                CategoriesViewModel ret = new CategoriesViewModel
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    Description = c.Description
                };

                return View(ret);
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { e.Message });
            }
        }

        [HttpPost]
        public ActionResult Update(CategoriesViewModel categoriesViewModel)
        {
            try
            {
                Category category = new Category
                {
                    CategoryName = categoriesViewModel.CategoryName,
                    CategoryID = categoriesViewModel.CategoryID,
                    Description = categoriesViewModel.Description
                };

                categoriesLogic.Update(category);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { e.Message });
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            try
            {
                Category c = categoriesLogic.Find(id);

                CategoriesViewModel ret = new CategoriesViewModel
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    Description = c.Description
                };

                return View(ret);
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Error", new { e.Message });
            }
        }
    }
}