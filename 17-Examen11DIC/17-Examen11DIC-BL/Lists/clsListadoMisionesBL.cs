using _17_Examen11DIC_DAL.Lists;
using _17_Examen11DIC_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Examen11DIC_BL.Lists
{
    public class clsListadoMisionesBL
    {
        /// <summary>
        /// Es el intermedario entre la UI y la capa DAL
        /// </summary>
        /// <returns>El listado de Misiones disponibles</returns>
        public List<clsMisiones> listadoMisionesDisponibles()
        {
            clsListadoMisionesDAL list = new clsListadoMisionesDAL();
            return list.listadoMisionesDisponibles();
        }
    }
}
