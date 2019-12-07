
using _14_PersonajesLoL_DAL.Lists;
using _14_PersonajesLoL_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PersonajesLoL_BL.Lists
{
    public class clsListadosPersonajesBL
    {
        /// <summary>
        /// Es el intermedario entre la UI y la capa DAL
        /// </summary>
        /// <returns>El listado de Personajes</returns>
        public List<clsPersonaje> listadoPersonajes()
        {
            clsListadosPersonajes list = new clsListadosPersonajes();
            return list.listadoPersonajes();
        }
    }
}
