using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptareCaesar
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        
        private Caesar caesarForm;
        private void btn_caesar_Click(object sender, EventArgs e)
        {
            caesarForm = new Caesar();

            caesarForm.Top = this.Top;
            caesarForm.Left = this.Left;
            caesarForm.Size = this.Size;
            caesarForm.Show();

            this.Hide();
        }

        private Polybios polybiosForm;
        private void btn_polybios_Click(object sender, EventArgs e)
        {
            polybiosForm = new Polybios();

            polybiosForm.Top = this.Top;
            polybiosForm.Left = this.Left;
            polybiosForm.Size = this.Size;
            polybiosForm.Show();

            this.Hide();
        }

        private Playfair playFairForm;
        private void playfair_Click(object sender, EventArgs e)
        {
            playFairForm = new Playfair();

            playFairForm.Top = this.Top;
            playFairForm.Left = this.Left;
            playFairForm.Size = this.Size;
            playFairForm.Show();

            this.Hide();
        }

        private Vigenere vigenereForm;
        private void btn_vigenere_Click(object sender, EventArgs e)
        {
            vigenereForm = new Vigenere();

            vigenereForm.Top = this.Top;
            vigenereForm.Left = this.Left;
            vigenereForm.Size = this.Size;
            vigenereForm.Show();

            this.Hide();
        }

        private Transpozition transForm;
        private void btn_transpozition_Click(object sender, EventArgs e)
        {
            transForm = new Transpozition();

            transForm.Top = this.Top;
            transForm.Left = this.Left;
            transForm.Size = this.Size;
            transForm.Show();

            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/boobo94/Basic-Encryptions-C-Sharp");
            Process.Start(sInfo);
        }
    }
}
