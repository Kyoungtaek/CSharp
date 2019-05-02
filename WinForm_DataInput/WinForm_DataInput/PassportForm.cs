using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinForm_DataInput.Model;

namespace WinForm_DataInput
{
    public partial class PassportForm : Form
    {
        public PassportForm()
        {
            InitializeComponent();
        }

        public PassportForm(Passport p): this()
        {
            tbxPassportNo.Text = p.PassportNo;
            tbxSurname.Text = p.LastName;
            tbxGivenName.Text = p.FirstName;
            tbxNationality.Text = p.Nationality;
            dtpDob.Value = p.DOB;
            passportImage.Image = Bitmap.FromStream(new MemoryStream(p.Picture));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // To Create New Data
            //var passport = new Passport();
            //passport.PassportNo = tbxPassportNo.Text;
            //passport.LastName = tbxSurname.Text;
            //passport.FirstName = tbxGivenName.Text;
            //passport.Nationality = tbxNationality.Text;
            //passport.DOB = dtpDob.Value;

            //var converter = new ImageConverter();

            //if(passportImage.Image== null)
            //{
            //    passport.Picture = null;
            //}
            //else
            //{
            //    passport.Picture = (byte[])converter.ConvertTo(passportImage.Image, typeof(byte[]));
            //}

            //if (DataManager.Save(passport))
            //{
            //    MessageBox.Show("Saved successfully.", "Success");
            //}

            //SaveToCSV(passport);

            // To Update
            if (String.IsNullOrEmpty(tbxSurname.Text.Trim()))
            {
                MessageBox.Show("Last Name is Requirement.", "Up to 10 Characters.");
                tbxSurname.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tbxGivenName.Text.Trim()))
            {
                MessageBox.Show("First Name is Requirement.", "Up to 10 Characters.");
                tbxGivenName.Focus();
                return;
            }

            byte[] imageBytes = null;

            if (passportImage.Image != null)
            {
                var converter = new ImageConverter();
                imageBytes = (byte[])converter.ConvertTo(passportImage.Image, typeof(byte[]));
            }

            Passport p = new Passport
            {
                PassportNo = tbxPassportNo.Text.Trim(),
                LastName = tbxSurname.Text.Trim(),
                FirstName = tbxGivenName.Text.Trim(),
                Nationality = tbxNationality.Text.Trim(),
                DOB = dtpDob.Value,
                Picture = imageBytes
            };

            if (DataManager.Update(p))
            {
                // if success, close form
                MessageBox.Show("Data Updated Successfully!");

                this.Close();
            }
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
