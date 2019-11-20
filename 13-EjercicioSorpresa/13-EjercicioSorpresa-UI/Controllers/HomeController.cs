using _13_EjercicioSorpresa_BL.Lists;
using _13_EjercicioSorpresa_Entities;
using _13_EjercicioSorpresa_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _13_EjercicioSorpresa_UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            clsListadosDepartamentosBL capaBL = new clsListadosDepartamentosBL();
            clsListadoDepartamentosListadosPersonas list = new clsListadoDepartamentosListadosPersonas();
            list.Dptos = capaBL.listadoDepartamentos();
            list.Personas = new List<clsPersona>();
            return View(list);
        }

        [HttpPost]
        public ActionResult Index(string btnSeleccionar, string btnDetalles, clsListadoDepartamentosListadosPersonas list)
        {
            clsListadoDepartamentosListadosPersonas listado = new clsListadoDepartamentosListadosPersonas();
            clsListadosPersonaBL capaBL = new clsListadosPersonaBL();
            clsListadosDepartamentosBL capaBLDpto = new clsListadosDepartamentosBL();
            if (btnSeleccionar != null)
            {
                listado.Dptos = capaBLDpto.listadoDepartamentos();
                listado.Personas = capaBL.personasPorIDDepartamento(list.DepartamentoSeleccionado.ID);
                return View(listado);
            }
            else
            {
                listado.Dptos = capaBLDpto.listadoDepartamentos();
                listado.Personas = capaBL.personasPorIDDepartamento(list.DepartamentoSeleccionado.ID);
                listado.PersonaSeleccionada = capaBL.personaPorID(list.PersonaSeleccionada.IDPersona);
                //Detalles
                return View(listado);
            }
        }
    }
}