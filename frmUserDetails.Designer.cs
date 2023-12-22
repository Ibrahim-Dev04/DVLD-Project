namespace DVLD_Project
{
    partial class frmUserDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClosefrm = new System.Windows.Forms.Button();
            this.ctrlPersonAndUserInfo1 = new DVLD_Project.ctrlPersonAndUserInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClosefrm
            // 
            this.btnClosefrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosefrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnClosefrm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClosefrm.FlatAppearance.BorderSize = 0;
            this.btnClosefrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosefrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClosefrm.ForeColor = System.Drawing.Color.White;
            this.btnClosefrm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClosefrm.Location = new System.Drawing.Point(841, 3);
            this.btnClosefrm.Name = "btnClosefrm";
            this.btnClosefrm.Size = new System.Drawing.Size(39, 29);
            this.btnClosefrm.TabIndex = 5;
            this.btnClosefrm.Text = "X";
            this.btnClosefrm.UseVisualStyleBackColor = false;
            this.btnClosefrm.Click += new System.EventHandler(this.btnClosefrm_Click);
            // 
            // ctrlPersonAndUserInfo1
            // 
            this.ctrlPersonAndUserInfo1.Location = new System.Drawing.Point(1, 79);
            this.ctrlPersonAndUserInfo1.Name = "ctrlPersonAndUserInfo1";
            this.ctrlPersonAndUserInfo1.Size = new System.Drawing.Size(879, 412);
            this.ctrlPersonAndUserInfo1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "frmUserInfo";
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 492);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPersonAndUserInfo1);
            this.Controls.Add(this.btnClosefrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUserDetails_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmUserDetails_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmUserDetails_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClosefrm;
        private ctrlPersonAndUserInfo ctrlPersonAndUserInfo1;
        private System.Windows.Forms.Label label1;
    }
}