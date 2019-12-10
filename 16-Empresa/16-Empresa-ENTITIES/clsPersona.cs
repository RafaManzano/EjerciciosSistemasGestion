using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Empresa_ENTITIES
{
    public class clsPersona
    {
        public clsPersona()
        {

        }

        public clsPersona(string dni, string nombre, string apellidos, int idPuesto, int idDepartamento)
        {
            DNI = dni;
            Nombre = nombre;
            Apellidos = apellidos;
            IDPuestoTrabajo = idPuesto;
            IDDepartamento = idDepartamento;
        }

        public string DNI { get; set; }
        public string Nombre { get; set;}
        public string Apellidos { get; set; }
        public int IDPuestoTrabajo { get; set; }
        public int IDDepartamento { get; set; }
    }
}
