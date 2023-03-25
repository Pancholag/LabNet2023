using Lab.EF.MVC.Models;
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

        public ActionResult Add()
        {
            return View();
        }

        public async Task<ActionResult> Add(DataModel d)
        {
            string json =JsonConvert.SerializeObject(d);
            var client = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://jsonplaceholder.typicode.com/posts",content);

            
            return RedirectToAction("ApiTest");
        }

        public async Task<ActionResult> Update(int id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/");
            string content = await response.Content.ReadAsStringAsync();
            DataModel data = JsonConvert.DeserializeObject<List<DataModel>>(content).FirstOrDefault(d => d.Id == id);
            return View(data);
        }

        public async Task<ActionResult> Update(DataModel d)
        {
            string json = JsonConvert.SerializeObject(d);
            var client = new HttpClient();
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://jsonplaceholder.typicode.com/posts", content);

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

            return RedirectToAction("ApiTest");
            
        }
    }
}