using _17_Examen11DIC_BL.Handlers;
using _17_Examen11DIC_ENTITIES;
using _17_Examen11DIC_UI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17_Examen11DIC_UI.Controllers
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
            clsViewModel vm = new clsViewModel();
            clsManejadoraBL manejadora = new clsManejadoraBL();
            clsMisiones m = new clsMisiones();
            for(int i = 0; i < viewModel.IDSMisionesElegidas.Count; i++)
            {
                m.IDMision = viewModel.IDSMisionesElegidas[i];
                m.Reservada = 1;
                m.IDSuperheroe = viewModel.IDSuperheroeSeleccionado;

                manejadora.actualizarMision(m);
            }
            
            
            return RedirectToAction("Index");
        }
    }
}