
namespace SolutionADO_NET
{
    partial class FormFornecedor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblDadosLeitura = new System.Windows.Forms.TableLayoutPanel();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tblEventos = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvFornecedores = new System.Windows.Forms.DataGridView();
            this.aDO_NETDatabaseDataSet = new SolutionADO_NET.ADO_NETDatabaseDataSet();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new SolutionADO_NET.ADO_NETDatabaseDataSetTableAdapters.FornecedoresTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDadosLeitura.SuspendLayout();
            this.tblEventos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDO_NETDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblDadosLeitura
            // 
            this.tblDadosLeitura.ColumnCount = 2;
            this.tblDadosLeitura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.30159F));
            this.tblDadosLeitura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.69841F));
            this.tblDadosLeitura.Controls.Add(this.txtCnpj, 1, 2);
            this.tblDadosLeitura.Controls.Add(this.txtNome, 1, 1);
            this.tblDadosLeitura.Controls.Add(this.lblNome, 0, 1);
            this.tblDadosLeitura.Controls.Add(this.lblID, 0, 0);
            this.tblDadosLeitura.Controls.Add(this.lblCNPJ, 0, 2);
            this.tblDadosLeitura.Controls.Add(this.txtId, 1, 0);
            this.tblDadosLeitura.Cursor = System.Windows.Forms.Cursors.Default;
            this.tblDadosLeitura.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblDadosLeitura.Location = new System.Drawing.Point(3, 3);
            this.tblDadosLeitura.Name = "tblDadosLeitura";
            this.tblDadosLeitura.RowCount = 3;
            this.tblDadosLeitura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblDadosLeitura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblDadosLeitura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblDadosLeitura.Size = new System.Drawing.Size(408, 88);
            this.tblDadosLeitura.TabIndex = 0;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCnpj.Location = new System.Drawing.Point(53, 63);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(350, 20);
            this.txtCnpj.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNome.Location = new System.Drawing.Point(53, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(4, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "NOME:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(14, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(6, 66);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(37, 13);
            this.lblCNPJ.TabIndex = 1;
            this.lblCNPJ.Text = "CNPJ:";
            this.lblCNPJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtId.Location = new System.Drawing.Point(53, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(350, 20);
            this.txtId.TabIndex = 3;
            // 
            // tblEventos
            // 
            this.tblEventos.ColumnCount = 4;
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblEventos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblEventos.Controls.Add(this.btnRemover, 3, 0);
            this.tblEventos.Controls.Add(this.btnCancelar, 2, 0);
            this.tblEventos.Controls.Add(this.btnGravar, 1, 0);
            this.tblEventos.Controls.Add(this.btnNovo, 0, 0);
            this.tblEventos.Location = new System.Drawing.Point(3, 97);
            this.tblEventos.Name = "tblEventos";
            this.tblEventos.RowCount = 1;
            this.tblEventos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEventos.Size = new System.Drawing.Size(408, 28);
            this.tblEventos.TabIndex = 1;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(309, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(94, 22);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(207, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 22);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(105, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(96, 22);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(3, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(96, 22);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvFornecedores);
            this.panel1.Controls.Add(this.tblDadosLeitura);
            this.panel1.Controls.Add(this.tblEventos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 332);
            this.panel1.TabIndex = 2;
            // 
            // DgvFornecedores
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            this.DgvFornecedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvFornecedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvFornecedores.AutoGenerateColumns = false;
            this.DgvFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn});
            this.DgvFornecedores.DataSource = this.fornecedoresBindingSource;
            this.DgvFornecedores.Enabled = false;
            this.DgvFornecedores.Location = new System.Drawing.Point(3, 131);
            this.DgvFornecedores.Name = "DgvFornecedores";
            this.DgvFornecedores.RowHeadersWidth = 100;
            this.DgvFornecedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvFornecedores.Size = new System.Drawing.Size(408, 198);
            this.DgvFornecedores.TabIndex = 2;
            // 
            // aDO_NETDatabaseDataSet
            // 
            this.aDO_NETDatabaseDataSet.DataSetName = "ADO_NETDatabaseDataSet";
            this.aDO_NETDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.aDO_NETDatabaseDataSet;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 332);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFornecedor";
            this.Text = "Manutenção em dados de Fornecedor";
            this.Load += new System.EventHandler(this.FormFornecedor_Load);
            this.tblDadosLeitura.ResumeLayout(false);
            this.tblDadosLeitura.PerformLayout();
            this.tblEventos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDO_NETDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDadosLeitura;
        private System.Windows.Forms.TableLayoutPanel tblEventos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvFornecedores;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovo;
        private ADO_NETDatabaseDataSet aDO_NETDatabaseDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private ADO_NETDatabaseDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
    }
}

