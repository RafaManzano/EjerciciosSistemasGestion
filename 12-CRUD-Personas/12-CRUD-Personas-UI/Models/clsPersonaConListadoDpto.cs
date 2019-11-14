using _12_CRUD_Personas_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _12_CRUD_Personas_UI.Models
{
    public class clsPersonaConListadoDpto : clsPersona
    {
        public List<clsDepartamento> ListadoDepartamentos { get; set; }
    }
}