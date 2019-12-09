using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Futbolista_ENTITIES
{
    public class clsEquipo
    {
        public clsEquipo()
        {

        }

        public clsEquipo(int id, string nombre, int anhoFundacion) {
            ID = id;
            Nombre = nombre;
            AnhoFundacion = anhoFundacion;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public int AnhoFundacion { get; set; }
    }
}
