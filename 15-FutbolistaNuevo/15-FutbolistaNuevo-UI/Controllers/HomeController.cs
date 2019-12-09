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
        public ActionResult Index(int idEquipo, string boton)
        {
            clsListadoFutbolistaBL list = new clsListadoFutbolistaBL();
            clsViewModel vm = new clsViewModel();
            vm.Jugadores = list.listadoJugadoresPorEquipo(idEquipo);
            return View(vm);
        }
    }
}