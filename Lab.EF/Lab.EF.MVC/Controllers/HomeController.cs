﻿using Lab.EF.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public async Task<ActionResult> ApiTest()
        {
            if (TempData.ContainsKey("Message"))
            {
                ViewBag.Message = TempData["Message"];
                TempData["Message"] = ViewBag.Message;
            }

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/");
            string content = await response.Content.ReadAsStringAsync();
            List<DataModel> data = JsonConvert.DeserializeObject<List<DataModel>>(content);
            return View(data);
        }

        public async Task<ActionResult> Details(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/");
            string content = await response.Content.ReadAsStringAsync();
            DataModel data = JsonConvert.DeserializeObject<List<DataModel>>(content).FirstOrDefault(d => d.Id == id);
            return View(data);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Add(DataModel d)
        {
            string json =JsonConvert.SerializeObject(d);
            var client = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://jsonplaceholder.typicode.com/posts",content);

            if (response.IsSuccessStatusCode)
            {
                TempData["Message"] = "La operacion fue realizada con exito, aunque el modelo no fue agregado";
            }
            else
            {
                TempData["Message"] = "La operacion intentada fracaso";
            }

            return RedirectToAction("ApiTest");
        }

        [HttpGet]
        public async Task<ActionResult> Update(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/");
            string content = await response.Content.ReadAsStringAsync();
            DataModel data = JsonConvert.DeserializeObject<List<DataModel>>(content).FirstOrDefault(d => d.Id == id);
            return View(data);
        }

        [HttpPost]
        public async Task<ActionResult> Update(DataModel d)
        {
            string json = JsonConvert.SerializeObject(d);
            var client = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://jsonplaceholder.typicode.com/posts/" + d.Id, content);

            if (response.IsSuccessStatusCode)
            {
                TempData["Message"] = "La operacion fue realizada con exito, aunque el modelo no fue modificado";
            }
            else
            {
                TempData["Message"] = "La operacion intentada fracaso";
            }

            return RedirectToAction("ApiTest");
        }

        public async Task<ActionResult> Delete(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/");
            string content = await response.Content.ReadAsStringAsync();
            DataModel data = JsonConvert.DeserializeObject<List<DataModel>>(content).FirstOrDefault(d => d.Id == id);
            return View(data);
        }

        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var client = new HttpClient();
            var response = await client.DeleteAsync("https://jsonplaceholder.typicode.com/posts/" + id);

            if (response.IsSuccessStatusCode)
            {
                TempData["Message"] = "La operacion fue realizada con exito, aunque el modelo no fue eliminado";
            }
            else
            {
                TempData["Message"] = "La operacion intentada fracaso";
            }

            return RedirectToAction("ApiTest");
        }
    }
}