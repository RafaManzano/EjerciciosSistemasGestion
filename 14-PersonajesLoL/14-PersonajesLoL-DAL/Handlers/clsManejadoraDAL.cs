using _14_PersonajesLoL_DAL.Connection;
using _14_PersonajesLoL_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PersonajesLoL_DAL.Handlers
{
    public class clsManejadoraDAL
    {
        /// <summary>
        /// Actualizamos el personaje de la BBDD
        /// </summary>
        /// <param name="personaje">Este es el objeto que tiene que actualizar en la BBDD</param>
        public void actualizarPersonaje(clsPersonaje personaje)
        {
            int resultado = 0;
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = personaje.ID;
            miComando.Parameters.Add("@alias", System.Data.SqlDbType.VarChar).Value = personaje.Alias;
            miComando.Parameters.Add("@vida", System.Data.SqlDbType.Float).Value = personaje.Vida;
            miComando.Parameters.Add("@regeneracion", System.Data.SqlDbType.Float).Value = personaje.Regeneracion;
            miComando.Parameters.Add("@danno", System.Data.SqlDbType.Float).Value = personaje.Danno;
            miComando.Parameters.Add("@armadura", System.Data.SqlDbType.Float).Value = personaje.Armadura;
            miComando.Parameters.Add("@velocidadAtaque", System.Data.SqlDbType.Float).Value = personaje.VelocidadAtaque;
            miComando.Parameters.Add("@resistencia", System.Data.SqlDbType.Float).Value = personaje.Resistencia;
            miComando.Parameters.Add("@velocidadMovimiento", System.Data.SqlDbType.Float).Value = personaje.VelocidadMovimiento;
            miComando.Parameters.Add("@idCategoria", System.Data.SqlDbType.Int).Value = personaje.IDCategoria;

            try
            {
                miComando.CommandText = "UPDATE Personaje SET Alias = @alias, Vida = @vida, Regeneracion = @regeneracion, Danno =  @danno, Armadura = @armadura, VelocidadAtaque = @velocidadAtaque, Resistencia = @resistencia, VelocidadMovimiento = @velocidadMovimiento, IDCategoria = @idCategoria WHERE ID = @id";
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
