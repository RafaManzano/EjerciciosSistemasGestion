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
    
    public class DepartamentoController : ApiController
    {
        private clsListadoPersonasBL capaBL = new clsListadoPersonasBL();
        // GET: api/Departamento
        public IEnumerable<clsDepartamento> Get()
        {
            return capaBL.listadoDepartamentos();
        }

        // GET: api/Departamento/id
        public clsDepartamento Get(int id)
        {
            return capaBL.departamentoPorID(id);
        }

    }
}
