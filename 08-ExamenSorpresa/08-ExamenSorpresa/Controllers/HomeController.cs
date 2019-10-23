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
            departamentos.Add(new clsDepartamento(1, "INFORMATICA"));
            departamentos.Add(new clsDepartamento(2, "FINANZAS"));
            departamentos.Add(new clsDepartamento(3, "CONTABILIDAD"));
            departamentos.Add(new clsDepartamento(4, "VENTAS"));

            clsPersonaConListadoDepartamentos personaConDepartamento = new clsPersonaConListadoDepartamentos();
            personaConDepartamento.Persona = new clsPersona("Rafael", "Manzano", "Medina", DateTime.Now);
            personaConDepartamento.Departamentos = departamentos;
            return View(personaConDepartamento);
        }

        [HttpPost]
        public ActionResult Index(clsPersonaNombreDepartamento persona, string dpto)
        {
            persona.nombreDepartamento = dpto;
            return View("PersonaModificada", persona);
        }
    }
}