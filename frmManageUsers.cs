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
    public partial class frmManageUsers : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageUsers_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmManageUsers_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmManageUsers_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = dragFormPoint;
                newPoint.X += Cursor.Position.X - dragCursorPoint.X;
                newPoint.Y += Cursor.Position.Y - dragCursorPoint.Y;
                this.Location = newPoint;
            }
        }

        void _LoadImageToPbox()
        {
            PbUsersfrmImage.ImageLocation = @"C:\DVLD project icons\User_.png";
        }

        void _LoadItemsToFilterByTocombobox()
        {
            CbFilterBy.Items.Add("None");
            CbFilterBy.Items.Add("User Id");
            CbFilterBy.Items.Add("Name");
            CbFilterBy.Items.Add("Person Id");
            CbFilterBy.Items.Add("UserName");
            CbFilterBy.SelectedItem = "None";
        }

        void _LoadUsersListToDGV()
        {
            DgvUsersList.DataSource = clsUser.GetUserslist();
        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _LoadImageToPbox();
            _LoadItemsToFilterByTocombobox();
            _LoadUsersListToDGV();
            this.MouseMove += frmManageUsers_MouseMove;
            this.MouseUp += frmManageUsers_MouseUp;
            this.MouseDown += frmManageUsers_MouseDown; 
        }

        private void TbFilterByValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            string FilterBy = CbFilterBy.SelectedItem.ToString();

            switch (FilterBy)
            {
                case "User Id":
                case "Person Id":
                    {
                        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                            e.Handled = true;
                    }
                    break;

                case "Name":
                    {
                        if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                            e.Handled = true;
                    }
                    break;

                case "UserName":
                    {
                        if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
               
            }
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFilterBy.SelectedItem == "None")
                TbFilterByValue.Visible = false;
            else
            {
                TbFilterByValue.Text = string.Empty;
                TbFilterByValue.Visible = true;
            }
        
    }

        void _GetUsersFilterByColumnValueAndLoadTodgv(string ColumnName,string ColumnValue)
        {
            DgvUsersList.DataSource = clsUser.GetUsersFilterByColumnValue(ColumnName, ColumnValue);
        }

        private void TbFilterByValue_TextChanged(object sender, EventArgs e)
        {
            string ColumnName = CbFilterBy.SelectedItem.ToString();
            string ColumnValue = TbFilterByValue.Text;
            if(string.IsNullOrEmpty(ColumnValue))
            {
                _LoadUsersListToDGV();
                return;
            }

            switch (ColumnName)
            {
                case "Person Id":
                     _GetUsersFilterByColumnValueAndLoadTodgv("PersonID",ColumnValue);
                    break;
                case "User Id":
                    _GetUsersFilterByColumnValueAndLoadTodgv("UserID", ColumnValue);
                    break;
                case "Name":
                    _GetUsersFilterByColumnValueAndLoadTodgv("FullName", ColumnValue);
                    break;
                case "None":
                    _LoadUsersListToDGV();
                    break;
                case "UserName":
                    _GetUsersFilterByColumnValueAndLoadTodgv("UserName",ColumnValue);
                    break;
                    
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser User = new frmAddNewUser();
            User.ShowDialog();
            _LoadUsersListToDGV();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserId =  (int)DgvUsersList.CurrentRow.Cells[0].Value;

            frmAddNewUser frmuser  = new frmAddNewUser(UserId);
            frmuser.ShowDialog();
            _LoadUsersListToDGV();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(DgvUsersList.CurrentRow.Cells[0].Value);
            
            if (MessageBox.Show("Are you sure to delete", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.Delete(UserID))
                {
                    MessageBox.Show("Record deleted Succesfully.", "Deleting Succed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record deleted Failed.", "Deleting failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            _LoadUsersListToDGV();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(DgvUsersList.CurrentRow.Cells[0].Value);
            frmUserDetails frm = new frmUserDetails(UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(DgvUsersList.CurrentRow.Cells[0].Value);
            frmChangeUserPassword frm = new frmChangeUserPassword(UserID);
            frm.ShowDialog();
        }
    }
}
