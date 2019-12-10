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
    public class clsListadoDepartamentos
    {
        /// <summary>
        /// Se conecta a la BBDD y devuelve el listado de los departamentos de la empresa
        /// </summary>
        /// <returns>Listado de Departamentos List<clsDepartamento></returns>
        public List<clsDepartamento> listadoDepartamentos()
        {
            List<clsDepartamento> listado = new List<clsDepartamento>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsDepartamento oDepartamento;
            //Byte[] bytes = new Byte[20];
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
                        oDepartamento = new clsDepartamento();
                        oDepartamento.ID = (int)miLector["ID"];
                        oDepartamento.Nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                        listado.Add(oDepartamento);
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
