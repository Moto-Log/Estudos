
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCriarLinha = new System.Windows.Forms.Button();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(321, 187);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnCriarLinha
            // 
            this.btnCriarLinha.Location = new System.Drawing.Point(197, 1);
            this.btnCriarLinha.Name = "btnCriarLinha";
            this.btnCriarLinha.Size = new System.Drawing.Size(136, 23);
            this.btnCriarLinha.TabIndex = 3;
            this.btnCriarLinha.Text = "Criar linha para registro";
            this.btnCriarLinha.UseVisualStyleBackColor = true;
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Location = new System.Drawing.Point(12, 222);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(202, 23);
            this.btnCriarArquivo.TabIndex = 4;
            this.btnCriarArquivo.Text = "Criar arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(220, 222);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(113, 23);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // CriacaoDeArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 249);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.btnCriarLinha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNrFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CriacaoDeArquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados para geração de arquivo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNrFunc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCriarLinha;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

