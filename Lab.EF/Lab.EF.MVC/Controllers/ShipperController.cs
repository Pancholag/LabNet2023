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
    public class ShipperController : Controller
    {
        readonly ShippersLogic shippersLogic = new ShippersLogic();
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                List<ShipperViewModel> ret = shippersLogic.GetAll().Select(p => new ShipperViewModel
                {
                    ShipperId = p.ShipperID,
                    CompanyName = p.CompanyName
                }).ToList();

                return View(ret);
            }
            catch (Exception e) 
            {
                ViewBag.ErrorMessage = e.Message;
                return RedirectToAction("Error");
            }
        }

        [HttpGet]
        public ActionResult Insert() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShipperViewModel shipperViewModel) 
        {
            try
            {
                Shipper shipper = new Shipper { CompanyName = shipperViewModel.CompanyName };

                shippersLogic.Add(shipper);

                return RedirectToAction("Index");
            } catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                return RedirectToAction("Error");
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                Shipper s = shippersLogic.Find(id);

                ShipperViewModel ret = new ShipperViewModel
                {
                    ShipperId = s.ShipperID,
                    CompanyName = s.CompanyName
                };

                return View(ret);
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                return RedirectToAction("Error");
            }
        }
        [HttpGet]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                shippersLogic.Remove(id);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                return RedirectToAction("Error");
            }
        }
    }
}