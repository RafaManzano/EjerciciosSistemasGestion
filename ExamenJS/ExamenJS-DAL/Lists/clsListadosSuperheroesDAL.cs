using ExamenJS_DAL.Connection;
using ExamenJS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenJS_DAL.Lists
{
    public class clsListadosSuperheroesDAL
    {
        /// Se conecta a la BBDD y devuelve el listado de los superheroes
        /// </summary>
        /// <returns>Listado de Superhero List<clsSuperHero></returns>
        public List<clsSuperheroe> listadoSuperheroes()
        {
            List<clsSuperheroe> listado = new List<clsSuperheroe>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsSuperheroe oSuperhero;
            try
            {

                miComando.CommandText = "SELECT * FROM superheroes";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oSuperhero = new clsSuperheroe();
                        oSuperhero.IDSuperheroe = (int)miLector["idSuperheroe"];
                        oSuperhero.NombreSuperheroe = (miLector["nombreSuperheroe"] is DBNull) ? "NULL" : (string)miLector["nombreSuperheroe"];
                        listado.Add(oSuperhero);
                    }
                }
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

        /// Se conecta a la BBDD y devuelve el superheroe correspondiente a la id pasada como parametro
        /// </summary>
        /// <returns>Superheroe con esa id </returns>
        public clsSuperheroe superheroePorID(int id)
        {
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsSuperheroe oSuperhero = new clsSuperheroe();
            try
            {
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                miComando.CommandText = "SELECT * FROM superheroes WHERE idSuperheroe = @id";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oSuperhero.IDSuperheroe = (int)miLector["idSuperheroe"];
                        oSuperhero.NombreSuperheroe = (miLector["nombreSuperheroe"] is DBNull) ? "NULL" : (string)miLector["nombreSuperheroe"];
                    }
                }
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

            return oSuperhero;
        }
    }
}
