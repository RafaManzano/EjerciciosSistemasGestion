using _15_FutbolistaNuevo_DAL.Lists;
using _15_FutbolistaNuevo_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_FutbolistaNuevo_BL.Lists
{
    public class clsListadoFutbolistaBL
    {
        /// <summary>
        /// Capa intermedia entre la UI y la DAL
        /// </summary>
        /// <returns>Devuelve el listado de jugadores del equipo</returns>
        public List<clsJugador> listadoJugadoresPorEquipo(int idEquipo)
        {
            clsListadoFutbolistasDAL list = new clsListadoFutbolistasDAL();
            return list.listadoJugadoresPorEquipo(idEquipo);
        }

        public clsJugador jugadorPorID(int id)
        {
            clsListadoFutbolistasDAL list = new clsListadoFutbolistasDAL();
            return list.jugadorPorID(id);
        }
    }
}
