using _14_PersonajesLoL_BL.Lists;
using _14_PersonajesLoL_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _14_PersonajesLoL_UI.Models
{
    public class clsViewModel
    {
        private List<clsPersonaje> personajes;
        private clsPersonaje personaje;
        private List<clsCategoria> categorias;

        private clsListadosPersonajesBL plist = new clsListadosPersonajesBL();

        public clsViewModel()
        {
            personajes = plist.listadoPersonajes();
            personaje = new clsPersonaje();
        }

        public List<clsPersonaje> Personajes
        {
            get
            {
                return personajes;
            }
            set
            {
                personajes = value;
            }
        }

        public clsPersonaje Personaje
        {
            get
            {
                return personaje;
            }
            set
            {
                personaje = value;
            }
        }

        public List<clsCategoria> Categorias
        {
            get
            {
                return categorias;
            }
            set
            {
                categorias = value;
            }
        }
    }
}