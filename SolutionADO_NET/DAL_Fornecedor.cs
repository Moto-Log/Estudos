using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SolutionADO_NET
{
    public class DAL_Fornecedor
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        public void RemoveById(long? id)
        {
            var command = new SqlCommand("delete from FORNECEDORES where id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Update(Fornecedor fornecedor)
        {
            var command = new SqlCommand("update FORNECEDORES set cnpj = @cnpj, nome = @nome where id = @id", this.connection);
            command.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@id", fornecedor.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void Insert(Fornecedor fornecedor)
        {
            var command = new SqlCommand("insert into Fornecedores (CNPJ, NOME) values (@cnpj, @nome)", this.connection);
            command.Parameters.AddWithValue("@cnpj", fornecedor.CNPJ);
            command.Parameters.AddWithValue("@nome", fornecedor.Nome);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


        public void Save(Fornecedor fornecedor)
        {
            if (fornecedor.Id != null)
            {
                this.Update(fornecedor);
            }
            else
            {
                this.Insert(fornecedor);
            }
        }
    }
}
