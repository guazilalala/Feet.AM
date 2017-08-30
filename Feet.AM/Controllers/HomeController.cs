using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Feet.AM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //throw new Exception("异常");
            return View();
        }
    }
}