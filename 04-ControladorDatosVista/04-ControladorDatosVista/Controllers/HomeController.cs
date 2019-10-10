using _04_ControladorDatosVista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_ControladorDatosVista.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if(DateTime.Now.Hour < 12)
            {
                ViewData["saludo"] = "Buenos Dias";
            }
            else if(DateTime.Now.Hour < 20)
            {
                ViewData["saludo"] = "Buenas tardes";
            }
            else
            {
                ViewData["saludo"] = "Buenas noches";
            }

            clsPersona oPersona = new clsPersona();
            oPersona.Nombre = "Rafael";
            oPersona.PrimerApellido = "Manzano";
            oPersona.SegundoApellido = "Medina";
            oPersona.FechaNacimiento = new DateTime(1995,06,23);

            ViewBag.dia = DateTime.Now.ToLocalTime().ToString();
            return View(oPersona);
        }
    }
}