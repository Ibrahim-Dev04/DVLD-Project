namespace DVLD_Project
{
    partial class ctlrPersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbFilterByValue = new System.Windows.Forms.TextBox();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GbFilterBy = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearchBy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblphone = new System.Windows.Forms.Label();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GbFilterBy.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TbFilterByValue
            // 
            this.TbFilterByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFilterByValue.Location = new System.Drawing.Point(340, 25);
            this.TbFilterByValue.Name = "TbFilterByValue";
            this.TbFilterByValue.Size = new System.Drawing.Size(226, 28);
            this.TbFilterByValue.TabIndex = 11;
            this.TbFilterByValue.Visible = false;
            this.TbFilterByValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFilterByValue_KeyPress);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.FormattingEnabled = true;
            this.CbFilterBy.Location = new System.Drawing.Point(175, 25);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(153, 28);
            this.CbFilterBy.TabIndex = 10;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(79, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filter by";
            // 
            // GbFilterBy
            // 
            this.GbFilterBy.Controls.Add(this.button2);
            this.GbFilterBy.Controls.Add(this.btnSearchBy);
            this.GbFilterBy.Controls.Add(this.CbFilterBy);
            this.GbFilterBy.Controls.Add(this.TbFilterByValue);
            this.GbFilterBy.Controls.Add(this.label3);
            this.GbFilterBy.Location = new System.Drawing.Point(0, 3);
            this.GbFilterBy.Name = "GbFilterBy";
            this.GbFilterBy.Size = new System.Drawing.Size(882, 69);
            this.GbFilterBy.TabIndex = 12;
            this.GbFilterBy.TabStop = false;
            this.GbFilterBy.Text = "Find by";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::DVLD_Project.Properties.Resources.man;
            this.button2.Location = new System.Drawing.Point(659, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 36);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearchBy
            // 
            this.btnSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBy.Image = global::DVLD_Project.Properties.Resources.findUser;
            this.btnSearchBy.Location = new System.Drawing.Point(604, 19);
            this.btnSearchBy.Name = "btnSearchBy";
            this.btnSearchBy.Size = new System.Drawing.Size(43, 36);
            this.btnSearchBy.TabIndex = 12;
            this.btnSearchBy.UseVisualStyleBackColor = true;
            this.btnSearchBy.Click += new System.EventHandler(this.btnSearchBy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblDateOfBirth);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.lblphone);
            this.groupBox2.Controls.Add(this.pbPersonImage);
            this.groupBox2.Controls.Add(this.lblCountry);
            this.groupBox2.Controls.Add(this.pictureBox9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblPersonId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblAddress);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.lblGender);
            this.groupBox2.Controls.Add(this.lblNationalNo);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(3, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 301);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person info";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(155, 70);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(59, 20);
            this.LblName.TabIndex = 52;
            this.LblName.Text = "[????]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 51;
            this.label7.Text = "Name : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.person1;
            this.pictureBox1.Location = new System.Drawing.Point(105, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(557, 244);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(59, 20);
            this.lblDateOfBirth.TabIndex = 49;
            this.lblDateOfBirth.Text = "[????]";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD_Project.Properties.Resources.date1;
            this.pictureBox7.Location = new System.Drawing.Point(515, 241);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 48;
            this.pictureBox7.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(370, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 22);
            this.label12.TabIndex = 47;
            this.label12.Text = "Date Of Birth :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(726, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkLabel1.Size = new System.Drawing.Size(120, 20);
            this.linkLabel1.TabIndex = 46;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Edit person info";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(155, 164);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(59, 20);
            this.lblphone.TabIndex = 45;
            this.lblphone.Text = "[????]";
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.Location = new System.Drawing.Point(690, 43);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(177, 176);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 44;
            this.pbPersonImage.TabStop = false;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(557, 199);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(59, 20);
            this.lblCountry.TabIndex = 43;
            this.lblCountry.Text = "[????]";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD_Project.Properties.Resources.country1;
            this.pictureBox9.Location = new System.Drawing.Point(512, 197);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 40;
            this.pictureBox9.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(413, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 22);
            this.label14.TabIndex = 39;
            this.label14.Text = "Country :";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD_Project.Properties.Resources.phone_;
            this.pictureBox8.Location = new System.Drawing.Point(105, 160);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 38;
            this.pictureBox8.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 22);
            this.label13.TabIndex = 37;
            this.label13.Text = "Phone :";
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPersonId.Location = new System.Drawing.Point(152, 26);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(59, 20);
            this.lblPersonId.TabIndex = 34;
            this.lblPersonId.Text = "[????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Person Id : ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(155, 202);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 20);
            this.lblAddress.TabIndex = 32;
            this.lblAddress.Text = "[????]";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(154, 119);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 20);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "[????]";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(557, 159);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 20);
            this.lblGender.TabIndex = 30;
            this.lblGender.Text = "[????]";
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.AutoSize = true;
            this.lblNationalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalNo.Location = new System.Drawing.Point(191, 241);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(59, 20);
            this.lblNationalNo.TabIndex = 29;
            this.lblNationalNo.Text = "[????]";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_Project.Properties.Resources.address_;
            this.pictureBox5.Location = new System.Drawing.Point(105, 200);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Project.Properties.Resources.email1;
            this.pictureBox4.Location = new System.Drawing.Point(105, 116);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.male;
            this.pictureBox3.Location = new System.Drawing.Point(513, 158);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.nationalid;
            this.pictureBox2.Location = new System.Drawing.Point(141, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "Email :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Address : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(416, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Gender :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "National No :";
            // 
            // ctlrPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbFilterBy);
            this.Name = "ctlrPersonCardWithFilter";
            this.Size = new System.Drawing.Size(888, 399);
            this.Load += new System.EventHandler(this.ctlrPersonCardWithFilter_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctlrPersonCardWithFilter_KeyPress);
            this.GbFilterBy.ResumeLayout(false);
            this.GbFilterBy.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbFilterByValue;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GbFilterBy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSearchBy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label12;
    }
}
