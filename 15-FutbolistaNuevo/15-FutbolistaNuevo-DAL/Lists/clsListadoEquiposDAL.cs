using _15_FutbolistaNuevo_DAL.Connection;
using _15_FutbolistaNuevo_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_FutbolistaNuevo_DAL.Lists
{
    public class clsListadoEquiposDAL
    {
        /// Se conecta a la BBDD y devuelve el listado de los equipos
        /// </summary>
        /// <returns>Listado de Equipos List<clsEquipo></returns>
        public List<clsEquipo> listadoEquipos()
        {
            List<clsEquipo> listado = new List<clsEquipo>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsEquipo oEquipo;
            //Byte[] bytes = new Byte[20];
            try
            {

                miComando.CommandText = "SELECT * FROM Equipos";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oEquipo = new clsEquipo();
                        oEquipo.ID = (int)miLector["ID"];
                        oEquipo.Nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                        oEquipo.AnhoFundacion = (miLector["AnhoFundacion"] is DBNull) ? 0 : (int)miLector["AnhoFundacion"];
                        listado.Add(oEquipo);
                    }
                }

                //miLector.Close();
                //connection.closeConnection(ref conn);  
            }
            catch (Exception exSql)
            {
                throw exSql;
            }

            finally
            {
                if (miLector != null)
                {
                    miLector.Close();
                }

                if (conn != null)
                {
                    connection.closeConnection(ref conn);
                }
            }

            return listado;

        }
    }
}
