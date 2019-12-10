using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Empresa_ENTITIES
{
    public class clsPuestoTrabajo
    {
        public clsPuestoTrabajo()
        {

        }

        public clsPuestoTrabajo(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
    }
}
