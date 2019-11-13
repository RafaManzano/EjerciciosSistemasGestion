using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _12_CRUD_Personas_BL.Lists;
using _12_CRUD_Personas_Entities;
using _12_CRUD_Personas_UI.Models;

namespace _12_CRUD_Personas_UI
{
    public class clsPersonasController : Controller
    {
        private _12_CRUD_Personas_UIContext db = new _12_CRUD_Personas_UIContext();

        // GET: clsPersonas
        public ActionResult Index()
        {
            clsListadoPersonasBL list = new clsListadoPersonasBL();
            return View(list.listadoPersonas());
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
        public ActionResult Create([Bind(Include = "idPersona,nombre,apellidos,fechaNacimiento,direccion,telefono,foto,idDepartamento")] clsPersona clsPersona)
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
        public ActionResult Edit([Bind(Include = "idPersona,nombre,apellidos,fechaNacimiento,direccion,telefono,foto,idDepartamento")] clsPersona clsPersona)
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
