namespace Criptografias
{
    partial class Resultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPalavra = new System.Windows.Forms.Label();
            this.labelCesar = new System.Windows.Forms.Label();
            this.labelZP = new System.Windows.Forms.Label();
            this.labelR13 = new System.Windows.Forms.Label();
            this.labelVigenere = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPalavra
            // 
            this.labelPalavra.AutoSize = true;
            this.labelPalavra.Location = new System.Drawing.Point(37, 45);
            this.labelPalavra.Name = "labelPalavra";
            this.labelPalavra.Size = new System.Drawing.Size(161, 45);
            this.labelPalavra.TabIndex = 0;
            this.labelPalavra.Text = "Sua Palavra: ";
            // 
            // labelCesar
            // 
            this.labelCesar.AutoSize = true;
            this.labelCesar.Location = new System.Drawing.Point(37, 90);
            this.labelCesar.Name = "labelCesar";
            this.labelCesar.Size = new System.Drawing.Size(185, 45);
            this.labelCesar.TabIndex = 1;
            this.labelCesar.Text = "Cifra de César: ";
            // 
            // labelZP
            // 
            this.labelZP.AutoSize = true;
            this.labelZP.Location = new System.Drawing.Point(37, 135);
            this.labelZP.Name = "labelZP";
            this.labelZP.Size = new System.Drawing.Size(153, 45);
            this.labelZP.TabIndex = 2;
            this.labelZP.Text = "Zenit Polar: ";
            // 
            // labelR13
            // 
            this.labelR13.AutoSize = true;
            this.labelR13.Location = new System.Drawing.Point(37, 180);
            this.labelR13.Name = "labelR13";
            this.labelR13.Size = new System.Drawing.Size(134, 45);
            this.labelR13.TabIndex = 3;
            this.labelR13.Text = "Route 13: ";
            // 
            // labelVigenere
            // 
            this.labelVigenere.AutoSize = true;
            this.labelVigenere.Location = new System.Drawing.Point(37, 225);
            this.labelVigenere.Name = "labelVigenere";
            this.labelVigenere.Size = new System.Drawing.Size(222, 45);
            this.labelVigenere.TabIndex = 4;
            this.labelVigenere.Text = "Cifra de Vigenère: ";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(228, 283);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 51);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 355);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.labelVigenere);
            this.Controls.Add(this.labelR13);
            this.Controls.Add(this.labelZP);
            this.Controls.Add(this.labelCesar);
            this.Controls.Add(this.labelPalavra);
            this.Font = new System.Drawing.Font("Dubai", 16.2F);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPalavra;
        private System.Windows.Forms.Label labelCesar;
        private System.Windows.Forms.Label labelZP;
        private System.Windows.Forms.Label labelR13;
        private System.Windows.Forms.Label labelVigenere;
        private System.Windows.Forms.Button btnSair;
    }
}