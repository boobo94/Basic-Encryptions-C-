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

        
        private Form1 form1;
        private void btn_caesar_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
            
        }

        private polybios polybiosForm;
        private void btn_polybios_Click(object sender, EventArgs e)
        {
            polybiosForm = new polybios();
            polybiosForm.Show();
        }

        private playfair playFairForm;
        private void playfair_Click(object sender, EventArgs e)
        {
            playFairForm = new playfair();
            playFairForm.Show();
        }

        private Vigenere vigenereForm;
        private void btn_vigenere_Click(object sender, EventArgs e)
        {
            vigenereForm = new Vigenere();
            vigenereForm.Show();
        }

        private transpozitie transForm;
        private void btn_transpozition_Click(object sender, EventArgs e)
        {
            transForm = new transpozitie();
            transForm.Show();
        }
    }
}
