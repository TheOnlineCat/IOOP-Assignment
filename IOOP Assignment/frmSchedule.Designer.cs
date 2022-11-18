namespace IOOP_Assignment
{
    partial class frmSchedule
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblETC = new System.Windows.Forms.Label();
            this.lblStu = new System.Windows.Forms.Label();
            this.lblName_StuID = new System.Windows.Forms.Label();
            this.lblSch = new System.Windows.Forms.Label();
            this.picStu = new System.Windows.Forms.PictureBox();
            this.grdSch = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblETC
            // 
            this.lblETC.AutoSize = true;
            this.lblETC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblETC.Location = new System.Drawing.Point(0, -1);
            this.lblETC.Name = "lblETC";
            this.lblETC.Size = new System.Drawing.Size(52, 31);
            this.lblETC.TabIndex = 0;
            this.lblETC.Text = "ETC";
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStu.Location = new System.Drawing.Point(883, 14);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(86, 28);
            this.lblStu.TabIndex = 1;
            this.lblStu.Text = "Student";
            // 
            // lblName_StuID
            // 
            this.lblName_StuID.AutoSize = true;
            this.lblName_StuID.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName_StuID.Location = new System.Drawing.Point(866, 42);
            this.lblName_StuID.Name = "lblName_StuID";
            this.lblName_StuID.Size = new System.Drawing.Size(117, 17);
            this.lblName_StuID.TabIndex = 2;
            this.lblName_StuID.Text = "Name | StudentID";
            // 
            // lblSch
            // 
            this.lblSch.AutoSize = true;
            this.lblSch.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSch.Location = new System.Drawing.Point(12, 85);
            this.lblSch.Name = "lblSch";
            this.lblSch.Size = new System.Drawing.Size(247, 45);
            this.lblSch.TabIndex = 3;
            this.lblSch.Text = "Class Schedule";
            // 
            // picStu
            // 
            this.picStu.Image = global::IOOP_Assignment.Properties.Resources.student;
            this.picStu.Location = new System.Drawing.Point(989, 9);
            this.picStu.Name = "picStu";
            this.picStu.Size = new System.Drawing.Size(67, 62);
            this.picStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStu.TabIndex = 4;
            this.picStu.TabStop = false;
            // 
            // grdSch
            // 
            this.grdSch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.grdSch.Location = new System.Drawing.Point(12, 134);
            this.grdSch.Name = "grdSch";
            this.grdSch.RowHeadersWidth = 51;
            this.grdSch.RowTemplate.Height = 29;
            this.grdSch.Size = new System.Drawing.Size(1044, 304);
            this.grdSch.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Day/Time";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "3:00pm-4:30pm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "4:30pm-6:00pm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "6:00pm-7:30pm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "7:30pm-9:00pm";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "9:00pm-10:30pm";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 450);
            this.Controls.Add(this.grdSch);
            this.Controls.Add(this.picStu);
            this.Controls.Add(this.lblSch);
            this.Controls.Add(this.lblName_StuID);
            this.Controls.Add(this.lblStu);
            this.Controls.Add(this.lblETC);
            this.Name = "frmSchedule";
            this.Text = "frmSchedule";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblETC;
        private Label lblStu;
        private Label lblName_StuID;
        private Label lblSch;
        private PictureBox picStu;
        private DataGridView grdSch;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}