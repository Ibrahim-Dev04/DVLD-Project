using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationTypesBusinessLayer;

namespace DVLD_Project
{
    public partial class frmManageApplicationTypes : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

     
        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void btnClosefrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _LoadMainImageToPb()
        {
            pbApplicationImage.ImageLocation = @"C:\DVLD project icons\application.png";
        }

        void _LoadApplicationTypesListToDgv()
        {
            DgvApplicationTypesList.DataSource = clsApplicationType.GetApplicationTypesList();
            lblNumberOfRecords.Text = DgvApplicationTypesList.Rows.Count.ToString();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _LoadMainImageToPb();
            _LoadApplicationTypesListToDgv();
        }

        private void frmManageApplicationTypes_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = dragFormPoint;
                newPoint.X += Cursor.Position.X - dragCursorPoint.X;
                newPoint.Y += Cursor.Position.Y - dragCursorPoint.Y;
                this.Location = newPoint;
            }
        }

        private void frmManageApplicationTypes_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmManageApplicationTypes_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppID = (int)DgvApplicationTypesList.CurrentRow.Cells[0].Value;

            frmUpdateApplicationType frm = new frmUpdateApplicationType(AppID);
            frm.ShowDialog();
            _LoadApplicationTypesListToDgv();
        }
    }
}
