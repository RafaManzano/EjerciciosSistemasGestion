using System;
using System.Collections.Generic;
using System.Text;

namespace _14_CRUDPersonas_NETCORE_Entities
{
    public class clsDepartamento
    {
        public String nombre { get; set; }
        public int id { get; set; }

        public clsDepartamento()
        {

        }
        public clsDepartamento(String nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }
    }
}
