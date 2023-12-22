namespace DVLD_Project
{
    partial class frmManageApplicationTypes
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
            this.DgvApplicationTypesList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmstoolEditAppType = new System.Windows.Forms.ToolStripMenuItem();
            this.pbApplicationImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvApplicationTypesList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationImage)).BeginInit();
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
            this.btnClosefrm.Location = new System.Drawing.Point(759, 4);
            this.btnClosefrm.Name = "btnClosefrm";
            this.btnClosefrm.Size = new System.Drawing.Size(37, 29);
            this.btnClosefrm.TabIndex = 18;
            this.btnClosefrm.Text = "X";
            this.btnClosefrm.UseVisualStyleBackColor = false;
            this.btnClosefrm.Click += new System.EventHandler(this.btnClosefrm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "clsApplication Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(169, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 40);
            this.label2.TabIndex = 21;
            this.label2.Text = "Manage clsApplication Types";
            // 
            // DgvApplicationTypesList
            // 
            this.DgvApplicationTypesList.AllowUserToAddRows = false;
            this.DgvApplicationTypesList.AllowUserToDeleteRows = false;
            this.DgvApplicationTypesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvApplicationTypesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvApplicationTypesList.BackgroundColor = System.Drawing.Color.White;
            this.DgvApplicationTypesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvApplicationTypesList.ContextMenuStrip = this.contextMenuStrip1;
            this.DgvApplicationTypesList.Location = new System.Drawing.Point(12, 356);
            this.DgvApplicationTypesList.Name = "DgvApplicationTypesList";
            this.DgvApplicationTypesList.ReadOnly = true;
            this.DgvApplicationTypesList.RowHeadersWidth = 62;
            this.DgvApplicationTypesList.RowTemplate.Height = 28;
            this.DgvApplicationTypesList.Size = new System.Drawing.Size(776, 397);
            this.DgvApplicationTypesList.TabIndex = 22;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmstoolEditAppType});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(333, 109);
            // 
            // CmstoolEditAppType
            // 
            this.CmstoolEditAppType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmstoolEditAppType.Image = global::DVLD_Project.Properties.Resources.EditApplication64;
            this.CmstoolEditAppType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CmstoolEditAppType.Name = "CmstoolEditAppType";
            this.CmstoolEditAppType.Size = new System.Drawing.Size(332, 72);
            this.CmstoolEditAppType.Text = "Edit clsApplication type";
            this.CmstoolEditAppType.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // pbApplicationImage
            // 
            this.pbApplicationImage.Location = new System.Drawing.Point(275, 44);
            this.pbApplicationImage.Name = "pbApplicationImage";
            this.pbApplicationImage.Size = new System.Drawing.Size(238, 223);
            this.pbApplicationImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationImage.TabIndex = 19;
            this.pbApplicationImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 777);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "# Records :";
            // 
            // btnclose
            // 
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::DVLD_Project.Properties.Resources.close21;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(677, 769);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 39);
            this.btnclose.TabIndex = 24;
            this.btnclose.Text = "Close";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(128, 773);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(205, 29);
            this.lblNumberOfRecords.TabIndex = 25;
            this.lblNumberOfRecords.Text = "Record_Number";
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 822);
            this.ControlBox = false;
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvApplicationTypesList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbApplicationImage);
            this.Controls.Add(this.btnClosefrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmManageApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmManageApplicationTypes_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmManageApplicationTypes_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmManageApplicationTypes_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.DgvApplicationTypesList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClosefrm;
        private System.Windows.Forms.PictureBox pbApplicationImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvApplicationTypesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CmstoolEditAppType;
    }
}