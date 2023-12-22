using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class Mainfrm : Form
    {
        int _apptypeID = 0;

        public Mainfrm()
        {
            InitializeComponent();
        }
 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClosefrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
                frmManagePeople frm = new frmManagePeople();
                frm.ShowDialog();
        }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accountSettingsToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.ShowDropDown();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers MngUsers = new frmManageUsers();
            MngUsers.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int UserID = GlobalSettings._GlobalUserObj.ID;
            frmUserDetails frm = new frmUserDetails(UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int UserID = GlobalSettings._GlobalUserObj.ID;
            frmChangeUserPassword frm = new frmChangeUserPassword(UserID);
            frm.ShowDialog();
        }

        private void TsmItemMangeApptypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frm = new frmManageApplicationTypes();
            frm.ShowDialog();
        }

        private void TestTypesToolMenuStrip_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewLocalDrivingLienseApplication frm = new frmAddNewLocalDrivingLienseApplication(_apptypeID);
            frm.ShowDialog();
        }

        private void newDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _apptypeID = 1;
        }
    }
}
