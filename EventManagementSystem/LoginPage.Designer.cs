namespace EventManagementSystem
{
    partial class LoginPage
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
            UserName = new Label();
            Password = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.BackColor = Color.Transparent;
            UserName.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold);
            UserName.ForeColor = Color.WhiteSmoke;
            UserName.Location = new Point(261, 297);
            UserName.Name = "UserName";
            UserName.Size = new Size(173, 40);
            UserName.TabIndex = 0;
            UserName.Text = "UserName";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold);
            Password.ForeColor = Color.WhiteSmoke;
            Password.Location = new Point(261, 364);
            Password.Name = "Password";
            Password.Size = new Size(163, 40);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(471, 307);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(173, 30);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(471, 375);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(173, 30);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(307, 446);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(485, 446);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(171, 139);
            label1.Name = "label1";
            label1.Size = new Size(604, 64);
            label1.TabIndex = 6;
            label1.Text = "Make Memories at Will!";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.aditya_chinchure_ZhQCZjr9fHo_unsplash_1024x768;
            ClientSize = new Size(920, 589);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(Password);
            Controls.Add(UserName);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserName;
        private Label Password;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label label1;
    }
}