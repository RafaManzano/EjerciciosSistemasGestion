﻿using _12_CRUD_Personas_DAL.Lists;
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
    }
}
