using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        double acumula = 0;
        string operacao = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txb_Visor.Text += 0;

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txb_Visor.Text += 1;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txb_Visor.Text += 2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txb_Visor.Text += 3;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txb_Visor.Text += 4;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txb_Visor.Text += 5;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txb_Visor.Text += 6;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txb_Visor.Text += 7;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txb_Visor.Text += 8;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txb_Visor.Text += 9;
        }

        private void btn_Ponto_Click(object sender, EventArgs e)
        {
             txb_Visor.Text += ".";
        }

        private void txb_Visor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Menos_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula += double.Parse(txb_Visor.Text);
                txb_Visor.Text = "";
                operacao = "-";
            }

        }

        private void btn_Mais_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
             else 
            {
                acumula = double.Parse(txb_Visor.Text);
                txb_Visor.Text = "";
                operacao = "+";
            }


        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(txb_Visor.Text);
                txb_Visor.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(txb_Visor.Text);
                txb_Visor.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(txb_Visor.Text);
                txb_Visor.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(txb_Visor.Text) != 0)
                {
                    acumula /= double.Parse(txb_Visor.Text);
                    txb_Visor.Text = acumula.ToString();
                    
                }
                else
                {
                    txb_Visor.Text = "Dividindo por zero";
                }
                

                    }
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "+")
            {
                operacao = "/";
            }
            else
            {
                acumula += double.Parse(txb_Visor.Text);
                txb_Visor.Text = "";
                operacao = "/";
            }
        }

        private void btn_Mult_Click(object sender, EventArgs e)
        {
            if (operacao == "+" || operacao == "-" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(txb_Visor.Text);
                txb_Visor.Text = "";
                operacao = "*";
            }
           /* if(txb_Visor == txb_Visor && acumula == null)
            {
                txb_Visor.Text = "";
                acumula = double.Parse(txb_Visor.Text) * acumula;
                acumula = double.Parse(txb_Visor.Text);
            }*/
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            acumula = 0;
            txb_Visor.Text = "";
        }
    }
}
