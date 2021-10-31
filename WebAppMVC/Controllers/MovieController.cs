using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers

{
    public class MovieController : Controller
    {
       
        Uri baseAddress = new("https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/soon/ ");
        HttpClient  client;
       
        public MovieController()
             
        {
            client = new HttpClient();
            client.BaseAddress = BaseAddress();
        }

        private Uri BaseAddress()
        {
            throw new NotImplementedException();
        }

        public IActionResult Index()
           
        {

            List<Model> modelList = new List<Model>();

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/movie").Result;
           
            if (response.IsSuccessStatusCode)
                {
                string data = response.Content.ReadAsStringAsync().Result;

                modelList = JsonConvert.DeserializeObject < List < Model >>(data);
            }

            
            return View();
        }
    }
}
