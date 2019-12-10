using _16_Empresa_BL.Lists;
using _16_Empresa_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _16_Empresa_UI.Models.ViewModel
{
    public class clsViewModel
    {
        private List<clsDepartamento> departamentos;
        private int idDepartamento;
        private List<clsPersonaConNombreDptoYNombrePuesto> personasConDptoyPuesto;
        private clsPersonaConNombreDptoYNombrePuesto personaConDptoyPuesto;
        private List<clsPuestoTrabajo> puestos;

        private clsListadoDepartamentosBL dlist = new clsListadoDepartamentosBL();

        public clsViewModel()
        {
            departamentos = dlist.listadoDepartamentos();
            personaConDptoyPuesto = new clsPersonaConNombreDptoYNombrePuesto();
            personasConDptoyPuesto = new List<clsPersonaConNombreDptoYNombrePuesto>();
        }

        public List<clsDepartamento> Departamentos
        {
            get
            {
                return departamentos;
            }

            set
            {
                departamentos = value;
            }
        }

        public List<clsPuestoTrabajo> Puestos
        {
            get
            {
                return puestos;
            }

            set
            {
                puestos = value;
            }
        }

        public List<clsPersonaConNombreDptoYNombrePuesto> PersonasConDptoYPuesto
        {
            get
            {
                return personasConDptoyPuesto;
            }

            set
            {
                personasConDptoyPuesto = value;
            }
        }

        public clsPersonaConNombreDptoYNombrePuesto PersonaConDptoYPuesto
        {
            get
            {
                return personaConDptoyPuesto;
            }

            set
            {
                personaConDptoyPuesto = value;
            }
        }

        public int IDDepartamento
        {
            get
            {
                return idDepartamento;
            }

            set
            {
                idDepartamento = value;
            }
        }
    }
}