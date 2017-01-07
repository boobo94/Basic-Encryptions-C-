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
    public partial class playfair : Form
    {
        public playfair()
        {
            InitializeComponent();
        }

        private void cb_alphabet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private string alphabet;
        private string[,] cypherMatrix;
        int matrixLength;
        string password;

        void prepare()
        {
            password = tb_password.Text;
            int alphabetLength = cb_alphabet.Text.Length;

            for (int i=0;i< password.Length;i++)
            {
                char x = password[i];
                if (searchInAlphabet(x))
                    alphabet += x;
            }

            for (int i = 0; i < cb_alphabet.Text.Length; i++)
            {
                char x = cb_alphabet.Text[i];
                if (searchInAlphabet(x))
                    alphabet += x;
            }
        }


        void encrypt()
        {
            prepare();

            string message = tb_message.Text.ToUpper();
            

            matrixLength = (int)Math.Sqrt(alphabet.Length);
            cypherMatrix = new string[matrixLength, matrixLength];
            
            int k = 0;
            for (int i = 0; i < matrixLength; i++)
                for (int j = 0; j < matrixLength; j++)
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
            for (int i = 0; i < message.Length; i++)
            {
                encrypted += searchCharacter(message[i].ToString());
            }

            tb_cypher.Text = encrypted;

        }

        private Boolean searchInAlphabet(char a)
        {
            if (alphabet.IndexOf(a) > 0)
                return true;
            return false;
        }

        public string searchCharacter(string character)
        {
            for (int i = 0; i < matrixLength; i++)
                for (int j = 0; j < matrixLength; j++)
                {
                    if (cypherMatrix[i, j] == character)
                        return (j + 1) + "" + (i + 1);
                }

            return "";
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            encrypt();
        }

        private void playfair_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
