using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace _11_ADOConexionBBDD.Models
{
    public class clsPersona
    {
        public clsPersona()
        {
            IDPersona = -1;
            NombrePersona = "Default";
            ApellidosPersona = "Default";
            FechaNacimiento = DateTime.Now;
            FotoPersona = null;
            IDDepartamento = 1;
        }

        [Key]
        public int IDPersona { get; set; }
        public string NombrePersona { get; set; }
        public string ApellidosPersona { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public List<Byte> FotoPersona { get; set; }
        public int IDDepartamento { get; set; }
    }
}