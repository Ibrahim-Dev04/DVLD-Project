using ApplicationTypesBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmUpdateApplicationType : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        clsApplicationType _AppTypeobj;
        public frmUpdateApplicationType(int AppTypeID)
        {
            InitializeComponent();
            _AppTypeobj = clsApplicationType.FindByID(AppTypeID);

            this.MouseMove += frmUpdateApplicationType_MouseMove;
            this.MouseUp += FrmUpdateApplicationType_MouseUp;
            this.MouseDown += frmUpdateApplicationType_MouseDown;
        }

        private void FrmUpdateApplicationType_MouseUp(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void frmUpdateApplicationType_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = dragFormPoint;
                newPoint.X += Cursor.Position.X - dragCursorPoint.X;
                newPoint.Y += Cursor.Position.Y - dragCursorPoint.Y;
                this.Location = newPoint;
            }
        }

        private void frmUpdateApplicationType_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmUpdateApplicationType_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        void _LoadImagesToFrom()
        {
            pbAppTitle.ImageLocation = @"C:\DVLD project icons\appTitle.png";
            pbFees.ImageLocation = @"C:\DVLD project icons\fees.png";
        }
        void _LoadAppTypeInfoToForm()
        {
            if (_AppTypeobj == null)
                return;

            lblAppId.Text = _AppTypeobj.ID.ToString();
            tbTitle.Text = _AppTypeobj.AppTypeTitle.ToString();
            tbFees.Text = _AppTypeobj.AppFees.ToString();
        }
        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            _LoadImagesToFrom();
            _LoadAppTypeInfoToForm();
        }

        void _FillAppTypeObjwithData()
        {
            _AppTypeobj.AppTypeTitle = tbTitle.Text;
            _AppTypeobj.AppFees = Convert.ToDecimal(tbFees.Text.ToString());
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClosefrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool _validationFailed()
        {
            return (string.IsNullOrEmpty(tbTitle.Text) || string.IsNullOrEmpty(tbFees.Text));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           if (_validationFailed())
            {
                MessageBox.Show("You missed some info", "missed info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _FillAppTypeObjwithData();

           if (_AppTypeobj.Save())
           {
               MessageBox.Show("Record saved Succesfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
               MessageBox.Show("Record save failed", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void ValidatingComboboxes(object sender, CancelEventArgs e)
        {
            TextBox Tb = sender as TextBox;

            if (string.IsNullOrEmpty(Tb.Text))
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
    }
}
