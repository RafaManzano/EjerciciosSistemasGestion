using _12_CRUD_Personas_BL.Lists;
using _12_CRUD_Personas_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _12_CRUD_Personas_UI.Controllers.API
{
    public class PersonaController : ApiController
    {
        private clsListadoPersonasBL capaBL = new clsListadoPersonasBL();
        // GET: api/Persona
        public IEnumerable<clsPersona> Get()
        {
            return capaBL.listadoPersonas();
        }

        // GET: api/Persona/5
        public clsPersona Get(int id)
        {
            return capaBL.personaPorID(id);
        }

        // POST: api/Persona
        public void Post([FromBody]clsPersona value)
        {
            capaBL.crearPersona(value);
        }

        // PUT: api/Persona/5
        public void Put(int id, [FromBody]clsPersona value)
        {
            capaBL.actualizarPersona(value);
        }

        // DELETE: api/Persona/5
        public void Delete(int id)
        {
            capaBL.borrarPersona(id);
        }
    }
}
