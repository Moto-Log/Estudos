
namespace PesoIdeal
{
    partial class calculaPesoIdeal
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
            this.bxSexo = new System.Windows.Forms.GroupBox();
            this.rdBtnMasculino = new System.Windows.Forms.RadioButton();
            this.rdBtnFeminino = new System.Windows.Forms.RadioButton();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.bxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bxSexo
            // 
            this.bxSexo.Controls.Add(this.rdBtnFeminino);
            this.bxSexo.Controls.Add(this.rdBtnMasculino);
            this.bxSexo.Location = new System.Drawing.Point(12, 12);
            this.bxSexo.Name = "bxSexo";
            this.bxSexo.Size = new System.Drawing.Size(165, 47);
            this.bxSexo.TabIndex = 0;
            this.bxSexo.TabStop = false;
            this.bxSexo.Text = "Sexo";
            // 
            // rdBtnMasculino
            // 
            this.rdBtnMasculino.AutoSize = true;
            this.rdBtnMasculino.Location = new System.Drawing.Point(6, 19);
            this.rdBtnMasculino.Name = "rdBtnMasculino";
            this.rdBtnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdBtnMasculino.TabIndex = 0;
            this.rdBtnMasculino.TabStop = true;
            this.rdBtnMasculino.Text = "Masculino";
            this.rdBtnMasculino.UseVisualStyleBackColor = true;
            this.rdBtnMasculino.CheckedChanged += new System.EventHandler(this.rbnMasculino_CheckedChanged);
            // 
            // rdBtnFeminino
            // 
            this.rdBtnFeminino.AutoSize = true;
            this.rdBtnFeminino.Location = new System.Drawing.Point(85, 19);
            this.rdBtnFeminino.Name = "rdBtnFeminino";
            this.rdBtnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdBtnFeminino.TabIndex = 1;
            this.rdBtnFeminino.TabStop = true;
            this.rdBtnFeminino.Text = "Feminino";
            this.rdBtnFeminino.UseVisualStyleBackColor = true;
            this.rdBtnFeminino.CheckedChanged += new System.EventHandler(this.rbnMasculino_CheckedChanged);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(193, 12);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura:";
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Location = new System.Drawing.Point(94, 62);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(56, 13);
            this.lblPesoIdeal.TabIndex = 2;
            this.lblPesoIdeal.Text = "Peso ideal";
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.Red;
            this.lblPeso.Location = new System.Drawing.Point(93, 75);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(0, 20);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(196, 31);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(73, 20);
            this.txtAltura.TabIndex = 4;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // calculaPesoIdeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 117);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.bxSexo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "calculaPesoIdeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular peso ideal";
            this.Activated += new System.EventHandler(this.calculaPesoIdeal_Activated);
            this.bxSexo.ResumeLayout(false);
            this.bxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bxSexo;
        private System.Windows.Forms.RadioButton rdBtnFeminino;
        private System.Windows.Forms.RadioButton rdBtnMasculino;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtAltura;
    }
}

