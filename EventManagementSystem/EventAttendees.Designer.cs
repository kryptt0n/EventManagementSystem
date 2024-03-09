namespace EventManagementSystem
{
    partial class EventAttendees
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
            txtEventName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnDeleteAttendee = new Button();
            btnAddAttendee = new Button();
            dataGridView1 = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            UserEmail = new DataGridViewTextBoxColumn();
            UserPhone = new DataGridViewTextBoxColumn();
            label3 = new Label();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eventsToolStripMenuItem, usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(912, 32);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(56, 28);
            fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(158, 34);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(158, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // eventsToolStripMenuItem
            // 
            eventsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewEventsToolStripMenuItem, addEventToolStripMenuItem });
            eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            eventsToolStripMenuItem.Size = new Size(81, 28);
            eventsToolStripMenuItem.Text = "Events";
            // 
            // viewEventsToolStripMenuItem
            // 
            viewEventsToolStripMenuItem.Name = "viewEventsToolStripMenuItem";
            viewEventsToolStripMenuItem.Size = new Size(199, 34);
            viewEventsToolStripMenuItem.Text = "All Events";
            viewEventsToolStripMenuItem.Click += viewEventsToolStripMenuItem_Click;
            // 
            // addEventToolStripMenuItem
            // 
            addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            addEventToolStripMenuItem.Size = new Size(199, 34);
            addEventToolStripMenuItem.Text = "Add Event";
            addEventToolStripMenuItem.Click += addEventToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allUsersToolStripMenuItem, addUserToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(72, 28);
            usersToolStripMenuItem.Text = "Users";
            // 
            // allUsersToolStripMenuItem
            // 
            allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            allUsersToolStripMenuItem.Size = new Size(190, 34);
            allUsersToolStripMenuItem.Text = "All Users";
            allUsersToolStripMenuItem.Click += allUsersToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(190, 34);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // txtEventName
            // 
            txtEventName.BorderStyle = BorderStyle.FixedSingle;
            txtEventName.Location = new Point(201, 63);
            txtEventName.Name = "txtEventName";
            txtEventName.ReadOnly = true;
            txtEventName.Size = new Size(236, 30);
            txtEventName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 66);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 7;
            label1.Text = "Event Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(44, 120);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 9;
            label2.Text = "Attendees";
            // 
            // btnDeleteAttendee
            // 
            btnDeleteAttendee.Location = new Point(194, 484);
            btnDeleteAttendee.Name = "btnDeleteAttendee";
            btnDeleteAttendee.Size = new Size(112, 34);
            btnDeleteAttendee.TabIndex = 13;
            btnDeleteAttendee.Text = "Delete";
            btnDeleteAttendee.UseVisualStyleBackColor = true;
            // 
            // btnAddAttendee
            // 
            btnAddAttendee.Location = new Point(46, 484);
            btnAddAttendee.Name = "btnAddAttendee";
            btnAddAttendee.Size = new Size(112, 34);
            btnAddAttendee.TabIndex = 12;
            btnAddAttendee.Text = "Add";
            btnAddAttendee.UseVisualStyleBackColor = true;
            btnAddAttendee.Click += btnAddAttendee_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserName, UserEmail, UserPhone });
            dataGridView1.Location = new Point(44, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(821, 298);
            dataGridView1.TabIndex = 14;
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
            label3.Location = new Point(488, 66);
            label3.Name = "label3";
            label3.Size = new Size(125, 24);
            label3.TabIndex = 15;
            label3.Text = "Remain Seats";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(629, 63);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(236, 30);
            textBox1.TabIndex = 16;
            // 
            // EventAttendees
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 551);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnDeleteAttendee);
            Controls.Add(btnAddAttendee);
            Controls.Add(label2);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "EventAttendees";
            Text = "Event Attendees";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private TextBox txtEventName;
        private Label label1;
        private Label label2;
        private Button btnDeleteAttendee;
        private Button btnAddAttendee;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem allUsersToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserEmail;
        private DataGridViewTextBoxColumn UserPhone;
    }
}