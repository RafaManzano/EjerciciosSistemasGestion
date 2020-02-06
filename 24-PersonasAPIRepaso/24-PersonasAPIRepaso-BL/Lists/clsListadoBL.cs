using _24_PersonasAPIRepaso_DAL.Lists;
using _24_PersonasAPIRepaso_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_PersonasAPIRepaso_BL.Lists
{
    public class clsListadoBL
    {
        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <returns>El listado de personas List<clsPersona></returns>
        public List<clsPersona> listadoPersonas()
        {
            clsListadoDAL listBBDD = new clsListadoDAL();
            List<clsPersona> listado = new List<clsPersona>();
            listado = listBBDD.listadoPersona();
            return listado;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <returns>El listado de departamentos List<clsDepartamento></returns>
        public List<clsDepartamento> listadoDepartamentos()
        {
            clsListadoDAL listBBDD = new clsListadoDAL();
            List<clsDepartamento> listado = new List<clsDepartamento>();
            listado = listBBDD.listadoDpto();
            return listado;
        }
    }
}
