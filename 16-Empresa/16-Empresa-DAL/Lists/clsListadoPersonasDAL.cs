using _16_Empresa_DAL.Connection;
using _16_Empresa_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Empresa_DAL.Lists
{
    public class clsListadoPersonasDAL
    {
        /// <summary>
        /// Se conecta a la BBDD y devuelve el listado de personas por la ID del departamento
        /// </summary>
        /// <param name="idDepartamento">El ID del departamento a buscar</param>
        /// <returns>El listado de personas de ese departamento</returns>
        public List<clsPersona> listadoPersonasPorDepartamento(int idDepartamento)
        {
            List<clsPersona> listado = new List<clsPersona>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsPersona oPersona;
            //Byte[] bytes = new Byte[20];
            try
            {
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = idDepartamento;
                miComando.CommandText = "SELECT * FROM Personas WHERE IDDepartamento = @id";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona = new clsPersona();
                        oPersona.DNI = (miLector["DNI"] is DBNull) ? "NULL" : (string)miLector["DNI"];
                        oPersona.Nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                        oPersona.Apellidos = (miLector["Apellidos"] is DBNull) ? "NULL" : (string)miLector["Apellidos"];
                        oPersona.IDPuestoTrabajo = (miLector["IDPuestoTrabajo"] is DBNull) ? 0 : (int)miLector["IDPuestoTrabajo"];
                        oPersona.IDDepartamento = (miLector["IDDepartamento"] is DBNull) ? 0 : (int)miLector["IDDepartamento"];
                        listado.Add(oPersona);
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

        /// <summary>
        /// Se conecta a la BBDD y devuelve el listado de personas por la ID del puesto de trabajo
        /// </summary>
        /// <param name="idPuestoTrabajo">El ID del puesto de trabajo a buscar</param>
        /// <returns>El listado de personas de ese puesto de trabajo</returns>
        public List<clsPersona> listadoPersonasPorPuesto(int idPuestoTrabajo)
        {
            List<clsPersona> listado = new List<clsPersona>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsPersona oPersona;
            //Byte[] bytes = new Byte[20];
            try
            {
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = idPuestoTrabajo;
                miComando.CommandText = "SELECT * FROM Personas WHERE IDPuestoTrabajo = @id";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona = new clsPersona();
                        oPersona.DNI = (miLector["DNI"] is DBNull) ? "NULL" : (string)miLector["DNI"];
                        oPersona.Nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                        oPersona.Apellidos = (miLector["Apellidos"] is DBNull) ? "NULL" : (string)miLector["Apellidos"];
                        oPersona.IDPuestoTrabajo = (miLector["IDPuestoTrabajo"] is DBNull) ? 0 : (int)miLector["IDPuestoTrabajo"];
                        oPersona.IDDepartamento = (miLector["IDDepartamento"] is DBNull) ? 0 : (int)miLector["IDDepartamento"];
                        listado.Add(oPersona);
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

        /// <summary>
        /// Se conecta a la BBDD y devuelve el listado de personas por la id 
        /// </summary>
        /// <param name="id">El ID de la persona</param>
        /// <returns>La persona con esa id</returns>
        public clsPersona personaPorID(string dni)
        {
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsPersona oPersona = new clsPersona(); 
            //Byte[] bytes = new Byte[20];
            try
            {
                miComando.Parameters.Add("@dni", System.Data.SqlDbType.VarChar).Value = dni;
                miComando.CommandText = "SELECT * FROM Personas WHERE DNI = @dni";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona.DNI = (miLector["DNI"] is DBNull) ? "NULL" : (string)miLector["DNI"];
                        oPersona.Nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                        oPersona.Apellidos = (miLector["Apellidos"] is DBNull) ? "NULL" : (string)miLector["Apellidos"];
                        oPersona.IDPuestoTrabajo = (miLector["IDPuestoTrabajo"] is DBNull) ? 0 : (int)miLector["IDPuestoTrabajo"];
                        oPersona.IDDepartamento = (miLector["IDDepartamento"] is DBNull) ? 0 : (int)miLector["IDDepartamento"];
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

            return oPersona;
        }

        
    }
}
