using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _08_ExamenSorpresa.Models
{
    public class clsDepartamento
    {
        public clsDepartamento() { }
        public clsDepartamento(int id, string nombre)
        {
            this.ID = id;
            this.Nombre = nombre;
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        
    }
}