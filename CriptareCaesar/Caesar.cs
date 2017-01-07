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
    public partial class Caesar : Form
    {
        public Caesar()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        
        private string createCryptedAlphabet(string alphabet, int key, string password)
        {
            string cryptedAlphabet = "";

            if(password.Length > 0)
            {
                cryptedAlphabet = addIfIsNotIn(password, cryptedAlphabet);
                cryptedAlphabet = addIfIsNotIn(alphabet, cryptedAlphabet);
            }
            else
                cryptedAlphabet = alphabet.Substring(key, (alphabet.Length - key)) + alphabet.Substring(0, key);

            return cryptedAlphabet;
        }

        private void encrypt(int type)
        {
            string alphabet = cb_alphabet.Text;
            int key = (tb_key.Text.Length > 0) ? int.Parse(tb_key.Text) : 0; //if the key is unfilled then the value will be 0
            string plainText = tb_plainText.Text.ToUpper();
            string cyperText = "";// textul criptat/decriptat
            string password = tb_password.Text.ToUpper();

            // alfabet pentru criptare = alfabet de la key pana la final concatenat cu alfabet de la inceput pana la key
            //string cryptedAlphabet = alphabet.Substring(key, (alphabet.Length - key)) + alphabet.Substring(0, key);
            string cryptedAlphabet = createCryptedAlphabet(alphabet, key, password);

            // if type = 0 then encrypt
            // if type =  1 then decrypt
            string newAlphabet = (type == 0) ? alphabet : cryptedAlphabet;
            string newCryptedAlphabet = (type == 0) ? cryptedAlphabet : alphabet;

            for (int i = 0;i< plainText.Length; i++)
            {
                int positionInAlphabet = newAlphabet.IndexOf(plainText[i]);
                cyperText += (positionInAlphabet >= 0) ? newCryptedAlphabet[positionInAlphabet] : plainText[i];//if the character is not found in the new alphabet, then will be added to string
            }

            tb_cyperText.Text = cyperText;
        }

        private void btn_encryt_Click(object sender, EventArgs e)
        {
            encrypt(0);
        }

        private void btn_decryt_Click(object sender, EventArgs e)
        {
            encrypt(1);
        }

        private void Caesar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
