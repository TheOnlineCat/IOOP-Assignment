namespace IOOP_Assignment
{
    partial class Login
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.pictureBox_Key = new System.Windows.Forms.PictureBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Key)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(31, 12);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(353, 41);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Excellent Tuition Centre";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(61, 196);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(78, 20);
            this.label_Username.TabIndex = 1;
            this.label_Username.Text = "Username:";
            this.label_Username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.Image = global::IOOP_Assignment.Properties.Resources.Sample_User_Icon;
            this.pictureBox_User.Location = new System.Drawing.Point(14, 183);
            this.pictureBox_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(40, 47);
            this.pictureBox_User.TabIndex = 2;
            this.pictureBox_User.TabStop = false;
            // 
            // pictureBox_Key
            // 
            this.pictureBox_Key.Image = global::IOOP_Assignment.Properties.Resources.key_icon_614x4601;
            this.pictureBox_Key.Location = new System.Drawing.Point(14, 249);
            this.pictureBox_Key.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_Key.Name = "pictureBox_Key";
            this.pictureBox_Key.Size = new System.Drawing.Size(43, 24);
            this.pictureBox_Key.TabIndex = 4;
            this.pictureBox_Key.TabStop = false;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(64, 251);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(73, 20);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password:";
            this.label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(129, 192);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.PlaceholderText = "Username";
            this.textBox_Username.Size = new System.Drawing.Size(217, 27);
            this.textBox_Username.TabIndex = 5;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(129, 247);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.PlaceholderText = "Password";
            this.textBox_Password.Size = new System.Drawing.Size(217, 27);
            this.textBox_Password.TabIndex = 6;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(129, 297);
            this.button_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(122, 52);
            this.button_Login.TabIndex = 7;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(389, 365);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.pictureBox_Key);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.pictureBox_User);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_Title);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Key)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Title;
        private Label label_Username;
        private PictureBox pictureBox_User;
        private PictureBox pictureBox_Key;
        private Label label_Password;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private Button button_Login;
    }
}