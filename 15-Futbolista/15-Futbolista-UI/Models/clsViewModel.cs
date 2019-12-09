using _15_Futbolista_BL.Lists;
using _15_Futbolista_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _15_Futbolista_UI.Models
{
    public class clsViewModel
    {
        private List<clsEquipo> equipos;
        private List<clsJugador> jugadores;
        private int idEquipo;
        private clsJugador jugadorSeleccionado;

        private clsListadoEquiposBL elist = new clsListadoEquiposBL();

        public clsViewModel()
        {
            equipos = new List<clsEquipo>(elist.listadoEquipos());
            jugadores = new List<clsJugador>();
            idEquipo = 0;
            jugadorSeleccionado = new clsJugador();
        }

        public List<clsEquipo> Equipos
        {
            get
            {
                return equipos;
            }
            set
            {
                equipos = value;
            }
        }

        public List<clsJugador> Jugadores
        {
            get
            {
                return jugadores;
            }
            set
            {
                jugadores = value;
            }
        }

        public clsJugador JugadorSeleecionado
        {
            get
            {
                return jugadorSeleccionado;
            }
            set
            {
                jugadorSeleccionado = value;
            }
        }

        public int IDEquipo
        {
            get
            {
                return idEquipo;
            }
            set
            {
                idEquipo = value;
            }
        }
    }
}