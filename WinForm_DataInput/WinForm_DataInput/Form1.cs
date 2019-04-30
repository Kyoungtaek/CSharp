using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinForm_DataInput.Model;

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
            var passport = new Passport();
            passport.PassportNo = tbxPassportNo.Text;
            passport.LastName = tbxSurname.Text;
            passport.FirstName = tbxGivenName.Text;
            passport.Nationality = tbxNationality.Text;
            passport.DOB = dtpDob.Value;

            var converter = new ImageConverter();

            if(passportImage.Image== null)
            {
                passport.Picture = null;
            }
            else
            {
                passport.Picture = (byte[])converter.ConvertTo(passportImage.Image, typeof(byte[]));
            }

            if (DataManager.Save(passport))
            {
                MessageBox.Show("Saved successfully.", "Success");
            }

            SaveToCSV(passport);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RestField();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                passportImage.Image = Bitmap.FromFile(ofd.FileName);
            }
        }

        private void SaveToCSV(Passport passport)
        {
            string personData = $"{passport.PassportNo},{passport.LastName},{passport.FirstName},{passport.Nationality},{passport.DOB.ToShortDateString()}";

            var writer = new StreamWriter("data.csv", true);
            writer.WriteLine(personData);
            writer.Close();
        }

        private void RestField()
        {
            tbxPassportNo.Clear();
            tbxSurname.Clear();
            tbxGivenName.Clear();
            tbxNationality.Clear();
            dtpDob.Value = DateTime.Today;
            passportImage.Image = null;
            tbxPassportNo.Focus();
        }
    }
}
