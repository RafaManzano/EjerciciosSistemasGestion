using _16_Empresa_DAL.Lists;
using _16_Empresa_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Empresa_BL.Lists
{
    public class clsListadoDepartamentosBL
    {
        /// <summary>
        /// Capa intermedia entre la capa DAL y la UI
        /// </summary>
        /// <returns>Devuelve el listado de departamentos</returns>
        public List<clsDepartamento> listadoDepartamentos()
        {
            clsListadoDepartamentos list = new clsListadoDepartamentos();
            return list.listadoDepartamentos();
        }
    }
}
