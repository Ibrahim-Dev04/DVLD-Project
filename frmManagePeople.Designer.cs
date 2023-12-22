namespace DVLD_Project
{
    partial class frmManagePeople
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvpeopleList = new System.Windows.Forms.DataGridView();
            this.CmsPersonMangementMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.TbFilterByValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTotalRecords = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeopleList)).BeginInit();
            this.CmsPersonMangementMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(-4, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage people";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1516, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(689, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage people";
            // 
            // dgvpeopleList
            // 
            this.dgvpeopleList.AllowUserToAddRows = false;
            this.dgvpeopleList.AllowUserToDeleteRows = false;
            this.dgvpeopleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpeopleList.BackgroundColor = System.Drawing.Color.White;
            this.dgvpeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpeopleList.ContextMenuStrip = this.CmsPersonMangementMenu;
            this.dgvpeopleList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvpeopleList.Location = new System.Drawing.Point(12, 313);
            this.dgvpeopleList.Name = "dgvpeopleList";
            this.dgvpeopleList.ReadOnly = true;
            this.dgvpeopleList.RowHeadersWidth = 62;
            this.dgvpeopleList.RowTemplate.Height = 28;
            this.dgvpeopleList.Size = new System.Drawing.Size(1525, 346);
            this.dgvpeopleList.TabIndex = 4;
            // 
            // CmsPersonMangementMenu
            // 
            this.CmsPersonMangementMenu.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmsPersonMangementMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CmsPersonMangementMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.CmsPersonMangementMenu.Name = "CmsPersonMangementMenu";
            this.CmsPersonMangementMenu.Size = new System.Drawing.Size(249, 165);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.UserInfo;
            this.showDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.showDetailsToolStripMenuItem.Text = "Show details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.AddPersonIcon;
            this.addNewPersonToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit;
            this.editToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.delete_row;
            this.deleteToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter by";
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.FormattingEnabled = true;
            this.CbFilterBy.Location = new System.Drawing.Point(103, 272);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(153, 28);
            this.CbFilterBy.TabIndex = 6;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            // 
            // TbFilterByValue
            // 
            this.TbFilterByValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFilterByValue.Location = new System.Drawing.Point(268, 272);
            this.TbFilterByValue.Name = "TbFilterByValue";
            this.TbFilterByValue.Size = new System.Drawing.Size(226, 28);
            this.TbFilterByValue.TabIndex = 8;
            this.TbFilterByValue.Visible = false;
            this.TbFilterByValue.TextChanged += new System.EventHandler(this.TbFilterByValue_TextChanged);
            this.TbFilterByValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFilterByValue_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 703);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "# Records :";
            // 
            // LblTotalRecords
            // 
            this.LblTotalRecords.AutoSize = true;
            this.LblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTotalRecords.Location = new System.Drawing.Point(134, 703);
            this.LblTotalRecords.Name = "LblTotalRecords";
            this.LblTotalRecords.Size = new System.Drawing.Size(24, 25);
            this.LblTotalRecords.TabIndex = 10;
            this.LblTotalRecords.Text = "0";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddPerson.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Image = global::DVLD_Project.Properties.Resources.AddIcon;
            this.btnAddPerson.Location = new System.Drawing.Point(1461, 243);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(76, 64);
            this.btnAddPerson.TabIndex = 7;
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // pbPeople
            // 
            this.pbPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPeople.Image = global::DVLD_Project.Properties.Resources.grandPeople;
            this.pbPeople.Location = new System.Drawing.Point(659, 28);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(244, 130);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPeople.TabIndex = 2;
            this.pbPeople.TabStop = false;
            // 
            // frmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1550, 758);
            this.ControlBox = false;
            this.Controls.Add(this.LblTotalRecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbFilterByValue);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.CbFilterBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvpeopleList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MinimizeBox = false;
            this.Name = "frmManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpeopleList)).EndInit();
            this.CmsPersonMangementMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvpeopleList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ContextMenuStrip CmsPersonMangementMenu;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox TbFilterByValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTotalRecords;
    }
}