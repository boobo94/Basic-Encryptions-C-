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
    public partial class Polybios : Form
    {
        public Polybios()
        {
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            encrypt(0);
        }

        private string alphabet;
        private string[,] cypherMatrix;
        int matrixLength;
        void encrypt(int type)
        {
            alphabet = cb_alphabet.Text;
            string message = tb_message.Text.ToUpper();

            matrixLength = (int) Math.Sqrt(alphabet.Length);
            cypherMatrix = new string[matrixLength, matrixLength];

            int k = 0;
            for(int i=0;i<matrixLength;i++)
                for(int j = 0; j < matrixLength; j++)
                {
                    if (alphabet[k] == 'I')
                    {
                        cypherMatrix[i, j] = alphabet[k] + "|J";
                        k += 2;
                    }
                    else
                    {
                        cypherMatrix[i, j] = alphabet[k].ToString();
                        k++;
                    }
                }

            string encrypted = null;

            if (type == 0)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    encrypted += searchCharacter(message[i].ToString());
                }
            }
            else
            {
                encrypted = decrypt(message);
            }

            tb_chyper.Text = encrypted;

        }

        public string searchCharacter(string character)
        {
            for (int i = 0; i < matrixLength; i++)
                for (int j = 0; j < matrixLength; j++)
                {
                    if (cypherMatrix[i, j].Contains(character))
                        return (j+1) + "" + (i+1);
                }

            return "";
        }

        private string decrypt(string message)
        {
            int i = 0;
            string decrypted = "";

            while( i < message.Length)
            {
                decrypted += cypherMatrix[int.Parse(message[i+1].ToString())-1, int.Parse(message[i].ToString())-1];
                i += 2;
            }

            return decrypted;
        }

        private void polybios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            encrypt(1);
        }
    }
}
