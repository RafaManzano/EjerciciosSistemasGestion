using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _14_CRUDPersonas_NETCORE_UI.Models;
using _14_CRUDPersonas_NETCORE_BL.Lists;
using _14_CRUDPersonas_NETCORE_Entities;

namespace _14_CRUDPersonas_NETCORE_UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<clsPersonasConNombreDpto> personasConDpto = new List<clsPersonasConNombreDpto>();
            clsListadoPersonasBL list = new clsListadoPersonasBL();
            List<clsPersona> listado = list.listadoPersonas();
            foreach (var item in listado)
            {
                clsPersonasConNombreDpto oPersona = new clsPersonasConNombreDpto();
                oPersona.nombre = item.nombre;
                oPersona.apellidos = item.apellidos;
                oPersona.telefono = item.telefono;
                oPersona.fechaNacimiento = item.fechaNacimiento;
                oPersona.idPersona = item.idPersona;
                oPersona.foto = item.foto;
                oPersona.NombreDpto = list.departamentoPorID(item.idDepartamento).nombre;
                personasConDpto.Add(oPersona);
            }
            return View(personasConDpto);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult HolaMundo()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
