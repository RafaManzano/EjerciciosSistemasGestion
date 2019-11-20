using _13_EjercicioSorpresa_BL.Lists;
using _13_EjercicioSorpresa_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _13_EjercicioSorpresa_UI.Models
{
    public class clsListadoDepartamentosListadosPersonas
    {
        private clsListadosDepartamentosBL capaBL = new clsListadosDepartamentosBL();
        public clsListadoDepartamentosListadosPersonas()
        {
          
        }

        public clsListadoDepartamentosListadosPersonas(List<clsDepartamento> dptos, List<clsPersona> personas, clsDepartamento dpto, clsPersona persona)
        {
            Dptos = dptos;
            Personas = personas;
            DepartamentoSeleccionado = dpto;
            PersonaSeleccionada = persona;
        }
        public List<clsDepartamento> Dptos { get; set; }
        public List<clsPersona> Personas { get; set; }

        public clsDepartamento DepartamentoSeleccionado { get; set; }
        public clsPersona PersonaSeleccionada { get; set; }
    }
}