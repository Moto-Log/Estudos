using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_classes
{
    public class ProdutoNotaEntrada
    {
        public Guid Id { get; set; }
        public Produto ProdutoEntrada { get; set; }
        public double PrecoCustroCompra { get; set; }
        public double QuantidadeComprada { get; set; }

        protected bool Equals (ProdutoNotaEntrada other)
        {
            return Id.Equals(other.Id);
        }

        public override bool Equals (Object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(ProdutoNotaEntrada))
                return false;

            return Equals((ProdutoNotaEntrada)obj);
        }

        public override int GetHashCode()
        {
            return ProdutoEntrada.GetHashCode();
        }
    }
}
