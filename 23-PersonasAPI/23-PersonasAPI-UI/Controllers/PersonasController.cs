using _23_PersonasAPI_BL.Handlers;
using _23_PersonasAPI_BL.Lists;
using _23_PersonasAPI_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _23_PersonasAPI_UI.Controllers
{
    public class PersonasController : ApiController
    {
        private clsListadoBL listadoBL = new clsListadoBL();
        private clsManejadoraBL manejadoraBL = new clsManejadoraBL();

        // GET api/<controller>
        public IEnumerable<clsPersona> Get()
        {
            return listadoBL.listadoPersonas();
        }

        // GET api/<controller>/5
        public clsPersona Get(int id)
        {
            return manejadoraBL.personaPorID(id);
        }

        // POST api/<controller>
        public HttpResponseMessage Post([FromBody]clsPersona value)
        {
            HttpResponseMessage http = new HttpResponseMessage();
            int res = 0;
            res = manejadoraBL.crearPersona(value);

            if(res != 0)
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
            int resultado = 0;
            resultado = manejadoraBL.actualizarPersona(value);

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

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            HttpResponseMessage http = new HttpResponseMessage();
            int resultado = 0;
            resultado = manejadoraBL.borrarPersona(id);

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
    }
}