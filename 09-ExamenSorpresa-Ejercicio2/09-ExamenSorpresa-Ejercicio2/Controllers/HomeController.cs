using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09_ExamenSorpresa_Ejercicio2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(bool? esMiPrimeraVez)
        {
            if(esMiPrimeraVez == true){
                ViewBag.texto = "No es la primera vez que entras";
            }
            else
            {
                ViewBag.texto = "Es es la primera vez que entras";
            }
                
            
            return View();
        }
    }
}