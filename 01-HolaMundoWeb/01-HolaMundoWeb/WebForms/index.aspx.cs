using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_HolaMundoWeb.WebForms
{
    public partial class index : System.Web.UI.Page
    {
        private string nombre;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento que ocurre cuando se clicka el boton Enviar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            nombre = tbNombre.Text;
            if(String.IsNullOrWhiteSpace(nombre))
            {
                lbMuestra.Text = "Tienes que introducir algun nombre";
                lbMuestra.ForeColor = Color.Red;
            }
            else
            {
                lbMuestra.Text = "Que tal el dia, " + nombre;
                lbMuestra.ForeColor = Color.Green;
            }
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            
        }
    }
}