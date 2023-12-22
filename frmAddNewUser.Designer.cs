namespace DVLD_Project
{
    partial class frmAddNewUser
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
            this.lblAdd_EditUser = new System.Windows.Forms.Label();
            this.btnClosefrm = new System.Windows.Forms.Button();
            this.TcontrolAddNewUser = new System.Windows.Forms.TabControl();
            this.tpagePersonInfo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ctlrPersonCardWithFilter1 = new DVLD_Project.ctlrPersonCardWithFilter();
            this.tpageLoginInfo = new System.Windows.Forms.TabPage();
            this.chbxisActive = new System.Windows.Forms.CheckBox();
            this.TbConfirmpassword = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.TcontrolAddNewUser.SuspendLayout();
            this.tpagePersonInfo.SuspendLayout();
            this.tpageLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdd_EditUser
            // 
            this.lblAdd_EditUser.AutoSize = true;
            this.lblAdd_EditUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd_EditUser.ForeColor = System.Drawing.Color.Red;
            this.lblAdd_EditUser.Location = new System.Drawing.Point(321, 33);
            this.lblAdd_EditUser.Name = "lblAdd_EditUser";
            this.lblAdd_EditUser.Size = new System.Drawing.Size(255, 40);
            this.lblAdd_EditUser.TabIndex = 0;
            this.lblAdd_EditUser.Text = "Add New User";
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
            this.btnClosefrm.Location = new System.Drawing.Point(1032, 0);
            this.btnClosefrm.Name = "btnClosefrm";
            this.btnClosefrm.Size = new System.Drawing.Size(33, 29);
            this.btnClosefrm.TabIndex = 3;
            this.btnClosefrm.Text = "X";
            this.btnClosefrm.UseVisualStyleBackColor = false;
            this.btnClosefrm.Click += new System.EventHandler(this.btnClosefrm_Click);
            // 
            // TcontrolAddNewUser
            // 
            this.TcontrolAddNewUser.Controls.Add(this.tpagePersonInfo);
            this.TcontrolAddNewUser.Controls.Add(this.tpageLoginInfo);
            this.TcontrolAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcontrolAddNewUser.Location = new System.Drawing.Point(12, 98);
            this.TcontrolAddNewUser.Name = "TcontrolAddNewUser";
            this.TcontrolAddNewUser.SelectedIndex = 0;
            this.TcontrolAddNewUser.Size = new System.Drawing.Size(1053, 477);
            this.TcontrolAddNewUser.TabIndex = 7;
            // 
            // tpagePersonInfo
            // 
            this.tpagePersonInfo.Controls.Add(this.button1);
            this.tpagePersonInfo.Controls.Add(this.ctlrPersonCardWithFilter1);
            this.tpagePersonInfo.Location = new System.Drawing.Point(4, 29);
            this.tpagePersonInfo.Name = "tpagePersonInfo";
            this.tpagePersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpagePersonInfo.Size = new System.Drawing.Size(1045, 444);
            this.tpagePersonInfo.TabIndex = 0;
            this.tpagePersonInfo.Text = "Person info";
            this.tpagePersonInfo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::DVLD_Project.Properties.Resources.arrow_right1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(854, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctlrPersonCardWithFilter1
            // 
            this.ctlrPersonCardWithFilter1.Location = new System.Drawing.Point(3, 6);
            this.ctlrPersonCardWithFilter1.Name = "ctlrPersonCardWithFilter1";
            this.ctlrPersonCardWithFilter1.Size = new System.Drawing.Size(986, 380);
            this.ctlrPersonCardWithFilter1.TabIndex = 0;
            this.ctlrPersonCardWithFilter1.OnPersonSelected += new System.Action<int>(this.ctlrPersonCardWithFilter1_OnPersonSelected);
            this.ctlrPersonCardWithFilter1.Load += new System.EventHandler(this.ctlrPersonCardWithFilter1_Load);
            // 
            // tpageLoginInfo
            // 
            this.tpageLoginInfo.Controls.Add(this.chbxisActive);
            this.tpageLoginInfo.Controls.Add(this.TbConfirmpassword);
            this.tpageLoginInfo.Controls.Add(this.TbPassword);
            this.tpageLoginInfo.Controls.Add(this.TbUserName);
            this.tpageLoginInfo.Controls.Add(this.lblUserID);
            this.tpageLoginInfo.Controls.Add(this.label5);
            this.tpageLoginInfo.Controls.Add(this.label4);
            this.tpageLoginInfo.Controls.Add(this.label3);
            this.tpageLoginInfo.Controls.Add(this.label2);
            this.tpageLoginInfo.Location = new System.Drawing.Point(4, 29);
            this.tpageLoginInfo.Name = "tpageLoginInfo";
            this.tpageLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpageLoginInfo.Size = new System.Drawing.Size(1045, 444);
            this.tpageLoginInfo.TabIndex = 1;
            this.tpageLoginInfo.Text = "LoginInfo";
            this.tpageLoginInfo.UseVisualStyleBackColor = true;
            this.tpageLoginInfo.Click += new System.EventHandler(this.tpageLoginInfo_Click);
            // 
            // chbxisActive
            // 
            this.chbxisActive.AutoSize = true;
            this.chbxisActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxisActive.Location = new System.Drawing.Point(229, 241);
            this.chbxisActive.Name = "chbxisActive";
            this.chbxisActive.Size = new System.Drawing.Size(89, 24);
            this.chbxisActive.TabIndex = 4;
            this.chbxisActive.Text = "isActive";
            this.chbxisActive.UseVisualStyleBackColor = true;
            // 
            // TbConfirmpassword
            // 
            this.TbConfirmpassword.Location = new System.Drawing.Point(229, 189);
            this.TbConfirmpassword.Name = "TbConfirmpassword";
            this.TbConfirmpassword.PasswordChar = '*';
            this.TbConfirmpassword.Size = new System.Drawing.Size(163, 26);
            this.TbConfirmpassword.TabIndex = 3;
            this.TbConfirmpassword.Tag = "Confirm password";
            this.TbConfirmpassword.TextChanged += new System.EventHandler(this.TbConfirmpassword_TextChanged);
            this.TbConfirmpassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingConfirmPassword);
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(229, 140);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(163, 26);
            this.TbPassword.TabIndex = 2;
            this.TbPassword.Tag = "Password";
            this.TbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingComboboxes);
            // 
            // TbUserName
            // 
            this.TbUserName.Location = new System.Drawing.Point(229, 88);
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(163, 26);
            this.TbUserName.TabIndex = 1;
            this.TbUserName.Tag = "Username";
            this.TbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingComboboxes);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(225, 42);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(59, 20);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "[????]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Confirm password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "UserName :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD_Project.Properties.Resources._save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(931, 596);
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
            this.btnclose.Location = new System.Drawing.Point(791, 596);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 39);
            this.btnclose.TabIndex = 15;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 656);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.TcontrolAddNewUser);
            this.Controls.Add(this.btnClosefrm);
            this.Controls.Add(this.lblAdd_EditUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddNewUser_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAddNewUser_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmAddNewUser_MouseUp);
            this.TcontrolAddNewUser.ResumeLayout(false);
            this.tpagePersonInfo.ResumeLayout(false);
            this.tpageLoginInfo.ResumeLayout(false);
            this.tpageLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd_EditUser;
        private System.Windows.Forms.Button btnClosefrm;
        private System.Windows.Forms.TabControl TcontrolAddNewUser;
        private System.Windows.Forms.TabPage tpagePersonInfo;
        private System.Windows.Forms.TabPage tpageLoginInfo;
        private ctlrPersonCardWithFilter ctlrPersonCardWithFilter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbxisActive;
        private System.Windows.Forms.TextBox TbConfirmpassword;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnclose;
    }
}