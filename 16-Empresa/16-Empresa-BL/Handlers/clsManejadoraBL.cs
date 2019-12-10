using _16_Empresa_DAL.Handlers;
using _16_Empresa_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Empresa_BL.Handlers
{
    public class clsManejadoraBL
    {
        /// <summary>
        /// La capa intermedia entre UI y DAL
        /// </summary>
        /// <param name="id">El id del puesto de trabajo</param>
        /// <returns>El nombre del puesto de trabajo</returns>
        public string NombrePuestoPorID(int id)
        {
            clsManejadoraDAL list = new clsManejadoraDAL();
            return list.NombrePuestoPorID(id);
        }

        /// <summary>
        /// La capa intermedia entre UI y DAL
        /// </summary>
        /// <param name="id">El id del departamento</param>
        /// <returns>El nombre del departamento</returns>
        public string NombreDptoPorID(int id)
        {
            clsManejadoraDAL list = new clsManejadoraDAL();
            return list.NombreDptoPorID(id);
        }

        /// <summary>
        /// La capa intermedia entre UI y DAL
        /// </summary>
        /// <param name="persona">La persona a actualizar</param>
        /// <returns>El numero de filas afectadas</returns>
        public int actualizarPersona(clsPersona persona)
        {
            clsManejadoraDAL list = new clsManejadoraDAL();
            return list.actualizarPersona(persona);
        }
    }
}
