using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public class ConcreteMemento: Memento
    {
        private Stack<GroupBox> UndoPile;
        private Stack<GroupBox> RedoPile;

        public ConcreteMemento()
        {
            this.UndoPile = new Stack<GroupBox>();
            this.RedoPile = new Stack<GroupBox>();
        }

        public GroupBox desfazer()
        {
            return this.UndoPile.Pop(); 
        }

        public void Salvar(GroupBox gpBox)
        {
            this.UndoPile.Push(gpBox);
            
        }

        public GroupBox refazer()
        {
            return this.RedoPile.Pop();
        }
    }
}
