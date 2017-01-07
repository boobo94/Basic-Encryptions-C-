namespace CriptareCaesar
{
    partial class Caesar
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
            this.tb_key = new System.Windows.Forms.TextBox();
            this.tb_plainText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cyperText = new System.Windows.Forms.TextBox();
            this.btn_encryt = new System.Windows.Forms.Button();
            this.btn_decryt = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_alphabet
            // 
            this.cb_alphabet.FormattingEnabled = true;
            this.cb_alphabet.Items.AddRange(new object[] {
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            " .,;!?ABCDEFGHIJKLMNOPQRSTUVWXYZ",
            " .,;!?ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"});
            this.cb_alphabet.Location = new System.Drawing.Point(12, 31);
            this.cb_alphabet.Name = "cb_alphabet";
            this.cb_alphabet.Size = new System.Drawing.Size(260, 21);
            this.cb_alphabet.TabIndex = 0;
            this.cb_alphabet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alphabet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(13, 81);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(100, 20);
            this.tb_key.TabIndex = 3;
            // 
            // tb_plainText
            // 
            this.tb_plainText.Location = new System.Drawing.Point(13, 125);
            this.tb_plainText.Name = "tb_plainText";
            this.tb_plainText.Size = new System.Drawing.Size(259, 20);
            this.tb_plainText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plain Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Encrypted/Decrypted Text";
            // 
            // tb_cyperText
            // 
            this.tb_cyperText.Location = new System.Drawing.Point(12, 176);
            this.tb_cyperText.Name = "tb_cyperText";
            this.tb_cyperText.Size = new System.Drawing.Size(260, 20);
            this.tb_cyperText.TabIndex = 7;
            // 
            // btn_encryt
            // 
            this.btn_encryt.Location = new System.Drawing.Point(12, 226);
            this.btn_encryt.Name = "btn_encryt";
            this.btn_encryt.Size = new System.Drawing.Size(131, 23);
            this.btn_encryt.TabIndex = 8;
            this.btn_encryt.Text = "Encrypt";
            this.btn_encryt.UseVisualStyleBackColor = true;
            this.btn_encryt.Click += new System.EventHandler(this.btn_encryt_Click);
            // 
            // btn_decryt
            // 
            this.btn_decryt.Location = new System.Drawing.Point(149, 226);
            this.btn_decryt.Name = "btn_decryt";
            this.btn_decryt.Size = new System.Drawing.Size(123, 23);
            this.btn_decryt.TabIndex = 9;
            this.btn_decryt.Text = "Decrypt";
            this.btn_decryt.UseVisualStyleBackColor = true;
            this.btn_decryt.Click += new System.EventHandler(this.btn_decryt_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(149, 81);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // Caesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.btn_decryt);
            this.Controls.Add(this.btn_encryt);
            this.Controls.Add(this.tb_cyperText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_plainText);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_alphabet);
            this.Name = "Caesar";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Caesar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_alphabet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.TextBox tb_plainText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cyperText;
        private System.Windows.Forms.Button btn_encryt;
        private System.Windows.Forms.Button btn_decryt;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label5;
    }
}

