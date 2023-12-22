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
    public partial class frmPersonDetails : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();

            this.MouseDown += frmPersonDetails_MouseDown;
            this.MouseMove += frmPersonDetails_MouseMove;
            this.MouseUp += frmPersonDetails_MouseUp;
            ctrlPersonInformation1._DisplayPersonInfoToControl(PersonID);
        }

        /*You should use delegate to retrieve the personID for this form to load 
         * updated data again.
        */

        private void ctrlPersonInformation1_Load(object sender, EventArgs e)
        {
            
        }

        private void frmPersonDetails_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = dragFormPoint;
                newPoint.X += Cursor.Position.X - dragCursorPoint.X;
                newPoint.Y += Cursor.Position.Y - dragCursorPoint.Y;
                this.Location = newPoint;
            }
        }

        private void frmPersonDetails_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmPersonDetails_MouseDown(object sender, MouseEventArgs e)
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
