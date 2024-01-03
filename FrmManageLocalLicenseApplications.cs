using LocalDrivngLicenseApplicationBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class FrmManageLocalLicenseApplications : Form
    {
        public FrmManageLocalLicenseApplications()
        {
            InitializeComponent();
        }

        private void btnClosefrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _LoadMainImageToForm()
        {
            pbLocalApplicationImage.ImageLocation = @"C:\DVLD project icons\mngapplications512.png";
        }

        void _LoadItemsToFilterByComboBox()
        {
            CbFilterBy.Items.Add("None");
            CbFilterBy.Items.Add("L.D.LAppID");
            CbFilterBy.Items.Add("National No");
            CbFilterBy.Items.Add("FullName");
            CbFilterBy.Items.Add("Status");
        }

        void _LoadLocalDrivLicAppDataListToDGV()
        {
            DgvLocalApplicationsList.DataSource = LocalDrivingLicApp.GetLocalDrivnglicAppList();
            lblRecodsNumber.Text  = DgvLocalApplicationsList.RowCount.ToString();
        }
        private void FrmManageLocalLicenseApplications_Load(object sender, EventArgs e)
        {
            _LoadMainImageToForm();
            _LoadItemsToFilterByComboBox();
            _LoadLocalDrivLicAppDataListToDGV();
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string CbSelectedItem = CbFilterBy.SelectedItem.ToString();

            switch (CbSelectedItem)
            {
                case "None":
                    TbFilterByValue.Visible = false;
                    //
                    break;
                case "L.D.LAppID":
                    TbFilterByValue.Visible = true;
                    break;
                case "National No":
                    TbFilterByValue.Visible = true;
                    break;
                case "FullName":
                    TbFilterByValue.Visible = true;
                    break;
                case "Status":
                    TbFilterByValue.Visible = true;
                    break;
            }


        }

        private void btnAddNewApp_Click(object sender, EventArgs e)
        {
            frmAddNewLocalDrivingLienseApplication frm = new frmAddNewLocalDrivingLienseApplication(1);
            frm.ShowDialog();
        }
    }
}
