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
    public class clsListadoFutbolistasDAL
    {
        /// <summary>
        /// Se conecta a la BBDD y devuelve el listado de jugadores por la ID del equipo
        /// </summary>
        /// <param name="idEquipo">El ID del equipo ha buscar</param>
        /// <returns>El listado de jugadores de ese equipo</returns>
        public List<clsJugador> listadoJugadoresPorEquipo(int idEquipo)
        {
            List<clsJugador> listado = new List<clsJugador>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsJugador oJugador;
            //Byte[] bytes = new Byte[20];
            try
            {
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = idEquipo;
                miComando.CommandText = "SELECT * FROM Jugadores WHERE IDEquipo = @id";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oJugador = new clsJugador();
                        oJugador.ID = (int)miLector["ID"];
                        oJugador.Nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                        oJugador.Apellidos = (miLector["Apellidos"] is DBNull) ? "NULL" : (string)miLector["Apellidos"];
                        oJugador.Dorsal = (miLector["Dorsal"] is DBNull) ? 0 : (int)miLector["Dorsal"];
                        oJugador.Alias = (miLector["Alias"] is DBNull) ? "NULL" : (string)miLector["Alias"];
                        oJugador.Posicion = (miLector["Posicion"] is DBNull) ? "NULL" : (string)miLector["Posicion"];
                        oJugador.IDEquipo = (int)miLector["IDEquipo"];
                        listado.Add(oJugador);
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
