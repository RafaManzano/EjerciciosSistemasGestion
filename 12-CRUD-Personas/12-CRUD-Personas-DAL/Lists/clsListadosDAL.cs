using _12_CRUD_Personas_DAL.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12_CRUD_Personas_Entities;
using System.Data.SqlClient;

namespace _12_CRUD_Personas_DAL.Lists
{
    public class clsListadosDAL
    {
        public List<clsPersona> listadoPersona()
        {
            clsMyConnection connection = new clsMyConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsPersona oPersona;

        }

    }
}
