using _14_PersonajesLoL_DAL.Connection;
using _14_PersonajesLoL_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PersonajesLoL_DAL.Lists
{
    public class clsListadosCategoria
    {
        /// Se conecta a la BBDD y devuelve el listado de los personajes
        /// </summary>
        /// <returns>Listado de Personajes List<clsPersonaje></returns>
        public List<clsCategoria> listadoCategoria()
        {
            List<clsCategoria> listado = new List<clsCategoria>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsCategoria oCategoria;

            try
            {

                miComando.CommandText = "SELECT * FROM Categoria";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oCategoria = new clsCategoria();
                        oCategoria.ID = (int)miLector["ID"];
                        oCategoria.Nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                        listado.Add(oCategoria);
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
