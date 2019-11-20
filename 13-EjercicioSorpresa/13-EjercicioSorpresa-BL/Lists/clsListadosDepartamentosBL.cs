using _13_EjercicioSorpresa_DAL.Lists;
using _13_EjercicioSorpresa_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_EjercicioSorpresa_BL.Lists
{
    public class clsListadosDepartamentosBL
    {
        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <returns>El listado de departamentos List<clsDepartamento></returns>
        public List<clsDepartamento> listadoDepartamentos()
        {
            clsListadosDepartamentos listBBDD = new clsListadosDepartamentos();
            List<clsDepartamento> listado = new List<clsDepartamento>();
            listado = listBBDD.listadoDpto();
            return listado;
        }

    }
}
