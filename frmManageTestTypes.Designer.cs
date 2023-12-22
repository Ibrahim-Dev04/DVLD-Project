namespace DVLD_Project
{
    partial class frmManageTestTypes
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
            this.btnClosefrm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTestTypesList = new System.Windows.Forms.DataGridView();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnclose = new System.Windows.Forms.Button();
            this.PbMainfrmImage = new System.Windows.Forms.PictureBox();
            this.updateTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypesList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMainfrmImage)).BeginInit();
            this.SuspendLayout();
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
            this.btnClosefrm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClosefrm.Name = "btnClosefrm";
            this.btnClosefrm.Size = new System.Drawing.Size(29, 32);
            this.btnClosefrm.TabIndex = 20;
            this.btnClosefrm.Text = "X";
            this.btnClosefrm.UseVisualStyleBackColor = false;
            this.btnClosefrm.Click += new System.EventHandler(this.btnClosefrm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Manage Test Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(293, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 35);
            this.label2.TabIndex = 23;
            this.label2.Text = "Manage Test Types";
            // 
            // dgvTestTypesList
            // 
            this.dgvTestTypesList.AllowUserToAddRows = false;
            this.dgvTestTypesList.AllowUserToDeleteRows = false;
            this.dgvTestTypesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestTypesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTestTypesList.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestTypesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTypesList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTestTypesList.Location = new System.Drawing.Point(12, 316);
            this.dgvTestTypesList.Name = "dgvTestTypesList";
            this.dgvTestTypesList.ReadOnly = true;
            this.dgvTestTypesList.RowHeadersWidth = 62;
            this.dgvTestTypesList.RowTemplate.Height = 28;
            this.dgvTestTypesList.Size = new System.Drawing.Size(910, 304);
            this.dgvTestTypesList.TabIndex = 24;
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(127, 667);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(205, 29);
            this.lblNumberOfRecords.TabIndex = 28;
            this.lblNumberOfRecords.Text = "Record_Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 671);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "# Records :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateTestTypeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(293, 109);
            // 
            // btnclose
            // 
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::DVLD_Project.Properties.Resources.close21;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(817, 659);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 39);
            this.btnclose.TabIndex = 27;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // PbMainfrmImage
            // 
            this.PbMainfrmImage.Location = new System.Drawing.Point(354, 45);
            this.PbMainfrmImage.Name = "PbMainfrmImage";
            this.PbMainfrmImage.Size = new System.Drawing.Size(192, 189);
            this.PbMainfrmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMainfrmImage.TabIndex = 21;
            this.PbMainfrmImage.TabStop = false;
            // 
            // updateTestTypeToolStripMenuItem
            // 
            this.updateTestTypeToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Update;
            this.updateTestTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateTestTypeToolStripMenuItem.Name = "updateTestTypeToolStripMenuItem";
            this.updateTestTypeToolStripMenuItem.Size = new System.Drawing.Size(292, 72);
            this.updateTestTypeToolStripMenuItem.Text = "Update Test type";
            this.updateTestTypeToolStripMenuItem.Click += new System.EventHandler(this.updateTestTypeToolStripMenuItem_Click);
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 710);
            this.ControlBox = false;
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTestTypesList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PbMainfrmImage);
            this.Controls.Add(this.btnClosefrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmManageTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypesList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbMainfrmImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClosefrm;
        private System.Windows.Forms.PictureBox PbMainfrmImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTestTypesList;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateTestTypeToolStripMenuItem;
    }
}