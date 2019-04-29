using System;
using System.IO;
using System.Windows.Forms;

namespace WinForm_DataInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string personData = $"{tbxPassportNo.Text},{tbxSurname.Text},{tbxGivenName.Text},{tbxNationality.Text},{dtpDob.Value.ToShortDateString()}";

            var writer = new StreamWriter("data.csv", true);
            writer.WriteLine(personData);
            writer.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxPassportNo.Clear();
            tbxSurname.Clear();
            tbxGivenName.Clear();
            tbxNationality.Clear();
            dtpDob.Value = new DateTime(2000, 1, 1);
            tbxPassportNo.Focus();
        }
    }
}
