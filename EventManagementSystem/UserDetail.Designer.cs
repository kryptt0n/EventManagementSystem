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
            groupBoxRoles = new GroupBox();
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            label4 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            comboBoxValid = new ComboBox();
            groupBoxRoles.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.5F);
            label1.Location = new Point(73, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Tahoma", 10.5F);
            txtName.Location = new Point(232, 90);
            txtName.Margin = new Padding(4, 2, 4, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(369, 33);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.5F);
            label2.Location = new Point(73, 254);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 2;
            label2.Text = "Role";
            // 
            // adminRadioBtn
            // 
            adminRadioBtn.AutoSize = true;
            adminRadioBtn.Location = new Point(7, 18);
            adminRadioBtn.Margin = new Padding(4, 2, 4, 2);
            adminRadioBtn.Name = "adminRadioBtn";
            adminRadioBtn.Size = new Size(97, 29);
            adminRadioBtn.TabIndex = 3;
            adminRadioBtn.TabStop = true;
            adminRadioBtn.Text = "Admin";
            adminRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBoxRoles
            // 
            groupBoxRoles.Controls.Add(attendeeRadioBtn);
            groupBoxRoles.Controls.Add(managerRadioBtn);
            groupBoxRoles.Controls.Add(adminRadioBtn);
            groupBoxRoles.Font = new Font("Tahoma", 10.5F);
            groupBoxRoles.Location = new Point(232, 217);
            groupBoxRoles.Margin = new Padding(4, 2, 4, 2);
            groupBoxRoles.Name = "groupBoxRoles";
            groupBoxRoles.Padding = new Padding(4, 2, 4, 2);
            groupBoxRoles.Size = new Size(369, 144);
            groupBoxRoles.TabIndex = 4;
            groupBoxRoles.TabStop = false;
            // 
            // attendeeRadioBtn
            // 
            attendeeRadioBtn.AutoSize = true;
            attendeeRadioBtn.Location = new Point(7, 103);
            attendeeRadioBtn.Margin = new Padding(4, 2, 4, 2);
            attendeeRadioBtn.Name = "attendeeRadioBtn";
            attendeeRadioBtn.Size = new Size(121, 29);
            attendeeRadioBtn.TabIndex = 5;
            attendeeRadioBtn.TabStop = true;
            attendeeRadioBtn.Text = "Attendee";
            attendeeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // managerRadioBtn
            // 
            managerRadioBtn.AutoSize = true;
            managerRadioBtn.Location = new Point(7, 60);
            managerRadioBtn.Margin = new Padding(4, 2, 4, 2);
            managerRadioBtn.Name = "managerRadioBtn";
            managerRadioBtn.Size = new Size(118, 29);
            managerRadioBtn.TabIndex = 4;
            managerRadioBtn.TabStop = true;
            managerRadioBtn.Text = "Manager";
            managerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.5F);
            label3.Location = new Point(73, 380);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 5;
            label3.Text = "Date of Birth";
            // 
            // dateTimePickerDoB
            // 
            dateTimePickerDoB.Font = new Font("Tahoma", 10.5F);
            dateTimePickerDoB.Location = new Point(232, 380);
            dateTimePickerDoB.Margin = new Padding(4, 2, 4, 2);
            dateTimePickerDoB.Name = "dateTimePickerDoB";
            dateTimePickerDoB.Size = new Size(370, 33);
            dateTimePickerDoB.TabIndex = 6;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Wheat;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Tahoma", 10.5F);
            saveBtn.Location = new Point(159, 710);
            saveBtn.Margin = new Padding(4, 2, 4, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(138, 47);
            saveBtn.TabIndex = 7;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Wheat;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Tahoma", 10.5F);
            cancelBtn.Location = new Point(370, 710);
            cancelBtn.Margin = new Padding(4, 2, 4, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(138, 47);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Tahoma", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eventsToolStripMenuItem, usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 2, 0, 2);
            menuStrip1.Size = new Size(674, 33);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(60, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(270, 34);
            loginToolStripMenuItem.Text = "Log off";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // eventsToolStripMenuItem
            // 
            eventsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewEventsToolStripMenuItem, addEventToolStripMenuItem });
            eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            eventsToolStripMenuItem.Size = new Size(89, 29);
            eventsToolStripMenuItem.Text = "Events";
            // 
            // viewEventsToolStripMenuItem
            // 
            viewEventsToolStripMenuItem.Name = "viewEventsToolStripMenuItem";
            viewEventsToolStripMenuItem.Size = new Size(210, 34);
            viewEventsToolStripMenuItem.Text = "All Events";
            viewEventsToolStripMenuItem.Click += viewEventsToolStripMenuItem_Click;
            // 
            // addEventToolStripMenuItem
            // 
            addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            addEventToolStripMenuItem.Size = new Size(210, 34);
            addEventToolStripMenuItem.Text = "Add Event";
            addEventToolStripMenuItem.Click += addEventToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allUsersToolStripMenuItem, addUserToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(79, 29);
            usersToolStripMenuItem.Text = "Users";
            // 
            // allUsersToolStripMenuItem
            // 
            allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            allUsersToolStripMenuItem.Size = new Size(200, 34);
            allUsersToolStripMenuItem.Text = "All Users";
            allUsersToolStripMenuItem.Click += allUsersToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(200, 34);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
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
            label4.Font = new Font("Tahoma", 10.5F);
            label4.Location = new Point(73, 461);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 10;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.5F);
            label6.Location = new Point(73, 542);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 12;
            label6.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Tahoma", 10.5F);
            txtEmail.Location = new Point(232, 460);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(369, 33);
            txtEmail.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Tahoma", 10.5F);
            txtPhone.Location = new Point(232, 540);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(369, 33);
            txtPhone.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.5F);
            label5.Location = new Point(73, 173);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 15;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Tahoma", 10.5F);
            txtPassword.Location = new Point(232, 171);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(369, 33);
            txtPassword.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.5F);
            label7.Location = new Point(73, 623);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 17;
            label7.Text = "Valid";
            label7.Click += label7_Click;
            // 
            // comboBoxValid
            // 
            comboBoxValid.Font = new Font("Tahoma", 10.5F);
            comboBoxValid.FormattingEnabled = true;
            comboBoxValid.Items.AddRange(new object[] { "Y", "N" });
            comboBoxValid.Location = new Point(232, 620);
            comboBoxValid.Margin = new Padding(4, 3, 4, 3);
            comboBoxValid.Name = "comboBoxValid";
            comboBoxValid.Size = new Size(218, 33);
            comboBoxValid.TabIndex = 18;
            comboBoxValid.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // UserDetail
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(674, 793);
            Controls.Add(comboBoxValid);
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
            Controls.Add(groupBoxRoles);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Tahoma", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "UserDetail";
            Text = "User Detail";
            Load += UserDetail_Load;
            groupBoxRoles.ResumeLayout(false);
            groupBoxRoles.PerformLayout();
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
        private GroupBox groupBoxRoles;
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
        private Label label7;
        private ComboBox comboBoxValid;
    }
}