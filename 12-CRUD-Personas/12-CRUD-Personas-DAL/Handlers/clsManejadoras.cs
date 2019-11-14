using _12_CRUD_Personas_DAL.Connection;
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

    }
}
