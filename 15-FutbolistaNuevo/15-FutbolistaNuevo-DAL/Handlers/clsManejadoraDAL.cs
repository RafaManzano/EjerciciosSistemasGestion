using _15_FutbolistaNuevo_DAL.Connection;
using _15_FutbolistaNuevo_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_FutbolistaNuevo_DAL.Handlers
{
    public class clsManejadoraDAL
    {
        /// <summary>
        /// Actualizamos el jugador de la BBDD
        /// </summary>
        /// <param name="jugador">Este es el objeto que tiene que actualizar en la BBDD</param>
        public int actualizarJugador(clsJugador jugador)
        {
            int resultado = 0;
            try
            {
                clsMyConnection connection = new clsMyConnection();
                SqlConnection conn = connection.getConnection();
                SqlCommand miComando = new SqlCommand();
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = jugador.ID;
                miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = jugador.Nombre;
                miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = jugador.Apellidos;
                miComando.Parameters.Add("@alias", System.Data.SqlDbType.VarChar).Value = jugador.Alias;
                miComando.Parameters.Add("@dorsal", System.Data.SqlDbType.Int).Value = jugador.Dorsal;
                miComando.Parameters.Add("@posicion", System.Data.SqlDbType.VarChar).Value = jugador.Posicion;
                miComando.Parameters.Add("@idEquipo", System.Data.SqlDbType.Int).Value = jugador.IDEquipo;


                miComando.CommandText = "UPDATE Jugadores SET Nombre = @nombre, Apellidos = @apellidos, Dorsal = @dorsal, Alias = @alias, Posicion = @posicion, IDEquipo = @idEquipo WHERE ID = @id";
                miComando.Connection = conn;
                resultado = miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            return resultado;

        }

        /// <summary>
        /// Metodo que borra un jugador por su ID de la BBDD
        /// </summary>
        /// <param name="id">El ID del jugador a eliminar</param>
        public int borrarJugador(int id)
        {
            int resultado = 0;
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

            try
            {
                miComando.CommandText = "DELETE FROM Jugadores WHERE ID = @id";
                miComando.Connection = conn;
                resultado = miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            return resultado;

        }

        /// <summary>
        /// Insertar el nuevo jugador de la BBDD
        /// </summary>
        /// <param name="jugador">Este es el objeto que tiene que actualizar en la BBDD</param>
        public int insertarJugador(clsJugador jugador)
        {
            int resultado = 0;
            try
            {
                clsMyConnection connection = new clsMyConnection();
                SqlConnection conn = connection.getConnection();
                SqlCommand miComando = new SqlCommand();
                miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = jugador.Nombre;
                miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = jugador.Apellidos;
                miComando.Parameters.Add("@alias", System.Data.SqlDbType.VarChar).Value = jugador.Alias;
                miComando.Parameters.Add("@dorsal", System.Data.SqlDbType.Int).Value = jugador.Dorsal;
                miComando.Parameters.Add("@posicion", System.Data.SqlDbType.VarChar).Value = jugador.Posicion;
                miComando.Parameters.Add("@idEquipo", System.Data.SqlDbType.Int).Value = jugador.IDEquipo;


                miComando.CommandText = "INSERT INTO Jugadores VALUES (@nombre, @apellidos, @dorsal, @alias, @posicion, @idEquipo)";
                miComando.Connection = conn;
                resultado = miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            return resultado;

        }
    }
}
