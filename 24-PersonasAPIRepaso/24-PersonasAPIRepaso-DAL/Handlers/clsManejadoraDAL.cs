using _24_PersonasAPIRepaso_DAL.Connection;
using _24_PersonasAPIRepaso_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_PersonasAPIRepaso_DAL.Handlers
{
    public class clsManejadoraDAL
    {
        /// <summary>
        /// Metodo que borra una persona por su ID de la BBDD
        /// </summary>
        /// <param name="id">El ID de la persona a eliminar</param>
        public int borrarPersona(int id)
        {
            int resultado = 0;
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

            try
            {
                miComando.CommandText = "DELETE FROM Personas WHERE IdPersona = @id";
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
        /// Creamos la persona y la introducimos en la BBDD
        /// </summary>
        /// <param name="persona">Este es el objeto que tiene que introducir en la BBDD</param>
        public int crearPersona(clsPersona persona)
        {
            int resultado = 0;
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.nombre;
            miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.apellidos;
            miComando.Parameters.Add("@fechaNacimiento", System.Data.SqlDbType.Date).Value = persona.fechaNacimiento;
            miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.telefono;
            miComando.Parameters.Add("@foto", System.Data.SqlDbType.VarBinary).Value = persona.foto = new byte[10];
            miComando.Parameters.Add("@idDepartamento", System.Data.SqlDbType.Int).Value = persona.idDepartamento;

            try
            {
                miComando.CommandText = "INSERT INTO Personas (NombrePersona, ApellidosPersona, FechaNacimientoPersona, TelefonoPersona, FotoPersona, IDDepartamento) VALUES (@nombre, @apellidos, @fechaNacimiento, @telefono, @foto, @idDepartamento)";
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
        /// Actualizamos la persona de la BBDD
        /// </summary>
        /// <param name="persona">Este es el objeto que tiene que actualizar en la BBDD</param>
        public int actualizarPersona(clsPersona persona)
        {
            int resultado = 0;
            try
            {
                clsMyConnection connection = new clsMyConnection();
                SqlConnection conn = connection.getConnection();
                SqlCommand miComando = new SqlCommand();
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = persona.idPersona;
                miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.nombre;
                miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.apellidos;
                miComando.Parameters.Add("@idDpto", System.Data.SqlDbType.Int).Value = persona.idDepartamento;
                miComando.Parameters.Add("@fechaNacimiento", System.Data.SqlDbType.Date).Value = persona.fechaNacimiento;
                miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.telefono;
                miComando.Parameters.Add("@foto", System.Data.SqlDbType.VarBinary).Value = persona.foto = new byte[10];


                miComando.CommandText = "UPDATE Personas SET NombrePersona = @nombre, ApellidosPersona = @apellidos, IDDepartamento = @idDpto, FechaNacimientoPersona =  @fechaNacimiento, TelefonoPersona = @telefono, FotoPersona = @foto WHERE IdPersona = @id";
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
