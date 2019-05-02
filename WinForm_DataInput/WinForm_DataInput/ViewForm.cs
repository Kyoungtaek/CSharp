using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_DataInput.Model;

namespace WinForm_DataInput
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void passportGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            if (e.Button == MouseButtons.Right)
            {
                var grid = sender as DataGridView;

                grid.CurrentCell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = passportGridView.CurrentRow;

            var passport = new Passport()
            {
                PassportNo = row.Cells["PassportNo"].Value.ToString(),
                LastName = row.Cells["LastName"].Value.ToString(),
                FirstName = row.Cells["FirstName"].Value.ToString(),
                Nationality = row.Cells["Nationality"].Value.ToString(),
                DOB = (DateTime)row.Cells["DOB"].Value,
                Picture = (byte[])row.Cells["Picture"].Value,
            };

            var passportForm = new PassportForm(passport);
            passportForm.ShowDialog();
            GetData();
        }

        private void GetData()
        {
            DataSet ds = DataManager.GetPassportData();

            passportGridView.DataSource = ds.Tables[0];
        }
    }
}
