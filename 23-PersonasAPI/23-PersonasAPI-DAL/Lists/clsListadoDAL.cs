using _23_PersonasAPI_DAL.Connection;
using _23_PersonasAPI_ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_PersonasAPI_DAL.Lists
{
    public class clsListadoDAL
    {
        /// <summary>
        /// Se conecta a la BBDD y devuelve el listado de las personas
        /// </summary>
        /// <returns>Listado de personas List<clsPersona></returns>
        public List<clsPersona> listadoPersona()
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
                miComando.CommandText = "SELECT * FROM Personas";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona = new clsPersona();
                        oPersona.idPersona = (int)miLector["IdPersona"];
                        oPersona.nombre = (miLector["NombrePersona"] is DBNull) ? "NULL" : (string)miLector["NombrePersona"];
                        oPersona.apellidos = (miLector["ApellidosPersona"] is DBNull) ? "NULL" : (string)miLector["ApellidosPersona"];
                        oPersona.fechaNacimiento = (miLector["FechaNacimientoPersona"] is DBNull) ? new DateTime() : (DateTime)miLector["FechaNacimientoPersona"];
                        //oPersona.Direccion = ((string)miLector["direccion"] != null) ? (string)miLector["direccion"] : null;
                        oPersona.telefono = (miLector["TelefonoPersona"] is DBNull) ? "NULL" : (string)miLector["TelefonoPersona"];
                        oPersona.foto = (miLector["FotoPersona"] is DBNull) ? new byte[1] : (Byte[])miLector["FotoPersona"];
                        oPersona.idDepartamento = (int)miLector["IDDepartamento"];
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
        /// Se conecta a la BBDD y devuelve el listado de los departamentos
        /// </summary>
        /// <returns>Listado de departamentos List<clsDepartamento></returns>
        public List<clsDepartamento> listadoDpto()
        {
            List<clsDepartamento> listado = new List<clsDepartamento>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsDepartamento oDpto;
            try
            {
                miComando.CommandText = "SELECT * FROM Departamentos";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oDpto = new clsDepartamento();
                        oDpto.id = (int)miLector["IDDepartamento"];
                        oDpto.nombre = (string)miLector["NombreDepartamento"];
                        listado.Add(oDpto);
                    }
                }
                miLector.Close();
                connection.closeConnection(ref conn);
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return listado;
        }

        /// <summary>
        /// Se conecta a la BBDD y devuelve la persona que tiene esa ID
        /// </summary>
        /// <param name="id">El id que tenemos que buscar</param>
        /// <returns>Devolvemos la persona que tiene esa ID</returns>
        public clsPersona personaporID(int id)
        {
            clsPersona oPersona = new clsPersona();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            try
            {
                miComando.CommandText = "SELECT * FROM Personas WHERE idPersona = " + id;
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPersona.idPersona = (int)miLector["IdPersona"];
                        oPersona.nombre = (miLector["NombrePersona"] is DBNull) ? "NULL" : (string)miLector["NombrePersona"];
                        oPersona.apellidos = (miLector["ApellidosPersona"] is DBNull) ? "NULL" : (string)miLector["ApellidosPersona"];
                        oPersona.fechaNacimiento = (miLector["FechaNacimientoPersona"] is DBNull) ? new DateTime() : (DateTime)miLector["FechaNacimientoPersona"];
                        //oPersona.Direccion = ((string)miLector["direccion"] != null) ? (string)miLector["direccion"] : null;
                        oPersona.telefono = (miLector["TelefonoPersona"] is DBNull) ? "NULL" : (string)miLector["TelefonoPersona"];
                        oPersona.foto = (miLector["FotoPersona"] is DBNull) ? new byte[1] : (Byte[])miLector["FotoPersona"];
                        oPersona.idDepartamento = (int)miLector["IDDepartamento"];
                    }
                }
                miLector.Close();
                connection.closeConnection(ref conn);
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return oPersona;
        }

        /// <summary>
        /// Se conecta a la BBDD y devuelve el departamento por ID
        /// </summary>
        /// <param name="id">El id que tenemos que buscar</param>
        /// <returns>Devolvemos el departamento que tiene esa ID</returns>
        public clsDepartamento departamentoPorID(int id)
        {
            clsDepartamento oDpto = new clsDepartamento();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            try
            {
                miComando.CommandText = "SELECT * FROM Departamentos WHERE IDDepartamento  = " + id;
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oDpto = new clsDepartamento();
                        oDpto.id = (int)miLector["IDDepartamento"];
                        oDpto.nombre = (string)miLector["NombreDepartamento"];
                    }
                }
                miLector.Close();
                connection.closeConnection(ref conn);
            }
            catch (SqlException exSql)
            {
                throw exSql;
            }

            return oDpto;
        }
    }
}
