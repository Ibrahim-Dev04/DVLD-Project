namespace DVLD_Project
{
    partial class FrmManageLocalLicenseApplications
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
            this.TbFilterByValue = new System.Windows.Forms.TextBox();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvLocalApplicationsList = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecodsNumber = new System.Windows.Forms.Label();
            this.btnAddNewApp = new System.Windows.Forms.Button();
            this.pbLocalApplicationImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalApplicationsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalApplicationImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClosefrm
            // 
            this.btnClosefrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosefrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(241)))), ((int)(((byte)(157)))));
            this.btnClosefrm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClosefrm.FlatAppearance.BorderSize = 0;
            this.btnClosefrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosefrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosefrm.ForeColor = System.Drawing.Color.White;
            this.btnClosefrm.Location = new System.Drawing.Point(1315, 2);
            this.btnClosefrm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClosefrm.Name = "btnClosefrm";
            this.btnClosefrm.Size = new System.Drawing.Size(25, 29);
            this.btnClosefrm.TabIndex = 22;
            this.btnClosefrm.Text = "X";
            this.btnClosefrm.UseVisualStyleBackColor = false;
            this.btnClosefrm.Click += new System.EventHandler(this.btnClosefrm_Click);
            // 
            // TbFilterByValue
            // 
            this.TbFilterByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFilterByValue.Location = new System.Drawing.Point(337, 338);
            this.TbFilterByValue.Name = "TbFilterByValue";
            this.TbFilterByValue.Size = new System.Drawing.Size(282, 28);
            this.TbFilterByValue.TabIndex = 25;
            this.TbFilterByValue.Visible = false;
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.FormattingEnabled = true;
            this.CbFilterBy.Location = new System.Drawing.Point(119, 338);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(199, 28);
            this.CbFilterBy.TabIndex = 24;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Filter by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(176)))), ((int)(((byte)(232)))));
            this.label2.Location = new System.Drawing.Point(437, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 40);
            this.label2.TabIndex = 27;
            this.label2.Text = "Manage local license applications";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Manage local license applications";
            // 
            // DgvLocalApplicationsList
            // 
            this.DgvLocalApplicationsList.AllowUserToAddRows = false;
            this.DgvLocalApplicationsList.AllowUserToDeleteRows = false;
            this.DgvLocalApplicationsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLocalApplicationsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvLocalApplicationsList.BackgroundColor = System.Drawing.Color.White;
            this.DgvLocalApplicationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLocalApplicationsList.Location = new System.Drawing.Point(21, 398);
            this.DgvLocalApplicationsList.Name = "DgvLocalApplicationsList";
            this.DgvLocalApplicationsList.ReadOnly = true;
            this.DgvLocalApplicationsList.RowHeadersWidth = 62;
            this.DgvLocalApplicationsList.RowTemplate.Height = 28;
            this.DgvLocalApplicationsList.Size = new System.Drawing.Size(1291, 308);
            this.DgvLocalApplicationsList.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 737);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Records : ";
            // 
            // lblRecodsNumber
            // 
            this.lblRecodsNumber.AutoSize = true;
            this.lblRecodsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecodsNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblRecodsNumber.Location = new System.Drawing.Point(121, 734);
            this.lblRecodsNumber.Name = "lblRecodsNumber";
            this.lblRecodsNumber.Size = new System.Drawing.Size(126, 32);
            this.lblRecodsNumber.TabIndex = 32;
            this.lblRecodsNumber.Text = "Records";
            // 
            // btnAddNewApp
            // 
            this.btnAddNewApp.BackColor = System.Drawing.Color.White;
            this.btnAddNewApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewApp.Image = global::DVLD_Project.Properties.Resources.add_app2;
            this.btnAddNewApp.Location = new System.Drawing.Point(1227, 325);
            this.btnAddNewApp.Name = "btnAddNewApp";
            this.btnAddNewApp.Size = new System.Drawing.Size(85, 67);
            this.btnAddNewApp.TabIndex = 33;
            this.btnAddNewApp.UseVisualStyleBackColor = false;
            this.btnAddNewApp.Click += new System.EventHandler(this.btnAddNewApp_Click);
            // 
            // pbLocalApplicationImage
            // 
            this.pbLocalApplicationImage.Location = new System.Drawing.Point(614, 12);
            this.pbLocalApplicationImage.Name = "pbLocalApplicationImage";
            this.pbLocalApplicationImage.Size = new System.Drawing.Size(215, 197);
            this.pbLocalApplicationImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLocalApplicationImage.TabIndex = 26;
            this.pbLocalApplicationImage.TabStop = false;
            // 
            // FrmManageLocalLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 870);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddNewApp);
            this.Controls.Add(this.lblRecodsNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgvLocalApplicationsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbLocalApplicationImage);
            this.Controls.Add(this.TbFilterByValue);
            this.Controls.Add(this.CbFilterBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClosefrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmManageLocalLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmManageLocalLicenseApplications";
            this.Load += new System.EventHandler(this.FrmManageLocalLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocalApplicationsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalApplicationImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClosefrm;
        private System.Windows.Forms.TextBox TbFilterByValue;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLocalApplicationImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvLocalApplicationsList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecodsNumber;
        private System.Windows.Forms.Button btnAddNewApp;
    }
}