﻿using _17_Examen11DIC_DAL.Connection;
using _17_Examen11DIC_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Examen11DIC_DAL.Handlers
{
    public class clsManejadoraDAL
    {
        /// <summary>
        /// Actualizamos la mision de la BBDD con los nuevos datos introducidos
        /// </summary>
        /// <param name="mision">Este es el objeto que tiene que actualizar en la BBDD</param>
        public void actualizarMision(clsMisiones mision)
        {
            int resultado = 0;
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = mision.IDMision;
            //miComando.Parameters.Add("@titulo", System.Data.SqlDbType.VarChar).Value = mision.TituloMision;
            //miComando.Parameters.Add("@descripcion", System.Data.SqlDbType.VarChar).Value = mision.DescripcionMision;
            miComando.Parameters.Add("@reservada", System.Data.SqlDbType.Int).Value = mision.Reservada;
            miComando.Parameters.Add("@idSuperheroe", System.Data.SqlDbType.Int).Value = mision.IDSuperheroe;


            try
            {
                miComando.CommandText = "UPDATE misiones SET reservada = @reservada, idSuperheroe = @idSuperheroe WHERE idMision = @id";
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
