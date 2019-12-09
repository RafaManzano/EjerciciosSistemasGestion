using _15_Futbolista_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15_Futbolista_UI.Controllers
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