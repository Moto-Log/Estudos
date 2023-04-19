using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public class Memento
    {
        private GroupBox gpBox;
        private IList<GroupBox> historico;

        public Memento(GroupBox gpBox, IList<GroupBox> historico)
        {
            this.gpBox = new GroupBox { };
            this.historico = new List<GroupBox>{ };
        }



    }
}
