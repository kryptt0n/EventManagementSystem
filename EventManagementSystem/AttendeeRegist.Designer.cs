namespace EventManagementSystem
{
    partial class AttendeeRegist
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
            btnRegister = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(59, 247);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(102, 31);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(219, 247);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 31);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 49);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 105);
            label2.Name = "label2";
            label2.Size = new Size(127, 22);
            label2.TabIndex = 3;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 170);
            label3.Name = "label3";
            label3.Size = new Size(52, 22);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(219, 46);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(137, 29);
            txtUserName.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(219, 102);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(137, 29);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(219, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(137, 29);
            txtEmail.TabIndex = 7;
            // 
            // AttendeeRegist
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 350);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AttendeeRegist";
            Text = "Attendee Regist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
    }
}