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
    public partial class ctrlPersonAndUserInfo : UserControl
    {
        clsUser _user;
        public ctrlPersonAndUserInfo()
        {
            InitializeComponent();
        }

        void _DisplayPersonInfoToPersonComponent()
        {
            int PersonID = _user.PersonID;
            ctrlPersonInformation1._DisplayPersonInfoToControl(PersonID);
        }

        public void DisplayUserInfoToForm(int UserID)
        {
            _user = clsUser.FindByID(UserID);

            if (_user == null)
                return;

            lblUserID.Text = _user.ID.ToString();
            lblUsername.Text = _user.UserName;
            if (_user.isActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";

            _DisplayPersonInfoToPersonComponent();
        }
    }
}
