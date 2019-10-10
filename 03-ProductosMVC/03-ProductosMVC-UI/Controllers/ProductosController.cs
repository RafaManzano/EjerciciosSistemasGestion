using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_ProductosMVC_UI.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listadoProductos()
        {
            return View();
        }
    }
}