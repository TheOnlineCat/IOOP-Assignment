namespace IOOP_Assignment
{
    partial class TutorClassInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorClassInfo));
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTutor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSList = new System.Windows.Forms.Button();
            this.btnCInfo = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.picTutor = new System.Windows.Forms.PictureBox();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.gridClass = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picTutor)).BeginInit();
            this.grpClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(14, 12);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(78, 46);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "ETC";
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTutor.ForeColor = System.Drawing.Color.Black;
            this.lblTutor.Location = new System.Drawing.Point(560, 9);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(107, 46);
            this.lblTutor.TabIndex = 1;
            this.lblTutor.Text = "Tutor";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(582, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "$Name$";
            // 
            // btnSList
            // 
            this.btnSList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSList.Location = new System.Drawing.Point(14, 531);
            this.btnSList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSList.Name = "btnSList";
            this.btnSList.Size = new System.Drawing.Size(162, 53);
            this.btnSList.TabIndex = 4;
            this.btnSList.Text = "View Student List";
            this.btnSList.UseVisualStyleBackColor = false;
            this.btnSList.Click += new System.EventHandler(this.btnSList_Click);
            // 
            // btnCInfo
            // 
            this.btnCInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCInfo.Location = new System.Drawing.Point(543, 531);
            this.btnCInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCInfo.Name = "btnCInfo";
            this.btnCInfo.Size = new System.Drawing.Size(162, 53);
            this.btnCInfo.TabIndex = 4;
            this.btnCInfo.Text = "Update and Delete Class Infromation";
            this.btnCInfo.UseVisualStyleBackColor = false;
            this.btnCInfo.Click += new System.EventHandler(this.btnCInfo_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(593, 89);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 29);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // picTutor
            // 
            this.picTutor.Image = ((System.Drawing.Image)(resources.GetObject("picTutor.Image")));
            this.picTutor.Location = new System.Drawing.Point(655, 11);
            this.picTutor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picTutor.Name = "picTutor";
            this.picTutor.Size = new System.Drawing.Size(71, 75);
            this.picTutor.TabIndex = 18;
            this.picTutor.TabStop = false;
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.gridClass);
            this.grpClass.Location = new System.Drawing.Point(14, 127);
            this.grpClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpClass.Name = "grpClass";
            this.grpClass.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpClass.Size = new System.Drawing.Size(712, 396);
            this.grpClass.TabIndex = 19;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Class Information";
            // 
            // gridClass
            // 
            this.gridClass.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gridClass.Location = new System.Drawing.Point(0, 29);
            this.gridClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridClass.Name = "gridClass";
            this.gridClass.RowHeadersWidth = 51;
            this.gridClass.RowTemplate.Height = 25;
            this.gridClass.Size = new System.Drawing.Size(712, 363);
            this.gridClass.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tutor";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Subject";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Schedule";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Charges";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // TutorClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 605);
            this.Controls.Add(this.grpClass);
            this.Controls.Add(this.picTutor);
            this.Controls.Add(this.btnCInfo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSList);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTutor);
            this.Controls.Add(this.lblLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TutorClassInfo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picTutor)).EndInit();
            this.grpClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLogo;
        private Label lblTutor;
        private Label lblName;
        private Button btnSList;
        private Button btnCInfo;
        private Button btnUpdate;
        private PictureBox picTutor;
        private GroupBox grpClass;
        private DataGridView gridClass;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}