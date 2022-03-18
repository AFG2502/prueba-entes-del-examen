using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejer_2_condicionales
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnboton_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double valor, descuento, total;
            //datos de entrada
            valor = System.Convert.ToDouble(txtvalor.Text);
            //datos de salida
            if(valor > 1000)
            {
                descuento = valor * 0.20;
            }
            else
            {
                descuento = 0;
            }
            total = valor - descuento;
            lbldescuento.Text = System.Convert.ToString(descuento);
            lbltotal.Text= System.Convert.ToString(total);

        }
    }
}