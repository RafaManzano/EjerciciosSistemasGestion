using _16_Empresa_DAL.Lists;
using _16_Empresa_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Empresa_BL.Lists
{
    public class clsListadoPuestosBL
    {
        /// <summary>
        /// Capa intermedia entre UI y DAL
        /// </summary>
        /// <returns>Devuelve el listado de puestos de trabajo</returns>
        public List<clsPuestoTrabajo> listadoPuesto()
        {
            clsListadoPuestosDAL list = new clsListadoPuestosDAL();
            return list.listadoPuestosTrabajo();
        }
    }
}
