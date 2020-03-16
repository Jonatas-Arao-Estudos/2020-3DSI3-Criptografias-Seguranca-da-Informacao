namespace Criptografias
{
    partial class Criptografia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVigenere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCesar = new System.Windows.Forms.TextBox();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criptografias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sua Palavra";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(168, 82);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(471, 53);
            this.txtPalavra.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chave - Vigenère";
            // 
            // txtVigenere
            // 
            this.txtVigenere.Location = new System.Drawing.Point(215, 143);
            this.txtVigenere.Name = "txtVigenere";
            this.txtVigenere.Size = new System.Drawing.Size(424, 53);
            this.txtVigenere.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 48);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chave - Cesar";
            // 
            // txtCesar
            // 
            this.txtCesar.Location = new System.Drawing.Point(189, 205);
            this.txtCesar.Name = "txtCesar";
            this.txtCesar.Size = new System.Drawing.Size(450, 53);
            this.txtCesar.TabIndex = 6;
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(215, 273);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(211, 54);
            this.btnCriptografar.TabIndex = 7;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.BtnCriptografar_Click);
            // 
            // Criptografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 372);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.txtCesar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVigenere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "Criptografia";
            this.Text = "Criptografias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVigenere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCesar;
        private System.Windows.Forms.Button btnCriptografar;
    }
}

