using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculos
{
    public partial class Calcular : System.Web.UI.Page
    {
        public int Soma { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMais_Click(object sender, EventArgs e)
        {
            int a, b, resul;

            a = Convert.ToInt32(txtNum1.Text);
            b = Convert.ToInt32(txtNum2.Text);
            resul = a + b;
            txtResultadoMais.Text = resul.ToString();
        }
        
        protected void btnIgual_Click(object sender, EventArgs e)
        {
            

            Session["valor1"] = txtNum1.Text;
            Session["valor2"] = txtNum2.Text;
            

            // Redirecionando o usuario
            Response.Redirect("~/Resultado.aspx");

           

        }
    }
}