using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonBusinessLayer;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.IO;
using System.Threading;
using System.IO.Pipes;

namespace DVLD_Project
{
    public partial class frmAddNewPerson : Form
    {
        public delegate void DatabackEventHandler(object sender, int PersonID);
        public event DatabackEventHandler PersonIDBack;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        enum eMode { AddNew = 1 , Edit = 2 }
       
        int _PersonID = -1;
        string _MaleIconeimagePath ;
        string _FemaleIconeimagePath ;
        string _PersonImagePath;
        string _OpenFileDialogImagePath;
        string DestinationFolder ;
        string _Person_ImageFullFilePathDestination;
        clsPerson _objPerson;
        eMode _Mode;

        public frmAddNewPerson(int PersonID)
        {
            InitializeComponent();
            
            this._PersonID = PersonID;

            if (PersonID != -1)
            {
                _Mode = eMode.Edit;
                _objPerson = clsPerson.FindByID(PersonID);
            }
            else
            {
                _Mode = eMode.AddNew;
                _objPerson = new clsPerson();
            }


            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Optional
            this.MouseDown += frmAddNewPerson_MouseDown;
            this.MouseMove += frmAddNewPerson_MouseMove;
            this.MouseUp += frmAddNewPerson_MouseUp;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblPersonID.Text))
            {
                this.Close();
                return;
            }
                
