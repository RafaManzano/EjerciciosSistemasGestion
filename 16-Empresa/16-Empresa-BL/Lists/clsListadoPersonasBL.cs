using _16_Empresa_DAL.Lists;
using _16_Empresa_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Empresa_BL.Lists
{
    public class clsListadoPersonasBL
    {

        /// <summary>
        /// Capa intermedia entre la capa DAL y la UI
        /// </summary>
        /// <param name="idDepartamento">El id del departamento a buscar</param>
        /// <returns>Devuelve el listado de personas por el id del departamento</returns>
        public List<clsPersona> listadoPersonasPorDepartamento(int idDepartamento)
        {
            clsListadoPersonasDAL list = new clsListadoPersonasDAL();
            return list.listadoPersonasPorDepartamento(idDepartamento);
        }

        /// <summary>
        /// Capa intermedia entre la capa DAL y la UI
        /// </summary>
        /// <param name="idPuestoTrabajo">El id del puesto de trabajo a buscar</param>
        /// <returns>Devuelve el listado de personas por el id del puesto de trabajo</returns>
        public List<clsPersona> listadoPersonasPorPuesto(int idPuestoTrabajo)
        {
            clsListadoPersonasDAL list = new clsListadoPersonasDAL();
            return list.listadoPersonasPorPuesto(idPuestoTrabajo);
        }

        /// <summary>
        /// Capa intermedia entre la capa DAL y la UI
        /// </summary>
        /// <param name="id">El id de la persona a buscar</param>
        /// <returns>Devuelve a la persona que tenga esa id</returns>
        public clsPersona personaPorID(string dni)
        {
            clsListadoPersonasDAL list = new clsListadoPersonasDAL();
            return list.personaPorID(dni);
        }
    }
}
