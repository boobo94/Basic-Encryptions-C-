using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private polybios polybiosForm;
        private void btn_polybios_Click(object sender, EventArgs e)
        {
            polybiosForm = new polybios();

            polybiosForm.Top = this.Top;
            polybiosForm.Left = this.Left;
            polybiosForm.Size = this.Size;
            polybiosForm.Show();

            this.Hide();
        }

        private playfair playFairForm;
        private void playfair_Click(object sender, EventArgs e)
        {
            playFairForm = new playfair();

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

        private transpozitie transForm;
        private void btn_transpozition_Click(object sender, EventArgs e)
        {
            transForm = new transpozitie();

            transForm.Top = this.Top;
            transForm.Left = this.Left;
            transForm.Size = this.Size;
            transForm.Show();

            this.Hide();
        }
    }
}
