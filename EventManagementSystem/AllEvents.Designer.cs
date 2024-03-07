namespace EventManagementSystem
{
    partial class AllEvents
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
            groupBox1 = new GroupBox();
            btnCancelSearchEvent = new Button();
            txtEventName = new TextBox();
            btnSearchEvent = new Button();
            label1 = new Label();
            txtEventCapacity = new TextBox();
            label2 = new Label();
            label4 = new Label();
            dateTimePickerEvent = new DateTimePicker();
            comboBoxEventLocation = new ComboBox();
            label3 = new Label();
            lstEvents = new ListBox();
            btnEventAttendees = new Button();
            btnEditEvent = new Button();
            btnAddEvent = new Button();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            allUsersToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelSearchEvent);
            groupBox1.Controls.Add(txtEventName);
            groupBox1.Controls.Add(btnSearchEvent);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEventCapacity);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePickerEvent);
            groupBox1.Controls.Add(comboBoxEventLocation);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(56, 99);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(974, 256);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Events";
            // 
            // btnCancelSearchEvent
            // 
            btnCancelSearchEvent.Location = new Point(204, 175);
            btnCancelSearchEvent.Margin = new Padding(4);
            btnCancelSearchEvent.Name = "btnCancelSearchEvent";
            btnCancelSearchEvent.Size = new Size(132, 45);
            btnCancelSearchEvent.TabIndex = 15;
            btnCancelSearchEvent.Text = "Clear";
            btnCancelSearchEvent.UseVisualStyleBackColor = true;
            // 
            // txtEventName
            // 
            txtEventName.BackColor = SystemColors.Window;
            txtEventName.BorderStyle = BorderStyle.FixedSingle;
            txtEventName.Location = new Point(178, 39);
            txtEventName.Margin = new Padding(4);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(286, 39);
            txtEventName.TabIndex = 8;
            // 
            // btnSearchEvent
            // 
            btnSearchEvent.Location = new Point(24, 175);
            btnSearchEvent.Margin = new Padding(4);
            btnSearchEvent.Name = "btnSearchEvent";
            btnSearchEvent.Size = new Size(132, 45);
            btnSearchEvent.TabIndex = 14;
            btnSearchEvent.Text = "Search";
            btnSearchEvent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // txtEventCapacity
            // 
            txtEventCapacity.BackColor = SystemColors.Window;
            txtEventCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtEventCapacity.Location = new Point(649, 108);
            txtEventCapacity.Margin = new Padding(4);
            txtEventCapacity.Name = "txtEventCapacity";
            txtEventCapacity.Size = new Size(286, 39);
            txtEventCapacity.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 7;
            label2.Text = "Date / Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 111);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 12;
            label4.Text = "Capacity";
            // 
            // dateTimePickerEvent
            // 
            dateTimePickerEvent.Location = new Point(649, 40);
            dateTimePickerEvent.Margin = new Padding(4);
            dateTimePickerEvent.Name = "dateTimePickerEvent";
            dateTimePickerEvent.Size = new Size(285, 39);
            dateTimePickerEvent.TabIndex = 9;
            // 
            // comboBoxEventLocation
            // 
            comboBoxEventLocation.FormattingEnabled = true;
            comboBoxEventLocation.Items.AddRange(new object[] { "Toronto", "Etobicoke", "Scarborough", "North York", "East York", "York" });
            comboBoxEventLocation.Location = new Point(178, 107);
            comboBoxEventLocation.Margin = new Padding(4);
            comboBoxEventLocation.Name = "comboBoxEventLocation";
            comboBoxEventLocation.Size = new Size(285, 40);
            comboBoxEventLocation.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 111);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 32);
            label3.TabIndex = 10;
            label3.Text = "Location";
            // 
            // lstEvents
            // 
            lstEvents.FormattingEnabled = true;
            lstEvents.Location = new Point(56, 401);
            lstEvents.Margin = new Padding(4);
            lstEvents.Name = "lstEvents";
            lstEvents.Size = new Size(973, 292);
            lstEvents.TabIndex = 16;
            // 
            // btnEventAttendees
            // 
            btnEventAttendees.Location = new Point(441, 736);
            btnEventAttendees.Margin = new Padding(4);
            btnEventAttendees.Name = "btnEventAttendees";
            btnEventAttendees.Size = new Size(132, 45);
            btnEventAttendees.TabIndex = 19;
            btnEventAttendees.Text = "Attendees";
            btnEventAttendees.UseVisualStyleBackColor = true;
            btnEventAttendees.Click += btnEventAttendees_Click;
            // 
            // btnEditEvent
            // 
            btnEditEvent.Location = new Point(260, 736);
            btnEditEvent.Margin = new Padding(4);
            btnEditEvent.Name = "btnEditEvent";
            btnEditEvent.Size = new Size(132, 45);
            btnEditEvent.TabIndex = 18;
            btnEditEvent.Text = "Edit Event";
            btnEditEvent.UseVisualStyleBackColor = true;
            btnEditEvent.Click += btnEditEvent_Click;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(79, 736);
            btnAddEvent.Margin = new Padding(4);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(132, 45);
            btnAddEvent.TabIndex = 20;
            btnAddEvent.Text = "Add Event";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += button3_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem4, usersToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(7, 3, 0, 3);
            menuStrip2.Size = new Size(1093, 44);
            menuStrip2.TabIndex = 21;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(71, 38);
            toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(206, 44);
            toolStripMenuItem2.Text = "Login";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(206, 44);
            toolStripMenuItem3.Text = "Exit";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem6 });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(103, 38);
            toolStripMenuItem4.Text = "Events";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(359, 44);
            toolStripMenuItem5.Text = "All Events";
            toolStripMenuItem5.Click += viewEventsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(359, 44);
            toolStripMenuItem6.Text = "Add Event";
            toolStripMenuItem6.Click += addEventToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allUsersToolStripMenuItem, addUserToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(91, 38);
            usersToolStripMenuItem.Text = "Users";
            // 
            // allUsersToolStripMenuItem
            // 
            allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            allUsersToolStripMenuItem.Size = new Size(359, 44);
            allUsersToolStripMenuItem.Text = "All Users";
            allUsersToolStripMenuItem.Click += allUsersToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(359, 44);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // AllEvents
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 825);
            Controls.Add(menuStrip2);
            Controls.Add(btnAddEvent);
            Controls.Add(btnEventAttendees);
            Controls.Add(btnEditEvent);
            Controls.Add(groupBox1);
            Controls.Add(lstEvents);
            Margin = new Padding(4);
            Name = "AllEvents";
            Text = "All Events";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnCancelSearchEvent;
        private TextBox txtEventName;
        private Button btnSearchEvent;
        private Label label1;
        private TextBox txtEventCapacity;
        private Label label2;
        private Label label4;
        private DateTimePicker dateTimePickerEvent;
        private ComboBox comboBoxEventLocation;
        private Label label3;
        private ListBox lstEvents;
        private Button btnEventAttendees;
        private Button btnEditEvent;
        private Button btnAddEvent;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem allUsersToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
    }
}