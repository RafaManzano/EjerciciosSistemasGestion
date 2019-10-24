using _08_ExamenSorpresa.Models;
using _08_ExamenSorpresa.Utiles;
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
            clsPersonaConListadoDepartamentos persona = new clsPersonaConListadoDepartamentos();
            clsPersona p = new clsPersona("Rafael", "Manzano", "Medina", DateTime.Now, 4);
            clsListadoDepartamentos ld = new clsListadoDepartamentos();
            List<clsDepartamento> d = ld.listadoDepartamentos();

            persona.Nombre = p.Nombre;
            persona.PrimerApellido = p.PrimerApellido;
            persona.SegundoApellido = p.SegundoApellido;
            persona.FechaNacimiento = p.FechaNacimiento;
            persona.IdDepartamento = p.IdDepartamento;
            persona.Departamentos = d;

           
            return View(persona);
        }

        [HttpPost]
        public ActionResult Index(clsPersonaConListadoDepartamentos persona)
        {
            clsListadoDepartamentos ld = new clsListadoDepartamentos();
            clsPersonaNombreDepartamento personaNueva = new clsPersonaNombreDepartamento();
            personaNueva.Nombre = persona.Nombre;
            personaNueva.PrimerApellido = persona.PrimerApellido;
            personaNueva.SegundoApellido = persona.SegundoApellido;
            personaNueva.FechaNacimiento = persona.FechaNacimiento;
            personaNueva.nombreDepartamento = ld.buscarNombrePorID(persona.IdDepartamento);
           // persona.nombreDepartamento = dpto;
            return View("PersonaModificada", personaNueva);
        }
    }
}