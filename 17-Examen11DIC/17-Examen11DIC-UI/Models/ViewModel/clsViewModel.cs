using _17_Examen11DIC_BL.Lists;
using _17_Examen11DIC_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _17_Examen11DIC_UI.Models.ViewModel
{
    public class clsViewModel
    {
        private List<clsSuperheroe> superheroes;
        private List<clsMisiones> misionesDisponibles;
        private int idSuperheroeSeleccionado;
        private List<int> idsMisionesElegidas;
       

        private clsListadoMisionesBL mlist = new clsListadoMisionesBL();
        private clsListadoSuperheroesBL slist = new clsListadoSuperheroesBL();

        public clsViewModel()
        {
            superheroes = slist.listadoSuperheroes();
            misionesDisponibles = mlist.listadoMisionesDisponibles();
            idsMisionesElegidas = new List<int>();
            
        }

        public List<clsSuperheroe> Superheroes
        {
            get
            {
                return superheroes;
            }

            set
            {
                superheroes = value;
            }
        }

        public List<clsMisiones> MisionesDisponibles
        {
            get
            {
                return misionesDisponibles;
            }

            set
            {
                misionesDisponibles = value;
            }
        }

        public int IDSuperheroeSeleccionado
        {
            get
            {
                return idSuperheroeSeleccionado;
            }

            set
            {
                idSuperheroeSeleccionado = value;
            }
        }

        public List<int> IDSMisionesElegidas
        {
            get
            {
                return idsMisionesElegidas;
            }

            set
            {
                idsMisionesElegidas = value;
            }
        }

       
                

    }
}