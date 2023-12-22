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
    public partial class frmChangeUserPassword : Form
    {
        int _UserID = -1;
        clsUser _UserObj;

        public frmChangeUserPassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _UserObj = clsUser.FindByID(UserID);
            ctrlPersonAndUserInfo1.DisplayUserInfoToForm(UserID);
        }

        private void TextBoxes_Validating(object sender, CancelEventArgs e)
        {
            TextBox Tb = sender as TextBox;

            if (string.IsNullOrEmpty(Tb.Text.ToString()))
            {
                errorProvider1.SetError(Tb, $"{Tb.Tag} is required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(Tb, "");
                e.Cancel = false;
            }
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {

        }

        void _PrepareTheFormForClosing()
        {
            if (_ValidationFails())
            {
                errorProvider1.SetError(TbCrrentPassword, "");
                errorProvider1.SetError(TbNewpassword, "");
                errorProvider1.SetError(TbConfirmPassword, "");
            }

            this.Close();
        }

        private void btnClosefrm_Click(object sender, EventArgs e)
        {
            _PrepareTheFormForClosing();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            _PrepareTheFormForClosing();
        }

        private void ValidatingCofirmPassword(object sender, CancelEventArgs e)
        {
            TextBox TbConfirmpassword = sender as TextBox;

            if (string.IsNullOrEmpty(TbConfirmpassword.ToString()))
            {
                errorProvider1.SetError(TbConfirmpassword, $"{TbConfirmpassword.Tag} is required");
                e.Cancel = true;
            }
            else if (TbConfirmpassword.Text != TbNewpassword.Text)
            {
                errorProvider1.SetError(TbConfirmpassword, "Confirm password doesn't match the new password");
            }
            else
            {
                errorProvider1.SetError(TbConfirmpassword, "");
                e.Cancel = false;
            }
        }

        private void CurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            TextBox TbCurrentPassword = sender as TextBox;

            if (string.IsNullOrEmpty(TbCurrentPassword.ToString()))
            {
                errorProvider1.SetError(TbCurrentPassword, $"{TbCurrentPassword.Tag} is required");
                e.Cancel = true;
            }
        
            else
            {
                errorProvider1.SetError(TbCurrentPassword, "");
                e.Cancel = false;
            }
        }

        void _FillUserObjAndSave()
        {
            _UserObj.Password = TbConfirmPassword.Text;

            if (_UserObj.Save())
            {
                MessageBox.Show("User password saved Succesfully", "Save", MessageBoxButtons.OK
                 , MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User password save failed", "Save", MessageBoxButtons.OK
                 , MessageBoxIcon.Error);
            }
        }

        bool _ValidationFails()
        {
            return (string.IsNullOrEmpty(TbCrrentPassword.Text)|| string.IsNullOrEmpty(TbNewpassword.Text)|| 
                                        string.IsNullOrEmpty(TbConfirmPassword.Text));    
        }

        bool  _CheckisCurrentpasswordCorrect()
        {
            return (_UserObj.Password == TbCrrentPassword.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidationFails())
            {
                MessageBox.Show("You are missing some info,try to complete all the info", "Missing", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }
            if (!_CheckisCurrentpasswordCorrect())
            {
                MessageBox.Show("Current password is not correct,try again", "password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillUserObjAndSave();
        }
    }
 
}
