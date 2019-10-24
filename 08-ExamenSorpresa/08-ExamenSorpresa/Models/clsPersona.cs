using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _08_ExamenSorpresa.Models
{
    public class clsPersona
    {
        //Fernando usa para la propiedad privada asi _nombre, pero yo usare minusculas y para los metodos
        //Mayusculas
        private string nombre;
        //private string primerApellido;
        //private string segundoApellido;
        //private DateTime fechaNacimiento;

        public clsPersona(String nombre, String primerApellido, String segundoApellido, DateTime fecha, int IdDepartamento)
        {
            this.nombre = nombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
            this.FechaNacimiento = fecha;
            this.IdDepartamento = IdDepartamento;
        }

        public clsPersona()
        {
            //Es necesario porque sino peta
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdDepartamento { get; set; }
    }
}