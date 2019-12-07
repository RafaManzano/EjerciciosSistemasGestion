using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PersonajesLoL_ENTITIES
{
    public class clsPersonaje
    {
        public clsPersonaje()
        {

        }

        public clsPersonaje(int id, string alias, double vida, double regeneracion, double danno, double armadura, double velocidadAtaque, double resistencia, double velocidadMovimiento, int idCategoria) {
            ID = id;
            Alias = alias;
            Vida = vida;
            Regeneracion = regeneracion;
            Danno = danno;
            Armadura = armadura;
            VelocidadAtaque = velocidadAtaque;
            Resistencia = resistencia;
            VelocidadMovimiento = velocidadMovimiento;
            IDCategoria = idCategoria;
        }

        public int ID { get; set; }
        public string Alias { get; set; }
        public double Vida { get; set; }
        public double Regeneracion { get; set; }
        public double Danno { get; set; }
        public double Armadura { get; set; }
        public double VelocidadAtaque { get; set; }
        public double Resistencia { get; set; }
        public double VelocidadMovimiento { get; set; }
        public int IDCategoria { get; set; }
    }
}
