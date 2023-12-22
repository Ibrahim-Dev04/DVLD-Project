using PersonBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusinessLayer;

namespace DVLD_Project
{
    public partial class frmAddNewUser : Form
    {
        enum Emodes { AddNew = 0, Update = 1 };

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        int _PersonID = 0;
        Emodes _mode;
        clsUser _User;
        int _UserID = 0;

        public frmAddNewUser()
        {
            InitializeComponent();
            _mode = Emodes.AddNew;
        }

        public frmAddNewUser(int UserID)
        {
            InitializeComponent();

            _mode = Emodes.Update;
            _UserID = UserID;
            lblAdd_EditUser.Text = "Update user";
            _User = clsUser.FindByID(_UserID);

            _DisplayUserInfoOnLoginInfoTab();
            ctlrPersonCardWithFilter1.DisplayPersonInfoToForm(_User.PersonID);
            ctlrPersonCardWithFilter1.DisableGbFilterBy();
            
        }

        void _DisplayUserInfoOnLoginInfoTab()
        {
            TcontrolAddNewUser.TabPages[1].Enabled = true;
            lblUserID.Text = _User.ID.ToString();
            TbUserName.Text = _User.UserName;
            TbPassword.Text = _User.Password;
            TbConfirmpassword.Text = _User.Password;
            if (_User.isActive)
                chbxisActive.Checked = true;
        }

        void _PrepareControlsToColoseForm()
        {
            errorProvider1.SetError(TbUserName,"");
            errorProvider1.SetError(TbPassword, "");
            errorProvider1.SetError(TbConfirmpassword, "");
        }

        bool _isValidationFails()
        {
            return (TbUserName.Text == "" || TbPassword.Text == "" || TbConfirmpassword.Text == "");
        }

        private void btnClosefrm_Click(object sender, EventArgs e)
        {
            if (_isValidationFails())
            {
                _PrepareControlsToColoseForm();
                this.Close();
            }
            else
            this.Close();
        }

        private void frmAddNewUser_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmAddNewUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = dragFormPoint;
                newPoint.X += Cursor.Position.X - dragCursorPoint.X;
                newPoint.Y += Cursor.Position.Y - dragCursorPoint.Y;
                this.Location = newPoint;
            }
        }

        private void frmAddNewUser_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
           // TcontrolAddNewUser.TabPages[1].Enabled = false;
            this.MouseDown += frmAddNewUser_MouseDown;
            this.MouseMove += frmAddNewUser_MouseMove;
            this.MouseUp += frmAddNewUser_MouseUp;
        }

        bool _CheckisThePersonHasAuser()
        {
            return clsPerson.CheckIsThePersonAuserByPersonID(_PersonID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_CheckisThePersonHasAuser())
            {
                MessageBox.Show("Selected person is Already has a person", "Select another person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TcontrolAddNewUser.SelectedIndex < TcontrolAddNewUser.TabCount - 1 && _PersonID != 0)
            {
                TcontrolAddNewUser.TabPages[1].Enabled = true;
                TcontrolAddNewUser.SelectedIndex++;
            }
        }

        private void ctlrPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
        }

        private void ValidatingComboboxes(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, $"{textBox.Tag} is required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox, "");
                e.Cancel = false;
            }
        }

        private void ValidatingConfirmPassword(object sender, CancelEventArgs e)
        {
            TextBox tbConfirmPassword = sender as TextBox;

            if (string.IsNullOrEmpty(tbConfirmPassword.Text))
            {
                errorProvider1.SetError(tbConfirmPassword, $"{tbConfirmPassword.Tag} is required");
                e.Cancel = true;
            }
            else if (tbConfirmPassword.Text != TbPassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "Password confirmation does not match the password");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, "");
                e.Cancel = false;
            }
        }

        private void tpageLoginInfo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_mode == Emodes.AddNew)
            _User = new clsUser();

            _User.PersonID = _PersonID;
            _User.UserName = TbUserName.Text;
            _User.Password = TbPassword.Text;
            if (chbxisActive.Checked)
                _User.isActive = true;
            else
                _User.isActive = false;

            if (_User.Save())
            {
                MessageBox.Show("Saved Succesfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblUserID.Text = _User.ID.ToString();
            }
            else
            {
                MessageBox.Show("Save Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctlrPersonCardWithFilter1_Load(object sender, EventArgs e)
        {
            if (_PersonID != 0)
            {
                frmAddNewPerson AddPerson = new frmAddNewPerson(_PersonID);
            }
        }

        private void TbConfirmpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
