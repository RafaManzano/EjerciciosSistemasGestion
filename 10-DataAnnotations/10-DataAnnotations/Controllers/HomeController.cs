using _10_DataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10_DataAnnotations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            clsPersona persona = new clsPersona("Rafael", "Manzano", "Medina", DateTime.Now, "Mi casa", "606201950", 1);
            return View(persona);
        }

        [HttpPost]
        public ActionResult Index(clsPersona persona)
        {
            if(ModelState.IsValid)
            {
                return View("PersonaModificada", persona);
            }
            else
            {
                return View(persona);
            }
            
        }
    }
}