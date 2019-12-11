using _17_Examen11DIC_DAL.Handlers;
using _17_Examen11DIC_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Examen11DIC_BL.Handlers
{
    public class clsManejadoraBL
    {
        /// <summary>
        /// Union de la UI con la DAL
        /// </summary>
        /// <param name="mision">La mision a actualizar</param>
        public void actualizarMision(clsMisiones mision)
        {
            clsManejadoraDAL bbdd = new clsManejadoraDAL();
            bbdd.actualizarMision(mision);
        }
    }
}
