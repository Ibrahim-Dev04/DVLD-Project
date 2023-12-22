using ApplicationTypesBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeBusinessLayer;

namespace DVLD_Project
{
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void btnClosefrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _LoadPicToForm()
        {
            PbMainfrmImage.ImageLocation = @"C:\DVLD project icons\test128.png";
        }

        void _LoadTestTypesToDgv()
        {
            dgvTestTypesList.DataSource = clsTestType.GetTestTypesList();
            lblNumberOfRecords.Text = dgvTestTypesList.RowCount.ToString();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _LoadPicToForm();
            _LoadTestTypesToDgv();
        }

        private void updateTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestTypeID = (int)dgvTestTypesList.CurrentRow.Cells[0].Value;

            frmUpdateTestType frm = new frmUpdateTestType(TestTypeID);
            frm.ShowDialog();
            _LoadTestTypesToDgv();
        }
    }
}
