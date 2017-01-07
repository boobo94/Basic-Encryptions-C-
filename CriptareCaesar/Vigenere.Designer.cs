namespace CriptareCaesar
{
    partial class Vigenere
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
            this.cb_alphabet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_encrypted = new System.Windows.Forms.TextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_alphabet
            // 
            this.cb_alphabet.FormattingEnabled = true;
            this.cb_alphabet.Items.AddRange(new object[] {
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            " .,;!?ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            " .,;!?ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"});
            this.cb_alphabet.Location = new System.Drawing.Point(13, 31);
            this.cb_alphabet.Name = "cb_alphabet";
            this.cb_alphabet.Size = new System.Drawing.Size(259, 21);
            this.cb_alphabet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alphabet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(13, 90);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(259, 20);
            this.tb_message.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(13, 144);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(259, 20);
            this.tb_password.TabIndex = 5;
            this.tb_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Encrypted";
            // 
            // tb_encrypted
            // 
            this.tb_encrypted.Location = new System.Drawing.Point(13, 199);
            this.tb_encrypted.Name = "tb_encrypted";
            this.tb_encrypted.Size = new System.Drawing.Size(259, 20);
            this.tb_encrypted.TabIndex = 7;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(13, 226);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_encrypt.TabIndex = 8;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(197, 226);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_decrypt.TabIndex = 9;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = false;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // Vigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.tb_encrypted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_alphabet);
            this.Name = "Vigenere";
            this.Text = "Vigenere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_alphabet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_encrypted;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
    }
}