﻿using _15_Futbolista_DAL.Lists;
using _15_Futbolista_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Futbolista_BL.Lists
{
    public class clsListadoEquiposBL
    {
        /// <summary>
        /// Capa intermedia entre la UI y la DAL
        /// </summary>
        /// <returns>Devuelve el listado de equipos</returns>
        public List<clsEquipo> listadoEquipos()
        {
            clsListadoEquiposDAL list = new clsListadoEquiposDAL();
            return list.listadoEquipos();
        }
    }
}