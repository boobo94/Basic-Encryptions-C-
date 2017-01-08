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
    public partial class Transpozition : Form
    {
        public Transpozition()
        {
            InitializeComponent();
        }

        private string alphabet;
        private string[,] cypherMatrix;
        string password;
        int lengthLine, lengthColumn;
        string message;

        private void transpozition(int command)
        {

            alphabet = cb_alphabet.Text;
            message = tb_message.Text.ToUpper();
            password = tb_password.Text.ToUpper();

            lengthLine = password.Length;
            lengthColumn = (int) (message.Length + password.Length -1 ) / password.Length;
            cypherMatrix = new string[lengthLine, lengthColumn];

            

            string encrypted = "";

            if (command == 0)
            {
                //if the length of message is less than size of matrix, then will be filled with Q characters
                message = completeTheLengthOfMessage(message, lengthLine * lengthColumn);

                // fill the matrix with message
                fillMatrix();

                encrypted = encryptString();
            }
            else
            {

            }

            tb_encrypted.Text = encrypted;

        }

        private string completeTheLengthOfMessage(string str, int length)
        {
            while (str.Length < length)
                str += "Q";

            return str;
        }

        List<int> visited;
        private int currentLine()
        {
            int minIndex = 0;
            int min = 100;
            for (int i = 0; i < lengthLine; i++)
                if ((int)password[i] < min && notVisited(i))
                {
                    min = (int)password[i];
                    minIndex = i;
                }
            visited.Add(minIndex);
            return minIndex;
            
        }

        private Boolean notVisited(int index)
        {
            if (visited.Contains(index))
                return false;
            return true;
        }

        private string encryptString()
        {
            string encrypted = "";
            visited = new List<int>();

            for (int i = 0; i < lengthLine; i++)
            {
                int k = currentLine();
                for (int j = 0; j < lengthColumn; j++)
                {
                    encrypted += cypherMatrix[k, j];
                }
            }

            return encrypted;
        }

        private void fillMatrix()
        {
            int k = 0;
            for (int i = 0; i < lengthColumn; i++)
                for (int j = 0; j < lengthLine; j++) {
                    cypherMatrix[j, i] = message[k].ToString();
                    k++;
                }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            transpozition(0);
        }

        private void transpozitie_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            transpozition(1);
        }
    }
}
