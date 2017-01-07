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
    public partial class Vigenere : Form
    {
        public Vigenere()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private string alphabet;
        private string[,] cypherMatrix;
        int matrixLength;

        private string encrypted;
        void encrypt(int x)
        {
            string password = tb_password.Text.ToUpper();
            string message = tb_message.Text.ToUpper();
            alphabet = cb_alphabet.Text;
            matrixLength = alphabet.Length;
            cypherMatrix = new string[matrixLength, matrixLength];

            VigenereMatrix();



            string encrypted = null;

            if (x == 0)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    int mod = (int)i % password.Length;
                    encrypted += cypherMatrix[searchCharacter(message[i]), searchCharacter(password[(int)i % password.Length])];
                }
            }
            else
            {//decrypt
                for (int i = 0; i < message.Length; i++)
                {
                    int mod = (int)i % password.Length;
                    encrypted += cypherMatrix[searchCharacter(message[i]), searchCharacter(password[(int)i % password.Length])];
                }
            }

            tb_encrypted.Text = encrypted;
        }

        void VigenereMatrix()
        {
            for (int i = 0; i < matrixLength; i++)
                for (int j = 0; j < matrixLength; j++)
                {
                    int mod = (int)(j + i)%matrixLength;
                    cypherMatrix[i, j] = alphabet[mod].ToString();
                }
        }

        public int searchCharacter(char character)
        {
            int x = -1;
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (alphabet[j] == character)
                    x = j;
            }

            return x;
        }

        public int searchCharacterOnLine(char character)
        {
            int x = -1;
            for (int j = 0; j < alphabet.Length; j++)
            {
               // if (cypherMatrix[searchCharacter(ch),j] == character)
                    x = j;
            }

            return x;
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            encrypt(0);
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            encrypt(1);
        }
    }
}
