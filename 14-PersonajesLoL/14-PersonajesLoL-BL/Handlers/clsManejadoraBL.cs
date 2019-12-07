using _14_PersonajesLoL_DAL.Handlers;
using _14_PersonajesLoL_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PersonajesLoL_BL.Handlers
{
    public class clsManejadoraBL
    {
        /// <summary>
        /// Capa intermedia entre la UI y la DAL
        /// </summary>
        /// <param name="personaje">El personaje a actualizar en la BBDD</param>
        public void actualizarPersonaje(clsPersonaje personaje)
        {
            clsManejadoraDAL man = new clsManejadoraDAL();
            man.actualizarPersonaje(personaje);
        }
        
    }
}
