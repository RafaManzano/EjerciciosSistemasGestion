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
            List<clsPersona> listado = new List<clsPersona>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsPersona oPersona;
            Byte[] bytes = new Byte[20];
            try
            {
                miComando.CommandText = "SELECT * FROM dbo.PD_Personas";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona = new clsPersona();
                        oPersona.idPersona = (int)miLector["IdPersona"];
                        oPersona.nombre = (string)miLector["NombrePersona"];
                        oPersona.apellidos = (string)miLector["ApellidosPersona"];
                        //oPersona.fechaNacimiento = (DateTime)miLector["FechaNacimientoPersona"];
                        //oPersona.direccion = (string)miLector["direccion"];
                        oPersona.telefono = (oPersona.telefono != null) ? (string)miLector["TelefonoPersona"] : "000000000" ;
                        oPersona.foto = (oPersona.foto != null) ? (byte[])miLector["FotoPersona"]: bytes;
                        oPersona.idDepartamento = (int)miLector["IDDepartamento"];
                        listado.Add(oPersona);
                    }
                }
                miLector.Close();
                connection.closeConnection(ref conn);
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return listado;

        }

    }
}
