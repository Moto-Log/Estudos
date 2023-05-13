using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionADO_NET
{
    public class NotaEntrada
    {
        public long? Id { get; set; }
        public string Numero { get; set; }
        public Fornecedor FornecedorNota { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }

        public NotaEntrada()
        {
            this.Id = null;
        }
        /*
                public void RegistrarProduto
                    (ProdutoNotaEntrada produto)
                {
                    if (!this.Produtos.Contains(produto))
                        this.Produtos.Add(produto);
                }

                public void RemoverProduto
                    (ProdutoNotaEntrada produto)
                {
                    this.Produtos.Remove(produto);
                }

                public void RemoverTodosProdutos()
                {
                    this.Produtos.Clear();
                }*/
    }
}
