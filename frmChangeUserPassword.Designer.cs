namespace DVLD_Project
{
    partial class frmChangeUserPassword
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
            this.components = new System.ComponentModel.Container();
            this.ctrlPersonAndUserInfo1 = new DVLD_Project.ctrlPersonAndUserInfo();
            this.TbNewpassword = new System.Windows.Forms.TextBox();
            this.TbCrrentPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.TbConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClosefrm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlPersonAndUserInfo1
            // 
            this.ctrlPersonAndUserInfo1.Location = new System.Drawing.Point(0, 42);
            this.ctrlPersonAndUserInfo1.Name = "ctrlPersonAndUserInfo1";
            this.ctrlPersonAndUserInfo1.Size = new System.Drawing.Size(939, 412);
            this.ctrlPersonAndUserInfo1.TabIndex = 0;
            // 
            // TbNewpassword
            // 
            this.TbNewpassword.Location = new System.Drawing.Point(187, 523);
            this.TbNewpassword.Name = "TbNewpassword";
            this.TbNewpassword.PasswordChar = '*';
            this.TbNewpassword.Size = new System.Drawing.Size(163, 26);
            this.TbNewpassword.TabIndex = 6;
            this.TbNewpassword.Tag = "New password";
            this.TbNewpassword.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxes_Validating);
            // 
            // TbCrrentPassword
            // 
            this.TbCrrentPassword.Location = new System.Drawing.Point(187, 477);
            this.TbCrrentPassword.Name = "TbCrrentPassword";
            this.TbCrrentPassword.PasswordChar = '*';
            this.TbCrrentPassword.Size = new System.Drawing.Size(163, 26);
            this.TbCrrentPassword.TabIndex = 4;
            this.TbCrrentPassword.Tag = "Current Password";
            this.TbCrrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.CurrentPassword_Validating);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(37, 527);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(138, 22);
            this.lblNewPassword.TabIndex = 7;
            this.lblNewPassword.Text = "New password :";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(11, 478);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(164, 22);
            this.lblCurrentPassword.TabIndex = 5;
            this.lblCurrentPassword.Text = "Current Password :";
            // 
            // TbConfirmPassword
            // 
            this.TbConfirmPassword.Location = new System.Drawing.Point(187, 569);
            this.TbConfirmPassword.Name = "TbConfirmPassword";
            this.TbConfirmPassword.PasswordChar = '*';
            this.TbConfirmPassword.Size = new System.Drawing.Size(163, 26);
            this.TbConfirmPassword.TabIndex = 8;
            this.TbConfirmPassword.Tag = "Confirm password";
            this.TbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingCofirmPassword);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(11, 571);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(164, 22);
            this.lblConfirmPassword.TabIndex = 9;
            this.lblConfirmPassword.Text = "Confirm password :";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD_Project.Properties.Resources._save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(822, 609);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 39);
            this.btnSave.TabIndex = 16;
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
            this.btnclose.Location = new System.Drawing.Point(691, 609);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 39);
            this.btnclose.TabIndex = 15;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnClosefrm.Location = new System.Drawing.Point(899, 4);
            this.btnClosefrm.Name = "btnClosefrm";
            this.btnClosefrm.Size = new System.Drawing.Size(37, 29);
            this.btnClosefrm.TabIndex = 17;
            this.btnClosefrm.Text = "X";
            this.btnClosefrm.UseVisualStyleBackColor = false;
            this.btnClosefrm.Click += new System.EventHandler(this.btnClosefrm_Click);
            // 
            // frmChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 658);
            this.ControlBox = false;
            this.Controls.Add(this.btnClosefrm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.TbConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.TbNewpassword);
            this.Controls.Add(this.TbCrrentPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.ctrlPersonAndUserInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChangeUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmChangeUserPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonAndUserInfo ctrlPersonAndUserInfo1;
        private System.Windows.Forms.TextBox TbNewpassword;
        private System.Windows.Forms.TextBox TbCrrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox TbConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnClosefrm;
    }
}