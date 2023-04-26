using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora;

namespace Calculadora
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }
        
        Calculadora calculadora = new Calculadora();

        private void btnEquals_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(calculadora.calcular(Convert.ToDouble(txtOperador.Text), Convert.ToDouble(txtOperador.Text), Convert.ToString(lblOp.Text)));
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtOperador.Focus();
            lblOp.Text = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtOperador.Focus();
            lblOp.Text = "-";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            txtOperador.Focus();
            lblOp.Text = "x";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtOperador.Focus();
            lblOp.Text = "/";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtOperador.Focused)
            {
                txtOperador.Text += "1";
            }
            else
            {
                txtOperando.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtOperador.Focused)
            {
                txtOperador.Text += "2";
            }
            else
            {
                txtOperando.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtOperador.Focused)
            {
                txtOperador.Text += "3";
            }
            else
            {
                txtOperando.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtOperador.Focused)
            {
                txtOperador.Text += "4";
            }
            else
            {
                txtOperando.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtOperador.Focused)
            {
                txtOperador.Text += "5";
            }
            else
            {
                txtOperando.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtOperador.Focused)
            {
                txtOperador.Text += "6";
            }
            else
            {
                txtOperando.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtOperador.Focused)
            {
                txtOperador.Text += "7";
            }
            else
            {
                txtOperando.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtOperador.Focused)
            {
                txtOperador.Text += "8";
            }
            else
            {
                txtOperando.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtOperador.Focused)
            {
                txtOperador.Text += "9";
            }
            else
            {
                txtOperando.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtOperador.Focused)
            {
                txtOperador.Text += "0";
            }
            else
            {
                txtOperando.Text += "0";
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (txtOperador.Focused)
            {
                txtOperador.Text += ".";
            }
            else
            {
                txtOperando.Text += ".";
            }
        }
    }
}
