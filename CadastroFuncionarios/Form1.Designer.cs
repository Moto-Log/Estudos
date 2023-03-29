
namespace CadastroFuncionarios
{
    partial class CriacaoDeArquivo
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
            this.lblNrFunc = new System.Windows.Forms.Label();
            this.txtNrFuncionarios = new System.Windows.Forms.TextBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnCriarLinha = new System.Windows.Forms.Button();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.sfdCriarArquivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNrFunc
            // 
            this.lblNrFunc.AutoSize = true;
            this.lblNrFunc.Location = new System.Drawing.Point(9, 6);
            this.lblNrFunc.Name = "lblNrFunc";
            this.lblNrFunc.Size = new System.Drawing.Size(99, 13);
            this.lblNrFunc.TabIndex = 0;
            this.lblNrFunc.Text = "Nr. de funcionarios:";
            // 
            // txtNrFuncionarios
            // 
            this.txtNrFuncionarios.Location = new System.Drawing.Point(114, 3);
            this.txtNrFuncionarios.Name = "txtNrFuncionarios";
            this.txtNrFuncionarios.Size = new System.Drawing.Size(77, 20);
            this.txtNrFuncionarios.TabIndex = 1;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(12, 29);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(321, 187);
            this.dgvFuncionarios.TabIndex = 2;
            // 
            // btnCriarLinha
            // 
            this.btnCriarLinha.Location = new System.Drawing.Point(197, 1);
            this.btnCriarLinha.Name = "btnCriarLinha";
            this.btnCriarLinha.Size = new System.Drawing.Size(136, 23);
            this.btnCriarLinha.TabIndex = 3;
            this.btnCriarLinha.Text = "Criar linha para registro";
            this.btnCriarLinha.UseVisualStyleBackColor = true;
            this.btnCriarLinha.Click += new System.EventHandler(this.btnCriarLinha_Click);
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Enabled = false;
            this.btnCriarArquivo.Location = new System.Drawing.Point(12, 222);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(202, 23);
            this.btnCriarArquivo.TabIndex = 4;
            this.btnCriarArquivo.Text = "Criar arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(220, 222);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(113, 23);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // sfdCriarArquivo
            // 
            this.sfdCriarArquivo.DefaultExt = "*.txt";
            this.sfdCriarArquivo.Filter = "Arquivos textos|*.txt";
            this.sfdCriarArquivo.Title = "Dados para geração de arquivo";
            // 
            // CriacaoDeArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 249);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.btnCriarLinha);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.txtNrFuncionarios);
            this.Controls.Add(this.lblNrFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CriacaoDeArquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados para geração de arquivo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNrFunc;
        private System.Windows.Forms.TextBox txtNrFuncionarios;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Button btnCriarLinha;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.SaveFileDialog sfdCriarArquivo;
    }
}

