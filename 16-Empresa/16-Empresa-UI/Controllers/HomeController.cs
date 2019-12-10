using _16_Empresa_BL.Handlers;
using _16_Empresa_BL.Lists;
using _16_Empresa_ENTITIES;
using _16_Empresa_UI.Models;
using _16_Empresa_UI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_Empresa_UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            clsViewModel vm = new clsViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(clsViewModel viewModel)
        {
            clsListadoPersonasBL list = new clsListadoPersonasBL();
            clsManejadoraBL man = new clsManejadoraBL();
            clsViewModel vm = new clsViewModel();
            List<clsPersona> listPersonas = list.listadoPersonasPorDepartamento(viewModel.IDDepartamento);
            List<clsPersonaConNombreDptoYNombrePuesto> listado = new List<clsPersonaConNombreDptoYNombrePuesto>(); 

            foreach (clsPersona item in listPersonas)
            {
                clsPersonaConNombreDptoYNombrePuesto p = new clsPersonaConNombreDptoYNombrePuesto();
                p.DNI = item.DNI;
                p.Nombre = item.Nombre;
                p.Apellidos = item.Apellidos;
                p.NombrePuesto = man.NombrePuestoPorID(item.IDPuestoTrabajo);
                p.NombreDpto = man.NombreDptoPorID(item.IDDepartamento);
                listado.Add(p);
            }

            vm.PersonasConDptoYPuesto = listado;
            return View(vm);
        }

        public ActionResult Editar(string dni)
        {
            clsViewModel vm = new clsViewModel();
            clsListadoPersonasBL pList = new clsListadoPersonasBL();
            clsPersona persona = pList.personaPorID(dni);
            clsManejadoraBL man = new clsManejadoraBL();
            clsPersonaConNombreDptoYNombrePuesto personaFull = new clsPersonaConNombreDptoYNombrePuesto();
            clsListadoPuestosBL plist = new clsListadoPuestosBL();

            personaFull.DNI = persona.DNI;
            personaFull.Nombre = persona.Nombre;
            personaFull.Apellidos = persona.Apellidos;
            personaFull.NombrePuesto = man.NombrePuestoPorID(persona.IDPuestoTrabajo);
            personaFull.NombreDpto = man.NombreDptoPorID(persona.IDDepartamento);
            personaFull.IDPuestoTrabajo = persona.IDPuestoTrabajo;
            personaFull.IDDepartamento = persona.IDDepartamento;
            vm.PersonaConDptoYPuesto = personaFull;
            vm.Puestos = plist.listadoPuesto();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Editar(clsViewModel vm)
        {
            clsPersona persona = new clsPersona();
            //clsViewModel vm = new clsViewModel();
            //clsListadoPersonasBL pList = new clsListadoPersonasBL();
            //clsPersona persona = pList.personaPorID(dni);
            clsManejadoraBL man = new clsManejadoraBL();
            //clsPersonaConNombreDptoYNombrePuesto personaFull = new clsPersonaConNombreDptoYNombrePuesto();
            //clsListadoPuestosBL plist = new clsListadoPuestosBL();

            persona.DNI = vm.PersonaConDptoYPuesto.DNI;
            persona.Nombre = vm.PersonaConDptoYPuesto.Nombre;
            persona.Apellidos = vm.PersonaConDptoYPuesto.Apellidos;
            persona.IDDepartamento = vm.PersonaConDptoYPuesto.IDDepartamento;
            persona.IDPuestoTrabajo = vm.PersonaConDptoYPuesto.IDPuestoTrabajo;
            man.actualizarPersona(persona);

            //personaFull.NombrePuesto = man.NombrePuestoPorID(persona.IDPuestoTrabajo);
            //personaFull.NombreDpto = man.NombreDptoPorID(persona.IDDepartamento);
            return RedirectToAction("Index");

        }
    }
}