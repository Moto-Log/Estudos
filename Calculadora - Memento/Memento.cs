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
        void Salvar(Calculadora dados);
        Calculadora desfazer();
        Calculadora refazer();
    }


}
