using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Futbolista_ENTITIES
{
    public class clsJugador
    {
        public clsJugador()
        {

        }

        public clsJugador(int id, string nombre, string apellidos, int dorsal, string alias, string posicion, int idEquipo)
        {
            ID = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Dorsal = dorsal;
            Posicion = posicion;
            IDEquipo = IDEquipo;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Dorsal { get; set; }
        public string Alias { get; set; }
        public string Posicion { get; set;}
        public int IDEquipo { get; set; }
    }
}
