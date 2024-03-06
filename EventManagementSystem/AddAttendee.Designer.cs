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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnCancelSearchUser = new Button();
            txtUserName = new TextBox();
            btnSearchUser = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            btnAddAttendee = new Button();
            btnCancelAddAttendee = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eventsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(925, 32);
            menuStrip1.TabIndex = 3;
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
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(158, 34);
            exitToolStripMenuItem.Text = "Exit";
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
            viewEventsToolStripMenuItem.Size = new Size(270, 34);
            viewEventsToolStripMenuItem.Text = "Edit Events";
            viewEventsToolStripMenuItem.Click += viewEventsToolStripMenuItem_Click;
            // 
            // addEventToolStripMenuItem
            // 
            addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            addEventToolStripMenuItem.Size = new Size(270, 34);
            addEventToolStripMenuItem.Text = "Add Event";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 75);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelSearchUser);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(btnSearchUser);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(51, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(824, 148);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnCancelSearchUser
            // 
            btnCancelSearchUser.Location = new Point(175, 90);
            btnCancelSearchUser.Name = "btnCancelSearchUser";
            btnCancelSearchUser.Size = new Size(112, 34);
            btnCancelSearchUser.TabIndex = 15;
            btnCancelSearchUser.Text = "Clear";
            btnCancelSearchUser.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Window;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(151, 29);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(242, 30);
            txtUserName.TabIndex = 8;
            // 
            // btnSearchUser
            // 
            btnSearchUser.Location = new Point(20, 90);
            btnSearchUser.Name = "btnSearchUser";
            btnSearchUser.Size = new Size(112, 34);
            btnSearchUser.TabIndex = 14;
            btnSearchUser.Text = "Search";
            btnSearchUser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 32);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 6;
            label2.Text = "User Name";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(51, 262);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(824, 220);
            listBox1.TabIndex = 19;
            // 
            // btnAddAttendee
            // 
            btnAddAttendee.Location = new Point(71, 512);
            btnAddAttendee.Name = "btnAddAttendee";
            btnAddAttendee.Size = new Size(112, 34);
            btnAddAttendee.TabIndex = 20;
            btnAddAttendee.Text = "Add";
            btnAddAttendee.UseVisualStyleBackColor = true;
            btnAddAttendee.Click += btnAddAttendee_Click;
            // 
            // btnCancelAddAttendee
            // 
            btnCancelAddAttendee.Location = new Point(226, 512);
            btnCancelAddAttendee.Name = "btnCancelAddAttendee";
            btnCancelAddAttendee.Size = new Size(112, 34);
            btnCancelAddAttendee.TabIndex = 21;
            btnCancelAddAttendee.Text = "Cancel";
            btnCancelAddAttendee.UseVisualStyleBackColor = true;
            btnCancelAddAttendee.Click += btnCancelAddAttendee_Click;
            // 
            // AddAttendee
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 619);
            Controls.Add(btnCancelAddAttendee);
            Controls.Add(btnAddAttendee);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "AddAttendee";
            Text = "Add Attendee";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ListBox listBox1;
        private Button btnAddAttendee;
        private Button btnCancelAddAttendee;
    }
}