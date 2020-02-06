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
    public class SuperheroesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<clsSuperheroe> Get()
        {
            return new clsListadosSuperheroesBL().listadoSuperheroes();
        }

        
        // GET api/<controller>/5
        public clsSuperheroe Get(int id)
        {
            return new clsListadosSuperheroesBL().superheroePorID(id);
        }

       
    }
}