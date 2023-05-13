namespace SolutionADO_NET
{
    partial class FormProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.globalPanel = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDO_NETDatabaseDataSet1 = new SolutionADO_NET.ADO_NETDatabaseDataSet1();
            this.layoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.bntNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.layoutData = new System.Windows.Forms.TableLayoutPanel();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.produtosTableAdapter = new SolutionADO_NET.ADO_NETDatabaseDataSet1TableAdapters.ProdutosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDeCustoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDeVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.globalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDO_NETDatabaseDataSet1)).BeginInit();
            this.layoutButtons.SuspendLayout();
            this.layoutData.SuspendLayout();
            this.SuspendLayout();
            // 
            // globalPanel
            // 
            this.globalPanel.Controls.Add(this.dgvProdutos);
            this.globalPanel.Controls.Add(this.layoutButtons);
            this.globalPanel.Controls.Add(this.layoutData);
            this.globalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.globalPanel.Location = new System.Drawing.Point(0, 0);
            this.globalPanel.Name = "globalPanel";
            this.globalPanel.Size = new System.Drawing.Size(427, 450);
            this.globalPanel.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDeCustoDataGridViewTextBoxColumn,
            this.precoDeVendaDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.produtosBindingSource;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 185);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(419, 258);
            this.dgvProdutos.TabIndex = 2;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduto_CellClick);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.aDO_NETDatabaseDataSet1;
            // 
            // aDO_NETDatabaseDataSet1
            // 
            this.aDO_NETDatabaseDataSet1.DataSetName = "ADO_NETDatabaseDataSet1";
            this.aDO_NETDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutButtons
            // 
            this.layoutButtons.ColumnCount = 4;
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layoutButtons.Controls.Add(this.bntNovo, 0, 0);
            this.layoutButtons.Controls.Add(this.btnGravar, 1, 0);
            this.layoutButtons.Controls.Add(this.btnRemover, 2, 0);
            this.layoutButtons.Controls.Add(this.btnCancelar, 3, 0);
            this.layoutButtons.Location = new System.Drawing.Point(3, 152);
            this.layoutButtons.Name = "layoutButtons";
            this.layoutButtons.RowCount = 1;
            this.layoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutButtons.Size = new System.Drawing.Size(419, 31);
            this.layoutButtons.TabIndex = 1;
            // 
            // bntNovo
            // 
            this.bntNovo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntNovo.Location = new System.Drawing.Point(4, 4);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(95, 23);
            this.bntNovo.TabIndex = 0;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGravar.Location = new System.Drawing.Point(113, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(85, 23);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemover.Location = new System.Drawing.Point(212, 4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(95, 23);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(321, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // layoutData
            // 
            this.layoutData.ColumnCount = 2;
            this.layoutData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.layoutData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutData.Controls.Add(this.txtEstoque, 1, 4);
            this.layoutData.Controls.Add(this.txtPreco, 1, 3);
            this.layoutData.Controls.Add(this.txtCusto, 1, 2);
            this.layoutData.Controls.Add(this.txtDesc, 1, 1);
            this.layoutData.Controls.Add(this.lblId, 0, 0);
            this.layoutData.Controls.Add(this.lblEstoque, 0, 4);
            this.layoutData.Controls.Add(this.lblPreco, 0, 3);
            this.layoutData.Controls.Add(this.lblCusto, 0, 2);
            this.layoutData.Controls.Add(this.lblDesc, 0, 1);
            this.layoutData.Controls.Add(this.txtId, 1, 0);
            this.layoutData.Location = new System.Drawing.Point(3, 3);
            this.layoutData.Name = "layoutData";
            this.layoutData.RowCount = 5;
            this.layoutData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutData.Size = new System.Drawing.Size(419, 143);
            this.layoutData.TabIndex = 0;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEstoque.Location = new System.Drawing.Point(69, 117);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(343, 20);
            this.txtEstoque.TabIndex = 9;
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPreco.Location = new System.Drawing.Point(69, 88);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(343, 20);
            this.txtPreco.TabIndex = 8;
            // 
            // txtCusto
            // 
            this.txtCusto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCusto.Location = new System.Drawing.Point(69, 60);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(343, 20);
            this.txtCusto.TabIndex = 7;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDesc.Location = new System.Drawing.Point(69, 32);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(343, 20);
            this.txtDesc.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 7);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblEstoque
            // 
            this.lblEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(8, 121);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(49, 13);
            this.lblEstoque.TabIndex = 4;
            this.lblEstoque.Text = "Estoque:";
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(14, 91);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 3;
            this.lblPreco.Text = "Preço:";
            // 
            // lblCusto
            // 
            this.lblCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(14, 63);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(37, 13);
            this.lblCusto.TabIndex = 2;
            this.lblCusto.Text = "Custo:";
            this.lblCusto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(4, 35);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 13);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descrição:";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(69, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(343, 20);
            this.txtId.TabIndex = 5;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricão";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 165;
            // 
            // precoDeCustoDataGridViewTextBoxColumn
            // 
            this.precoDeCustoDataGridViewTextBoxColumn.DataPropertyName = "PrecoDeCusto";
            this.precoDeCustoDataGridViewTextBoxColumn.HeaderText = "Custo";
            this.precoDeCustoDataGridViewTextBoxColumn.Name = "precoDeCustoDataGridViewTextBoxColumn";
            this.precoDeCustoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoDeCustoDataGridViewTextBoxColumn.Width = 60;
            // 
            // precoDeVendaDataGridViewTextBoxColumn
            // 
            this.precoDeVendaDataGridViewTextBoxColumn.DataPropertyName = "PrecoDeVenda";
            this.precoDeVendaDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDeVendaDataGridViewTextBoxColumn.Name = "precoDeVendaDataGridViewTextBoxColumn";
            this.precoDeVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoDeVendaDataGridViewTextBoxColumn.Width = 60;
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn.Width = 60;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.globalPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produtos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.globalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDO_NETDatabaseDataSet1)).EndInit();
            this.layoutButtons.ResumeLayout(false);
            this.layoutData.ResumeLayout(false);
            this.layoutData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel globalPanel;
        private System.Windows.Forms.TableLayoutPanel layoutData;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TableLayoutPanel layoutButtons;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCancelar;
        private ADO_NETDatabaseDataSet1 aDO_NETDatabaseDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private ADO_NETDatabaseDataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDeCustoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDeVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
    }
}