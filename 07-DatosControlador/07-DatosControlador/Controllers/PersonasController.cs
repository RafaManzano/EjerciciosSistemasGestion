using _07_DatosAControlador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_DatosControlador.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Editar()
        {
            clsPersona persona = new clsPersona("Rafael", "Manzano", "Medina", DateTime.Now);
            return View(persona);
        }

        [HttpPost]
        public ActionResult Editar(clsPersona persona)
        {
            return View("PersonaModificada", persona);
        }
    }
}