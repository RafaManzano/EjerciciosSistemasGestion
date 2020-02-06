using ExamenJS_DAL.Lists;
using ExamenJS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenJS_BL.Lists
{
    public class clsListadosMisionesBL
    {
        /// <summary>
        /// Capa intermedia entre la DAL y la UI
        /// </summary>
        /// <param name="id">El id del superheroe</param>
        /// <returns>El listado de misisones asignadas a ese superheroe</returns>
        public List<clsMision> listadoMisionesPorSuperheroe(int id)
        {
            clsListadosMisionesDAL list = new clsListadosMisionesDAL();
            return list.listadoMisionesPorSuperheroe(id);
        }
    }
}
