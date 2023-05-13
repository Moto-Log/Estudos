using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionADO_NET
{
    public partial class FormProdutos : Form
    {
        private Produto produtoAtual;
        private readonly DAL_Produto dal = new DAL_Produto();
        public FormProdutos()
        {
            InitializeComponent();
            GetAllProdutos();
        }


        //metodos
        private void GetAllProdutos()
        {
            var connection = DBConnection.DB_Connection;
            var adapter = new SqlDataAdapter("SELECT id, descricao, PrecoDeCusto, PrecoDeVenda, Estoque FROM Produtos", connection);
            var table = new DataTable();
            adapter.Fill(table);
            dgvProdutos.DataSource = table;
            connection.Close();
        }
        private Produto GetProdutoById(long id)
        {
            Produto produto = new Produto();
            var connection = DBConnection.DB_Connection;
            var command = new SqlCommand("SELECT id, descricao, PrecoDeCusto, PrecoDeVenda, Estoque FROM Produtos where id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    produto.Id = reader.GetInt64(0);
                    produto.Descricao = reader.GetString(1);
                    produto.PrecoDeCusto = Convert.ToDouble(reader.GetDecimal(2));
                    produto.PrecoDeVenda = Convert.ToDouble(reader.GetDecimal(3));
                    produto.Estoque = Convert.ToDouble(reader.GetDecimal(4));
                }
            }
            connection.Close();
            if (produto.Id > 0)
                return produto;
            return null;
        }
        private void ClearControls()
        {
            txtId.Clear();
            txtDesc.Clear();
            txtCusto.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
            GetAllProdutos();
            dgvProdutos.ClearSelection();
            this.produtoAtual = null;
            txtDesc.Focus();
        }

        //eventos
        private void btnGravar_Click(object sender, EventArgs e)
        {
            dal.Save(new Produto()
            {
                Id = string.IsNullOrEmpty(txtId.Text) ? (long?)null : Convert.ToInt64(txtId.Text),
                Descricao = txtDesc.Text,
                PrecoDeCusto = Convert.ToDouble(txtCusto.Text),
                PrecoDeVenda = Convert.ToDouble(txtPreco.Text),
                Estoque = Convert.ToDouble(txtEstoque.Text)

            });
            MessageBox.Show("Manutenção com sucesso");
            ClearControls();
        }

      

        private void DgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            this.produtoAtual = GetProdutoById(Convert.ToInt64(dgvProdutos.Rows[e.RowIndex].Cells[0].Value));
            txtId.Text = this.produtoAtual.Id.ToString();
            txtDesc.Text = this.produtoAtual.Descricao;
            txtCusto.Text = this.produtoAtual.PrecoDeCusto.ToString();
            txtPreco.Text = this.produtoAtual.PrecoDeVenda.ToString();
            txtEstoque.Text = this.produtoAtual.Estoque.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione o PRODUTO a ser removido da base" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            else
            {
                this.dal.RemoveById(this.produtoAtual.Id);
                ClearControls();
                MessageBox.Show("Produto removido com sucesso");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aDO_NETDatabaseDataSet1.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.aDO_NETDatabaseDataSet1.Produtos);

        }
    }
}
