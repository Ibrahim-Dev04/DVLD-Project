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
    public partial class frmUserDetails : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        int _userID;
        clsUser User;

        public frmUserDetails(int UserID)
        {
            this.MouseDown += frmUserDetails_MouseDown;
            this.MouseMove += frmUserDetails_MouseMove;
            this.MouseUp += frmUserDetails_MouseUp;

            InitializeComponent();

            ctrlPersonAndUserInfo1.DisplayUserInfoToForm(UserID);
        }

        private void frmUserDetails_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = dragFormPoint;
                newPoint.X += Cursor.Position.X - dragCursorPoint.X;
                newPoint.Y += Cursor.Position.Y - dragCursorPoint.Y;
                this.Location = newPoint;
            }
        }

        private void frmUserDetails_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmUserDetails_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void btnClosefrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
