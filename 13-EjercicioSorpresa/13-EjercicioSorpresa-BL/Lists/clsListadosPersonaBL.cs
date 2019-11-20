using _13_EjercicioSorpresa_DAL.Lists;
using _13_EjercicioSorpresa_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_EjercicioSorpresa_BL.Lists
{
    public class clsListadosPersonaBL
    {
        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <returns>El listado de personas List<clsPersona></returns>
        public List<clsPersona> listadoPersonas()
        {
            clsListadosPersona listBBDD = new clsListadosPersona();
            List<clsPersona> listado = new List<clsPersona>();
            listado = listBBDD.listadoPersona();
            return listado;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="id">El id del departamento a buscar</param>
        /// <returns>Devuelve las personsa que sea de ese ID</returns>
        public List<clsPersona> personasPorIDDepartamento(int id)
        {
            clsListadosPersona listBBDD = new clsListadosPersona();
            List<clsPersona> personas = new List<clsPersona>();
            personas = listBBDD.personasPorDepartamento(id);
            return personas;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="id">El id de la persona a buscar</param>
        /// <returns>Devuelve la persona que sea de ese ID</returns>
        public clsPersona personaPorID(int id)
        {
            clsListadosPersona listBBDD = new clsListadosPersona();
            clsPersona persona = new clsPersona();
            persona = listBBDD.personaporID(id);
            return persona;
        }

    }
}
