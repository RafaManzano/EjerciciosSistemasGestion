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
    public class clsListadosMisionesDAL
    {


        /// <summary>
        /// Con este metodo obtenemos las misiones asignadas a un superheroe pasado su id por parametro
        /// </summary>
        /// <param name="id">El id del superheroe</param>
        /// <returns>Devuelve el listado de las misiones de ese superheroe</returns>
        public List<clsMision> listadoMisionesPorSuperheroe(int id)
        {
            List<clsMision> listado = new List<clsMision>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsMision oMision;

            try
            {
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                miComando.CommandText = "SELECT * FROM misiones WHERE idSuperheroe = @id";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oMision = new clsMision();
                        oMision.IDMision = (int)miLector["idMision"];
                        oMision.TituloMision = (miLector["tituloMision"] is DBNull) ? "NULL" : (string)miLector["tituloMision"];
                        oMision.DescripcionMision = (miLector["descripcionMision"] is DBNull) ? "NULL" : (string)miLector["descripcionMision"];
                        oMision.Reservada = (miLector["reservada"] is false) ? 0 : 1;
                        oMision.IDSuperheroe = (miLector["idSuperheroe"] is DBNull) ? 0 : (int)miLector["idSuperheroe"];
                        oMision.Observaciones = (miLector["observaciones"] is DBNull) ? "NULL" : (string)miLector["observaciones"];
                        listado.Add(oMision);
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
    }
}
