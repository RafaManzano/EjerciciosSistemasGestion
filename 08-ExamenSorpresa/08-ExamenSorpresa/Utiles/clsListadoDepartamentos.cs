using _08_ExamenSorpresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _08_ExamenSorpresa.Utiles
{
    public class clsListadoDepartamentos
    {
        public List<clsDepartamento> listadoDepartamentos()
        {
            List<clsDepartamento> departamentos = new List<clsDepartamento>();
            departamentos.Add(new clsDepartamento(1, "INFORMATICA"));
            departamentos.Add(new clsDepartamento(2, "FINANZAS"));
            departamentos.Add(new clsDepartamento(3, "CONTABILIDAD"));
            departamentos.Add(new clsDepartamento(4, "VENTAS"));
            return departamentos;
        }

        public String buscarNombrePorID(int id)
        {
            List<clsDepartamento> departamentos = listadoDepartamentos();
            return departamentos.Find(x => x.ID == id).Nombre;
        }
    }
}