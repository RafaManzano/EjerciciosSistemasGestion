using _15_FutbolistaNuevo_BL.Handlers;
using _15_FutbolistaNuevo_BL.Lists;
using _15_FutbolistaNuevo_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _15_FutbolistaNuevo_UI.Controllers
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
        public ActionResult Index(int idEquipo)
        {
            clsListadoFutbolistaBL list = new clsListadoFutbolistaBL();
            clsViewModel vm = new clsViewModel();
            vm.Jugadores = list.listadoJugadoresPorEquipo(idEquipo);
            return View(vm);
        }

        
        public ActionResult Editar(int id)
        {
            clsViewModel vm = new clsViewModel();
            clsListadoFutbolistaBL list = new clsListadoFutbolistaBL();
            vm.JugadorSeleecionado = list.jugadorPorID(id);
            return View(vm);
        }

        [HttpPost]
        public ActionResult Editar(clsViewModel viewModel)
        {
            clsViewModel vm = new clsViewModel();
            clsManejadoraBL manejadora = new clsManejadoraBL();
            manejadora.actualizarJugador(viewModel.JugadorSeleecionado);
            return RedirectToAction("Index");
        }

        public ActionResult Liberar(int id)
        {
            clsViewModel vm = new clsViewModel();
            clsManejadoraBL manejadora = new clsManejadoraBL();
            int i = manejadora.borrarJugador(id);
            return RedirectToAction("Index");
        }

        public ActionResult Transferir(int id)
        {
            clsViewModel vm = new clsViewModel();
            clsListadoFutbolistaBL list = new clsListadoFutbolistaBL();
            vm.JugadorSeleecionado = list.jugadorPorID(id);
            return View(vm);
        }

        [HttpPost]
        public ActionResult Transferir(clsViewModel vm)
        {
            //clsViewModel vm = new clsViewModel();
            clsManejadoraBL manejadora = new clsManejadoraBL();
            manejadora.insertarJugador(vm.JugadorSeleecionado);
            manejadora.borrarJugador(vm.JugadorSeleecionado.ID);
            return RedirectToAction("Index");
        }
    }
}