using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVC.Views
{
    public class Index : Controller
    {
        public IActionResult Index2()
        {
            return View();
        }
    }
}
