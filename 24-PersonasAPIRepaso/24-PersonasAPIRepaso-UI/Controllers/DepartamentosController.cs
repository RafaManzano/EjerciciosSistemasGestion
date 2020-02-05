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
    public class DepartamentosController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<clsDepartamento> Get()
        {
            return new clsListadoBL().listadoDepartamentos();
        }

        // GET api/<controller>/5
        public clsDepartamento Get(int id)
        {
            return new clsManejadoraBL().departamentoPorID(id);
        }
    }
}