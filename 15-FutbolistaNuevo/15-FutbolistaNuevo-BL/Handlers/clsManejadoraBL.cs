using _15_FutbolistaNuevo_DAL.Handlers;
using _15_FutbolistaNuevo_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_FutbolistaNuevo_BL.Handlers
{
   
    public class clsManejadoraBL
    {
        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="jugador">El jugador que se desea actualizar</param>
        /// <returns></returns>
        public int actualizarJugador(clsJugador jugador)
        {
            clsManejadoraDAL obj = new clsManejadoraDAL();
            return obj.actualizarJugador(jugador);
        }
    

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="id">El id del jugador para eliminarla</param>
        public int borrarJugador(int id)
        {
            int resultado = 0;
            clsManejadoraDAL obj = new clsManejadoraDAL();
            resultado = obj.borrarJugador(id);
            return resultado;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="jugador">El jugador que se desea insertar</param>
        /// <returns></returns>
        public int insertarJugador(clsJugador jugador)
        {
            clsManejadoraDAL obj = new clsManejadoraDAL();
            return obj.insertarJugador(jugador);
        }
    }
}
