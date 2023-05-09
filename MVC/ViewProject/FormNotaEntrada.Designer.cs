namespace ViewProject
{
    partial class FormNotaEntrada
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDNotaEntrada = new System.Windows.Forms.TextBox();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNotasEntrada = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoverNota = new System.Windows.Forms.Button();
            this.btnCancelarNota = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnNovoNota = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRemoverProduto = new System.Windows.Forms.Button();
            this.BtnCancelarProduto = new System.Windows.Forms.Button();
            this.BtnGravarProduto = new System.Windows.Forms.Button();
            this.BtnNovoProduto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasEntrada)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dtpEntrada, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtNumero, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtIDNotaEntrada, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpEmissao, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxFornecedor, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.69912F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.23894F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 113);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrada.Location = new System.Drawing.Point(149, 91);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(141, 22);
            this.dtpEntrada.TabIndex = 9;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(149, 45);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(140, 22);
            this.txtNumero.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fornecedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Emissão:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Entrada:";
            // 
            // txtIDNotaEntrada
            // 
            this.txtIDNotaEntrada.Location = new System.Drawing.Point(149, 3);
            this.txtIDNotaEntrada.Name = "txtIDNotaEntrada";
            this.txtIDNotaEntrada.Size = new System.Drawing.Size(140, 22);
            this.txtIDNotaEntrada.TabIndex = 5;
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(149, 69);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(141, 22);
            this.dtpEmissao.TabIndex = 8;
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(149, 25);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(141, 24);
            this.cbxFornecedor.TabIndex = 5;
            this.cbxFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbxFornecedor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(72, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Corpo da Nota";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNotasEntrada);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 426);
            this.panel1.TabIndex = 2;
            // 
            // dgvNotasEntrada
            // 
            this.dgvNotasEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotasEntrada.Location = new System.Drawing.Point(14, 227);
            this.dgvNotasEntrada.Name = "dgvNotasEntrada";
            this.dgvNotasEntrada.RowHeadersWidth = 51;
            this.dgvNotasEntrada.RowTemplate.Height = 24;
            this.dgvNotasEntrada.Size = new System.Drawing.Size(289, 181);
            this.dgvNotasEntrada.TabIndex = 3;
            this.dgvNotasEntrada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotasEntrada_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnRemoverNota, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelarNota, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGravar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNovoNota, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 169);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(293, 42);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnRemoverNota
            // 
            this.btnRemoverNota.Location = new System.Drawing.Point(222, 3);
            this.btnRemoverNota.Name = "btnRemoverNota";
            this.btnRemoverNota.Size = new System.Drawing.Size(67, 23);
            this.btnRemoverNota.TabIndex = 3;
            this.btnRemoverNota.Text = "Remover";
            this.btnRemoverNota.UseVisualStyleBackColor = true;
            this.btnRemoverNota.Click += new System.EventHandler(this.btnRemoverNota_Click);
            // 
            // btnCancelarNota
            // 
            this.btnCancelarNota.Location = new System.Drawing.Point(149, 3);
            this.btnCancelarNota.Name = "btnCancelarNota";
            this.btnCancelarNota.Size = new System.Drawing.Size(67, 23);
            this.btnCancelarNota.TabIndex = 2;
            this.btnCancelarNota.Text = "Cancelar";
            this.btnCancelarNota.UseVisualStyleBackColor = true;
            this.btnCancelarNota.Click += new System.EventHandler(this.btnCancelarNota_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(76, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(67, 23);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnNovoNota
            // 
            this.btnNovoNota.Location = new System.Drawing.Point(3, 3);
            this.btnNovoNota.Name = "btnNovoNota";
            this.btnNovoNota.Size = new System.Drawing.Size(67, 23);
            this.btnNovoNota.TabIndex = 0;
            this.btnNovoNota.Text = "Novo";
            this.btnNovoNota.UseVisualStyleBackColor = true;
            this.btnNovoNota.Click += new System.EventHandler(this.btnNovoNota_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProdutos);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Location = new System.Drawing.Point(400, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 426);
            this.panel2.TabIndex = 4;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(14, 227);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.Size = new System.Drawing.Size(289, 181);
            this.dgvProdutos.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.BtnRemoverProduto, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnCancelarProduto, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnGravarProduto, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnNovoProduto, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 169);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(293, 42);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // BtnRemoverProduto
            // 
            this.BtnRemoverProduto.Enabled = false;
            this.BtnRemoverProduto.Location = new System.Drawing.Point(222, 3);
            this.BtnRemoverProduto.Name = "BtnRemoverProduto";
            this.BtnRemoverProduto.Size = new System.Drawing.Size(67, 23);
            this.BtnRemoverProduto.TabIndex = 3;
            this.BtnRemoverProduto.Text = "Remover";
            this.BtnRemoverProduto.UseVisualStyleBackColor = true;
            this.BtnRemoverProduto.Click += new System.EventHandler(this.BtnRemoverProduto_Click);
            // 
            // BtnCancelarProduto
            // 
            this.BtnCancelarProduto.Enabled = false;
            this.BtnCancelarProduto.Location = new System.Drawing.Point(149, 3);
            this.BtnCancelarProduto.Name = "BtnCancelarProduto";
            this.BtnCancelarProduto.Size = new System.Drawing.Size(67, 23);
            this.BtnCancelarProduto.TabIndex = 2;
            this.BtnCancelarProduto.Text = "Cancelar";
            this.BtnCancelarProduto.UseVisualStyleBackColor = true;
            this.BtnCancelarProduto.Click += new System.EventHandler(this.BtnCancelarProduto_Click);
            // 
            // BtnGravarProduto
            // 
            this.BtnGravarProduto.Enabled = false;
            this.BtnGravarProduto.Location = new System.Drawing.Point(76, 3);
            this.BtnGravarProduto.Name = "BtnGravarProduto";
            this.BtnGravarProduto.Size = new System.Drawing.Size(67, 23);
            this.BtnGravarProduto.TabIndex = 1;
            this.BtnGravarProduto.Text = "gravar";
            this.BtnGravarProduto.UseVisualStyleBackColor = true;
            this.BtnGravarProduto.Click += new System.EventHandler(this.BtnGravarProduto_Click);
            // 
            // BtnNovoProduto
            // 
            this.BtnNovoProduto.Location = new System.Drawing.Point(3, 3);
            this.BtnNovoProduto.Name = "BtnNovoProduto";
            this.BtnNovoProduto.Size = new System.Drawing.Size(67, 23);
            this.BtnNovoProduto.TabIndex = 0;
            this.BtnNovoProduto.Text = "Novo";
            this.BtnNovoProduto.UseVisualStyleBackColor = true;
            this.BtnNovoProduto.Click += new System.EventHandler(this.Produto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(72, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Produtos comprados";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.txtQuantidade, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.cbxProduto, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtCusto, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtIDProduto, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(14, 49);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.69912F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.23894F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(293, 104);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(149, 79);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(140, 22);
            this.txtQuantidade.TabIndex = 11;
            // 
            // cbxProduto
            // 
            this.cbxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduto.Enabled = false;
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(149, 29);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(141, 24);
            this.cbxProduto.TabIndex = 10;
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.cbxProduto_SelectedIndexChanged);
            // 
            // txtCusto
            // 
            this.txtCusto.Enabled = false;
            this.txtCusto.Location = new System.Drawing.Point(149, 52);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(140, 22);
            this.txtCusto.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Custo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Produto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Id:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Quantidade:";
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Location = new System.Drawing.Point(149, 3);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(140, 22);
            this.txtIDProduto.TabIndex = 5;
            // 
            // FormNotaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormNotaEntrada";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasEntrada)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDNotaEntrada;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.ComboBox cbxFornecedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNotasEntrada;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnRemoverNota;
        private System.Windows.Forms.Button btnCancelarNota;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnNovoNota;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnRemoverProduto;
        private System.Windows.Forms.Button BtnCancelarProduto;
        private System.Windows.Forms.Button BtnGravarProduto;
        private System.Windows.Forms.Button BtnNovoProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDProduto;
    }
}