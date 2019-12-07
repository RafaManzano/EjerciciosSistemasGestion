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
    public class clsListadosPersonajes
    {
        /// Se conecta a la BBDD y devuelve el listado de los personajes
        /// </summary>
        /// <returns>Listado de Personajes List<clsPersonaje></returns>
        public List<clsPersonaje> listadoPersonajes()
        {
            List<clsPersonaje> listado = new List<clsPersonaje>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsPersonaje oPersonaje;
            //Byte[] bytes = new Byte[20];
            try
            {

                miComando.CommandText = "SELECT * FROM Personaje";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersonaje = new clsPersonaje();
                        oPersonaje.ID = (int)miLector["ID"];
                        oPersonaje.Alias = (miLector["Alias"] is DBNull) ? "NULL" : (string)miLector["Alias"];
                        oPersonaje.Vida = (miLector["Vida"] is DBNull) ? 0 : (double)miLector["Vida"];
                        oPersonaje.Regeneracion = (miLector["Regeneracion"] is DBNull) ? 0 : (double)miLector["Regeneracion"];
                        oPersonaje.Danno = (miLector["Danno"] is DBNull) ? 0 : (double)miLector["Danno"];
                        oPersonaje.Armadura = (miLector["Armadura"] is DBNull) ? 0 : (double)miLector["Armadura"];
                        oPersonaje.VelocidadAtaque = (miLector["VelocidadAtaque"] is DBNull) ? 0 : (double)miLector["VelocidadAtaque"];
                        oPersonaje.Resistencia = (miLector["Resistencia"] is DBNull) ? 0 : (double)miLector["Resistencia"];
                        oPersonaje.VelocidadMovimiento = (miLector["VelocidadMovimiento"] is DBNull) ? 0 : (double)miLector["VelocidadMovimiento"];
                        oPersonaje.IDCategoria = (int)miLector["IDCategoria"];
                        listado.Add(oPersonaje);
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
