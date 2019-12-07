using _14_PersonajesLoL_BL.Handlers;
using _14_PersonajesLoL_BL.Lists;
using _14_PersonajesLoL_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _14_PersonajesLoL_UI.Controllers
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
        public ActionResult Index(clsViewModel vm, String boton)
        {
            clsViewModel viewModel = new clsViewModel();
            clsListadosPersonajesBL listPer = new clsListadosPersonajesBL();
            clsManejadoraBL manejadora = new clsManejadoraBL();
            if(boton.Equals("Elegir"))
            {
                viewModel.Personaje=  listPer.personajePorID(vm.Personaje.ID);
            }
            else
            {
                manejadora.actualizarPersonaje(vm.Personaje);
                viewModel = new clsViewModel();
                //ViewBag("Completado con exito");
            }

            return View(viewModel);

        }
    }
}