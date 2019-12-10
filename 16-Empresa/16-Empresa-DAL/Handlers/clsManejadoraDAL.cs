using _16_Empresa_DAL.Connection;
using _16_Empresa_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Empresa_DAL.Handlers
{
    public class clsManejadoraDAL
    {
        /// <summary>
        /// Con este metodo mediante el id pasado por parametro recogemos el nombre
        /// </summary>
        /// <param name="id">El id del departamento</param>
        /// <returns>El nombre del departamento</returns>
        public String NombreDptoPorID(int id)
        {
            string nombre = "";
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

            try
            {
                miComando.CommandText = "SELECT Nombre FROM Departamentos WHERE ID = @id";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }

            return nombre;
        }

        /// <summary>
        /// Con este metodo mediante el id pasado por parametro recogemos el nombre
        /// </summary>
        /// <param name="id">El id del puesto de trabajo</param>
        /// <returns>El nombre del puesto de trabajo</returns>
        public String NombrePuestoPorID(int id)
        {
            string nombre = "";
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

            try
            {
                miComando.CommandText = "SELECT Nombre FROM PuestosTrabajos WHERE ID = @id";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }

            return nombre;
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
                miComando.Parameters.Add("@dni", System.Data.SqlDbType.VarChar).Value = persona.DNI;
                miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.Nombre;
                miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.Apellidos;
                miComando.Parameters.Add("@idDpto", System.Data.SqlDbType.Int).Value = persona.IDDepartamento;
                miComando.Parameters.Add("@idPuesto", System.Data.SqlDbType.Int).Value = persona.IDPuestoTrabajo;


                miComando.CommandText = "UPDATE Personas SET Nombre = @nombre, Apellidos = @apellidos, IDDepartamento = @idDpto, IDPuestoTrabajo =  @idPuesto WHERE DNI = @dni";
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
