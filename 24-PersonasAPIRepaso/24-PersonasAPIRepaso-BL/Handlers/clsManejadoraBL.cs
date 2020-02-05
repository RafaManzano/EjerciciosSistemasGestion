using _24_PersonasAPIRepaso_DAL.Handlers;
using _24_PersonasAPIRepaso_DAL.Lists;
using _24_PersonasAPIRepaso_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_PersonasAPIRepaso_BL.Handlers
{
    public class clsManejadoraBL
    {
        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="id">El id del departamento a buscar</param>
        /// <returns>Devuelve el Departamento que sea de ese ID</returns>
        public clsDepartamento departamentoPorID(int id)
        {
            clsListadoDAL listBBDD = new clsListadoDAL();
            clsDepartamento dpto = new clsDepartamento();
            dpto = listBBDD.departamentoPorID(id);
            return dpto;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="id">El id de la persona a buscar</param>
        /// <returns>Devuelve la persona que sea de ese ID</returns>
        public clsPersona personaPorID(int id)
        {
            clsListadoDAL listBBDD = new clsListadoDAL();
            clsPersona persona = new clsPersona();
            persona = listBBDD.personaporID(id);
            return persona;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="id">El id de la persona para eliminarla</param>
        public int borrarPersona(int id)
        {
            int resultado = 0;
            clsManejadoraDAL crud = new clsManejadoraDAL();
            resultado = crud.borrarPersona(id);
            return resultado;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="persona">La persona nueva a introducir en la BBDD</param>
        public int crearPersona(clsPersona persona)
        {
            int resultado = 0;
            clsManejadoraDAL crud = new clsManejadoraDAL();
            resultado = crud.crearPersona(persona);
            return resultado;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="persona">La persona modificada para actualizar en la BBDD</param>
        public int actualizarPersona(clsPersona persona)
        {
            int resultado = 0;
            clsManejadoraDAL crud = new clsManejadoraDAL();
            resultado = crud.actualizarPersona(persona);
            return resultado;
        }
    }
}
