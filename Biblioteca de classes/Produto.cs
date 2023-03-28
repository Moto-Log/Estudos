using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_classes
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public double precoDeCusto { get; set; }
        public double PrecoDeVenda { get; set; }
        public double Estoque { get; set; }
    }
}
