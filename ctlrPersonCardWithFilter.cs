using PersonBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD_Project
{
    public partial class ctlrPersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;

            if (Handler != null)
            {
                Handler(PersonID);
            }
        }

        
        clsPerson _Person;
        int _PersonID = 0;
        string _PersonIconeImagePath = @"C:\DVLD project icons\Personnnn.png";

        public ctlrPersonCardWithFilter()
        {
            InitializeComponent();
        }

        void _LoadPersonImagePic()
        {
            pbPersonImage.ImageLocation = _PersonIconeImagePath;

        }

        void _LoadItemsToFilterByCB()
        {
            CbFilterBy.Items.Add("None");
            CbFilterBy.Items.Add("Person ID");
            CbFilterBy.Items.Add("National No");
            CbFilterBy.Items.Add("First Name");
            CbFilterBy.Items.Add("Second Name");
            CbFilterBy.Items.Add("Third Name");
            CbFilterBy.Items.Add("Last Name");
            CbFilterBy.Items.Add("Gender");
            CbFilterBy.Items.Add("Date Of Birth");
            CbFilterBy.Items.Add("Nationality");
            CbFilterBy.Items.Add("Phone");
            CbFilterBy.Items.Add("Email");
        }

        private void ctlrPersonCardWithFilter_Load(object sender, EventArgs e)
        {
           // _LoadPersonImagePic();
            _LoadItemsToFilterByCB();
        }

        private void ctlrPersonCardWithFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            string FilterBy = CbFilterBy.SelectedItem.ToString();
            switch (FilterBy)
            {

                case "Person ID":
                    {
                        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "National No":
                    {
                        if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "First Name":
                case "Second Name":
                case "Third Name":
                case "Last Name":
                    {
                        if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                            e.Handled = true;
                    }
                    break;
                case "Gender":
                    {
                        if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "Date Of Birth":
                    {
                        if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
                case "Nationality":
                    {
                        if (!char.IsLetter(e.KeyChar) && e.KeyChar != ((char)Keys.Space) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "Phone":
                    {
                        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "Email":
                    {
                        if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                default:
                    break;
            }
        }

        void _DisplayInitialValuesToLabels()
        {
            TbFilterByValue.Text = string.Empty;

            lblPersonId.Text = "[????]";
            LblName.Text = "[????]"; 
            LblName.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblAddress.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblphone.Text = "[????]";
            lblCountry.Text = "[????]";
            pbPersonImage.ImageLocation = _PersonIconeImagePath;
            
        }

        public void DisableGbFilterBy()
        {
            GbFilterBy.Enabled = false;
        }

        public void DisplayPersonInfoToForm(int PersonID)
        {
            //we use the event here to get personID from the other form when to call this function .
            if (OnPersonSelected != null)
            {
                PersonSelected(PersonID);
            }

            _Person = clsPerson.FindByID(PersonID);
            TbFilterByValue.Text = string.Empty;

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
            if(_Person.Gender == 0)
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
                else
                {
                    pbPersonImage.ImageLocation = _PersonIconeImagePath;
                }
            }
            else
            {
                pbPersonImage.ImageLocation = _PersonIconeImagePath;
            }
        } 

        private void btnSearchBy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbFilterByValue.Text))
            {
                return;
            }

            string ColumnValue = TbFilterByValue.Text;
            string ColumnName = CbFilterBy.SelectedItem.ToString().Replace(" ","");

            _Person =  clsPerson.FindByColumnName(ColumnName, ColumnValue);
          
            if (_Person != null)
            {
                DisplayPersonInfoToForm(_Person.PersonID);

                if (OnPersonSelected != null)
                {
                    PersonSelected(_Person.PersonID);
                } 
            }
            else
            {
                MessageBox.Show($"Person with {ColumnName} = {ColumnValue} Does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _DisplayInitialValuesToLabels();
                if (OnPersonSelected != null)
                {
                    PersonSelected(-1);
                }
            }
        }

        void frmUpdateEditPerson_PersonIdBack(object obj,int PersonID)
        {
            DisplayPersonInfoToForm(PersonID);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Person == null)
                return;
            
            frmAddNewPerson frm = new frmAddNewPerson(_Person.PersonID);
            frm.PersonIDBack += frmUpdateEditPerson_PersonIdBack;
            frm.ShowDialog();
        }

        private void TbFilterByValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            string FilterBy = CbFilterBy.SelectedItem.ToString();
            switch (FilterBy)
            {

                case "Person ID":
                    {
                        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "National No":
                    {
                        if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "First Name":
                case "Second Name":
                case "Third Name":
                case "Last Name":
                    {
                        if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                            e.Handled = true;
                    }
                    break;
                case "Gender":
                    {
                        if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "Date Of Birth":
                    {
                        if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space && e.KeyChar != (char)Keys.Back)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
                case "Nationality":
                    {
                        if (!char.IsLetter(e.KeyChar) && e.KeyChar != ((char)Keys.Space) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "Phone":
                    {
                        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                case "Email":
                    {
                        if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;
                default:
                    break;
            }
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CbFilterBy.SelectedIndex != -1 && CbFilterBy.SelectedItem != "None")
            {
                TbFilterByValue.Visible = true;
            }
        }

        private void PersonID_DataBack(object sender, int PersonID)
        {
            _Person = clsPerson.FindByID(PersonID);
            DisplayPersonInfoToForm(_PersonID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddNewPerson AddPerson = new frmAddNewPerson(-1);
            AddPerson.PersonIDBack += PersonID_DataBack;
            AddPerson.ShowDialog();
        }

      
    }
}
