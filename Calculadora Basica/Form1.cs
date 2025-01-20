using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Basica
{
    public partial class Form1 : Form
    {

        double valor1 = 0, valor2 = 0;
        int operador;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += "9";

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case 0:
                    valor2 = Convert.ToDouble(tbDisplay.Text);
                    tbDisplay.Text = Convert.ToString(valor1 + valor2);
                    break;
                case 1:
                    valor2 = Convert.ToDouble(tbDisplay.Text);
                    tbDisplay.Text = Convert.ToString(valor1 - valor2);
                    break;
                case 2:
                    valor2 = Convert.ToDouble(tbDisplay.Text);
                    tbDisplay.Text = Convert.ToString(valor1 * valor2);
                    break;
                case 3:
                    valor2 = Convert.ToDouble(tbDisplay.Text);
                    tbDisplay.Text = Convert.ToString(valor1 / valor2);
                    break;
            }

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operador = 0;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
           
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            operador = 1;

            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }


        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";

        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += ".";
        }

    }
}
