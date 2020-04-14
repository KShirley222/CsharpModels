using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("Users")]

        public IActionResult Index()
        {

            User Kyle = new User(){Name = "Kyle"};
            User Steve = new User(){Name = "Steve"};
            User Smith = new User(){Name = "Smith"};
            User Quin = new User(){Name = "Quinn"};

            List<User> u = new List<User>(){Kyle, Steve, Smith, Quin};
            return View("Users", u);
        }
        [HttpGet("User")]

        public IActionResult User()
        {

            User Kyle = new User(){Name = "Kyle"};
    
            return View("User", Kyle);
        }


        [HttpGet]
        [Route("")]
        public IActionResult Message()
        {
            string msg = "lorem djnfdasnfjhnasdfdnfn;sad";
            return View("Index", msg);
        }

        [HttpGet]
        [Route("Numbers")]
        public IActionResult Numbers()
        {
            int[] nums = {1,2,3,4,56,546,365,352,532,352};
            return View("Numbers", nums);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
