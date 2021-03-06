﻿using _14_CRUDPersonas_NETCORE_DAL.Handlers;
using _14_CRUDPersonas_NETCORE_DAL.Lists;
using _14_CRUDPersonas_NETCORE_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _14_CRUDPersonas_NETCORE_BL.Lists
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
        public void borrarPersona(int id)
        {
            clsManejadoras crud = new clsManejadoras();
            crud.borrarPersona(id);
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="persona">La persona nueva a introducir en la BBDD</param>
        public void crearPersona(clsPersona persona)
        {
            clsManejadoras crud = new clsManejadoras();
            crud.crearPersona(persona);
        }

        /// <summary>
        /// Recoge de la capa DAL el listado y lo pasa a la CAPA UI
        /// </summary>
        /// <param name="persona">La persona modificada para actualizar en la BBDD</param>
        public void actualizarPersona(clsPersona persona)
        {
            clsManejadoras crud = new clsManejadoras();
            crud.actualizarPersona(persona);
        }
    }
}
