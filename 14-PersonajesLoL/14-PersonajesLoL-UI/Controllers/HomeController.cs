using _14_PersonajesLoL_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14_PersonajesLoL_UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            clsViewModel vm = new clsViewModel();
            return View(vm);
        }
    }
}