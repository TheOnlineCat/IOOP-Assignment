namespace IOOP_Assignment
{
    partial class frmViewStatus
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
            this.lblETC = new System.Windows.Forms.Label();
            this.lblStu = new System.Windows.Forms.Label();
            this.lblName_StuID = new System.Windows.Forms.Label();
            this.picStu = new System.Windows.Forms.PictureBox();
            this.lstDetail = new System.Windows.Forms.ListBox();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.lblReq = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblDelReq = new System.Windows.Forms.Label();
            this.cmbReq = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblETC
            // 
            this.lblETC.AutoSize = true;
            this.lblETC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblETC.Location = new System.Drawing.Point(1, -1);
            this.lblETC.Name = "lblETC";
            this.lblETC.Size = new System.Drawing.Size(52, 31);
            this.lblETC.TabIndex = 0;
            this.lblETC.Text = "ETC";
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStu.Location = new System.Drawing.Point(216, 16);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(86, 28);
            this.lblStu.TabIndex = 1;
            this.lblStu.Text = "Student";
            // 
            // lblName_StuID
            // 
            this.lblName_StuID.AutoSize = true;
            this.lblName_StuID.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName_StuID.Location = new System.Drawing.Point(194, 44);
            this.lblName_StuID.Name = "lblName_StuID";
            this.lblName_StuID.Size = new System.Drawing.Size(133, 17);
            this.lblName_StuID.TabIndex = 2;
            this.lblName_StuID.Text = "$NAME$ | StudentID";
            // 
            // picStu
            // 
            this.picStu.Image = global::IOOP_Assignment.Properties.Resources.student;
            this.picStu.Location = new System.Drawing.Point(333, 12);
            this.picStu.Name = "picStu";
            this.picStu.Size = new System.Drawing.Size(67, 62);
            this.picStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStu.TabIndex = 3;
            this.picStu.TabStop = false;
            // 
            // lstDetail
            // 
            this.lstDetail.FormattingEnabled = true;
            this.lstDetail.ItemHeight = 20;
            this.lstDetail.Location = new System.Drawing.Point(12, 118);
            this.lstDetail.Name = "lstDetail";
            this.lstDetail.Size = new System.Drawing.Size(184, 244);
            this.lstDetail.TabIndex = 4;
            // 
            // lstStatus
            // 
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.ItemHeight = 20;
            this.lstStatus.Location = new System.Drawing.Point(216, 118);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(184, 244);
            this.lstStatus.TabIndex = 5;
            // 
            // lblReq
            // 
            this.lblReq.AutoSize = true;
            this.lblReq.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReq.Location = new System.Drawing.Point(12, 95);
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(67, 20);
            this.lblReq.TabIndex = 6;
            this.lblReq.Text = "Request:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(216, 95);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDel.Location = new System.Drawing.Point(12, 421);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(94, 29);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // lblDelReq
            // 
            this.lblDelReq.AutoSize = true;
            this.lblDelReq.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDelReq.Location = new System.Drawing.Point(12, 382);
            this.lblDelReq.Name = "lblDelReq";
            this.lblDelReq.Size = new System.Drawing.Size(115, 20);
            this.lblDelReq.TabIndex = 9;
            this.lblDelReq.Text = "Delete Request:";
            // 
            // cmbReq
            // 
            this.cmbReq.FormattingEnabled = true;
            this.cmbReq.Location = new System.Drawing.Point(131, 379);
            this.cmbReq.Name = "cmbReq";
            this.cmbReq.Size = new System.Drawing.Size(151, 28);
            this.cmbReq.TabIndex = 10;
            this.cmbReq.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmViewStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 500);
            this.Controls.Add(this.cmbReq);
            this.Controls.Add(this.lblDelReq);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblReq);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.lstDetail);
            this.Controls.Add(this.picStu);
            this.Controls.Add(this.lblName_StuID);
            this.Controls.Add(this.lblStu);
            this.Controls.Add(this.lblETC);
            this.Name = "frmViewStatus";
            this.Text = "frmViewStatus";
            this.Load += new System.EventHandler(this.frmViewStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblETC;
        private Label lblStu;
        private Label lblName_StuID;
        private PictureBox picStu;
        private ListBox lstDetail;
        private ListBox lstStatus;
        private Label lblReq;
        private Label lblStatus;
        private Button btnDel;
        private Label lblDelReq;
        private ComboBox cmbReq;
    }
}