using _05_ControladorDatosVista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_ControladorDatosVista.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listado()
        {
                List<clsPersona> list = new List<clsPersona>
            {
                new clsPersona("Rafa", "Manzano", "Medina", DateTime.Now),
                new clsPersona("Ivan", "Moreno", "Romero", DateTime.Now),
                new clsPersona("Pablo", "Prats", "Jimenez", DateTime.Now),
                new clsPersona("Victor Manuel", "Perez", "Lobato", DateTime.Now),
                new clsPersona("Yeray Manuel", "Campanario", "Fernandez", DateTime.Now),
                new clsPersona("Daniel", "Gordillo", "Rodriguez", DateTime.Now)
            };
                return View(list);
            
        }
    }
}