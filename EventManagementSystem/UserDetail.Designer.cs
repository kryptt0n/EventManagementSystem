namespace EventManagementSystem
{
    partial class UserDetail
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            adminRadioBtn = new RadioButton();
            groupBox1 = new GroupBox();
            attendeeRadioBtn = new RadioButton();
            managerRadioBtn = new RadioButton();
            label3 = new Label();
            dateTimePickerDoB = new DateTimePicker();
            saveBtn = new Button();
            cancelBtn = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            eventsToolStripMenuItem = new ToolStripMenuItem();
            viewEventsToolStripMenuItem = new ToolStripMenuItem();
            addEventToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            allUsersToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            attendeeToolStripMenuItem = new ToolStripMenuItem();
            myEventsToolStripMenuItem = new ToolStripMenuItem();
            registForEventsToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label4 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F);
            label1.Location = new Point(91, 62);
            label1.Name = "label1";
            label1.Size = new Size(55, 22);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Tahoma", 9F);
            txtName.Location = new Point(180, 62);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(308, 29);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F);
            label2.Location = new Point(101, 158);
            label2.Name = "label2";
            label2.Size = new Size(44, 22);
            label2.TabIndex = 2;
            label2.Text = "Role";
            // 
            // adminRadioBtn
            // 
            adminRadioBtn.AutoSize = true;
            adminRadioBtn.Location = new Point(5, 9);
            adminRadioBtn.Margin = new Padding(3, 2, 3, 2);
            adminRadioBtn.Name = "adminRadioBtn";
            adminRadioBtn.Size = new Size(85, 26);
            adminRadioBtn.TabIndex = 3;
            adminRadioBtn.TabStop = true;
            adminRadioBtn.Text = "Admin";
            adminRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(attendeeRadioBtn);
            groupBox1.Controls.Add(managerRadioBtn);
            groupBox1.Controls.Add(adminRadioBtn);
            groupBox1.Font = new Font("Tahoma", 9F);
            groupBox1.Location = new Point(180, 158);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(255, 113);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // attendeeRadioBtn
            // 
            attendeeRadioBtn.AutoSize = true;
            attendeeRadioBtn.Location = new Point(5, 68);
            attendeeRadioBtn.Margin = new Padding(3, 2, 3, 2);
            attendeeRadioBtn.Name = "attendeeRadioBtn";
            attendeeRadioBtn.Size = new Size(105, 26);
            attendeeRadioBtn.TabIndex = 5;
            attendeeRadioBtn.TabStop = true;
            attendeeRadioBtn.Text = "Attendee";
            attendeeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // managerRadioBtn
            // 
            managerRadioBtn.AutoSize = true;
            managerRadioBtn.Location = new Point(5, 38);
            managerRadioBtn.Margin = new Padding(3, 2, 3, 2);
            managerRadioBtn.Name = "managerRadioBtn";
            managerRadioBtn.Size = new Size(102, 26);
            managerRadioBtn.TabIndex = 4;
            managerRadioBtn.TabStop = true;
            managerRadioBtn.Text = "Manager";
            managerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F);
            label3.Location = new Point(40, 280);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 5;
            label3.Text = "Date of Birth";
            // 
            // dateTimePickerDoB
            // 
            dateTimePickerDoB.Font = new Font("Tahoma", 9F);
            dateTimePickerDoB.Location = new Point(180, 275);
            dateTimePickerDoB.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerDoB.Name = "dateTimePickerDoB";
            dateTimePickerDoB.Size = new Size(309, 29);
            dateTimePickerDoB.TabIndex = 6;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Tahoma", 9F);
            saveBtn.Location = new Point(101, 473);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(115, 35);
            saveBtn.TabIndex = 7;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Tahoma", 9F);
            cancelBtn.Location = new Point(320, 473);
            cancelBtn.Margin = new Padding(3, 2, 3, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(115, 35);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Tahoma", 9F);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eventsToolStripMenuItem, usersToolStripMenuItem, attendeeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(551, 30);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(52, 26);
            fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(153, 34);
            loginToolStripMenuItem.Text = "Login";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(153, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // eventsToolStripMenuItem
            // 
            eventsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewEventsToolStripMenuItem, addEventToolStripMenuItem });
            eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            eventsToolStripMenuItem.Size = new Size(78, 26);
            eventsToolStripMenuItem.Text = "Events";
            // 
            // viewEventsToolStripMenuItem
            // 
            viewEventsToolStripMenuItem.Name = "viewEventsToolStripMenuItem";
            viewEventsToolStripMenuItem.Size = new Size(191, 34);
            viewEventsToolStripMenuItem.Text = "All Events";
            viewEventsToolStripMenuItem.Click += viewEventsToolStripMenuItem_Click;
            // 
            // addEventToolStripMenuItem
            // 
            addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            addEventToolStripMenuItem.Size = new Size(191, 34);
            addEventToolStripMenuItem.Text = "Add Event";
            addEventToolStripMenuItem.Click += addEventToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allUsersToolStripMenuItem, addUserToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(69, 26);
            usersToolStripMenuItem.Text = "Users";
            // 
            // allUsersToolStripMenuItem
            // 
            allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            allUsersToolStripMenuItem.Size = new Size(182, 34);
            allUsersToolStripMenuItem.Text = "All Users";
            allUsersToolStripMenuItem.Click += allUsersToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(182, 34);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // attendeeToolStripMenuItem
            // 
            attendeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myEventsToolStripMenuItem, registForEventsToolStripMenuItem });
            attendeeToolStripMenuItem.Name = "attendeeToolStripMenuItem";
            attendeeToolStripMenuItem.Size = new Size(96, 26);
            attendeeToolStripMenuItem.Text = "Attendee";
            // 
            // myEventsToolStripMenuItem
            // 
            myEventsToolStripMenuItem.Name = "myEventsToolStripMenuItem";
            myEventsToolStripMenuItem.Size = new Size(244, 34);
            myEventsToolStripMenuItem.Text = "My Events";
            myEventsToolStripMenuItem.Click += myEventsToolStripMenuItem_Click;
            // 
            // registForEventsToolStripMenuItem
            // 
            registForEventsToolStripMenuItem.Name = "registForEventsToolStripMenuItem";
            registForEventsToolStripMenuItem.Size = new Size(244, 34);
            registForEventsToolStripMenuItem.Text = "Regist for Events";
            registForEventsToolStripMenuItem.Click += registForEventsToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F);
            label4.Location = new Point(94, 327);
            label4.Name = "label4";
            label4.Size = new Size(52, 22);
            label4.TabIndex = 10;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F);
            label6.Location = new Point(87, 373);
            label6.Name = "label6";
            label6.Size = new Size(59, 22);
            label6.TabIndex = 12;
            label6.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Tahoma", 9F);
            txtEmail.Location = new Point(180, 325);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(308, 29);
            txtEmail.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Tahoma", 9F);
            txtPhone.Location = new Point(180, 371);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(308, 29);
            txtPhone.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 110);
            label5.Name = "label5";
            label5.Size = new Size(84, 22);
            label5.TabIndex = 15;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(180, 107);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(308, 29);
            txtPassword.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F);
            label7.Location = new Point(86, 422);
            label7.Name = "label7";
            label7.Size = new Size(48, 22);
            label7.TabIndex = 17;
            label7.Text = "Valid";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Y", "N" });
            comboBox1.Location = new Point(180, 419);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 30);
            comboBox1.TabIndex = 18;
            // 
            // UserDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 531);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(menuStrip1);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(dateTimePickerDoB);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserDetail";
            Text = "User Detail";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private RadioButton adminRadioBtn;
        private GroupBox groupBox1;
        private RadioButton attendeeRadioBtn;
        private RadioButton managerRadioBtn;
        private Label label3;
        private DateTimePicker dateTimePickerDoB;
        private Button saveBtn;
        private Button cancelBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem eventsToolStripMenuItem;
        private ToolStripMenuItem viewEventsToolStripMenuItem;
        private ToolStripMenuItem addEventToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem allUsersToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtPassword;
        private ToolStripMenuItem attendeeToolStripMenuItem;
        private ToolStripMenuItem myEventsToolStripMenuItem;
        private ToolStripMenuItem registForEventsToolStripMenuItem;
        private Label label7;
        private ComboBox comboBox1;
    }
}