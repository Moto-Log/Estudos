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

        
        private void numbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            string op = comboBox1.Text;

            double num1 = Convert.ToDouble(numbox1.Text);
            double num2 = Convert.ToDouble(numbox2.Text);

            double result = 0;

            switch(op)
            {
                case "+":
                    result = num1 + num2;
                    txtResult.Visible = true;
                    break;
                case "-":
                    result = num1 - num2;
                    txtResult.Visible = true;
                    break;
                case "x":
                    result = num1 * num2;
                    txtResult.Visible = true;
                    break;
                case "/":
                    if(num2 == 0)
                    {
                        MessageBox.Show("Valor invalido!\n Impossivel dividr por 0!");
                        txtResult.Visible = false;
                    }
                    else
                    {
                        result = num1 / num2;
                        txtResult.Visible = true;
                    }
                    break;
                case "":
                    MessageBox.Show("Favor inserir uma operacao!");
                    break;
            }
            txtResult.Text = result.ToString();
        }
    }
}
