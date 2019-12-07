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
        public HttpResponseMessage Post([FromBody]clsPersona value)
        {
            HttpResponseMessage http = new HttpResponseMessage();
            int resultado = 0;
            resultado = capaBL.crearPersona(value);

            if (resultado != 0)
            {
                http = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Todo OK Jose Luis") };
            }
            else
            {
                http = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent("Hay algo que no has escrito bien, lo siento por no darte mas informacion") };
            }

            return http;
        }

        // PUT: api/Persona/5
        public HttpResponseMessage Put([FromBody]clsPersona value)
        {
            HttpResponseMessage http = new HttpResponseMessage();
            int resultado = 0;
            resultado = capaBL.actualizarPersona(value);

            if (resultado != 0)
            {
                http = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Todo OK Jose Luis") };
            }
            else
            {
                http = new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("No se encuentra en la BBDD") };
            }

            return http;
        }

        // DELETE: api/Persona/5
        public HttpResponseMessage Delete(int id)
        {
            HttpResponseMessage http = new HttpResponseMessage();
            int resultado = 0;
            resultado = capaBL.borrarPersona(id);

            if(resultado != 0)
            {
                http = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Todo OK Jose Luis") };
            }
            else
            {
                http = new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("No se encuentra en la BBDD") };
            }

            return http;
        }
    }
}
