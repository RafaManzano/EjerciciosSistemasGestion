using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PersonajesLoL_ENTITIES
{
    public class clsCategoria
    {
        public clsCategoria()
        {

        }

        public clsCategoria(int id, string nombre) 
        {
            ID = id;
            Nombre = nombre;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }

    }
}
