using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuLich.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Create()
        {
            return View();
        }
    }
}