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
        private Stack<Calculadora> UndoPile;
        private Stack<Calculadora> RedoPile;

        public ConcreteMemento()
        {
            this.UndoPile = new Stack<Calculadora>();
            this.RedoPile = new Stack<Calculadora>();
        }

        public Calculadora desfazer()
        {
            int num = UndoPile.Count;
            if (num == 0)
                return (Calculadora dados = new Calculadora("","",""));
            return this.UndoPile.Pop();
        }

        public void Salvar(Calculadora dados)
        {
           
            this.UndoPile.Push(dados);
            this.RedoPile.Clear();
            
        }

        public Calculadora refazer()
        {
            return this.RedoPile.Pop();
        }
    }
}
