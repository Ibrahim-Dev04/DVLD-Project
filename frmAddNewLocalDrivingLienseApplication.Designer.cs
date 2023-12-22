namespace DVLD_Project
{
    partial class frmAddNewLocalDrivingLienseApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClosefrm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TcAddNewLocalDrivingLicenseApp = new System.Windows.Forms.TabControl();
            this.TpPersonalinfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctlrPersonCardWithFilter1 = new DVLD_Project.ctlrPersonCardWithFilter();
            this.TpApplicationinfo = new System.Windows.Forms.TabPage();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblUserCreatedBy = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.TcAddNewLocalDrivingLicenseApp.SuspendLayout();
            this.TpPersonalinfo.SuspendLayout();
            this.TpApplicationinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new local driving license application";
            // 
            // btnClosefrm
            // 
            this.btnClosefrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosefrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnClosefrm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClosefrm.FlatAppearance.BorderSize = 0;
            this.btnClosefrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosefrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosefrm.ForeColor = System.Drawing.Color.White;
            this.btnClosefrm.Location = new System.Drawing.Point(925, 2);
            this.btnClosefrm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClosefrm.Name = "btnClosefrm";
            this.btnClosefrm.Size = new System.Drawing.Size(25, 29);
            this.btnClosefrm.TabIndex = 21;
            this.btnClosefrm.Text = "X";
            this.btnClosefrm.UseVisualStyleBackColor = false;
            this.btnClosefrm.Click += new System.EventHandler(this.btnClosefrm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(173, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Add new local driving license application";
            // 
            // TcAddNewLocalDrivingLicenseApp
            // 
            this.TcAddNewLocalDrivingLicenseApp.Controls.Add(this.TpPersonalinfo);
            this.TcAddNewLocalDrivingLicenseApp.Controls.Add(this.TpApplicationinfo);
            this.TcAddNewLocalDrivingLicenseApp.Location = new System.Drawing.Point(15, 113);
            this.TcAddNewLocalDrivingLicenseApp.Name = "TcAddNewLocalDrivingLicenseApp";
            this.TcAddNewLocalDrivingLicenseApp.SelectedIndex = 0;
            this.TcAddNewLocalDrivingLicenseApp.Size = new System.Drawing.Size(924, 485);
            this.TcAddNewLocalDrivingLicenseApp.TabIndex = 23;
            // 
            // TpPersonalinfo
            // 
            this.TpPersonalinfo.Controls.Add(this.btnNext);
            this.TpPersonalinfo.Controls.Add(this.ctlrPersonCardWithFilter1);
            this.TpPersonalinfo.Location = new System.Drawing.Point(4, 29);
            this.TpPersonalinfo.Name = "TpPersonalinfo";
            this.TpPersonalinfo.Padding = new System.Windows.Forms.Padding(3);
            this.TpPersonalinfo.Size = new System.Drawing.Size(916, 452);
            this.TpPersonalinfo.TabIndex = 0;
            this.TpPersonalinfo.Text = "Personal info";
            this.TpPersonalinfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::DVLD_Project.Properties.Resources.arrow_right1;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(761, 400);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 46);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctlrPersonCardWithFilter1
            // 
            this.ctlrPersonCardWithFilter1.Location = new System.Drawing.Point(12, 2);
            this.ctlrPersonCardWithFilter1.Name = "ctlrPersonCardWithFilter1";
            this.ctlrPersonCardWithFilter1.Size = new System.Drawing.Size(888, 392);
            this.ctlrPersonCardWithFilter1.TabIndex = 0;
            this.ctlrPersonCardWithFilter1.OnPersonSelected += new System.Action<int>(this.ctlrPersonCardWithFilter1_OnPersonSelected);
            // 
            // TpApplicationinfo
            // 
            this.TpApplicationinfo.Controls.Add(this.lblApplicationID);
            this.TpApplicationinfo.Controls.Add(this.pictureBox4);
            this.TpApplicationinfo.Controls.Add(this.lblUserCreatedBy);
            this.TpApplicationinfo.Controls.Add(this.pictureBox3);
            this.TpApplicationinfo.Controls.Add(this.lblAppFees);
            this.TpApplicationinfo.Controls.Add(this.pictureBox2);
            this.TpApplicationinfo.Controls.Add(this.CbLicenseClasses);
            this.TpApplicationinfo.Controls.Add(this.pictureBox1);
            this.TpApplicationinfo.Controls.Add(this.lblApplicationDate);
            this.TpApplicationinfo.Controls.Add(this.pictureBox7);
            this.TpApplicationinfo.Controls.Add(this.label7);
            this.TpApplicationinfo.Controls.Add(this.label6);
            this.TpApplicationinfo.Controls.Add(this.label5);
            this.TpApplicationinfo.Controls.Add(this.label4);
            this.TpApplicationinfo.Controls.Add(this.label3);
            this.TpApplicationinfo.Location = new System.Drawing.Point(4, 29);
            this.TpApplicationinfo.Name = "TpApplicationinfo";
            this.TpApplicationinfo.Padding = new System.Windows.Forms.Padding(3);
            this.TpApplicationinfo.Size = new System.Drawing.Size(916, 452);
            this.TpApplicationinfo.TabIndex = 1;
            this.TpApplicationinfo.Text = "clsApplication info";
            this.TpApplicationinfo.UseVisualStyleBackColor = true;
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(317, 80);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(59, 20);
            this.lblApplicationID.TabIndex = 59;
            this.lblApplicationID.Text = "[????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Project.Properties.Resources.nationalid;
            this.pictureBox4.Location = new System.Drawing.Point(269, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 58;
            this.pictureBox4.TabStop = false;
            // 
            // lblUserCreatedBy
            // 
            this.lblUserCreatedBy.AutoSize = true;
            this.lblUserCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCreatedBy.Location = new System.Drawing.Point(316, 260);
            this.lblUserCreatedBy.Name = "lblUserCreatedBy";
            this.lblUserCreatedBy.Size = new System.Drawing.Size(59, 20);
            this.lblUserCreatedBy.TabIndex = 57;
            this.lblUserCreatedBy.Text = "[????]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(266, 254);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.Location = new System.Drawing.Point(316, 212);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(59, 20);
            this.lblAppFees.TabIndex = 55;
            this.lblAppFees.Text = "[????]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.fees;
            this.pictureBox2.Location = new System.Drawing.Point(267, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // CbLicenseClasses
            // 
            this.CbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbLicenseClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbLicenseClasses.FormattingEnabled = true;
            this.CbLicenseClasses.Location = new System.Drawing.Point(318, 164);
            this.CbLicenseClasses.Name = "CbLicenseClasses";
            this.CbLicenseClasses.Size = new System.Drawing.Size(346, 28);
            this.CbLicenseClasses.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.License1;
            this.pictureBox1.Location = new System.Drawing.Point(267, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(316, 125);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(59, 20);
            this.lblApplicationDate.TabIndex = 51;
            this.lblApplicationDate.Text = "[????]";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD_Project.Properties.Resources.date1;
            this.pictureBox7.Location = new System.Drawing.Point(267, 122);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 50;
            this.pictureBox7.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Created By :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "clsApplication Fees :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "License class :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "clsApplication date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "D.L clsApplication ID :";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD_Project.Properties.Resources._save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(824, 604);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 39);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save\r\n";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnclose
            // 
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::DVLD_Project.Properties.Resources.close21;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(704, 604);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 39);
            this.btnclose.TabIndex = 24;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmAddNewLocalDrivingLienseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 654);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.TcAddNewLocalDrivingLicenseApp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClosefrm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddNewLocalDrivingLienseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAddNewLocalDrivingLienseApplication_Load);
            this.TcAddNewLocalDrivingLicenseApp.ResumeLayout(false);
            this.TpPersonalinfo.ResumeLayout(false);
            this.TpApplicationinfo.ResumeLayout(false);
            this.TpApplicationinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClosefrm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl TcAddNewLocalDrivingLicenseApp;
        private System.Windows.Forms.TabPage TpPersonalinfo;
        private System.Windows.Forms.TabPage TpApplicationinfo;
        private ctlrPersonCardWithFilter ctlrPersonCardWithFilter1;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CbLicenseClasses;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserCreatedBy;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnclose;
    }
}