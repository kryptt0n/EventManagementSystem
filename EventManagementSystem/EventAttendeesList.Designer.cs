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
            btnClearUnregistered = new Button();
            btnSearchUnregistered = new Button();
            txtUnregistered = new TextBox();
            label2 = new Label();
            listBoxUnregistered = new ListBox();
            groupBox2 = new GroupBox();
            btnClearRegistered = new Button();
            btnSearchRegistered = new Button();
            txtRegistered = new TextBox();
            label4 = new Label();
            listBoxRegistered = new ListBox();
            moveRightBtn = new Button();
            moveLeftBtn = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AllowMerge = false;
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Tahoma", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eventsToolStripMenuItem, usersToolStripMenuItem, attendeeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1065, 42);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(77, 38);
            fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(215, 44);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(215, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // eventsToolStripMenuItem
            // 
            eventsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewEventsToolStripMenuItem, addEventToolStripMenuItem });
            eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            eventsToolStripMenuItem.Size = new Size(118, 38);
            eventsToolStripMenuItem.Text = "Events";
            // 
            // viewEventsToolStripMenuItem
            // 
            viewEventsToolStripMenuItem.Name = "viewEventsToolStripMenuItem";
            viewEventsToolStripMenuItem.Size = new Size(275, 44);
            viewEventsToolStripMenuItem.Text = "All Events";
            viewEventsToolStripMenuItem.Click += viewEventsToolStripMenuItem_Click;
            // 
            // addEventToolStripMenuItem
            // 
            addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            addEventToolStripMenuItem.Size = new Size(275, 44);
            addEventToolStripMenuItem.Text = "Add Event";
            addEventToolStripMenuItem.Click += addEventToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allUsersToolStripMenuItem, addUserToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(104, 38);
            usersToolStripMenuItem.Text = "Users";
            // 
            // allUsersToolStripMenuItem
            // 
            allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            allUsersToolStripMenuItem.Size = new Size(261, 44);
            allUsersToolStripMenuItem.Text = "All Users";
            allUsersToolStripMenuItem.Click += allUsersToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(261, 44);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // attendeeToolStripMenuItem
            // 
            attendeeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myEventsToolStripMenuItem, registForEventsToolStripMenuItem });
            attendeeToolStripMenuItem.Name = "attendeeToolStripMenuItem";
            attendeeToolStripMenuItem.Size = new Size(146, 38);
            attendeeToolStripMenuItem.Text = "Attendee";
            // 
            // myEventsToolStripMenuItem
            // 
            myEventsToolStripMenuItem.Name = "myEventsToolStripMenuItem";
            myEventsToolStripMenuItem.Size = new Size(359, 44);
            myEventsToolStripMenuItem.Text = "My Events";
            myEventsToolStripMenuItem.Click += myEventsToolStripMenuItem_Click;
            // 
            // registForEventsToolStripMenuItem
            // 
            registForEventsToolStripMenuItem.Name = "registForEventsToolStripMenuItem";
            registForEventsToolStripMenuItem.Size = new Size(359, 44);
            registForEventsToolStripMenuItem.Text = "Regist for Events";
            registForEventsToolStripMenuItem.Click += registForEventsToolStripMenuItem_Click;
            // 
            // txtRemainSeats
            // 
            txtRemainSeats.BorderStyle = BorderStyle.FixedSingle;
            txtRemainSeats.Location = new Point(618, 79);
            txtRemainSeats.Margin = new Padding(4, 3, 4, 3);
            txtRemainSeats.Name = "txtRemainSeats";
            txtRemainSeats.ReadOnly = true;
            txtRemainSeats.Size = new Size(235, 41);
            txtRemainSeats.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(185, 34);
            label3.TabIndex = 19;
            label3.Text = "Remain Seats";
            // 
            // txtEventName
            // 
            txtEventName.BorderStyle = BorderStyle.FixedSingle;
            txtEventName.Location = new Point(183, 79);
            txtEventName.Margin = new Padding(4, 3, 4, 3);
            txtEventName.Name = "txtEventName";
            txtEventName.ReadOnly = true;
            txtEventName.Size = new Size(235, 41);
            txtEventName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 34);
            label1.TabIndex = 17;
            label1.Text = "Event Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClearUnregistered);
            groupBox1.Controls.Add(btnSearchUnregistered);
            groupBox1.Controls.Add(txtUnregistered);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(listBoxUnregistered);
            groupBox1.Location = new Point(57, 153);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(398, 630);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "          Unregistered Users";
            // 
            // btnClearUnregistered
            // 
            btnClearUnregistered.BackColor = Color.Wheat;
            btnClearUnregistered.FlatStyle = FlatStyle.Flat;
            btnClearUnregistered.Location = new Point(190, 136);
            btnClearUnregistered.Margin = new Padding(4, 3, 4, 3);
            btnClearUnregistered.Name = "btnClearUnregistered";
            btnClearUnregistered.Size = new Size(117, 47);
            btnClearUnregistered.TabIndex = 17;
            btnClearUnregistered.Text = "Clear";
            btnClearUnregistered.UseVisualStyleBackColor = false;
            btnClearUnregistered.Click += btnClearUnregistered_Click;
            // 
            // btnSearchUnregistered
            // 
            btnSearchUnregistered.BackColor = Color.Wheat;
            btnSearchUnregistered.FlatStyle = FlatStyle.Flat;
            btnSearchUnregistered.Location = new Point(47, 136);
            btnSearchUnregistered.Margin = new Padding(4, 3, 4, 3);
            btnSearchUnregistered.Name = "btnSearchUnregistered";
            btnSearchUnregistered.Size = new Size(117, 47);
            btnSearchUnregistered.TabIndex = 16;
            btnSearchUnregistered.Text = "Search";
            btnSearchUnregistered.UseVisualStyleBackColor = false;
            btnSearchUnregistered.Click += btnSearchUnregistered_Click;
            // 
            // txtUnregistered
            // 
            txtUnregistered.BackColor = SystemColors.Window;
            txtUnregistered.BorderStyle = BorderStyle.FixedSingle;
            txtUnregistered.Location = new Point(176, 73);
            txtUnregistered.Margin = new Padding(4, 3, 4, 3);
            txtUnregistered.Name = "txtUnregistered";
            txtUnregistered.Size = new Size(175, 41);
            txtUnregistered.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 76);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 34);
            label2.TabIndex = 9;
            label2.Text = "User Name";
            // 
            // listBoxUnregistered
            // 
            listBoxUnregistered.FormattingEnabled = true;
            listBoxUnregistered.ItemHeight = 34;
            listBoxUnregistered.Location = new Point(36, 209);
            listBoxUnregistered.Margin = new Padding(4, 3, 4, 3);
            listBoxUnregistered.Name = "listBoxUnregistered";
            listBoxUnregistered.Size = new Size(336, 378);
            listBoxUnregistered.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnClearRegistered);
            groupBox2.Controls.Add(btnSearchRegistered);
            groupBox2.Controls.Add(txtRegistered);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(listBoxRegistered);
            groupBox2.Location = new Point(610, 153);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(398, 630);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "          Registered Attendees";
            // 
            // btnClearRegistered
            // 
            btnClearRegistered.BackColor = Color.Wheat;
            btnClearRegistered.FlatStyle = FlatStyle.Flat;
            btnClearRegistered.Location = new Point(198, 136);
            btnClearRegistered.Margin = new Padding(4, 3, 4, 3);
            btnClearRegistered.Name = "btnClearRegistered";
            btnClearRegistered.Size = new Size(117, 47);
            btnClearRegistered.TabIndex = 21;
            btnClearRegistered.Text = "Clear";
            btnClearRegistered.UseVisualStyleBackColor = false;
            btnClearRegistered.Click += btnClearRegistered_Click;
            // 
            // btnSearchRegistered
            // 
            btnSearchRegistered.BackColor = Color.Wheat;
            btnSearchRegistered.FlatStyle = FlatStyle.Flat;
            btnSearchRegistered.Location = new Point(55, 136);
            btnSearchRegistered.Margin = new Padding(4, 3, 4, 3);
            btnSearchRegistered.Name = "btnSearchRegistered";
            btnSearchRegistered.Size = new Size(117, 47);
            btnSearchRegistered.TabIndex = 20;
            btnSearchRegistered.Text = "Search";
            btnSearchRegistered.UseVisualStyleBackColor = false;
            btnSearchRegistered.Click += btnSearchRegistered_Click;
            // 
            // txtRegistered
            // 
            txtRegistered.BackColor = SystemColors.Window;
            txtRegistered.BorderStyle = BorderStyle.FixedSingle;
            txtRegistered.Location = new Point(175, 74);
            txtRegistered.Margin = new Padding(4, 3, 4, 3);
            txtRegistered.Name = "txtRegistered";
            txtRegistered.Size = new Size(175, 41);
            txtRegistered.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 77);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(126, 34);
            label4.TabIndex = 18;
            label4.Text = "Attendee";
            // 
            // listBoxRegistered
            // 
            listBoxRegistered.FormattingEnabled = true;
            listBoxRegistered.ItemHeight = 34;
            listBoxRegistered.Location = new Point(28, 209);
            listBoxRegistered.Margin = new Padding(4, 3, 4, 3);
            listBoxRegistered.Name = "listBoxRegistered";
            listBoxRegistered.Size = new Size(336, 378);
            listBoxRegistered.TabIndex = 0;
            // 
            // moveRightBtn
            // 
            moveRightBtn.BackColor = Color.LightGray;
            moveRightBtn.FlatStyle = FlatStyle.Flat;
            moveRightBtn.Location = new Point(502, 440);
            moveRightBtn.Margin = new Padding(4, 3, 4, 3);
            moveRightBtn.Name = "moveRightBtn";
            moveRightBtn.Size = new Size(64, 58);
            moveRightBtn.TabIndex = 23;
            moveRightBtn.Text = ">";
            moveRightBtn.UseVisualStyleBackColor = false;
            moveRightBtn.Click += moveRightBtn_Click;
            // 
            // moveLeftBtn
            // 
            moveLeftBtn.BackColor = Color.LightGray;
            moveLeftBtn.FlatStyle = FlatStyle.Flat;
            moveLeftBtn.Location = new Point(502, 623);
            moveLeftBtn.Margin = new Padding(4, 3, 4, 3);
            moveLeftBtn.Name = "moveLeftBtn";
            moveLeftBtn.Size = new Size(64, 58);
            moveLeftBtn.TabIndex = 24;
            moveLeftBtn.Text = "<";
            moveLeftBtn.UseVisualStyleBackColor = false;
            moveLeftBtn.Click += moveLeftBtn_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Wheat;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(67, 834);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 47);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Wheat;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(241, 834);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 47);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // EventAttendeesList
            // 
            AutoScaleDimensions = new SizeF(15F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1065, 919);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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
            Font = new Font("Tahoma", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EventAttendeesList";
            Text = "Event Attendees";
            Load += EventAttendeesList_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button btnClearUnregistered;
        private Button btnSearchUnregistered;
        private Button btnClearRegistered;
        private Button btnSearchRegistered;
        private TextBox txtRegistered;
        private Label label4;
        private Button btnSave;
        private Button btnCancel;
        private ToolStripMenuItem attendeeToolStripMenuItem;
        private ToolStripMenuItem myEventsToolStripMenuItem;
        private ToolStripMenuItem registForEventsToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}