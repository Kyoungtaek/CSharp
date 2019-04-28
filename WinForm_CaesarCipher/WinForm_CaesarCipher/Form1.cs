using System;
using System.Windows.Forms;

namespace WinForm_CaesarCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            var plainText = tbxPlainText.Text;

            if (plainText.Length < 1)
            {
                MessageBox.Show("Please enter text to encrypt.", "Encryption");
                tbxPlainText.Clear();
                tbxPlainText.Focus();
            }
            else
            {
                string temp = CaesarCipher.Encrypt(plainText.Trim(), (int)shiftKey.Value);

                tbxCrptograph.Text = temp.ToString();
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            var cryptoText = tbxCrptograph.Text;

            if(cryptoText.Length < 1)
            {
                MessageBox.Show("Please enter text to decrypt.", "Decryption");
                tbxCrptograph.Clear();
                tbxCrptograph.Focus();
            }
            else
            {
                string temp = CaesarCipher.Decrypt(cryptoText.Trim(), (int)shiftKey.Value);

                tbxPlainText.Text = temp.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxPlainText.Clear();
            tbxCrptograph.Clear();
            tbxPlainText.Focus();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
