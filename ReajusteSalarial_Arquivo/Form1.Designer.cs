
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPnReajuste = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.lblPercentualReajuste = new System.Windows.Forms.Label();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.tbPnReajuste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(219, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 89);
            this.panel1.TabIndex = 0;
            // 
            // tbPnReajuste
            // 
            this.tbPnReajuste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbPnReajuste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPnReajuste.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tbPnReajuste.ColumnCount = 3;
            this.tbPnReajuste.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.96644F));
            this.tbPnReajuste.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.03356F));
            this.tbPnReajuste.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tbPnReajuste.Controls.Add(this.lblPercentualReajuste, 2, 0);
            this.tbPnReajuste.Controls.Add(this.lblTotalSemReajuste, 0, 0);
            this.tbPnReajuste.Controls.Add(this.lblTotalComReajuste, 1, 0);
            this.tbPnReajuste.Location = new System.Drawing.Point(12, 35);
            this.tbPnReajuste.Name = "tbPnReajuste";
            this.tbPnReajuste.RowCount = 2;
            this.tbPnReajuste.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPnReajuste.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPnReajuste.Size = new System.Drawing.Size(423, 33);
            this.tbPnReajuste.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
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
            // lblPercentualReajuste
            // 
            this.lblPercentualReajuste.AutoSize = true;
            this.lblPercentualReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblPercentualReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualReajuste.Location = new System.Drawing.Point(284, 2);
            this.lblPercentualReajuste.Name = "lblPercentualReajuste";
            this.lblPercentualReajuste.Size = new System.Drawing.Size(122, 13);
            this.lblPercentualReajuste.TabIndex = 8;
            this.lblPercentualReajuste.Text = "Percentual Reajuste";
            this.lblPercentualReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.AutoSize = true;
            this.lblTotalComReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalComReajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComReajuste.Location = new System.Drawing.Point(131, 2);
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPnReajuste);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "reajustecomarquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitura de arquivo para reajuste salarial";
            this.tbPnReajuste.ResumeLayout(false);
            this.tbPnReajuste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbPnReajuste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPercentualReajuste;
        private System.Windows.Forms.Label lblTotalComReajuste;
    }
}

