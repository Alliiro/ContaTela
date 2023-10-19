namespace ContaTela
{
    partial class Form1
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
            this.btnPoupanca = new System.Windows.Forms.Button();
            this.bntInvestimento = new System.Windows.Forms.Button();
            this.pnlTelas = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntInvestimento);
            this.panel1.Controls.Add(this.btnPoupanca);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 703);
            this.panel1.TabIndex = 0;
            // 
            // btnPoupanca
            // 
            this.btnPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoupanca.Location = new System.Drawing.Point(3, 107);
            this.btnPoupanca.Name = "btnPoupanca";
            this.btnPoupanca.Size = new System.Drawing.Size(203, 81);
            this.btnPoupanca.TabIndex = 0;
            this.btnPoupanca.Text = "Poupança";
            this.btnPoupanca.UseVisualStyleBackColor = true;
            this.btnPoupanca.Click += new System.EventHandler(this.btnPoupanca_Click);
            // 
            // bntInvestimento
            // 
            this.bntInvestimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntInvestimento.Location = new System.Drawing.Point(0, 312);
            this.bntInvestimento.Name = "bntInvestimento";
            this.bntInvestimento.Size = new System.Drawing.Size(222, 76);
            this.bntInvestimento.TabIndex = 1;
            this.bntInvestimento.Text = "Investimento";
            this.bntInvestimento.UseVisualStyleBackColor = true;
            this.bntInvestimento.Click += new System.EventHandler(this.bntInvestimento_Click);
            // 
            // pnlTelas
            // 
            this.pnlTelas.Location = new System.Drawing.Point(277, 3);
            this.pnlTelas.Name = "pnlTelas";
            this.pnlTelas.Size = new System.Drawing.Size(1060, 703);
            this.pnlTelas.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1831, 734);
            this.Controls.Add(this.pnlTelas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntInvestimento;
        private System.Windows.Forms.Button btnPoupanca;
        private System.Windows.Forms.Panel pnlTelas;
    }
}

