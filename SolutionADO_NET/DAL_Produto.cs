using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionADO_NET
{
    public class DAL_Produto
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        public void RemoveById(long? id)
        {
            var command = new SqlCommand("delete from PRODUTOS where id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Update(Produto produto)
        {
            var command = new SqlCommand("update PRODUTOS set Descricao = @Descricao, PrecoDeCusto = @PrecoDeCusto, " +
                "PrecoDeVenda = @PrecoDeVenda, Estoque = @Estoque where id = @id", this.connection);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.Parameters.AddWithValue("@PrecoDeCusto", produto.PrecoDeCusto);
            command.Parameters.AddWithValue("@PrecoDeVenda", produto.PrecoDeVenda);
            command.Parameters.AddWithValue("@Estoque", produto.Estoque);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void Insert(Produto produto)
        {
            var command = new SqlCommand("INSERT into PRODUTOS  (Descricao, PrecoDeCusto, PrecoDeVenda, Estoque)" + 
                " VALUES (@Descricao, @PrecoDeCusto, @PrecoDeVenda, @Estoque)", this.connection);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.Parameters.AddWithValue("@PrecoDeCusto", produto.PrecoDeCusto);
            command.Parameters.AddWithValue("@PrecoDeVenda", produto.PrecoDeVenda);
            command.Parameters.AddWithValue("@Estoque", produto.Estoque);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


        public void Save(Produto produto)
        {
            if (produto.Id != null)
            {
                this.Update(produto);
            }
            else
            {
                this.Insert(produto);
            }
        }
    }
}
