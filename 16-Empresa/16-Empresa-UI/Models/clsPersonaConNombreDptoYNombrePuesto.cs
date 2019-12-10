using _16_Empresa_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _16_Empresa_UI.Models
{
    public class clsPersonaConNombreDptoYNombrePuesto : clsPersona
    {
        public clsPersonaConNombreDptoYNombrePuesto()
        {

        }

        public clsPersonaConNombreDptoYNombrePuesto(string nombreDpto, string nombrePuesto)
        {
            NombreDpto = nombreDpto;
            NombrePuesto = nombrePuesto;
        }
        public string NombreDpto { get; set; }
        public string NombrePuesto { get; set; }
    }
}