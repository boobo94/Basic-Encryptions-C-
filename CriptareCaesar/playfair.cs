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
    public partial class Playfair : Form
    {
        public Playfair()
        {
            InitializeComponent();
        }

        private void cb_alphabet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private string alphabet = "";
        private string[,] cypherMatrix;// the matrix where used for playfair cypher
        int matrixLength;
        string password;

        void playfairCypher(int type)
        {
            string initialAlphabet = cb_alphabet.Text.ToUpper();
            string message = tb_message.Text.ToUpper();
            password = tb_password.Text;

            alphabet = addIfIsNotIn(password, alphabet);// add the password to the alphabet that will be use in cypher
            alphabet = addIfIsNotIn(initialAlphabet, alphabet);// add the letter from main alphabet

            matrixLength = (int)Math.Sqrt(alphabet.Length);
            cypherMatrix = new string[matrixLength, matrixLength];
            
            // fill the cypherMatrix - begin
            int k = 0;// index in alphabet
            for (int i = 0; i < matrixLength; i++)
                for (int j = 0; j < matrixLength; j++)
                {
                    if (alphabet[k] == 'I')
                    {
                        cypherMatrix[i, j] = alphabet[k] + "|J";
                        k++;
                    }
                    else if(alphabet[k] == 'J')
                    {
                        cypherMatrix[i, j] = alphabet[k+1].ToString();
                        k += 2;
                    }
                    else
                    {
                        cypherMatrix[i, j] = alphabet[k].ToString();
                        k++;
                    }  
                }

            // fill the cypherMatrix - end

            tb_cypher.Text = encryptString(message,type);// display encrypted string
        }

        private string addIfIsNotIn(string str, string current)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (current.IndexOf(str[i]) < 0)
                    current += str[i];
            }

            return current;
        }

        /**
         * @param string message - message
         * @param int type - if type = 0 - encrypt
         *                 -    type = 1 - decrypt
         */
        private string encryptString(string message, int type)
        {
            string encrypted = null;

            //todo implement alghoritm
            if (message.Length % 2 != 0) // if message is not even, add Q character at the end
                message += "X";

            int i = 0;
            while (i < message.Length)
            {
                int[] a = searchCharacter(message[i].ToString());
                int[] b = searchCharacter(message[i+1].ToString());

                if(a[1] == b[1])// if the letters are on the same column
                {
                    if (type == 0) // encrypt
                    {
                        encrypted += cypherMatrix[(int)((a[0] + 1) % matrixLength), a[1]];//add first letter
                        encrypted += cypherMatrix[(int)((b[0] + 1) % matrixLength), b[1]];//add second letter
                    }
                    else // decrypt
                    {
                        encrypted += cypherMatrix[(int)(Math.Abs(a[0] - 1) % matrixLength), a[1]];//add first letter
                        encrypted += cypherMatrix[(int)(Math.Abs(b[0] - 1) % matrixLength), b[1]];//add second letter
                    }
                   
                }
                else if (a[0] == b[0]) // if are on the same line
                {
                    if (type == 0) // encrypt
                    {
                        encrypted += cypherMatrix[a[0], (int)((a[1] + 1) % matrixLength)];//add first letter
                        encrypted += cypherMatrix[b[0], (int)((b[1] + 1) % matrixLength)];//add second letter
                    }
                    else // decrypt
                    {
                        encrypted += cypherMatrix[a[0], (int)(Math.Abs(a[1] - 1) % matrixLength)];//add first letter
                        encrypted += cypherMatrix[b[0], (int)(Math.Abs(b[1] - 1) % matrixLength)];//add second letter
                    }
                }
                else
                {
                    
                    encrypted += cypherMatrix[a[0], b[1]];//add first letter
                    encrypted += cypherMatrix[b[0], a[1]];//add second letter
                   
                }

                i += 2;
            }

            if (type == 1 && encrypted[encrypted.Length - 1] == 'X')
                encrypted = encrypted.Substring(0, encrypted.Length - 1);
            return encrypted;
        }

        public int[] searchCharacter(string character)
        {
            int[] pos = new int[2];
            for (int i = 0; i < matrixLength; i++)
                for (int j = 0; j < matrixLength; j++)
                {
                    if (cypherMatrix[i, j].Contains(character))
                    {
                        pos[0] = i;//adaug linia
                        pos[1] = j;//adaug coloana
                    }
                }

            return pos;
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            playfairCypher(0);
        }

        private void playfair_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            playfairCypher(1);
        }
    }
}
