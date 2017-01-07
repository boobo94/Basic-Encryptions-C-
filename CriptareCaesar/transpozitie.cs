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
    public partial class transpozitie : Form
    {
        public transpozitie()
        {
            InitializeComponent();
        }

        private string alphabet;
        private string[,] cypherMatrix;
        string password;
        int lengthLine, lengthColumn;
        string message;

        private void encrypt(int command)
        {

            alphabet = cb_alphabet.Text;
            message = tb_message.Text.ToUpper();
            password = tb_password.Text;

            lengthLine = password.Length;
            lengthColumn = (int) message.Length / password.Length;
            cypherMatrix = new string[lengthLine, lengthColumn];

            // fill the matrix with message
            fillMatrix();

            min = (int)password[0];


            
            
        }

        int min;
        private int currentLine()
        {
            for (int i = 1; i < lengthLine; i++)
                if ((int)password[i] < min)
                {
                    min = (int)password[i];
                    return i;
                }
            return -1;
            
        }

        private void fillMatrix()
        {
            int k = 0;
            for (int i = 0; i < lengthLine; i++)
                for (int j = 0; j < lengthColumn; j++) {
                    cypherMatrix[i, j] = message[k].ToString();
                    k++;
                }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            encrypt(0);
        }

        private void transpozitie_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            encrypt(1);
        }
    }
}
