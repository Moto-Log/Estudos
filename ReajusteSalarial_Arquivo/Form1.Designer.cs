
namespace ReajusteSalarial_Arquivo
{
    partial class reajustecomarquivo
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
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.dgvReajuste = new System.Windows.Forms.DataGridView();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.tbPnReajuste = new System.Windows.Forms.TableLayoutPanel();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblPercentualReajuste = new System.Windows.Forms.Label();
            this.lblComReajuste = new System.Windows.Forms.Label();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.lblSemReajuste = new System.Windows.Forms.Label();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReajuste)).BeginInit();
            this.tbPnReajuste.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArquivo
            // 
            this.txtArquivo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtArquivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(12, 9);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(385, 20);
            this.txtArquivo.TabIndex = 3;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(403, 7);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(32, 23);
            this.btnPesquisa.TabIndex = 4;
            this.btnPesquisa.Text = "...";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // dgvReajuste
            // 
            this.dgvReajuste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReajuste.Location = new System.Drawing.Point(5, 74);
            this.dgvReajuste.Name = "dgvReajuste";
            this.dgvReajuste.Size = new System.Drawing.Size(430, 240);
            this.dgvReajuste.TabIndex = 5;
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.Filter = "Arquivos Textos|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção do arquivo com dados de funcionarios";
            // 
            // tbPnReajuste
            // 
            this.tbPnReajuste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbPnReajuste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPnReajuste.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tbPnReajuste.ColumnCount = 3;
            this.tbPnReajuste.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.1832F));
            this.tbPnReajuste.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.8168F));
            this.tbPnReajuste.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tbPnReajuste.Controls.Add(this.lblPercent, 2, 1);
            this.tbPnReajuste.Controls.Add(this.lblPercentualReajuste, 2, 0);
            this.tbPnReajuste.Controls.Add(this.lblComReajuste, 1, 1);
            this.tbPnReajuste.Controls.Add(this.lblTotalSemReajuste, 0, 0);
            this.tbPnReajuste.Controls.Add(this.lblSemReajuste, 0, 1);
            this.tbPnReajuste.Controls.Add(this.lblTotalComReajuste, 1, 0);
            this.tbPnReajuste.Location = new System.Drawing.Point(12, 35);
            this.tbPnReajuste.Name = "tbPnReajuste";
            this.tbPnReajuste.RowCount = 2;
            this.tbPnReajuste.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPnReajuste.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPnReajuste.Size = new System.Drawing.Size(423, 33);
            this.tbPnReajuste.TabIndex = 1;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(283, 17);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(0, 13);
            this.lblPercent.TabIndex = 7;
            // 
            // lblPercentualReajuste
            // 
            this.lblPercentualReajuste.AutoSize = true;
            this.lblPercentualReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblPercentualReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualReajuste.Location = new System.Drawing.Point(283, 2);
            this.lblPercentualReajuste.Name = "lblPercentualReajuste";
            this.lblPercentualReajuste.Size = new System.Drawing.Size(122, 13);
            this.lblPercentualReajuste.TabIndex = 8;
            this.lblPercentualReajuste.Text = "Percentual Reajuste";
            this.lblPercentualReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComReajuste
            // 
            this.lblComReajuste.AutoSize = true;
            this.lblComReajuste.Location = new System.Drawing.Point(134, 17);
            this.lblComReajuste.Name = "lblComReajuste";
            this.lblComReajuste.Size = new System.Drawing.Size(0, 13);
            this.lblComReajuste.TabIndex = 6;
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.AutoSize = true;
            this.lblTotalSemReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalSemReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(5, 2);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(111, 13);
            this.lblTotalSemReajuste.TabIndex = 8;
            this.lblTotalSemReajuste.Text = "Total sem reajuste";
            this.lblTotalSemReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSemReajuste
            // 
            this.lblSemReajuste.AutoSize = true;
            this.lblSemReajuste.Location = new System.Drawing.Point(5, 17);
            this.lblSemReajuste.Name = "lblSemReajuste";
            this.lblSemReajuste.Size = new System.Drawing.Size(0, 13);
            this.lblSemReajuste.TabIndex = 2;
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.AutoSize = true;
            this.lblTotalComReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalComReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComReajuste.Location = new System.Drawing.Point(134, 2);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(126, 13);
            this.lblTotalComReajuste.TabIndex = 9;
            this.lblTotalComReajuste.Text = "Total com reajuste";
            this.lblTotalComReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reajustecomarquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 326);
            this.Controls.Add(this.tbPnReajuste);
            this.Controls.Add(this.dgvReajuste);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtArquivo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "reajustecomarquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitura de arquivo para reajuste salarial";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReajuste)).EndInit();
            this.tbPnReajuste.ResumeLayout(false);
            this.tbPnReajuste.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DataGridView dgvReajuste;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
        private System.Windows.Forms.TableLayoutPanel tbPnReajuste;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblPercentualReajuste;
        private System.Windows.Forms.Label lblComReajuste;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.Label lblSemReajuste;
        private System.Windows.Forms.Label lblTotalComReajuste;
    }
}

