namespace EventManagementSystem
{
    partial class AddAttendee
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnCancelSearchUser = new Button();
            txtUserName = new TextBox();
            btnSearchUser = new Button();
            label2 = new Label();
            btnAddAttendee = new Button();
            btnCancelAddAttendee = new Button();
            dataGridView1 = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            UserEmail = new DataGridViewTextBoxColumn();
            UserPhone = new DataGridViewTextBoxColumn();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eventsToolStripMenuItem, usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(783, 30);
            menuStrip1.TabIndex = 3;
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
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(153, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
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
            viewEventsToolStripMenuItem.Size = new Size(270, 34);
            viewEventsToolStripMenuItem.Text = "All Events";
            viewEventsToolStripMenuItem.Click += viewEventsToolStripMenuItem_Click;
            // 
            // addEventToolStripMenuItem
            // 
            addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            addEventToolStripMenuItem.Size = new Size(270, 34);
            addEventToolStripMenuItem.Text = "Add Event";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 69);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelSearchUser);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(btnSearchUser);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(46, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(674, 164);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search users";
            // 
            // btnCancelSearchUser
            // 
            btnCancelSearchUser.Location = new Point(165, 104);
            btnCancelSearchUser.Name = "btnCancelSearchUser";
            btnCancelSearchUser.Size = new Size(102, 31);
            btnCancelSearchUser.TabIndex = 15;
            btnCancelSearchUser.Text = "Clear";
            btnCancelSearchUser.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Window;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(153, 45);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(220, 29);
            txtUserName.TabIndex = 8;
            // 
            // btnSearchUser
            // 
            btnSearchUser.Location = new Point(34, 104);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(102, 31);
            btnSearchUser.TabIndex = 14;
            btnSearchUser.Text = "Search";
            btnSearchUser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 48);
            label2.Name = "label2";
            label2.Size = new Size(96, 22);
            label2.TabIndex = 6;
            label2.Text = "User Name";
            // 
            // btnAddAttendee
            // 
            btnAddAttendee.Location = new Point(80, 506);
            btnAddAttendee.Name = "btnAddAttendee";
            btnAddAttendee.Size = new Size(102, 31);
            btnAddAttendee.TabIndex = 20;
            btnAddAttendee.Text = "Add";
            btnAddAttendee.UseVisualStyleBackColor = true;
            btnAddAttendee.Click += btnAddAttendee_Click;
            // 
            // btnCancelAddAttendee
            // 
            btnCancelAddAttendee.Location = new Point(221, 506);
            btnCancelAddAttendee.Name = "btnCancelAddAttendee";
            btnCancelAddAttendee.Size = new Size(102, 31);
            btnCancelAddAttendee.TabIndex = 21;
            btnCancelAddAttendee.Text = "Cancel";
            btnCancelAddAttendee.UseVisualStyleBackColor = true;
            btnCancelAddAttendee.Click += btnCancelAddAttendee_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserName, UserEmail, UserPhone });
            dataGridView1.Location = new Point(46, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(674, 213);
            dataGridView1.TabIndex = 22;
            // 
            // UserName
            // 
            UserName.HeaderText = "Name";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            UserName.Width = 200;
            // 
            // UserEmail
            // 
            UserEmail.HeaderText = "Email";
            UserEmail.MinimumWidth = 8;
            UserEmail.Name = "UserEmail";
            UserEmail.Width = 200;
            // 
            // UserPhone
            // 
            UserPhone.HeaderText = "Phone";
            UserPhone.MinimumWidth = 8;
            UserPhone.Name = "UserPhone";
            UserPhone.Width = 200;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 237);
            label3.Name = "label3";
            label3.Size = new Size(60, 22);
            label3.TabIndex = 23;
            label3.Text = "Users";
            // 
            // AddAttendee
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 567);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelAddAttendee);
            Controls.Add(btnAddAttendee);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AddAttendee";
            Text = "Add Attendee";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem eventsToolStripMenuItem;
        private ToolStripMenuItem viewEventsToolStripMenuItem;
        private ToolStripMenuItem addEventToolStripMenuItem;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnCancelSearchUser;
        private TextBox txtUserName;
        private Button btnSearchUser;
        private Label label2;
        private Button btnAddAttendee;
        private Button btnCancelAddAttendee;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem allUsersToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserEmail;
        private DataGridViewTextBoxColumn UserPhone;
        private Label label3;
    }
}