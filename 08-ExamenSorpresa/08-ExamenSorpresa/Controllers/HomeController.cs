using _08_ExamenSorpresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08_ExamenSorpresa.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<clsDepartamento> departamentos = new List<clsDepartamento>();
            
            clsPersonaConListadoDepartamentos personaConDepartamento = new clsPersonaConListadoDepartamentos();
            personaConDepartamento.Persona = new clsPersona("Rafael", "Manzano", "Medina", DateTime.Now,4);
            personaConDepartamento.Departamentos = departamentos;
            return View(personaConDepartamento);
        }

        [HttpPost]
        public ActionResult Index(clsPersonaNombreDepartamento persona)
        {
           // persona.nombreDepartamento = dpto;
            return View("PersonaModificada", persona);
        }
    }
}