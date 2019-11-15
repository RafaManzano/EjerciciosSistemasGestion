using _12_CRUD_Personas_DAL.Connection;
using _12_CRUD_Personas_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CRUD_Personas_DAL.Handlers
{
    public class clsManejadoras
    {
        /// <summary>
        /// Metodo que borra una persona por su ID de la BBDD
        /// </summary>
        /// <param name="id">El ID de la persona a eliminar</param>
        public void borrarPersona(int id)
        {
            int resultado = 0;
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            
            try
            {
                miComando.CommandText = "DELETE FROM dbo.PD_Personas WHERE IdPersona = @id";
                miComando.Connection = conn;
                resultado = miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Creamos la persona y la introducimos en la BBDD
        /// </summary>
        /// <param name="persona">Este es el objeto que tiene que introducir en la BBDD</param>
        public void crearPersona(clsPersona persona)
        {
            int resultado = 0;
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.nombre;
            miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.apellidos;
            miComando.Parameters.Add("@idDpto", System.Data.SqlDbType.Int).Value = persona.idDepartamento;
            miComando.Parameters.Add("@fechaNacimiento", System.Data.SqlDbType.Date).Value = persona.fechaNacimiento;
            miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.telefono;
            miComando.Parameters.Add("@foto", System.Data.SqlDbType.VarBinary).Value = persona.foto = new byte[10];

            try
            {
                miComando.CommandText = "INSERT INTO dbo.PD_Personas VALUES (@nombre, @apellidos, @idDpto, @fechaNacimiento, @telefono, @foto)";
                miComando.Connection = conn;
                resultado = miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Actualizamos la persona de la BBDD
        /// </summary>
        /// <param name="persona">Este es el objeto que tiene que actualizar en la BBDD</param>
        public void actualizarPersona(clsPersona persona)
        {
            int resultado = 0;
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

            try
            {
                miComando.CommandText = "UPDATE dbo.PD_Personas SET NombrePersona = @nombre, ApellidosPersona = @apellidos, IDDepartamento = @idDpto, FechaNacimientoPersona =  @fechaNacimiento, TelefonoPersona = @telefono, FotoPersona = @foto WHERE IdPersona = @id";
                miComando.Connection = conn;
                resultado = miComando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
