namespace DVLD_Project
{
    partial class frmUpdateTestType
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
            this.lbltestId = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClosefrm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.tbFees = new System.Windows.Forms.TextBox();
            this.pbFees = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.pbTestDescription = new System.Windows.Forms.PictureBox();
            this.pbTestTitle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltestId
            // 
            this.lbltestId.AutoSize = true;
            this.lbltestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltestId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbltestId.Location = new System.Drawing.Point(139, 116);
            this.lbltestId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltestId.Name = "lbltestId";
            this.lbltestId.Size = new System.Drawing.Size(75, 22);
            this.lbltestId.TabIndex = 41;
            this.lbltestId.Text = "App_ID";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(211, 233);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(376, 189);
            this.tbDescription.TabIndex = 40;
            this.tbDescription.Tag = "Description";
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(211, 173);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(376, 36);
            this.tbTitle.TabIndex = 39;
            this.tbTitle.Tag = "Title";
            this.tbTitle.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateTextBoxes);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Title :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(167, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Update Test types";
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
            this.btnClosefrm.Location = new System.Drawing.Point(618, 1);
            this.btnClosefrm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClosefrm.Name = "btnClosefrm";
            this.btnClosefrm.Size = new System.Drawing.Size(25, 32);
            this.btnClosefrm.TabIndex = 32;
            this.btnClosefrm.Text = "X";
            this.btnClosefrm.UseVisualStyleBackColor = false;
            this.btnClosefrm.Click += new System.EventHandler(this.btnClosefrm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Update Test types";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(67, 452);
            this.lblFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(66, 22);
            this.lblFees.TabIndex = 44;
            this.lblFees.Text = "Fees :";
            // 
            // tbFees
            // 
            this.tbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFees.Location = new System.Drawing.Point(211, 443);
            this.tbFees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbFees.Multiline = true;
            this.tbFees.Name = "tbFees";
            this.tbFees.Size = new System.Drawing.Size(376, 36);
            this.tbFees.TabIndex = 46;
            this.tbFees.Tag = "Fees";
            // 
            // pbFees
            // 
            this.pbFees.Location = new System.Drawing.Point(143, 449);
            this.pbFees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbFees.Name = "pbFees";
            this.pbFees.Size = new System.Drawing.Size(49, 30);
            this.pbFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFees.TabIndex = 45;
            this.pbFees.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::DVLD_Project.Properties.Resources._save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(542, 505);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 43);
            this.btnSave.TabIndex = 43;
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
            this.btnclose.Location = new System.Drawing.Point(428, 505);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(106, 43);
            this.btnclose.TabIndex = 42;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pbTestDescription
            // 
            this.pbTestDescription.Location = new System.Drawing.Point(143, 232);
            this.pbTestDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbTestDescription.Name = "pbTestDescription";
            this.pbTestDescription.Size = new System.Drawing.Size(49, 30);
            this.pbTestDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestDescription.TabIndex = 38;
            this.pbTestDescription.TabStop = false;
            // 
            // pbTestTitle
            // 
            this.pbTestTitle.Location = new System.Drawing.Point(143, 174);
            this.pbTestTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbTestTitle.Name = "pbTestTitle";
            this.pbTestTitle.Size = new System.Drawing.Size(49, 30);
            this.pbTestTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestTitle.TabIndex = 37;
            this.pbTestTitle.TabStop = false;
            // 
            // frmUpdateTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 550);
            this.ControlBox = false;
            this.Controls.Add(this.tbFees);
            this.Controls.Add(this.pbFees);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lbltestId);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.pbTestDescription);
            this.Controls.Add(this.pbTestTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClosefrm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUpdateTestType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmUpdateTestType_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUpdateTestType_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmUpdateTestType_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lbltestId;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.PictureBox pbTestDescription;
        private System.Windows.Forms.PictureBox pbTestTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClosefrm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.PictureBox pbFees;
        private System.Windows.Forms.TextBox tbFees;
    }
}