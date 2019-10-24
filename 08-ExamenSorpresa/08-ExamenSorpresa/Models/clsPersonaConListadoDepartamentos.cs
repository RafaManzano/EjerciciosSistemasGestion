using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _08_ExamenSorpresa.Models
{
    public class clsPersonaConListadoDepartamentos : clsPersona
    {
        public List<clsDepartamento> Departamentos{ get; set; }
    }
}