namespace EventManagementSystem
{
    partial class EventAttendeesList
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
            attendeeToolStripMenuItem = new ToolStripMenuItem();
            myEventsToolStripMenuItem = new ToolStripMenuItem();
            registForEventsToolStripMenuItem = new ToolStripMenuItem();
            txtRemainSeats = new TextBox();
            label3 = new Label();
            txtEventName = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            btnCancelSearchUser = new Button();
            btnSearchUnregistered = new Button();
            txtUnregistered = new TextBox();
            label2 = new Label();
            listBoxUnregistered = new ListBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            btnSearchRegistered = new Button();
            txtRegistered = new TextBox();
            label4 = new Label();
            listBoxRegistered = new ListBox();
            moveRightBtn = new Button();
            moveLeftBtn = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eventsToolStripMenuItem, usersToolStripMenuItem, attendeeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(741, 37);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(69, 33);
            fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(201, 44);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(201, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // eventsToolStripMenuItem
            // 
            eventsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewEventsToolStripMenuItem, addEventToolStripMenuItem });
            eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            eventsToolStripMenuItem.Size = new Size(103, 33);
            eventsToolStripMenuItem.Text = "Events";
            // 
            // viewEventsToolStripMenuItem
            // 
            viewEventsToolStripMenuItem.Name = "viewEventsToolStripMenuItem";
            viewEventsToolStripMenuItem.Size = new Size(252, 44);
            viewEventsToolStripMenuItem.Text = "All Events";
            viewEventsToolStripMenuItem.Click += viewEventsToolStripMenuItem_Click;
            // 
            // addEventToolStripMenuItem
            // 
            addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            addEventToolStripMenuItem.Size = new Size(252, 44);
            addEventToolStripMenuItem.Text = "Add Event";
            addEventToolStripMenuItem.Click += addEventToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allUsersToolStripMenuItem, addUserToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(93, 33);
            usersToolStripMenuItem.Text = "Users";
            // 
            // allUsersToolStripMenuItem
            // 
            allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            allUsersToolStripMenuItem.Size = new Size(242, 44);
            allUsersToolStripMenuItem.Text = "All Users";
            allUsersToolStripMenuItem.Click += allUsersToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(242, 44);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // attendeeToolStripMenuItem
            // 
            attendeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myEventsToolStripMenuItem, registForEventsToolStripMenuItem });
            attendeeToolStripMenuItem.Name = "attendeeToolStripMenuItem";
            attendeeToolStripMenuItem.Size = new Size(128, 33);
            attendeeToolStripMenuItem.Text = "Attendee";
            // 
            // myEventsToolStripMenuItem
            // 
            myEventsToolStripMenuItem.Name = "myEventsToolStripMenuItem";
            myEventsToolStripMenuItem.Size = new Size(326, 44);
            myEventsToolStripMenuItem.Text = "My Events";
            myEventsToolStripMenuItem.Click += myEventsToolStripMenuItem_Click;
            // 
            // registForEventsToolStripMenuItem
            // 
            registForEventsToolStripMenuItem.Name = "registForEventsToolStripMenuItem";
            registForEventsToolStripMenuItem.Size = new Size(326, 44);
            registForEventsToolStripMenuItem.Text = "Regist for Events";
            registForEventsToolStripMenuItem.Click += registForEventsToolStripMenuItem_Click;
            // 
            // txtRemainSeats
            // 
            txtRemainSeats.BorderStyle = BorderStyle.FixedSingle;
            txtRemainSeats.Location = new Point(509, 55);
            txtRemainSeats.Name = "txtRemainSeats";
            txtRemainSeats.ReadOnly = true;
            txtRemainSeats.Size = new Size(196, 36);
            txtRemainSeats.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 57);
            label3.Name = "label3";
            label3.Size = new Size(158, 29);
            label3.TabIndex = 19;
            label3.Text = "Remain Seats";
            // 
            // txtEventName
            // 
            txtEventName.BorderStyle = BorderStyle.FixedSingle;
            txtEventName.Location = new Point(147, 55);
            txtEventName.Name = "txtEventName";
            txtEventName.ReadOnly = true;
            txtEventName.Size = new Size(196, 36);
            txtEventName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 57);
            label1.Name = "label1";
            label1.Size = new Size(142, 29);
            label1.TabIndex = 17;
            label1.Text = "Event Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelSearchUser);
            groupBox1.Controls.Add(btnSearchUnregistered);
            groupBox1.Controls.Add(txtUnregistered);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(listBoxUnregistered);
            groupBox1.Location = new Point(25, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 494);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unregistered Users";
            // 
            // btnCancelSearchUser
            // 
            btnCancelSearchUser.Location = new Point(149, 95);
            btnCancelSearchUser.Name = "btnCancelSearchUser";
            btnCancelSearchUser.Size = new Size(93, 35);
            btnCancelSearchUser.TabIndex = 17;
            btnCancelSearchUser.Text = "Clear";
            btnCancelSearchUser.UseVisualStyleBackColor = true;
            btnCancelSearchUser.Click += btnCancelSearchUser_Click;
            // 
            // btnSearchUnregistered
            // 
            btnSearchUnregistered.Location = new Point(30, 95);
            btnSearchUnregistered.Name = "btnSearchUnregistered";
            btnSearchUnregistered.Size = new Size(93, 35);
            btnSearchUnregistered.TabIndex = 16;
            btnSearchUnregistered.Text = "Search";
            btnSearchUnregistered.UseVisualStyleBackColor = true;
            btnSearchUnregistered.Click += btnSearchUnregistered_Click;
            // 
            // txtUnregistered
            // 
            txtUnregistered.BackColor = SystemColors.Window;
            txtUnregistered.BorderStyle = BorderStyle.FixedSingle;
            txtUnregistered.Location = new Point(122, 41);
            txtUnregistered.Name = "txtUnregistered";
            txtUnregistered.Size = new Size(146, 36);
            txtUnregistered.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 44);
            label2.Name = "label2";
            label2.Size = new Size(132, 29);
            label2.TabIndex = 9;
            label2.Text = "User Name";
            // 
            // listBoxUnregistered
            // 
            listBoxUnregistered.FormattingEnabled = true;
            listBoxUnregistered.ItemHeight = 29;
            listBoxUnregistered.Location = new Point(14, 148);
            listBoxUnregistered.Name = "listBoxUnregistered";
            listBoxUnregistered.Size = new Size(254, 265);
            listBoxUnregistered.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(btnSearchRegistered);
            groupBox2.Controls.Add(txtRegistered);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(listBoxRegistered);
            groupBox2.Location = new Point(420, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 494);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registered Attendees";
            // 
            // button3
            // 
            button3.Location = new Point(150, 98);
            button3.Name = "button3";
            button3.Size = new Size(93, 35);
            button3.TabIndex = 21;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnSearchRegistered
            // 
            btnSearchRegistered.Location = new Point(31, 98);
            btnSearchRegistered.Name = "btnSearchRegistered";
            btnSearchRegistered.Size = new Size(93, 35);
            btnSearchRegistered.TabIndex = 20;
            btnSearchRegistered.Text = "Search";
            btnSearchRegistered.UseVisualStyleBackColor = true;
            btnSearchRegistered.Click += btnSearchRegistered_Click;
            // 
            // txtRegistered
            // 
            txtRegistered.BackColor = SystemColors.Window;
            txtRegistered.BorderStyle = BorderStyle.FixedSingle;
            txtRegistered.Location = new Point(123, 44);
            txtRegistered.Name = "txtRegistered";
            txtRegistered.Size = new Size(146, 36);
            txtRegistered.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 47);
            label4.Name = "label4";
            label4.Size = new Size(108, 29);
            label4.TabIndex = 18;
            label4.Text = "Attendee";
            // 
            // listBoxRegistered
            // 
            listBoxRegistered.FormattingEnabled = true;
            listBoxRegistered.ItemHeight = 29;
            listBoxRegistered.Location = new Point(15, 148);
            listBoxRegistered.Name = "listBoxRegistered";
            listBoxRegistered.Size = new Size(254, 265);
            listBoxRegistered.TabIndex = 0;
            // 
            // moveRightBtn
            // 
            moveRightBtn.Location = new Point(339, 344);
            moveRightBtn.Name = "moveRightBtn";
            moveRightBtn.Size = new Size(53, 51);
            moveRightBtn.TabIndex = 23;
            moveRightBtn.Text = ">";
            moveRightBtn.UseVisualStyleBackColor = true;
            moveRightBtn.Click += moveRightBtn_Click;
            // 
            // moveLeftBtn
            // 
            moveLeftBtn.Location = new Point(339, 473);
            moveLeftBtn.Name = "moveLeftBtn";
            moveLeftBtn.Size = new Size(53, 51);
            moveLeftBtn.TabIndex = 24;
            moveLeftBtn.Text = "<";
            moveLeftBtn.UseVisualStyleBackColor = true;
            moveLeftBtn.Click += moveLeftBtn_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(55, 640);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 39);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(200, 640);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 39);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EventAttendeesList
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 713);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(moveLeftBtn);
            Controls.Add(moveRightBtn);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(txtRemainSeats);
            Controls.Add(label3);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "EventAttendeesList";
            Text = "Event Attendees";
            Load += EventAttendeesList_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem allUsersToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private TextBox txtRemainSeats;
        private Label label3;
        private TextBox txtEventName;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button moveRightBtn;
        private Button moveLeftBtn;
        private ListBox listBoxUnregistered;
        private ListBox listBoxRegistered;
        private TextBox txtUnregistered;
        private Label label2;
        private Button btnCancelSearchUser;
        private Button btnSearchUnregistered;
        private Button button3;
        private Button btnSearchRegistered;
        private TextBox txtRegistered;
        private Label label4;
        private Button btnSave;
        private Button btnCancel;
        private ToolStripMenuItem attendeeToolStripMenuItem;
        private ToolStripMenuItem myEventsToolStripMenuItem;
        private ToolStripMenuItem registForEventsToolStripMenuItem;
    }
}