﻿using _12_CRUD_Personas_DAL.Handlers;
using _12_CRUD_Personas_DAL.Lists;
using _12_CRUD_Personas_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CRUD_Personas_BL.Lists
{
    public class clsListadoPersonasBL
    {
        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <returns>El listado de personas List<clsPersona></returns>
        public List<clsPersona> listadoPersonas()
        {
            clsListadosDAL listBBDD = new clsListadosDAL();
            List<clsPersona> listado = new List<clsPersona>();
            listado = listBBDD.listadoPersona();
            return listado;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <returns>El listado de departamentos List<clsDepartamento></returns>
        public List<clsDepartamento> listadoDepartamentos()
        {
            clsListadosDAL listBBDD = new clsListadosDAL();
            List<clsDepartamento> listado = new List<clsDepartamento>();
            listado = listBBDD.listadoDpto();
            return listado;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="id">El id del departamento a buscar</param>
        /// <returns>Devuelve el Departamento que sea de ese ID</returns>
        public clsDepartamento departamentoPorID(int id)
        {
            clsListadosDAL listBBDD = new clsListadosDAL();
            clsDepartamento dpto = new clsDepartamento();
            dpto = listBBDD.departamentoPorID(id);
            return dpto;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="id">El id de la persona a buscar</param>
        /// <returns>Devuelve la persona que sea de ese ID</returns>
        public clsPersona personaPorID(int id)
        {
            clsListadosDAL listBBDD = new clsListadosDAL();
            clsPersona persona = new clsPersona();
            persona = listBBDD.personaporID(id);
            return persona;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="id">El id de la persona para eliminarla</param>
        public int borrarPersona(int id)
        {
            int resultado = 0;
            clsManejadoras crud = new clsManejadoras();
            resultado = crud.borrarPersona(id);
            return resultado;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="persona">La persona nueva a introducir en la BBDD</param>
        public int crearPersona(clsPersona persona)
        {
            int resultado = 0;
            clsManejadoras crud = new clsManejadoras();
            resultado = crud.crearPersona(persona);
            return resultado;
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="persona">La persona modificada para actualizar en la BBDD</param>
        public int actualizarPersona(clsPersona persona)
        {
            int resultado = 0;
            clsManejadoras crud = new clsManejadoras();
            resultado = crud.actualizarPersona(persona);
            return resultado;
        }
    }
}
