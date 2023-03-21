using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gastoRestaurante
{
    public partial class CalcularDespesa : Form
    {
        public CalcularDespesa()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtDespesa.Text != "")
            {
                double total = (Convert.ToDouble(txtDespesa.Text) * 1.1);
                txtTotal.Text = Convert.ToString(total);
                txtDespesa.Clear();
                txtDespesa.Focus();
            } 
            else
            {
                MessageBox.Show("Favor inserir a despesa", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtTotal.Clear();
            }
        }

        private void txtDespesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) btnCalcular_Click(sender, e);
        }
    }
}
