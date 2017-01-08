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
        void encrypt(int command)
        {
            string password = tb_password.Text.ToUpper();
            string message = tb_message.Text.ToUpper();
            alphabet = cb_alphabet.Text;
            matrixLength = alphabet.Length;
            cypherMatrix = new string[matrixLength, matrixLength];

            VigenereMatrix();

            string encrypted = null;

            if (command == 0)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    // search after element from intersection beteween letter from message and letter from password
                    encrypted += cypherMatrix[searchCharacter(message[i]), searchCharacter(password[(int)i % password.Length])];
                }
            }
            else
            {//decrypt
                for (int i = 0; i < message.Length; i++)
                {
                    int line = searchCharacter(password[(int)i % password.Length]);
                    encrypted += alphabet[searchCharacterOnLine(message[i],line)];
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
                if (alphabet[j].Equals(character))
                    x = j;
            }

            return x;
        }

        public int searchCharacterOnLine(char character, int line)
        {
            int x = -1;
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (cypherMatrix[line, j] == character.ToString())
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

        private void Vigenere_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
