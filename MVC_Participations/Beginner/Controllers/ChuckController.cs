using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Beginner.Controllers
{
    public class ChuckController : Controller
    {
        // GET: Chuck
        public ActionResult Index()
        {
            return View();
        }
    }
}