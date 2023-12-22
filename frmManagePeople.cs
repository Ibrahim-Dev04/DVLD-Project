using PersonBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        clsPerson _Person;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _LoadPeopleListToDGV()
        {
            dgvpeopleList.Refresh();
            DataTable dt = clsPerson.GetPeopleList();
            dgvpeopleList.DataSource = dt;
        }

        void _LoadColumnNameToFilterbyCB()
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

        void _DeletePersonImageFromfolder()
        {
            try
            {
                if (File.Exists(_Person.ImagePath))
                {
                    File.Delete(_Person.ImagePath);
                }

            }
            catch(Exception ex)
            {

            }
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _LoadColumnNameToFilterbyCB();
            _LoadPeopleListToDGV();

            LblTotalRecords.Text = dgvpeopleList.Rows.Count.ToString();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(-1);

            frm.ShowDialog();
            _LoadPeopleListToDGV();
            LblTotalRecords.Text = dgvpeopleList.Rows.Count.ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvpeopleList.CurrentRow.Cells[0].Value;
            frmAddNewPerson frm = new frmAddNewPerson(PersonID);
            frm.ShowDialog();
            _LoadPeopleListToDGV();
            LblTotalRecords.Text = dgvpeopleList.Rows.Count.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvpeopleList.CurrentRow.Cells[0].Value;

            _Person = clsPerson.FindByID(PersonID); 
            if (clsPerson.Delete(PersonID))
            {
                _DeletePersonImageFromfolder();
                MessageBox.Show("Record deleted Succesfully", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadPeopleListToDGV();
            }
            else
            {
                MessageBox.Show("Deleting failed", "delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LblTotalRecords.Text = dgvpeopleList.Rows.Count.ToString();
        }

        void _FilterByColumnName(string ColumnName,string ColumnValue)
        {
            
            DataTable PeopleListFilgerByColumnName = clsPerson.GetPeoplelistFilterdByColumnName(ColumnName, ColumnValue);

            if (string.IsNullOrEmpty(ColumnValue))
            {
                dgvpeopleList.DataSource = clsPerson.GetPeopleList();

            }
            else
            {
                if (ColumnName == "DateOfBirth")
                {
                    dgvpeopleList.DataSource = clsPerson.GetPeoplelistFilterdByBirthDate(ColumnValue);
                }
                else
                {
                    dgvpeopleList.DataSource = clsPerson.GetPeoplelistFilterdByColumnName(ColumnName, ColumnValue);
                    // it still something not completed here like to show the table header even when datatable return no record.
                }

            }
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CbFilterBy.SelectedIndex != -1 && CbFilterBy.SelectedItem != "None")
            {
                TbFilterByValue.Visible = true;
            }
        }

        private void TbFilterByValue_TextChanged(object sender, EventArgs e)
        {
            string Columnvalue = TbFilterByValue.Text.ToString();
            string FilterBy = CbFilterBy.SelectedItem.ToString();
            TbFilterByValue.Visible = true;

            if (Columnvalue == " ")
                return;
            switch (FilterBy)
            {
                
                case "Person ID":
                        _FilterByColumnName("PersonID",Columnvalue);
                    break;
                case "National No":
                    _FilterByColumnName("NationalNo", Columnvalue);
                    break;
                case "First Name":
                        _FilterByColumnName("FirstName", Columnvalue);
                    break;
                case "Second Name":
                    _FilterByColumnName("SecondName", Columnvalue);
                    break;
                case "Third Name":
                    _FilterByColumnName("ThirdName", Columnvalue);
                    break;
                case "Last Name":
                    _FilterByColumnName("LastName", Columnvalue);
                    break;
                case "Gender":
                    {
                        if(Columnvalue == "")
                        {
                            dgvpeopleList.DataSource = clsPerson.GetPeopleList();
                        }

                        else if ( Columnvalue.ToLower() == "female")
                        {
                            _FilterByColumnName("Gender", "1");
                        }
                        else if ( Columnvalue.ToLower() == "male")
                        {
                            _FilterByColumnName("Gender", "0");
                        }
                        else
                        {
                            dgvpeopleList.DataSource = null;
                        }
                        
                    }
                    
                    break;
                case "Date Of Birth":
                    _FilterByColumnName("DateOfBirth", Columnvalue);
                    break;
                case "Nationality":
                    _FilterByColumnName("CountryName", Columnvalue);
                    break;
                case "Phone":
                    _FilterByColumnName("Phone", Columnvalue);
                    break;
                case "Email":
                    _FilterByColumnName("Email", Columnvalue);
                    break;
                default:
                    break;
            }
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

      

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgvpeopleList.CurrentRow.Cells[0].Value);
            frmPersonDetails frmPersonDetails = new frmPersonDetails(PersonID);
            frmPersonDetails.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(-1);
            frm.ShowDialog();
            _LoadPeopleListToDGV();
            LblTotalRecords.Text = dgvpeopleList.Rows.Count.ToString();
        }
    }
}
