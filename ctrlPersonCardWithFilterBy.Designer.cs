namespace DVLD_Project
{
    partial class ctrlFindPersonBy
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
            this.TbFindBy = new System.Windows.Forms.TextBox();
            this.CbFilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.GbFindpersonBy = new System.Windows.Forms.GroupBox();
            this.GbFindpersonBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbFindBy
            // 
            this.TbFindBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbFindBy.Location = new System.Drawing.Point(290, 25);
            this.TbFindBy.Name = "TbFindBy";
            this.TbFindBy.Size = new System.Drawing.Size(226, 28);
            this.TbFindBy.TabIndex = 11;
            this.TbFindBy.Visible = false;
            this.TbFindBy.TextChanged += new System.EventHandler(this.TbFilterByValue_TextChanged);
            this.TbFindBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFilterByValue_KeyPress);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.FormattingEnabled = true;
            this.CbFilterBy.Location = new System.Drawing.Point(125, 25);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(153, 28);
            this.CbFilterBy.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Find by";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(616, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.BackColor = System.Drawing.Color.White;
            this.btnFindPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPerson.Image = global::DVLD_Project.Properties.Resources.findUser;
            this.btnFindPerson.Location = new System.Drawing.Point(550, 19);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(50, 38);
            this.btnFindPerson.TabIndex = 12;
            this.btnFindPerson.UseVisualStyleBackColor = false;
            // 
            // GbFindpersonBy
            // 
            this.GbFindpersonBy.BackColor = System.Drawing.SystemColors.Control;
            this.GbFindpersonBy.Controls.Add(this.TbFindBy);
            this.GbFindpersonBy.Controls.Add(this.button2);
            this.GbFindpersonBy.Controls.Add(this.label3);
            this.GbFindpersonBy.Controls.Add(this.btnFindPerson);
            this.GbFindpersonBy.Controls.Add(this.CbFilterBy);
            this.GbFindpersonBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbFindpersonBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbFindpersonBy.Location = new System.Drawing.Point(0, 0);
            this.GbFindpersonBy.Name = "GbFindpersonBy";
            this.GbFindpersonBy.Size = new System.Drawing.Size(853, 75);
            this.GbFindpersonBy.TabIndex = 14;
            this.GbFindpersonBy.TabStop = false;
            this.GbFindpersonBy.Text = "FindBy";
            // 
            // ctrlFindPersonBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GbFindpersonBy);
            this.Name = "ctrlFindPersonBy";
            this.Size = new System.Drawing.Size(853, 75);
            this.Load += new System.EventHandler(this.ctrlFilterPersonBy_Load);
            this.GbFindpersonBy.ResumeLayout(false);
            this.GbFindpersonBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbFindBy;
        private System.Windows.Forms.ComboBox CbFilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox GbFindpersonBy;
    }
}
