using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public interface Memento
    {
        void Salvar(string Operando, string Operador, string Resultado);
        GroupBox desfazer();
        GroupBox refazer();
    }


}
