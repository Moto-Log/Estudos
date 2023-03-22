
namespace ReajusteSalarial
{
    partial class ReajusteSalarial
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.bxCategoria = new System.Windows.Forms.GroupBox();
            this.rdVeterano = new System.Windows.Forms.RadioButton();
            this.rdCalouro = new System.Windows.Forms.RadioButton();
            this.bxTurno = new System.Windows.Forms.GroupBox();
            this.rdNoturno = new System.Windows.Forms.RadioButton();
            this.rdVerpestino = new System.Windows.Forms.RadioButton();
            this.rdMatutino = new System.Windows.Forms.RadioButton();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dica = new System.Windows.Forms.ToolTip(this.components);
            this.bxCategoria.SuspendLayout();
            this.bxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 16);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(78, 13);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Salário Minimo:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(12, 40);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(100, 13);
            this.lblHoras.TabIndex = 1;
            this.lblHoras.Text = "Horas Trabalhadas:";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(118, 37);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(103, 20);
            this.txtHoras.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(118, 13);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(103, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // txtSituacao
            // 
            this.txtSituacao.BackColor = System.Drawing.Color.Yellow;
            this.txtSituacao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSituacao.Location = new System.Drawing.Point(27, 220);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(182, 20);
            this.txtSituacao.TabIndex = 4;
            this.txtSituacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bxCategoria
            // 
            this.bxCategoria.Controls.Add(this.rdVeterano);
            this.bxCategoria.Controls.Add(this.rdCalouro);
            this.bxCategoria.Location = new System.Drawing.Point(15, 70);
            this.bxCategoria.Name = "bxCategoria";
            this.bxCategoria.Size = new System.Drawing.Size(206, 42);
            this.bxCategoria.TabIndex = 5;
            this.bxCategoria.TabStop = false;
            this.bxCategoria.Text = "Categoria";
            // 
            // rdVeterano
            // 
            this.rdVeterano.AutoSize = true;
            this.rdVeterano.Location = new System.Drawing.Point(117, 19);
            this.rdVeterano.Name = "rdVeterano";
            this.rdVeterano.Size = new System.Drawing.Size(68, 17);
            this.rdVeterano.TabIndex = 1;
            this.rdVeterano.TabStop = true;
            this.rdVeterano.Text = "Veterano";
            this.rdVeterano.UseVisualStyleBackColor = true;
            // 
            // rdCalouro
            // 
            this.rdCalouro.AutoSize = true;
            this.rdCalouro.Location = new System.Drawing.Point(14, 19);
            this.rdCalouro.Name = "rdCalouro";
            this.rdCalouro.Size = new System.Drawing.Size(61, 17);
            this.rdCalouro.TabIndex = 0;
            this.rdCalouro.TabStop = true;
            this.rdCalouro.Text = "Calouro";
            this.rdCalouro.UseVisualStyleBackColor = true;
            // 
            // bxTurno
            // 
            this.bxTurno.Controls.Add(this.rdNoturno);
            this.bxTurno.Controls.Add(this.rdVerpestino);
            this.bxTurno.Controls.Add(this.rdMatutino);
            this.bxTurno.Location = new System.Drawing.Point(231, 12);
            this.bxTurno.Name = "bxTurno";
            this.bxTurno.Size = new System.Drawing.Size(95, 100);
            this.bxTurno.TabIndex = 6;
            this.bxTurno.TabStop = false;
            this.bxTurno.Text = "Turno";
            // 
            // rdNoturno
            // 
            this.rdNoturno.AutoSize = true;
            this.rdNoturno.Location = new System.Drawing.Point(6, 70);
            this.rdNoturno.Name = "rdNoturno";
            this.rdNoturno.Size = new System.Drawing.Size(63, 17);
            this.rdNoturno.TabIndex = 3;
            this.rdNoturno.TabStop = true;
            this.rdNoturno.Text = "Noturno";
            this.rdNoturno.UseVisualStyleBackColor = true;
            // 
            // rdVerpestino
            // 
            this.rdVerpestino.AutoSize = true;
            this.rdVerpestino.Location = new System.Drawing.Point(6, 47);
            this.rdVerpestino.Name = "rdVerpestino";
            this.rdVerpestino.Size = new System.Drawing.Size(75, 17);
            this.rdVerpestino.TabIndex = 2;
            this.rdVerpestino.TabStop = true;
            this.rdVerpestino.Text = "Vespertino";
            this.rdVerpestino.UseVisualStyleBackColor = true;
            // 
            // rdMatutino
            // 
            this.rdMatutino.AutoSize = true;
            this.rdMatutino.Location = new System.Drawing.Point(6, 24);
            this.rdMatutino.Name = "rdMatutino";
            this.rdMatutino.Size = new System.Drawing.Size(66, 17);
            this.rdMatutino.TabIndex = 1;
            this.rdMatutino.TabStop = true;
            this.rdMatutino.Text = "Matutino";
            this.rdMatutino.UseVisualStyleBackColor = true;
            // 
            // lbxResumo
            // 
            this.lbxResumo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.ItemHeight = 14;
            this.lbxResumo.Location = new System.Drawing.Point(12, 119);
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.Size = new System.Drawing.Size(314, 88);
            this.lbxResumo.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(221, 218);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dica
            // 
            this.dica.IsBalloon = true;
            this.dica.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dica.ToolTipTitle = "Ajuda";
            // 
            // ReajusteSalarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 251);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.bxTurno);
            this.Controls.Add(this.bxCategoria);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblSalario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ReajusteSalarial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Salário";
            this.bxCategoria.ResumeLayout(false);
            this.bxCategoria.PerformLayout();
            this.bxTurno.ResumeLayout(false);
            this.bxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.GroupBox bxCategoria;
        private System.Windows.Forms.RadioButton rdVeterano;
        private System.Windows.Forms.RadioButton rdCalouro;
        private System.Windows.Forms.GroupBox bxTurno;
        private System.Windows.Forms.RadioButton rdNoturno;
        private System.Windows.Forms.RadioButton rdVerpestino;
        private System.Windows.Forms.RadioButton rdMatutino;
        private System.Windows.Forms.ListBox lbxResumo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ToolTip dica;
    }
}

