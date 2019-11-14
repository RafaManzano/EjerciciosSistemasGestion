using System;
using System.Collections.Generic;
using System.Data;
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
       

        // GET: clsPersonas
        public ActionResult Index()
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

        // GET: clsPersonas/Details/5
        public ActionResult Details(int id)
        {
            clsListadoPersonasBL capaBL = new clsListadoPersonasBL();
            clsPersona pers = new clsPersona();
            clsDepartamento dpto = new clsDepartamento();
            pers = capaBL.personaPorID(id);
            dpto = capaBL.departamentoPorID(pers.idDepartamento);

            clsPersonasConNombreDpto personaCompleta = new clsPersonasConNombreDpto();

            personaCompleta.nombre = pers.nombre;
            personaCompleta.apellidos = pers.apellidos;
            personaCompleta.telefono = pers.telefono;
            personaCompleta.fechaNacimiento = pers.fechaNacimiento;
            //personaCompleta.idPersona = pers.idPersona;
            personaCompleta.foto = pers.foto;
            personaCompleta.NombreDpto = dpto.nombre;

            return View(personaCompleta);
        }
        
        // GET: clsPersonas/Create
        public ActionResult Create()
        {
            clsListadoPersonasBL capaBL = new clsListadoPersonasBL();
            clsPersonaConListadoDpto personaListadoDpto = new clsPersonaConListadoDpto();
            personaListadoDpto.ListadoDepartamentos = capaBL.listadoDepartamentos();
            return View(personaListadoDpto);
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
                         clsListadoPersonasBL capaBL = new clsListadoPersonasBL();
                         capaBL.crearPersona(clsPersona);
                        //db.clsPersonas.Add(clsPersona);
                        //db.SaveChanges();
                        return RedirectToAction("Index");
                    }

                    return View(clsPersona);
                }
        /*
                       // GET: clsPersonas/Edit/5
                       public ActionResult Edit(int? id)
                       {
                           if (id == null)
                           {
                               return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                           }
                           //clsPersona clsPersona = db.clsPersonas.Find(id);
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
                               //db.Entry(clsPersona).State = EntityState.Modified;
                              // db.SaveChanges();
                               return RedirectToAction("Index");
                           }
                           return View(clsPersona);
                       }
       */
        // GET: clsPersonas/Delete/5
        public ActionResult Delete(int id)
                {
                    clsListadoPersonasBL capaBL = new clsListadoPersonasBL();
                    clsPersona pers = new clsPersona();
                    clsDepartamento dpto = new clsDepartamento();
                    pers = capaBL.personaPorID(id);
                    dpto = capaBL.departamentoPorID(pers.idDepartamento);

                    clsPersonasConNombreDpto personaCompleta = new clsPersonasConNombreDpto();

                    personaCompleta.nombre = pers.nombre;
                    personaCompleta.apellidos = pers.apellidos;
                    personaCompleta.telefono = pers.telefono;
                    personaCompleta.fechaNacimiento = pers.fechaNacimiento;
                    //personaCompleta.idPersona = pers.idPersona;
                    personaCompleta.foto = pers.foto;
                    personaCompleta.NombreDpto = dpto.nombre;

                    return View(personaCompleta);
        }

                // POST: clsPersonas/Delete/5
                [HttpPost, ActionName("Delete")]
                [ValidateAntiForgeryToken]
                public ActionResult DeleteConfirmed(int id)
                {
                    clsListadoPersonasBL capaBL = new clsListadoPersonasBL();
                    capaBL.borrarPersona(id);
                    return RedirectToAction("Index");
                }
/*
                protected override void Dispose(bool disposing)
                {
                    if (disposing)
                    {
                        //db.Dispose();
                    }
                    base.Dispose(disposing);
                }
                */
    }

}
