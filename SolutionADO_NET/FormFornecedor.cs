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
    public partial class FormFornecedor : Form
    {
        private Fornecedor fornecedorAtual;
        private readonly DAL_Fornecedor dal = new DAL_Fornecedor();


        public FormFornecedor()
        {
            InitializeComponent();
            GetAllFornecedores();
        }


        //Metodos
        private Fornecedor GetFornecedorById(long id)
        {
            Fornecedor fornecedor = new Fornecedor();
            var connection = DBConnection.DB_Connection;
            var command = new SqlCommand("select id, cnpj, nome from FORNECEDORES where id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            { 
                while (reader.Read())
                {
                    fornecedor.Id = reader.GetInt64(0);
                    fornecedor.CNPJ = reader.GetString(1);
                    fornecedor.Nome = reader.GetString(2);
                }
            }
            connection.Close();
            if (fornecedor.Id > 0)
                return fornecedor;
            return null;
        }

            private void GetAllFornecedores()
        {
            var connection = DBConnection.DB_Connection;
            var adapter = new SqlDataAdapter("select id, cnpj, nome from FORNECEDORES", connection);
            var table = new DataTable();
            adapter.Fill(table);
            DgvFornecedores.DataSource = table;
            connection.Close();
        }
        private void ClearControls()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCnpj.Clear();
            GetAllFornecedores();
            DgvFornecedores.ClearSelection();
            this.fornecedorAtual = null;
            txtNome.Focus();
        }



        //eventos
        private void btnGravar_Click(object sender, EventArgs e)
        {
            dal.Save(new Fornecedor(){ 
                Id = string.IsNullOrEmpty(txtId.Text)? (long?) null: Convert.ToInt64(txtId.Text), 
                Nome = txtNome.Text,
                CNPJ = txtCnpj.Text
            });
            MessageBox.Show("Manutenção com sucesso");
            ClearControls();
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aDO_NETDatabaseDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.aDO_NETDatabaseDataSet.Fornecedores);
        }

        private void DgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            
            this.fornecedorAtual = GetFornecedorById(Convert.ToInt64(DgvFornecedores.Rows[e.RowIndex].Cells[0].Value));
            txtId.Text = this.fornecedorAtual.Id.ToString();
            txtNome.Text = this.fornecedorAtual.Nome;
            txtCnpj.Text = this.fornecedorAtual.CNPJ;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione o FORNECEDOR a ser removido da base" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            else
            {
                this.dal.RemoveById(this.fornecedorAtual.Id);
                ClearControls();
                MessageBox.Show("Fornecedor removido com sucesso");
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
    }
}
