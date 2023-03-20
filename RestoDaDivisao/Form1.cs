using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoDaDivisao
{
    public partial class RestoDiv : Form
    {
        public RestoDiv()
        {
            InitializeComponent();
        }

        private void limpeza()
        {
            txtDivisor.Clear();
            txtDividendo.Clear();
            txtDividendo.Focus();
        }

        private void btnResto_Click(object sender, EventArgs e)
        {
            if ((txtDividendo.Text != "") && (txtDivisor.Text != "")){ 

                if (txtDivisor.Text == "0")
                {
                    MessageBox.Show("Não é possivel calcular divisão por 0!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpeza();
                    txtResto.Clear();
                }
                else
                {
                    int resto = Convert.ToInt16(txtDividendo.Text) % Convert.ToInt16(txtDivisor.Text);
                    txtResto.Text = Convert.ToString(resto);
                    limpeza();
                }
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtResto.Clear();
            }
        }

        private void txtDivisor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnResto_Click(sender, e);
            }
        }
    }
}
