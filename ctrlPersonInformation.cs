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

namespace DVLD_Project
{
    public partial class ctrlPersonInformation : UserControl
    {

        int _PersonID = -1;
        clsPerson _Person;
        string _PersonIconeImagePath = @"C:\DVLD project icons\Personnnn.png";

        public ctrlPersonInformation()
        {
            InitializeComponent();

            _LoadPersonIconImage();
        }

        public void _DisplayPersonInfoToControl(int PersonID)
        {
            _PersonID = PersonID;
            _Person = clsPerson.FindByID(PersonID);

            if (_Person == null)
            {
                return;
            }
            lblPersonId.Text = _Person.PersonID.ToString();
            LblName.Text = "";
            LblName.Text += _Person.FirstName + " ";
            LblName.Text += _Person.SecondName + " ";

            if (!string.IsNullOrEmpty(_Person.ThirdName))
                LblName.Text += _Person.ThirdName + " ";

            LblName.Text += _Person.LastName;

            lblNationalNo.Text = _Person.NationalNo.ToString();
            if (_Person.Gender == 0)
                lblGender.Text = "Male";
            else
                lblGender.Text = "Female";

            lblEmail.Text = _Person.Email.ToString();
            lblAddress.Text = _Person.Address.ToString();
            lblDateOfBirth.Text = _Person.DateOfBirth.ToString();
            lblphone.Text = _Person.Phone.ToString();
            lblCountry.Text = clsPerson.GetPersonCountry(_Person.PersonID);

            if (!string.IsNullOrEmpty(_Person.ImagePath) )
            {
                if (clsFilepath.isExist(_Person.ImagePath))
                {
                    pbPersonImage.ImageLocation = _Person.ImagePath;
                }
            }
            else
            {
                pbPersonImage.ImageLocation = _PersonIconeImagePath;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        void _LoadPersonIconImage()
        {
            pbPersonImage.ImageLocation = _PersonIconeImagePath.ToString(); 
        }

        

        private void ctrlPersonInformation_Load(object sender, EventArgs e)
        {
            _DisplayPersonInfoToControl(_PersonID);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(_PersonID);
            frm.PersonIDBack += _frmAddEditPerson_PersonIDBack;
            frm.ShowDialog();
        }

        void _frmAddEditPerson_PersonIDBack(object obj, int PersonID)
        {
            _DisplayPersonInfoToControl(PersonID);
        }



    }
}
