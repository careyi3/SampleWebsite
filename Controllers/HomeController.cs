using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Web;

namespace SampleWebsite.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {

        [Route("/")]
        [HttpGet]
        public IActionResult Index(string key)
        {
            return View();
        }

        [Route("/about")]
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [Route("/error")]
        [Route("/error/{status}")]
        [HttpGet]
        public IActionResult Error(string status)
        {
            return View();
        }
    }
}
