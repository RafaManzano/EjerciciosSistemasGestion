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
        public List<clsPersona> listadoPersonas()
        {
            clsListadosDAL listBBDD = new clsListadosDAL();
            List<clsPersona> listado = new List<clsPersona>();
            listado = listBBDD.listadoPersona();
            return listado;
        }
}
}
