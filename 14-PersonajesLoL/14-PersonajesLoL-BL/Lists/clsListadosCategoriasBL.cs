using _14_PersonajesLoL_DAL.Lists;
using _14_PersonajesLoL_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PersonajesLoL_BL.Lists
{
    public class clsListadosCategoriasBL
    {
        /// <summary>
        /// Es el intermedario entre la UI y la capa DAL
        /// </summary>
        /// <returns>El listado de Categorias</returns>
        public List<clsCategoria> listadoCategorias()
        {
            clsListadosCategoria list = new clsListadosCategoria();
            return list.listadoCategoria();
        }
    }
}
