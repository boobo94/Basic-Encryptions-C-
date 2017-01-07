namespace CriptareCaesar
{
    partial class Main
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
            this.btn_caesar = new System.Windows.Forms.Button();
            this.btn_polybios = new System.Windows.Forms.Button();
            this.playfair = new System.Windows.Forms.Button();
            this.btn_vigenere = new System.Windows.Forms.Button();
            this.btn_transpozition = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_caesar
            // 
            this.btn_caesar.Location = new System.Drawing.Point(32, 26);
            this.btn_caesar.Name = "btn_caesar";
            this.btn_caesar.Size = new System.Drawing.Size(75, 23);
            this.btn_caesar.TabIndex = 0;
            this.btn_caesar.Text = "Caesar";
            this.btn_caesar.UseVisualStyleBackColor = true;
            this.btn_caesar.Click += new System.EventHandler(this.btn_caesar_Click);
            // 
            // btn_polybios
            // 
            this.btn_polybios.Location = new System.Drawing.Point(174, 26);
            this.btn_polybios.Name = "btn_polybios";
            this.btn_polybios.Size = new System.Drawing.Size(75, 23);
            this.btn_polybios.TabIndex = 1;
            this.btn_polybios.Text = "Polybios";
            this.btn_polybios.UseVisualStyleBackColor = true;
            this.btn_polybios.Click += new System.EventHandler(this.btn_polybios_Click);
            // 
            // playfair
            // 
            this.playfair.Location = new System.Drawing.Point(32, 65);
            this.playfair.Name = "playfair";
            this.playfair.Size = new System.Drawing.Size(75, 23);
            this.playfair.TabIndex = 2;
            this.playfair.Text = "Playfair";
            this.playfair.UseVisualStyleBackColor = true;
            this.playfair.Click += new System.EventHandler(this.playfair_Click);
            // 
            // btn_vigenere
            // 
            this.btn_vigenere.Location = new System.Drawing.Point(174, 65);
            this.btn_vigenere.Name = "btn_vigenere";
            this.btn_vigenere.Size = new System.Drawing.Size(75, 23);
            this.btn_vigenere.TabIndex = 3;
            this.btn_vigenere.Text = "Vigenere";
            this.btn_vigenere.UseVisualStyleBackColor = true;
            this.btn_vigenere.Click += new System.EventHandler(this.btn_vigenere_Click);
            // 
            // btn_transpozition
            // 
            this.btn_transpozition.Location = new System.Drawing.Point(32, 106);
            this.btn_transpozition.Name = "btn_transpozition";
            this.btn_transpozition.Size = new System.Drawing.Size(75, 23);
            this.btn_transpozition.TabIndex = 4;
            this.btn_transpozition.Text = "Transpozition";
            this.btn_transpozition.UseVisualStyleBackColor = true;
            this.btn_transpozition.Click += new System.EventHandler(this.btn_transpozition_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(142, 239);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bogdan Alexandru Militaru";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_transpozition);
            this.Controls.Add(this.btn_vigenere);
            this.Controls.Add(this.playfair);
            this.Controls.Add(this.btn_polybios);
            this.Controls.Add(this.btn_caesar);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_caesar;
        private System.Windows.Forms.Button btn_polybios;
        private System.Windows.Forms.Button playfair;
        private System.Windows.Forms.Button btn_vigenere;
        private System.Windows.Forms.Button btn_transpozition;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}