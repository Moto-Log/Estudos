
namespace RegistroConsumoEnergia
{
    partial class RegistroConsumoDeEnergia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNumeroCasa = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.txtNrCasa = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnProcessarDados = new System.Windows.Forms.Button();
            this.dgvLeituras = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalSemDesconto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroCasa
            // 
            this.lblNumeroCasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroCasa.AutoSize = true;
            this.lblNumeroCasa.Location = new System.Drawing.Point(9, 21);
            this.lblNumeroCasa.Name = "lblNumeroCasa";
            this.lblNumeroCasa.Size = new System.Drawing.Size(43, 13);
            this.lblNumeroCasa.TabIndex = 0;
            this.lblNumeroCasa.Text = "nr.Casa";
            // 
            // lblConsumo
            // 
            this.lblConsumo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(134, 24);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(51, 13);
            this.lblConsumo.TabIndex = 1;
            this.lblConsumo.Text = "Consumo";
            // 
            // txtNrCasa
            // 
            this.txtNrCasa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNrCasa.Location = new System.Drawing.Point(58, 18);
            this.txtNrCasa.Name = "txtNrCasa";
            this.txtNrCasa.Size = new System.Drawing.Size(70, 20);
            this.txtNrCasa.TabIndex = 2;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConsumo.Location = new System.Drawing.Point(191, 21);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(73, 20);
            this.txtConsumo.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.Location = new System.Drawing.Point(270, 22);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnProcessarDados
            // 
            this.btnProcessarDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProcessarDados.Location = new System.Drawing.Point(12, 250);
            this.btnProcessarDados.Name = "btnProcessarDados";
            this.btnProcessarDados.Size = new System.Drawing.Size(75, 23);
            this.btnProcessarDados.TabIndex = 5;
            this.btnProcessarDados.Text = "Processar";
            this.btnProcessarDados.UseVisualStyleBackColor = true;
            this.btnProcessarDados.Click += new System.EventHandler(this.btnProcessarDados_Click);
            // 
            // dgvLeituras
            // 
            this.dgvLeituras.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeituras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLeituras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeituras.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLeituras.Location = new System.Drawing.Point(12, 51);
            this.dgvLeituras.Name = "dgvLeituras";
            this.dgvLeituras.Size = new System.Drawing.Size(332, 179);
            this.dgvLeituras.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(120, 255);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(158, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total de consumo com Desonto";
            // 
            // lblTotalSemDesconto
            // 
            this.lblTotalSemDesconto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalSemDesconto.AutoSize = true;
            this.lblTotalSemDesconto.Location = new System.Drawing.Point(297, 255);
            this.lblTotalSemDesconto.Name = "lblTotalSemDesconto";
            this.lblTotalSemDesconto.Size = new System.Drawing.Size(0, 13);
            this.lblTotalSemDesconto.TabIndex = 8;
            // 
            // RegistroConsumoDeEnergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 292);
            this.Controls.Add(this.lblTotalSemDesconto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvLeituras);
            this.Controls.Add(this.btnProcessarDados);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtNrCasa);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblNumeroCasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistroConsumoDeEnergia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de consumo de Energia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroCasa;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox txtNrCasa;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnProcessarDados;
        private System.Windows.Forms.DataGridView dgvLeituras;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalSemDesconto;
    }
}

