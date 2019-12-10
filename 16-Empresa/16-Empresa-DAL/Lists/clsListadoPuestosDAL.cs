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
    public class clsListadoPuestosDAL
    {
        /// <summary>
        /// Se conecta a la BBDD y devuelve el listado de los puestos de trabajo de la empresa
        /// </summary>
        /// <returns>Listado de puestos de trabajo List<clsPuestoTrabajo></returns>
        public List<clsPuestoTrabajo> listadoPuestosTrabajo()
        {
            List<clsPuestoTrabajo> listado = new List<clsPuestoTrabajo>();
            clsMyConnection connection = new clsMyConnection();
            SqlConnection conn = connection.getConnection();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector = null;
            clsPuestoTrabajo oPuesto;
            //Byte[] bytes = new Byte[20];
            try
            {

                miComando.CommandText = "SELECT * FROM PuestosTrabajos";
                miComando.Connection = conn;
                miLector = miComando.ExecuteReader();
                //Si hay lineas en el lector
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPuesto = new clsPuestoTrabajo();
                        oPuesto.ID = (int)miLector["ID"];
                        oPuesto.Nombre = (miLector["Nombre"] is DBNull) ? "NULL" : (string)miLector["Nombre"];
                        listado.Add(oPuesto);
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
