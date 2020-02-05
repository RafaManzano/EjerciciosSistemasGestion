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
    public class DepartamentosController : ApiController
    {
        private clsListadoBL listadoBL = new clsListadoBL();
        private clsManejadoraBL manejadoraBL = new clsManejadoraBL();
        // GET api/<controller>
        public IEnumerable<clsDepartamento> Get()
        {
            return listadoBL.listadoDepartamentos();
        }

        // GET api/<controller>/5
        public clsDepartamento Get(int id)
        {
            return manejadoraBL.departamentoPorID(id);
        }
    }
}