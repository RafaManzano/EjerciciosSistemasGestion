using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10_DataAnnotations.Models
{
    public class clsPersona
    {
        //Fernando usa para la propiedad privada asi _nombre, pero yo usare minusculas y para los metodos
        //Mayusculas
        private string nombre;
        //private string primerApellido;
        //private string segundoApellido;
        //private DateTime fechaNacimiento;

        public clsPersona(String nombre, String primerApellido, String segundoApellido, DateTime fecha, String direccion, String telefono, int id)
        {
            this.nombre = nombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
            this.FechaNacimiento = fecha;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.ID = id;
        }

        public clsPersona()
        {
            //Es necesario porque sino peta
        }

        [Required(ErrorMessage ="El nombre es requerido")]
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

        [MaxLength(40), Required(ErrorMessage ="El primer apellido es requerido, ademas tiene que tener menos de 40 caracteres")]
        public string PrimerApellido { get; set; }
        [MaxLength(40), Required(ErrorMessage = "El primer apellido es requerido, ademas tiene que tener menos de 40 caracteres")]
        public string SegundoApellido { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }

        [MaxLength(200, ErrorMessage ="Maximo 200 caracteres")]
        public string Direccion { get; set; }
        // Solo digitos [RegularExpression("^[+-]?\\d+(\\.\\d+)?$", ErrorMessage ="El telefono debe ser de Españita")]
       [RegularExpression("\\A[0-9]{3} [0-9]{3} [0-9]{3}\\Z", ErrorMessage ="El telefono debe ser de Españita (000 000 000)")]
        public string Telefono { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }
    }
}