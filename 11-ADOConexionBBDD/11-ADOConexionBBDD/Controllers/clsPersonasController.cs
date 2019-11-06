using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _11_ADOConexionBBDD.Models;

namespace _11_ADOConexionBBDD.Controllers
{
    public class clsPersonasController : Controller
    {
        private _11_ADOConexionBBDDContext db = new _11_ADOConexionBBDDContext();

        // GET: clsPersonas
        public ActionResult Index()
        {
            SqlConnection miConexion = new SqlConnection();
            List<clsPersona> listadoPersonas = new List<clsPersona>();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsPersona oPersona;
            miConexion.ConnectionString = "server=rafamanzano.database.windows.net;database=Personas;uid=rmanzano;pwd=MiTesoro.;";
            try
            {
                miConexion.Open();
                //Creamos el comando (Creamos el comando, le pasamos la sentencia y la conexion, y lo ejecutamos)
                miComando.CommandText = "SELECT * FROM dbo.PD_Personas";
                miComando.Connection = miConexion;
                miLector = miComando.ExecuteReader();
                //miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona = new clsPersona();
                        oPersona.IDPersona = (int)miLector["IdPersona"];
                        oPersona.NombrePersona = (string)miLector["NombrePersona"];
                        oPersona.ApellidosPersona = (string)miLector["ApellidosPersona"];
                        //oPersona.FechaNacimiento = (DateTime)miLector["FechaNacimientoPersona"];
                        oPersona.IDDepartamento = (int)miLector["IDDepartamento"];
                        listadoPersonas.Add(oPersona);
                    }
                }
                miLector.Close();
                miConexion.Close();
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return View("Index", listadoPersonas);
        }

        // GET: clsPersonas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clsPersona clsPersona = db.clsPersonas.Find(id);
            if (clsPersona == null)
            {
                return HttpNotFound();
            }
            return View(clsPersona);
        }

        // GET: clsPersonas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: clsPersonas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDPersona,NombrePersona,ApellidosPersona,FechaNacimiento,IDDepartamento")] clsPersona clsPersona)
        {
            if (ModelState.IsValid)
            {
                db.clsPersonas.Add(clsPersona);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clsPersona);
        }

        // GET: clsPersonas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clsPersona clsPersona = db.clsPersonas.Find(id);
            if (clsPersona == null)
            {
                return HttpNotFound();
            }
            return View(clsPersona);
        }

        // POST: clsPersonas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDPersona,NombrePersona,ApellidosPersona,FechaNacimiento,IDDepartamento")] clsPersona clsPersona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clsPersona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clsPersona);
        }

        // GET: clsPersonas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clsPersona clsPersona = db.clsPersonas.Find(id);
            if (clsPersona == null)
            {
                return HttpNotFound();
            }
            return View(clsPersona);
        }

        // POST: clsPersonas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            clsPersona clsPersona = db.clsPersonas.Find(id);
            db.clsPersonas.Remove(clsPersona);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
