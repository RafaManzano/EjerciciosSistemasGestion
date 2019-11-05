using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace _11_ADOConexionBBDD.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection conn = new SqlConnection();

       
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Index")]
        public ActionResult Garbancito()
        {
            try
            {
                conn.ConnectionString = "server=rafamanzano.database.windows.net;database=Personas;uid=rmanzano;pwd=MiTesoro.;";
                conn.Open();
                ViewBag.Error = conn.State;
            }
            catch
            {
                ViewBag.Error = conn.State;
            }

            return View("Index", ViewBag.Error);
        }
    }
}