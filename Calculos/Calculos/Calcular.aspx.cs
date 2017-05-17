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
        public int Subtracao { get; set; }
        public int Multiplicacao { get; set; }
        public int Divisao { get; set; }


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

        protected void btnMenos_Click(object sender, EventArgs e)
        {
            int a, b, resul;

            a = Convert.ToInt32(txtNumMenos.Text);
            b = Convert.ToInt32(txtNumMenos2.Text);
            resul = a - b;
            txtResultMenos.Text = resul.ToString();
        }

        protected void btnVezes_Click(object sender, EventArgs e)
        {
            int a, b, resul;

            a = Convert.ToInt32(txtNumVezes.Text);
            b = Convert.ToInt32(txtNumVezes2.Text);
            resul = a * b;
            txtResulVezes.Text = resul.ToString();
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            int a, b, resul;

            a = Convert.ToInt32(txtNumDiv.Text);
            b = Convert.ToInt32(txtNumDiv2.Text);
            resul = a / b;
            txtResulDiv.Text = resul.ToString();
        }
    }
}