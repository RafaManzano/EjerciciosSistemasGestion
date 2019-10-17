using _06_DatosAControlador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06_DatosAControlador.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Editar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Editar(clsPersona persona)
        {
            return View("PersonaModificada", persona);
        }
    }
}