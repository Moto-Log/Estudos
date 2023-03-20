
namespace RestoDaDivisao
{
    partial class RestoDiv
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
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.lblDividendo = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.btnResto = new System.Windows.Forms.Button();
            this.lblResto = new System.Windows.Forms.Label();
            this.txtResto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(73, 13);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(59, 20);
            this.txtDividendo.TabIndex = 0;
            // 
            // txtDivisor
            // 
            this.txtDivisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDivisor.Location = new System.Drawing.Point(190, 13);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(59, 20);
            this.txtDivisor.TabIndex = 1;
            this.txtDivisor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDivisor_KeyDown);
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(12, 16);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(58, 13);
            this.lblDividendo.TabIndex = 2;
            this.lblDividendo.Text = "Dividendo:";
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(142, 16);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(42, 13);
            this.lblDivisor.TabIndex = 3;
            this.lblDivisor.Text = "Divisor:";
            // 
            // btnResto
            // 
            this.btnResto.BackColor = System.Drawing.Color.White;
            this.btnResto.Location = new System.Drawing.Point(24, 49);
            this.btnResto.Name = "btnResto";
            this.btnResto.Size = new System.Drawing.Size(108, 23);
            this.btnResto.TabIndex = 4;
            this.btnResto.Text = "Realizar Divisão";
            this.btnResto.UseVisualStyleBackColor = false;
            this.btnResto.Click += new System.EventHandler(this.btnResto_Click);
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Location = new System.Drawing.Point(149, 54);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(38, 13);
            this.lblResto.TabIndex = 5;
            this.lblResto.Text = "Resto:";
            // 
            // txtResto
            // 
            this.txtResto.BackColor = System.Drawing.SystemColors.Window;
            this.txtResto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResto.Location = new System.Drawing.Point(190, 52);
            this.txtResto.Name = "txtResto";
            this.txtResto.Size = new System.Drawing.Size(59, 20);
            this.txtResto.TabIndex = 6;
            // 
            // RestoDiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(273, 84);
            this.Controls.Add(this.txtResto);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.btnResto);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.lblDividendo);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.txtDividendo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RestoDiv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resto da Divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Button btnResto;
        private System.Windows.Forms.Label lblResto;
        private System.Windows.Forms.TextBox txtResto;
    }
}

