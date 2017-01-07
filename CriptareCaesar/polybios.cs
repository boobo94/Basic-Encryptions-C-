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
    public partial class polybios : Form
    {
        public polybios()
        {
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            encrypt();
        }

        private string alphabet;
        private string[,] cypherMatrix;
        int matrixLength;
        void encrypt()
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
            for(int i = 0; i < message.Length; i++)
            {
                encrypted += searchCharacter(message[i].ToString());
            }

            tb_chyper.Text = encrypted;

        }

        public string searchCharacter(string character)
        {
            for (int i = 0; i < matrixLength; i++)
                for (int j = 0; j < matrixLength; j++)
                {
                    if (cypherMatrix[i, j] == character)
                        return (j+1) + "" + (i+1);
                }

            return "";
        }
    }
}
