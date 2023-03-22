using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReajusteSalarial
{
    public partial class ReajusteSalarial : Form
    {
        public ReajusteSalarial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            RadioButton rbnTurno = bxTurno.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            RadioButton rbnCategoria = bxCategoria.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
            if (rbnTurno == null)
                MessageBox.Show("Selecione um turno!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (rbnCategoria == null)
                MessageBox.Show("Selecione uma categoria!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
                Processar(rbnTurno, rbnCategoria, Convert.ToDouble(txtHoras.Text), Convert.ToDouble(txtSalario.Text));

        }

        private void Processar(RadioButton rbnTurno, RadioButton rbnCategoria, double horasTrabalhadas, double valorSalarioMinimo)
        {
            lbxResumo.Items.Clear();
            double valorCoeficiente = GetCoeficiente(rbnTurno);
            double valorGratificacao = GetGratificacao(rbnTurno, horasTrabalhadas);
            double valorSalarioBruto = horasTrabalhadas * valorCoeficiente;
            double valorImposto = GetImposto(rbnCategoria, valorSalarioBruto);
            double valorAuxilioAlimentacao = GetAuxilio(rbnCategoria, valorSalarioBruto, valorSalarioMinimo);
            double valorSalarioLiquido = valorSalarioBruto + valorGratificacao + valorAuxilioAlimentacao - valorImposto;
            Resultados(valorCoeficiente, valorSalarioBruto, valorImposto, valorGratificacao, valorAuxilioAlimentacao, valorSalarioLiquido);
        }

        private double GetCoeficiente(RadioButton rbnTurno)
        {
            double valorCoeficiente = 0;
            switch (rbnTurno.Text)
            {
                case "Matutino":
                    valorCoeficiente = Convert.ToDouble(txtSalario.Text) * 0.01;
                    break;
                case "Vespertino":
                    valorCoeficiente = Convert.ToDouble(txtSalario.Text) * 0.02;
                    break;
                case "Noturno":
                    valorCoeficiente = Convert.ToDouble(txtSalario.Text) * 0.03;
                    break;
            }
            return valorCoeficiente;
        }

        private double GetGratificacao(RadioButton rbnTurno, double horasTrabalhadas)
        {
            double valorGratificacao = 30;
            if (rbnTurno.Text.Equals("Noturno") && horasTrabalhadas > 80)
                valorGratificacao = 50;
            return valorGratificacao;
        }

        private static double GetImposto(RadioButton rbnCategoria, double valorSalarioBruto)
        {
            double valorImposto = 0;
            switch (rbnCategoria.Text)
            {
                case "Calouro":
                    if (valorSalarioBruto < 300)
                        valorImposto = valorSalarioBruto * 0.01;
                    else
                        valorImposto = valorSalarioBruto * 0.02;
                    break;
                case "Veterano":
                    if (valorSalarioBruto < 400)
                        valorImposto = valorSalarioBruto * 0.03;
                    else
                        valorImposto = valorSalarioBruto * 0.04;
                    break;
            }
            return valorImposto;
        }

        private double GetAuxilio(RadioButton rbnCategoria, double valorSalarioBruto, double valorSalarioMinimo)
        {
            double valorAuxilioAlimentacao = valorSalarioBruto / 3 / 2;
            if (rbnCategoria.Text.Equals("Calouro") && (valorSalarioBruto < (valorSalarioMinimo / 2)))
                valorAuxilioAlimentacao = (valorSalarioBruto / 3);
            return valorAuxilioAlimentacao;
        }

        private void Resultados(double valorCoeficiente, double valorSalarioBruto, double valorImposto, double valorGratificacao, double valorAuxilioAlimentacao, double valorSalarioLiquido)
        {
            txtSituacao.Text = GetSituacao(valorSalarioLiquido);
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do coeficiente:", valorCoeficiente));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Salário bruto:", valorSalarioBruto));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor do imposto :", valorImposto));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor da gratificação :", valorGratificacao));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Valor auxilio alimentação :", valorAuxilioAlimentacao));
            lbxResumo.Items.Add(String.Format("{0,-29}{1,12:C}", "Salário líquido:", valorSalarioLiquido));
        }

        private string GetSituacao(double valorSalarioLiquido)
        {
            if (valorSalarioLiquido < 350)
                return "Mal remunerado";
            else if (valorSalarioLiquido < 600)
                return "Normal";
            else
                return "Bem remunerado";
        }
    }
}
