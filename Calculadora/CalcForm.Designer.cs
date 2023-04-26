
namespace Calculadora
{
    partial class CalcForm
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
            this.WFgpBox = new System.Windows.Forms.GroupBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefazer = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.tblBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.calcGpBox = new System.Windows.Forms.GroupBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.txtOperando = new System.Windows.Forms.TextBox();
            this.WFgpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblBotoes.SuspendLayout();
            this.calcGpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WFgpBox
            // 
            this.WFgpBox.Controls.Add(this.picBox);
            this.WFgpBox.Controls.Add(this.tableLayoutPanel1);
            this.WFgpBox.Controls.Add(this.tblBotoes);
            this.WFgpBox.Controls.Add(this.calcGpBox);
            this.WFgpBox.Location = new System.Drawing.Point(0, -1);
            this.WFgpBox.Name = "WFgpBox";
            this.WFgpBox.Size = new System.Drawing.Size(224, 321);
            this.WFgpBox.TabIndex = 0;
            this.WFgpBox.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBox.Image = global::Calculadora.Properties.Resources.pop_cat;
            this.picBox.Location = new System.Drawing.Point(144, 89);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(65, 50);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 5;
            this.picBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnRefazer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDesfazer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(144, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(65, 66);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnRefazer
            // 
            this.btnRefazer.Enabled = false;
            this.btnRefazer.Location = new System.Drawing.Point(3, 36);
            this.btnRefazer.Name = "btnRefazer";
            this.btnRefazer.Size = new System.Drawing.Size(59, 23);
            this.btnRefazer.TabIndex = 1;
            this.btnRefazer.Text = "Refazer";
            this.btnRefazer.UseVisualStyleBackColor = true;
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.Enabled = false;
            this.btnDesfazer.Location = new System.Drawing.Point(3, 3);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(59, 27);
            this.btnDesfazer.TabIndex = 0;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            // 
            // tblBotoes
            // 
            this.tblBotoes.ColumnCount = 4;
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tblBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblBotoes.Controls.Add(this.btnDot, 2, 3);
            this.tblBotoes.Controls.Add(this.btn0, 1, 3);
            this.tblBotoes.Controls.Add(this.btnDiv, 3, 3);
            this.tblBotoes.Controls.Add(this.btnTimes, 3, 2);
            this.tblBotoes.Controls.Add(this.btnMinus, 3, 1);
            this.tblBotoes.Controls.Add(this.btn3, 2, 0);
            this.tblBotoes.Controls.Add(this.btn2, 1, 0);
            this.tblBotoes.Controls.Add(this.btn1, 0, 0);
            this.tblBotoes.Controls.Add(this.btn4, 0, 1);
            this.tblBotoes.Controls.Add(this.btn5, 1, 1);
            this.tblBotoes.Controls.Add(this.btn6, 2, 1);
            this.tblBotoes.Controls.Add(this.btn7, 0, 2);
            this.tblBotoes.Controls.Add(this.btn8, 1, 2);
            this.tblBotoes.Controls.Add(this.btn9, 2, 2);
            this.tblBotoes.Controls.Add(this.btnEquals, 0, 3);
            this.tblBotoes.Controls.Add(this.btnPlus, 3, 0);
            this.tblBotoes.Location = new System.Drawing.Point(6, 151);
            this.tblBotoes.Name = "tblBotoes";
            this.tblBotoes.RowCount = 4;
            this.tblBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBotoes.Size = new System.Drawing.Size(206, 164);
            this.tblBotoes.TabIndex = 3;
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(93, 126);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(39, 35);
            this.btnDot.TabIndex = 10;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(48, 126);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(39, 35);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(138, 126);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(65, 35);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimes.Location = new System.Drawing.Point(138, 85);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(65, 35);
            this.btnTimes.TabIndex = 14;
            this.btnTimes.Text = "x";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(138, 44);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(65, 35);
            this.btnMinus.TabIndex = 13;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(93, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(39, 35);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(48, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(39, 35);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(39, 35);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 44);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(39, 35);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(48, 44);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(39, 35);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(93, 44);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(39, 35);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 85);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(39, 35);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(48, 85);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(39, 35);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(93, 85);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(39, 35);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(3, 126);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(39, 35);
            this.btnEquals.TabIndex = 9;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(138, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(65, 35);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // calcGpBox
            // 
            this.calcGpBox.Controls.Add(this.lblOp);
            this.calcGpBox.Controls.Add(this.lblEqual);
            this.calcGpBox.Controls.Add(this.txtResultado);
            this.calcGpBox.Controls.Add(this.txtOperador);
            this.calcGpBox.Controls.Add(this.txtOperando);
            this.calcGpBox.Location = new System.Drawing.Point(6, 13);
            this.calcGpBox.Name = "calcGpBox";
            this.calcGpBox.Size = new System.Drawing.Size(128, 132);
            this.calcGpBox.TabIndex = 1;
            this.calcGpBox.TabStop = false;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(53, 42);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 24);
            this.lblOp.TabIndex = 4;
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual.Location = new System.Drawing.Point(6, 102);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(21, 24);
            this.lblEqual.TabIndex = 3;
            this.lblEqual.Text = "=";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(33, 106);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(89, 20);
            this.txtResultado.TabIndex = 2;
            // 
            // txtOperador
            // 
            this.txtOperador.Location = new System.Drawing.Point(6, 69);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(116, 20);
            this.txtOperador.TabIndex = 1;
            this.txtOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOperando
            // 
            this.txtOperando.Location = new System.Drawing.Point(6, 19);
            this.txtOperando.Name = "txtOperando";
            this.txtOperando.Size = new System.Drawing.Size(116, 20);
            this.txtOperando.TabIndex = 0;
            this.txtOperando.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 321);
            this.Controls.Add(this.WFgpBox);
            this.Name = "CalcForm";
            this.Text = "Calculadora";
            this.WFgpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tblBotoes.ResumeLayout(false);
            this.calcGpBox.ResumeLayout(false);
            this.calcGpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WFgpBox;
        private System.Windows.Forms.TableLayoutPanel tblBotoes;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRefazer;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.GroupBox calcGpBox;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.TextBox txtOperando;
        private System.Windows.Forms.Label lblOp;
    }
}

