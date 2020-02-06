using ExamenJS_DAL.Lists;
using ExamenJS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenJS_BL.Lists
{
    public class clsListadosSuperheroesBL
    {
        /// <summary>
        /// Es el intermedario entre la UI y la capa DAL
        /// </summary>
        /// <returns>El listado de Superheroes</returns>
        public List<clsSuperheroe> listadoSuperheroes()
        {
            clsListadosSuperheroesDAL list = new clsListadosSuperheroesDAL();
            return list.listadoSuperheroes();
        }

        /// <summary>
        /// Es el intermedario entre la UI y la capa DAL
        /// </summary>
        /// <param name="id">El id del superheroe</param>
        /// <returns>Un superheroe con esa id</returns>
        public clsSuperheroe superheroePorID(int id)
        {
            clsListadosSuperheroesDAL list = new clsListadosSuperheroesDAL();
            return list.superheroePorID(id);
        }
    }
}
