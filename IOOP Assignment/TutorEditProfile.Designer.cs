namespace IOOP_Assignment
{
    partial class TutorEditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorEditProfile));
            this.picTutor = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTutor = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTName = new System.Windows.Forms.Label();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.lblCPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpPass = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTutor)).BeginInit();
            this.grpClass.SuspendLayout();
            this.grpPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTutor
            // 
            this.picTutor.Image = ((System.Drawing.Image)(resources.GetObject("picTutor.Image")));
            this.picTutor.Location = new System.Drawing.Point(575, 5);
            this.picTutor.Name = "picTutor";
            this.picTutor.Size = new System.Drawing.Size(62, 56);
            this.picTutor.TabIndex = 24;
            this.picTutor.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(218, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 37);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Editing Profile";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(510, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 15);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "$Name$";
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTutor.ForeColor = System.Drawing.Color.Black;
            this.lblTutor.Location = new System.Drawing.Point(498, 9);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(86, 37);
            this.lblTutor.TabIndex = 20;
            this.lblTutor.Text = "Tutor";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(6, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(63, 37);
            this.lblLogo.TabIndex = 19;
            this.lblLogo.Text = "ETC";
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.btnEdit);
            this.grpClass.Controls.Add(this.txtUsername);
            this.grpClass.Controls.Add(this.txtName);
            this.grpClass.Controls.Add(this.lblUsername);
            this.grpClass.Controls.Add(this.lblTName);
            this.grpClass.Location = new System.Drawing.Point(145, 120);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(357, 146);
            this.grpClass.TabIndex = 25;
            this.grpClass.TabStop = false;
            this.grpClass.Text = "Tutor";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(132, 112);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 22);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "Edit Password";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.Location = new System.Drawing.Point(98, 77);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(224, 23);
            this.txtUsername.TabIndex = 31;
            this.txtUsername.Text = "$USERNAME$";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtName.Location = new System.Drawing.Point(98, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 23);
            this.txtName.TabIndex = 30;
            this.txtName.Text = "$NAME$";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(29, 80);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 15);
            this.lblUsername.TabIndex = 27;
            this.lblUsername.Text = "Username:";
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.Location = new System.Drawing.Point(50, 34);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(42, 15);
            this.lblTName.TabIndex = 26;
            this.lblTName.Text = "Name:";
            // 
            // txtCPassword
            // 
            this.txtCPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtCPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCPassword.Location = new System.Drawing.Point(98, 74);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.Size = new System.Drawing.Size(224, 23);
            this.txtCPassword.TabIndex = 33;
            this.txtCPassword.Text = "Confirm Password";
            // 
            // lblCPassword
            // 
            this.lblCPassword.AutoSize = true;
            this.lblCPassword.Location = new System.Drawing.Point(21, 72);
            this.lblCPassword.Name = "lblCPassword";
            this.lblCPassword.Size = new System.Drawing.Size(60, 30);
            this.lblCPassword.TabIndex = 29;
            this.lblCPassword.Text = "Confirm\r\nPassword:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.Location = new System.Drawing.Point(98, 26);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(224, 23);
            this.txtPassword.TabIndex = 32;
            this.txtPassword.Text = "Enter New Password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(21, 24);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 30);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "New\r\nPassword:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(126, 118);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(100, 15);
            this.lblCurrent.TabIndex = 30;
            this.lblCurrent.Text = "Current Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(71, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 23);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "Enter Current password to save changes";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirm.Location = new System.Drawing.Point(510, 471);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 35;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(40, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // grpPass
            // 
            this.grpPass.Controls.Add(this.lblPassword);
            this.grpPass.Controls.Add(this.txtCPassword);
            this.grpPass.Controls.Add(this.txtPassword);
            this.grpPass.Controls.Add(this.textBox1);
            this.grpPass.Controls.Add(this.lblCPassword);
            this.grpPass.Controls.Add(this.lblCurrent);
            this.grpPass.Location = new System.Drawing.Point(145, 272);
            this.grpPass.Name = "grpPass";
            this.grpPass.Size = new System.Drawing.Size(357, 193);
            this.grpPass.TabIndex = 37;
            this.grpPass.TabStop = false;
            this.grpPass.Text = "Password";
            // 
            // TutorEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 550);
            this.Controls.Add(this.grpPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpClass);
            this.Controls.Add(this.picTutor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTutor);
            this.Controls.Add(this.lblLogo);
            this.Name = "TutorEditProfile";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.picTutor)).EndInit();
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            this.grpPass.ResumeLayout(false);
            this.grpPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picTutor;
        private Label lblTitle;
        private Label lblName;
        private Label lblTutor;
        private Label lblLogo;
        private GroupBox grpClass;
        private TextBox txtCPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtName;
        private Label lblCPassword;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblTName;
        private Label lblCurrent;
        private TextBox textBox1;
        private Button btnConfirm;
        private Button btnEdit;
        private Button btnCancel;
        private GroupBox grpPass;
    }
}