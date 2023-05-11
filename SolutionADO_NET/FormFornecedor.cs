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
        private string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;


        private void GetAllFornecedores()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            var connection = new SqlConnection(connectionString);
            var adapter = new SqlDataAdapter("select id, cnpj, nome from FORNECEDORES", connectionString);
            var builder = new SqlCommandBuilder(adapter);
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
            txtNome.Focus();
        }

        public FormFornecedor()
        {
            InitializeComponent();
            GetAllFornecedores();
        }



        //eventos
        private void btnGravar_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "insert into FORNECEDORES(nome,cnpj) values(@nome, @cnpj)";
                command.Parameters.AddWithValue("@nome", txtNome.Text);
                command.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
                command.ExecuteNonQuery();
            }
            
            MessageBox.Show("Fornecedor registrado com sucesso");
            ClearControls();
            GetAllFornecedores();
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aDO_NETDatabaseDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.aDO_NETDatabaseDataSet.Fornecedores);
        }
    }
}
