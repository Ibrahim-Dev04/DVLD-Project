using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeBusinessLayer;

namespace DVLD_Project
{
    public partial class frmUpdateTestType : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        clsTestType _TestType_obj;

        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            _TestType_obj = clsTestType.FindByID(TestTypeID);

            this.MouseMove += frmUpdateTestType_MouseMove;
            this.MouseUp += FrmUpdateTestType_MouseUp; ;
            this.MouseDown += frmUpdateTestType_MouseDown;
        }

        private void FrmUpdateTestType_MouseUp(object sender, MouseEventArgs e)
        {

            dragging = false;
        }

        private void btnClosefrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _LoadfrmMainControlImages()
        {
            pbTestTitle.ImageLocation = @"C:\DVLD project icons\appTitle.png";
            pbTestDescription.ImageLocation = @"C:\DVLD project icons\Description32.png";
            pbFees.ImageLocation = @"C:\DVLD project icons\fees.png";
        }

        void _LoadTestTypeInfoToForm()
        {
            lbltestId.Text     = _TestType_obj.ID.ToString();
            tbTitle.Text       = _TestType_obj.TestTypeTitle.ToString();
            tbDescription.Text = _TestType_obj.TestTypeDescription.ToString();
            tbFees.Text       = _TestType_obj.TestTypeFees.ToString();
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _LoadfrmMainControlImages();
            _LoadTestTypeInfoToForm();
        }

        bool _ValidationFails()
        {
            return (string.IsNullOrEmpty(tbTitle.Text) || string.IsNullOrEmpty(tbDescription.Text) || string.IsNullOrEmpty(tbFees.Text));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidationFails())
            {
                MessageBox.Show("some info are missed,try to fill all info", "Missed info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestType_obj.TestTypeTitle = tbTitle.Text;
            _TestType_obj.TestTypeDescription = tbDescription.Text;
            _TestType_obj.TestTypeFees = Convert.ToDecimal(tbFees.Text);

            if (_TestType_obj.Save())
            {
                MessageBox.Show("Record Saved successfully","Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record saved fails", "Missed info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ValidateTextBoxes(object sender, CancelEventArgs e)
        {
            TextBox Tb = sender as TextBox;
            ErrorProvider ep = new ErrorProvider();
            if (string.IsNullOrEmpty(Tb.Text))
            {
                ep.SetError(Tb,$"{Tb.Tag} is required");
                e.Cancel = true;
            }
            else
            {
                ep.SetError(Tb, "");
                e.Cancel = false;
            }

        }

        private void frmUpdateTestType_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmUpdateTestType_MouseMove(object sender, MouseEventArgs e)
        {

            if (dragging)
            {
                Point newPoint = dragFormPoint;
                newPoint.X += Cursor.Position.X - dragCursorPoint.X;
                newPoint.Y += Cursor.Position.Y - dragCursorPoint.Y;
                this.Location = newPoint;
            }
        }

      
    }
}
