using Microsoft.AspNetCore.Mvc;
using MVC_Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Intro.Controllers
{
    public class MIS3033 : Controller
    {
        public IActionResult Index()
        {
            Student s = new Student()
            {
                FirstName = "Miach",
                LastName = "Tison"
            };

            return View();
        }
    }
}
