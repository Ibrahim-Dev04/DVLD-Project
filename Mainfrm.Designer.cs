namespace DVLD_Project
{
    partial class Mainfrm
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
            this.MenuStrpAccountSettings = new System.Windows.Forms.MenuStrip();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmItemMangeApptypes = new System.Windows.Forms.ToolStripMenuItem();
            this.TestTypesToolMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicenseServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMenuStripPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClosefrm = new System.Windows.Forms.Button();
            this.MenuStrpAccountSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrpAccountSettings
            // 
            this.MenuStrpAccountSettings.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrpAccountSettings.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrpAccountSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountSettingsToolStripMenuItem,
            this.ToolMenuStripPeople,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem1});
            this.MenuStrpAccountSettings.Location = new System.Drawing.Point(0, 0);
            this.MenuStrpAccountSettings.Name = "MenuStrpAccountSettings";
            this.MenuStrpAccountSettings.Size = new System.Drawing.Size(1184, 80);
            this.MenuStrpAccountSettings.TabIndex = 4;
            this.MenuStrpAccountSettings.Text = "menuStrip1";
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmItemMangeApptypes,
            this.TestTypesToolMenuStrip,
            this.drivingLicenseServicesToolStripMenuItem,
            this.manageAToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Applicants;
            this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(218, 76);
            this.accountSettingsToolStripMenuItem.Text = "Applications";
            this.accountSettingsToolStripMenuItem.Click += new System.EventHandler(this.accountSettingsToolStripMenuItem_Click);
            // 
            // TsmItemMangeApptypes
            // 
            this.TsmItemMangeApptypes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmItemMangeApptypes.Image = global::DVLD_Project.Properties.Resources.management64;
            this.TsmItemMangeApptypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TsmItemMangeApptypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsmItemMangeApptypes.Name = "TsmItemMangeApptypes";
            this.TsmItemMangeApptypes.Size = new System.Drawing.Size(438, 82);
            this.TsmItemMangeApptypes.Text = "Manage clsApplication Types";
            this.TsmItemMangeApptypes.Click += new System.EventHandler(this.TsmItemMangeApptypes_Click);
            // 
            // TestTypesToolMenuStrip
            // 
            this.TestTypesToolMenuStrip.Image = global::DVLD_Project.Properties.Resources.Test64;
            this.TestTypesToolMenuStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TestTypesToolMenuStrip.Name = "TestTypesToolMenuStrip";
            this.TestTypesToolMenuStrip.Size = new System.Drawing.Size(438, 82);
            this.TestTypesToolMenuStrip.Text = "Manage Test Types";
            this.TestTypesToolMenuStrip.Click += new System.EventHandler(this.TestTypesToolMenuStrip_Click);
            // 
            // drivingLicenseServicesToolStripMenuItem
            // 
            this.drivingLicenseServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem});
            this.drivingLicenseServicesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.License;
            this.drivingLicenseServicesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drivingLicenseServicesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.drivingLicenseServicesToolStripMenuItem.Name = "drivingLicenseServicesToolStripMenuItem";
            this.drivingLicenseServicesToolStripMenuItem.Size = new System.Drawing.Size(438, 82);
            this.drivingLicenseServicesToolStripMenuItem.Text = "Driving License Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.globalToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.AddLicense;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(308, 36);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            this.newDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.newDrivingLicenseToolStripMenuItem_Click);
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.LocalLIcense;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(308, 36);
            this.localLicenseToolStripMenuItem.Text = "Local license";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // globalToolStripMenuItem
            // 
            this.globalToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.international;
            this.globalToolStripMenuItem.Name = "globalToolStripMenuItem";
            this.globalToolStripMenuItem.Size = new System.Drawing.Size(308, 36);
            this.globalToolStripMenuItem.Text = "International license";
            // 
            // manageAToolStripMenuItem
            // 
            this.manageAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicensesToolStripMenuItem});
            this.manageAToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.project_management64;
            this.manageAToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageAToolStripMenuItem.Name = "manageAToolStripMenuItem";
            this.manageAToolStripMenuItem.Size = new System.Drawing.Size(438, 82);
            this.manageAToolStripMenuItem.Text = "Manage applications";
            this.manageAToolStripMenuItem.Click += new System.EventHandler(this.manageAToolStripMenuItem_Click);
            // 
            // localDrivingLicensesToolStripMenuItem
            // 
            this.localDrivingLicensesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.LocalLIcense;
            this.localDrivingLicensesToolStripMenuItem.Name = "localDrivingLicensesToolStripMenuItem";
            this.localDrivingLicensesToolStripMenuItem.Size = new System.Drawing.Size(428, 36);
            this.localDrivingLicensesToolStripMenuItem.Text = "Local driving licenses application";
            this.localDrivingLicensesToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicensesToolStripMenuItem_Click);
            // 
            // ToolMenuStripPeople
            // 
            this.ToolMenuStripPeople.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolMenuStripPeople.Image = global::DVLD_Project.Properties.Resources.People;
            this.ToolMenuStripPeople.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolMenuStripPeople.Name = "ToolMenuStripPeople";
            this.ToolMenuStripPeople.Size = new System.Drawing.Size(163, 76);
            this.ToolMenuStripPeople.Text = "People";
            this.ToolMenuStripPeople.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Users;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(151, 76);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem1
            // 
            this.accountSettingsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem1,
            this.changePasswordToolStripMenuItem1,
            this.signOutToolStripMenuItem1});
            this.accountSettingsToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingsToolStripMenuItem1.Image = global::DVLD_Project.Properties.Resources.account_settings;
            this.accountSettingsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.White;
            this.accountSettingsToolStripMenuItem1.Name = "accountSettingsToolStripMenuItem1";
            this.accountSettingsToolStripMenuItem1.Size = new System.Drawing.Size(261, 76);
            this.accountSettingsToolStripMenuItem1.Text = "Account Settings";
            this.accountSettingsToolStripMenuItem1.MouseHover += new System.EventHandler(this.accountSettingsToolStripMenuItem1_MouseHover);
            // 
            // currentUserInfoToolStripMenuItem1
            // 
            this.currentUserInfoToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.currentUserInfoToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserInfoToolStripMenuItem1.Image = global::DVLD_Project.Properties.Resources.UserInfo;
            this.currentUserInfoToolStripMenuItem1.Name = "currentUserInfoToolStripMenuItem1";
            this.currentUserInfoToolStripMenuItem1.Size = new System.Drawing.Size(279, 36);
            this.currentUserInfoToolStripMenuItem1.Text = "Current user info";
            this.currentUserInfoToolStripMenuItem1.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem1_Click);
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.changePasswordToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem1.Image = global::DVLD_Project.Properties.Resources.password;
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(279, 36);
            this.changePasswordToolStripMenuItem1.Text = "Change password";
            this.changePasswordToolStripMenuItem1.Click += new System.EventHandler(this.changePasswordToolStripMenuItem1_Click);
            // 
            // signOutToolStripMenuItem1
            // 
            this.signOutToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.signOutToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutToolStripMenuItem1.Image = global::DVLD_Project.Properties.Resources.sign_out__1_;
            this.signOutToolStripMenuItem1.Name = "signOutToolStripMenuItem1";
            this.signOutToolStripMenuItem1.Size = new System.Drawing.Size(279, 36);
            this.signOutToolStripMenuItem1.Text = "Sign Out";
            this.signOutToolStripMenuItem1.Click += new System.EventHandler(this.signOutToolStripMenuItem1_Click);
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
            this.btnClosefrm.Location = new System.Drawing.Point(1151, 0);
            this.btnClosefrm.Name = "btnClosefrm";
            this.btnClosefrm.Size = new System.Drawing.Size(33, 29);
            this.btnClosefrm.TabIndex = 5;
            this.btnClosefrm.Text = "X";
            this.btnClosefrm.UseVisualStyleBackColor = false;
            this.btnClosefrm.Click += new System.EventHandler(this.btnClosefrm_Click);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 500);
            this.Controls.Add(this.btnClosefrm);
            this.Controls.Add(this.MenuStrpAccountSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrpAccountSettings;
            this.Name = "Mainfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainfrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.MenuStrpAccountSettings.ResumeLayout(false);
            this.MenuStrpAccountSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrpAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolMenuStripPeople;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem1;
        private System.Windows.Forms.Button btnClosefrm;
        private System.Windows.Forms.ToolStripMenuItem TsmItemMangeApptypes;
        private System.Windows.Forms.ToolStripMenuItem TestTypesToolMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenseServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicensesToolStripMenuItem;
    }
}