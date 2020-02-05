using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_PersonasAPI_ENTITIES
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
