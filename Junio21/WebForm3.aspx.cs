using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio21
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false; // ocultamos el panel
            TextBox1.Enabled = false; // desabilitamos el couadro de texto
            TextBox2.ReadOnly = true; // Dejamos texto solo lectura
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var controlNuevo = new Literal();
                controlNuevo.Text = "El Objeto es valido";
                Panel1.Controls.Add(controlNuevo);
            }
            else
            {
                var controlNuevo = new Literal();
                controlNuevo.Text = "El Objeto no es valido";
                Panel1.Controls.Add(controlNuevo);
            }
        }
    }
}