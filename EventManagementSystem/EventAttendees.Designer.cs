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
            txtEventName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnDeleteAttendee = new Button();
            btnAddAttendee = new Button();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eventsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(925, 32);
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
            loginToolStripMenuItem.Size = new Size(270, 34);
            loginToolStripMenuItem.Text = "Login";
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
            // txtEventName
            // 
            txtEventName.BorderStyle = BorderStyle.FixedSingle;
            txtEventName.Location = new Point(185, 71);
            txtEventName.Name = "txtEventName";
            txtEventName.ReadOnly = true;
            txtEventName.Size = new Size(150, 30);
            txtEventName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 73);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 7;
            label1.Text = "Event Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 137);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 9;
            label2.Text = "Attendees";
            // 
            // btnDeleteAttendee
            // 
            btnDeleteAttendee.Location = new Point(230, 387);
            btnDeleteAttendee.Name = "btnDeleteAttendee";
            btnDeleteAttendee.Size = new Size(112, 34);
            btnDeleteAttendee.TabIndex = 13;
            btnDeleteAttendee.Text = "Delete";
            btnDeleteAttendee.UseVisualStyleBackColor = true;
            // 
            // btnAddAttendee
            // 
            btnAddAttendee.Location = new Point(66, 387);
            btnAddAttendee.Name = "btnAddAttendee";
            btnAddAttendee.Size = new Size(112, 34);
            btnAddAttendee.TabIndex = 12;
            btnAddAttendee.Text = "Add";
            btnAddAttendee.UseVisualStyleBackColor = true;
            btnAddAttendee.Click += btnAddAttendee_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(47, 164);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(826, 196);
            listBox1.TabIndex = 11;
            // 
            // EventAttendees
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 485);
            Controls.Add(btnDeleteAttendee);
            Controls.Add(btnAddAttendee);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "EventAttendees";
            Text = "Event Attendees";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private ListBox listBox1;
    }
}