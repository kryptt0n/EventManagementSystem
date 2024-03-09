﻿namespace EventManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            UserName = new Label();
            Password = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.BackColor = Color.Transparent;
            UserName.Font = new Font("Tahoma", 9F);
            UserName.ForeColor = Color.Black;
            UserName.Location = new Point(620, 368);
            UserName.Name = "UserName";
            UserName.Size = new Size(90, 22);
            UserName.TabIndex = 0;
            UserName.Text = "UserName";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Tahoma", 9F);
            Password.ForeColor = Color.Black;
            Password.Location = new Point(626, 431);
            Password.Name = "Password";
            Password.Size = new Size(84, 22);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(734, 366);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(157, 29);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(734, 429);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(157, 29);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(626, 494);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 31);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(766, 494);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 31);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(595, 286);
            label1.Name = "label1";
            label1.Size = new Size(325, 34);
            label1.TabIndex = 6;
            label1.Text = "Login to Your Account";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.MH_01065_Annual_Events_and_Festivals_01;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 622);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(687, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 133);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1002, 620);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(Password);
            Controls.Add(UserName);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}