            int PersonID = Convert.ToInt32( lblPersonID.Text.ToString());
            PersonIDBack?.Invoke(this, PersonID);
            this.Close();

        }

        private void ValidateTextBoxes(object sender, CancelEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (string.IsNullOrEmpty(textbox.Text))
            {
                errorProvider1.SetError(textbox, $"{textbox.Tag} is required");
                e.Cancel = true;
            }
            else
            {

                errorProvider1.SetError(textbox, "");
                e.Cancel = false;
            }
        }

        private void TextBoxes(object sender, KeyPressEventArgs e)
        {
            TextBox textbox1 = sender as TextBox;

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void validatingNationalNoTb(object sender, CancelEventArgs e)
        {
            TextBox Tb = sender as TextBox;
            if (string.IsNullOrEmpty(Tb.Text))
            {
                errorProvider1.SetError(Tb, "NationalNo is required");
                e.Cancel = true;
            }
            else if(/*!string.IsNullOrEmpty(Tb.Text) && */clsPerson.isExistByNationalNo(Tb.Text.ToString()))
            {
                errorProvider1.SetError(Tb, "This National number is used for another _objPerson");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(Tb, "");
                e.Cancel = false;
            }

        }

        private void ValidateEmailTb(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string emailPattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";

            if (!Regex.IsMatch(textBox.Text.ToString(), emailPattern) && !string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider1.SetError(textBox, "Email format is not valid,try Something@gamil.com");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox, "");
                e.Cancel = false;
            }
        }

        void _InitialTheDefaultImagePaths()
        {
            _MaleIconeimagePath = "C:\\DVLD project icons\\homme.png";
            _FemaleIconeimagePath = "C:\\DVLD project icons\\male2.png";
            DestinationFolder = "C:\\DVLD_People_Image";
        }

        void _LoadCountriesToCB()
        {
            DataTable dt = clsPerson.GetCountriesList();

            foreach (DataRow row in dt.Rows)
            {
                CbCountries.Items.Add(row["CountryName"]);

            }
        }

        void _SetSomeControlsAsDefault()
        {
            tbfirstName.Focus();
            PbPersonImage.Tag = _MaleIconeimagePath;
            rbMale.Checked = true;
            PbPersonImage.ImageLocation = _MaleIconeimagePath;
            // storing filepath in tag is for some logic reasons : to change the icons of the pbPersonImage based on the checked radio button
            Dtpdateofbirth.MaxDate = DateTime.Now.AddYears(-18);
        }

        void _DisplayPersonDataToTheForm()
        {
            if(_objPerson != null)
            {
                LblAdd_Edit.Text = "Update Person";
                lblPersonID.Text = _objPerson.PersonID.ToString();
                tbfirstName.Text = _objPerson.FirstName;
                tbSecondName.Text = _objPerson.SecondName;
                tbthirdname.Text = _objPerson.ThirdName;
                tblastname.Text = _objPerson.LastName;
                tbNationalNo.Text = _objPerson.NationalNo;
                Dtpdateofbirth.Text = _objPerson.DateOfBirth.ToString();
                if (_objPerson.Gender == 0)
                    rbMale.Checked = true;
                else
                    rbfemale.Checked = true;

                tbPhone.Text = _objPerson.Phone;
                tbEmail.Text = _objPerson.Email;
                CbCountries.SelectedItem = clsPerson.GetPersonCountry(_PersonID);
                tbAddress.Text = _objPerson.Address;
                PbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
                if (_objPerson.ImagePath != "")  
                {
                    if (_CheckIsImageExisted(_objPerson.ImagePath))
                    {
                        PbPersonImage.ImageLocation = _objPerson.ImagePath;
                        _PersonImagePath = _objPerson.ImagePath;
                        PbPersonImage.Tag = PbPersonImage.Image;
                    }
                     
                }
            }
            else
            {
                MessageBox.Show("Error to find _objPerson", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }

        }

        string _GetGuidImageForDestFilePath()
        {
            Guid NewGuid = Guid.NewGuid();

             _Person_ImageFullFilePathDestination = Path.Combine(DestinationFolder, (NewGuid.ToString() + Path.GetExtension(_OpenFileDialogImagePath)));

            return _Person_ImageFullFilePathDestination;
        }

        void _CopyImagetoDVLD_people_ImagesFolder()
        {
            if (!_CheckIsPersonImageSet())
            {
                return;
            }

            else
            {
                try
                {
                    if (_Mode == eMode.Edit)
                    {
                        if (!File.Exists(_PersonImagePath))
                        {
                            File.Copy(_OpenFileDialogImagePath, _Person_ImageFullFilePathDestination, true);
                            PbPersonImage.Tag = _Person_ImageFullFilePathDestination.ToString();
                            PbPersonImage.ImageLocation = _Person_ImageFullFilePathDestination;
                        }
                        else
                        {

                            File.Copy(_OpenFileDialogImagePath, _Person_ImageFullFilePathDestination, true);
                            PbPersonImage.Tag = _Person_ImageFullFilePathDestination.ToString();
                            PbPersonImage.ImageLocation = _Person_ImageFullFilePathDestination;
                            //Thread.Sleep(1000);
                            File.Delete(_PersonImagePath);
                        }
                    }
                    else
                    {

                        File.Copy(_OpenFileDialogImagePath, _Person_ImageFullFilePathDestination, true);
                    }

                }
                catch (Exception ex)
                {

                }
            }
        }  

        bool _CheckIsImageExisted(string Imagepath)
        {
            return File.Exists(Imagepath);
        }

        private void frmAddNewPerson_Load(object sender, EventArgs e)
        {
            _InitialTheDefaultImagePaths();
             _SetSomeControlsAsDefault();
            _LoadCountriesToCB();

            if (_Mode == eMode.Edit)
            {
                _DisplayPersonDataToTheForm();
                return;
            }
        }

        private void TbPhone_keyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {
            
            if (_MaleIconeimagePath.Equals(PbPersonImage.Tag.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                PbPersonImage.Tag = _FemaleIconeimagePath;
                PbPersonImage.ImageLocation = _FemaleIconeimagePath;
            }
           
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
           
            if (_FemaleIconeimagePath.Equals(PbPersonImage.Tag.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                PbPersonImage.ImageLocation = _MaleIconeimagePath;
                PbPersonImage.Tag = _MaleIconeimagePath;
            }
               
        }

        private void NationalNo_PerssKey(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled |= true;
            }
        }

        private void lblImageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               _OpenFileDialogImagePath = openFileDialog.FileName;

                PbPersonImage.Image = Image.FromFile(_OpenFileDialogImagePath);
                //PbPersonImage.ImageLocation = _OpenFileDialogImagePath;
                PbPersonImage.Tag = _OpenFileDialogImagePath;
                lbRmoveImage.Visible = true;
            }

           
        }

        bool _isThereAmissedPersonInfo()
        {
            if (tbfirstName.Text == "" || tbSecondName.Text == "" || tblastname.Text == "" || tbNationalNo.Text == ""
                || tbPhone.Text == "" || CbCountries.SelectedIndex == -1 || tbAddress.Text == "")

                return true;
            else
                return false;
        }

        bool _CheckIsPersonImageSet()
        {
            if (_MaleIconeimagePath.Equals(PbPersonImage.Tag.ToString(), StringComparison.OrdinalIgnoreCase)
                || _FemaleIconeimagePath.Equals(PbPersonImage.Tag.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            else
            {
                return true;
            }
               
        }

        void _FillPersonObjectWithEnteredInfo()
        {
            if (_objPerson == null)
                return;

            _objPerson.FirstName = tbfirstName.Text;
            _objPerson.SecondName = tbSecondName.Text;
            _objPerson.ThirdName = tbthirdname.Text;
            _objPerson.LastName = tblastname.Text;
            _objPerson.NationalNo = tbNationalNo.Text;
            _objPerson.DateOfBirth = Dtpdateofbirth.Value;
            _objPerson.Phone = tbPhone.Text;
            _objPerson.Email = tbEmail.Text;
            _objPerson.NatCountryID = clsPerson.GetNatCountryIDByCountryName(CbCountries.SelectedItem.ToString()) ;
            _objPerson.Address = tbAddress.Text;

            if (rbfemale.Checked)
                _objPerson.Gender = 1;
            else
                _objPerson.Gender = 0;

            if (_CheckIsPersonImageSet())
            {
                _objPerson.ImagePath = _Person_ImageFullFilePathDestination ;
            }
            else
                _objPerson.ImagePath = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void CbCountries_Validating(object sender, CancelEventArgs e)
        {
            

            if(CbCountries.SelectedIndex == -1)
            {
                errorProvider1.SetError(CbCountries, "County is Obligatory to enter");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(CbCountries, "");
                e.Cancel = false;
            }
        }

        void _DisplayPersonIDToForm()
        {
            lblPersonID.Text = _objPerson.PersonID.ToString(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isThereAmissedPersonInfo())
            {
                MessageBox.Show("There are some missed info,please try to enter all the important info");
                return;
            }

            _Person_ImageFullFilePathDestination = _GetGuidImageForDestFilePath();
            
            _FillPersonObjectWithEnteredInfo();

            if (_objPerson.Save())
            {
                _DisplayPersonIDToForm();
                _CopyImagetoDVLD_people_ImagesFolder();//this method still not complited,it need some features to add
                MessageBox.Show("Person Saved succesfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Person Added Failed", "Add new", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbRmoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rbMale.Checked)
            {
                PbPersonImage.ImageLocation = _MaleIconeimagePath;
                PbPersonImage.Tag = _MaleIconeimagePath;
            }
            else
            {
                PbPersonImage.ImageLocation = _FemaleIconeimagePath;
                PbPersonImage.ImageLocation = _FemaleIconeimagePath;
            }
        }

        private void frmAddNewPerson_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmAddNewPerson_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = dragFormPoint;
                newPoint.X += Cursor.Position.X - dragCursorPoint.X;
                newPoint.Y += Cursor.Position.Y - dragCursorPoint.Y;
                this.Location = newPoint;
            }
        }

        private void frmAddNewPerson_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
