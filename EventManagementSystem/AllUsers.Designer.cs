namespace EventManagementSystem
{
    partial class AllUsers
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
            label1 = new Label();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
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
            groupBox1 = new GroupBox();
            btnCancelSearchEvent = new Button();
            btnSearchEvent = new Button();
            attendeeRadioBtn = new RadioButton();
            managerRadioBtn = new RadioButton();
            adminRadioBtn = new RadioButton();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            UserRole = new DataGridViewTextBoxColumn();
            DoB = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 36);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 1;
            label1.Text = "Users";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(602, 69);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(127, 34);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(602, 126);
            editBtn.Margin = new Padding(3, 2, 3, 2);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(127, 34);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(602, 184);
            deleteBtn.Margin = new Padding(3, 2, 3, 2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(127, 34);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eventsToolStripMenuItem, usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(760, 32);
            menuStrip1.TabIndex = 5;
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
            loginToolStripMenuItem.Size = new Size(270, 34);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelSearchEvent);
            groupBox1.Controls.Add(btnSearchEvent);
            groupBox1.Controls.Add(attendeeRadioBtn);
            groupBox1.Controls.Add(managerRadioBtn);
            groupBox1.Controls.Add(adminRadioBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(28, 402);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(722, 150);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search users";
            // 
            // btnCancelSearchEvent
            // 
            btnCancelSearchEvent.Location = new Point(552, 76);
            btnCancelSearchEvent.Name = "btnCancelSearchEvent";
            btnCancelSearchEvent.Size = new Size(149, 34);
            btnCancelSearchEvent.TabIndex = 17;
            btnCancelSearchEvent.Text = "Clear";
            btnCancelSearchEvent.UseVisualStyleBackColor = true;
            // 
            // btnSearchEvent
            // 
            btnSearchEvent.Location = new Point(552, 33);
            btnSearchEvent.Name = "btnSearchEvent";
            btnSearchEvent.Size = new Size(149, 37);
            btnSearchEvent.TabIndex = 16;
            btnSearchEvent.Text = "Search";
            btnSearchEvent.UseVisualStyleBackColor = true;
            // 
            // attendeeRadioBtn
            // 
            attendeeRadioBtn.AutoSize = true;
            attendeeRadioBtn.Location = new Point(368, 96);
            attendeeRadioBtn.Margin = new Padding(3, 2, 3, 2);
            attendeeRadioBtn.Name = "attendeeRadioBtn";
            attendeeRadioBtn.Size = new Size(115, 28);
            attendeeRadioBtn.TabIndex = 8;
            attendeeRadioBtn.TabStop = true;
            attendeeRadioBtn.Text = "Attendee";
            attendeeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // managerRadioBtn
            // 
            managerRadioBtn.AutoSize = true;
            managerRadioBtn.Location = new Point(368, 64);
            managerRadioBtn.Margin = new Padding(3, 2, 3, 2);
            managerRadioBtn.Name = "managerRadioBtn";
            managerRadioBtn.Size = new Size(113, 28);
            managerRadioBtn.TabIndex = 7;
            managerRadioBtn.TabStop = true;
            managerRadioBtn.Text = "Manager";
            managerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // adminRadioBtn
            // 
            adminRadioBtn.AutoSize = true;
            adminRadioBtn.Location = new Point(368, 33);
            adminRadioBtn.Margin = new Padding(3, 2, 3, 2);
            adminRadioBtn.Name = "adminRadioBtn";
            adminRadioBtn.Size = new Size(93, 28);
            adminRadioBtn.TabIndex = 6;
            adminRadioBtn.TabStop = true;
            adminRadioBtn.Text = "Admin";
            adminRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 38);
            label3.Name = "label3";
            label3.Size = new Size(52, 24);
            label3.TabIndex = 2;
            label3.Text = "Role:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 38);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 30);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 38);
            label2.Name = "label2";
            label2.Size = new Size(66, 24);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserName, UserRole, DoB });
            dataGridView1.Location = new Point(28, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(536, 280);
            dataGridView1.TabIndex = 7;
            // 
            // UserName
            // 
            UserName.HeaderText = "User Name";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            UserName.Width = 150;
            // 
            // UserRole
            // 
            UserRole.HeaderText = "User Role";
            UserRole.MinimumWidth = 8;
            UserRole.Name = "UserRole";
            UserRole.Width = 150;
            // 
            // DoB
            // 
            DoB.HeaderText = "Date of Birth";
            DoB.MinimumWidth = 8;
            DoB.Name = "DoB";
            DoB.Width = 170;
            // 
            // AllUsers
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 565);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AllUsers";
            Text = "All Users";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
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
        private GroupBox groupBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private RadioButton attendeeRadioBtn;
        private RadioButton managerRadioBtn;
        private RadioButton adminRadioBtn;
        private Button btnCancelSearchEvent;
        private Button btnSearchEvent;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserRole;
        private DataGridViewTextBoxColumn DoB;
    }
}