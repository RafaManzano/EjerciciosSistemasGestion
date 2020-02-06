using _24_PersonasAPIRepaso_BL.Handlers;
using _24_PersonasAPIRepaso_BL.Lists;
using _24_PersonasAPIRepaso_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _24_PersonasAPIRepaso_UI.Controllers
{
    public class PersonasController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<clsPersona> Get()
        {
            return new clsListadoBL().listadoPersonas();
        }

        // GET api/<controller>/5
        public clsPersona Get(int id)
        {
            return new clsManejadoraBL().personaPorID(id);
        }

        // POST api/<controller>
        public HttpResponseMessage Post([FromBody]clsPersona value)
        {
            HttpResponseMessage http = new HttpResponseMessage();
            int res = 0;
            res = new clsManejadoraBL().crearPersona(value);

            if (res != 0)
            {
                http = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Funciona correcto") };
            }
            else
            {
                http = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent("Hay algo que no has escrito bien, lo siento por no darte mas informacion") };
            }

            return http;
        }

        // PUT api/<controller>/5
        public HttpResponseMessage Put([FromBody]clsPersona value)
        {
            HttpResponseMessage http = new HttpResponseMessage();
            int res = 0;
            res = new clsManejadoraBL().actualizarPersona(value);

            if (res != 0)
            {
                http = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Funciona correcto") };
            }
            else
            {
                http = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent("Hay algo que no has escrito bien, lo siento por no darte mas informacion") };
            }

            return http;
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            HttpResponseMessage http = new HttpResponseMessage();
            int res = 0;
            res = new clsManejadoraBL().borrarPersona(id);

            if (res != 0)
            {
                http = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Funciona correcto") };
            }
            else
            {
                http = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent("Hay algo que no has escrito bien, lo siento por no darte mas informacion") };
            }

            return http;
        }
    }
}