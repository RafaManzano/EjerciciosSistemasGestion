using ExamenJS_BL.Lists;
using ExamenJS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExamenJS_UI.Controllers
{
    public class MisionesController : ApiController
    {
        // GET api/<controller>/5
        public IEnumerable<clsMision> Get(int id)
        {
            return new clsListadosMisionesBL().listadoMisionesPorSuperheroe(id);
        }
    }
}