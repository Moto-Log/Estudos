using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class calculaPesoIdeal : Form
    {
        RadioButton rbnSelecionado = null;
        private void rbnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;

            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }
        }

        private void limpaRadio()
        {
            rdBtnMasculino.Checked = false;
            rdBtnFeminino.Checked = false;
            txtAltura.Focus();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            if ((rdBtnMasculino.Checked == false) && (rdBtnFeminino.Checked == false))
            {
                MessageBox.Show("Selecione uma das opções", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SetPesoIdeal();
            }
        }



        private void SetPesoIdeal()
        {
            try
            {
                if (txtAltura.Text == "")
                {
                    lblPeso.Text = "";
                }
                else
                {
                    double altura = Convert.ToDouble(txtAltura.Text);
                    double pesoIdeal;
                    if (rbnSelecionado.Text.Equals("Feminino"))
                    {
                        pesoIdeal = (62.1 * altura) - 44.7;
                    }
                    else
                    {
                        pesoIdeal = (72.7 * altura) - 58;
                    }
                    lblPeso.Text = pesoIdeal.ToString("N");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione o sexo e informe a altura corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public calculaPesoIdeal()
        {
            InitializeComponent();
        }

        private void calculaPesoIdeal_Activated(object sender, EventArgs e)
        {
            limpaRadio();
        }
    }
}
