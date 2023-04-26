using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public class Calculadora
    {
        public string operando;
        public string operacao;
        public string operador;

        public Calculadora(string operando, string operacao, string operador)
        {
            this.operando = operando;
            this.operacao = operacao;
            this.operador = operador;
        }

        public double calcular(double operando, double operador, string operacao)
        {
            double resultado = 0;
            switch (operacao)
            {
                case "+":
                    resultado = operando + operador;
                    break;
                case "-":
                    resultado = operando - operador;
                    break;
                case "/":
                    if (operador == 0)
                    {
                        MessageBox.Show("Impossivel dividir por 0!" + MessageBoxIcon.Error);
                        break;
                    }
                    resultado = operando / operador;
                    break;
                case "x":
                    resultado = operando * operador;
                    break;
                default:
                    MessageBox.Show("Favor realizar alguma operação!" + MessageBoxIcon.Error);
                    break;
            }
            return resultado;
        }
    }
}
