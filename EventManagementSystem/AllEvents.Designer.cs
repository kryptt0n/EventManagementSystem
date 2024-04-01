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
            txtBoxLocation = new TextBox();
            btnCancelSearchEvent = new Button();
            txtEventName = new TextBox();
            btnSearchEvent = new Button();
            label1 = new Label();
            txtEventCapacity = new TextBox();
            label2 = new Label();
            label4 = new Label();
            dateTimePickerEvent = new DateTimePicker();
            label3 = new Label();
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
            attendeeToolStripMenuItem = new ToolStripMenuItem();
            myEventsToolStripMenuItem = new ToolStripMenuItem();
            registForEventsToolStripMenuItem = new ToolStripMenuItem();
            btnRegister = new Button();
            label6 = new Label();
            btnDelete = new Button();
            btnCancelRegister = new Button();
            dataGridEvents = new DataGridView();
            groupBox1.SuspendLayout();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEvents).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBoxLocation);
            groupBox1.Controls.Add(btnCancelSearchEvent);
            groupBox1.Controls.Add(txtEventName);
            groupBox1.Controls.Add(btnSearchEvent);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEventCapacity);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePickerEvent);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(41, 424);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1093, 158);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Events";
            // 
            // txtBoxLocation
            // 
            txtBoxLocation.BackColor = SystemColors.Window;
            txtBoxLocation.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLocation.Location = new Point(154, 91);
            txtBoxLocation.Name = "txtBoxLocation";
            txtBoxLocation.Size = new Size(220, 36);
            txtBoxLocation.TabIndex = 16;
            // 
            // btnCancelSearchEvent
            // 
            btnCancelSearchEvent.Location = new Point(969, 93);
            btnCancelSearchEvent.Name = "btnCancelSearchEvent";
            btnCancelSearchEvent.Size = new Size(102, 35);
            btnCancelSearchEvent.TabIndex = 15;
            btnCancelSearchEvent.Text = "Clear";
            btnCancelSearchEvent.UseVisualStyleBackColor = true;
            btnCancelSearchEvent.Click += btnCancelSearchEvent_Click;
            // 
            // txtEventName
            // 
            txtEventName.BackColor = SystemColors.Window;
            txtEventName.BorderStyle = BorderStyle.FixedSingle;
            txtEventName.Location = new Point(154, 43);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(220, 36);
            txtEventName.TabIndex = 8;
            // 
            // btnSearchEvent
            // 
            btnSearchEvent.Location = new Point(969, 39);
            btnSearchEvent.Name = "btnSearchEvent";
            btnSearchEvent.Size = new Size(102, 33);
            btnSearchEvent.TabIndex = 14;
            btnSearchEvent.Text = "Search";
            btnSearchEvent.UseVisualStyleBackColor = true;
            btnSearchEvent.Click += btnSearchEvent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 46);
            label1.Name = "label1";
            label1.Size = new Size(75, 29);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // txtEventCapacity
            // 
            txtEventCapacity.BackColor = SystemColors.Window;
            txtEventCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtEventCapacity.Location = new Point(630, 87);
            txtEventCapacity.Name = "txtEventCapacity";
            txtEventCapacity.Size = new Size(220, 36);
            txtEventCapacity.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(497, 45);
            label2.Name = "label2";
            label2.Size = new Size(140, 29);
            label2.TabIndex = 7;
            label2.Text = "Date / Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(497, 89);
            label4.Name = "label4";
            label4.Size = new Size(102, 29);
            label4.TabIndex = 12;
            label4.Text = "Capacity";
            // 
            // dateTimePickerEvent
            // 
            dateTimePickerEvent.Location = new Point(630, 40);
            dateTimePickerEvent.Name = "dateTimePickerEvent";
            dateTimePickerEvent.Size = new Size(220, 36);
            dateTimePickerEvent.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 93);
            label3.Name = "label3";
            label3.Size = new Size(101, 29);
            label3.TabIndex = 10;
            label3.Text = "Location";
            // 
            // btnEventAttendees
            // 
            btnEventAttendees.Location = new Point(1015, 251);
            btnEventAttendees.Name = "btnEventAttendees";
            btnEventAttendees.Size = new Size(102, 34);
            btnEventAttendees.TabIndex = 19;
            btnEventAttendees.Text = "Attendees";
            btnEventAttendees.UseVisualStyleBackColor = true;
            btnEventAttendees.Click += btnEventAttendees_Click;
            // 
            // btnEditEvent
            // 
            btnEditEvent.Location = new Point(1015, 154);
            btnEditEvent.Name = "btnEditEvent";
            btnEditEvent.Size = new Size(102, 34);
            btnEditEvent.TabIndex = 18;
            btnEditEvent.Text = "Edit Event";
            btnEditEvent.UseVisualStyleBackColor = true;
            btnEditEvent.Click += btnEditEvent_Click;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(1015, 106);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(102, 34);
            btnAddEvent.TabIndex = 20;
            btnAddEvent.Text = "Add Event";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += button3_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem4, usersToolStripMenuItem, attendeeToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(5, 2, 0, 2);
            menuStrip2.Size = new Size(1178, 37);
            menuStrip2.TabIndex = 21;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(69, 33);
            toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(201, 44);
            toolStripMenuItem2.Text = "Login";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(201, 44);
            toolStripMenuItem3.Text = "Exit";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem6 });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(103, 33);
            toolStripMenuItem4.Text = "Events";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(252, 44);
            toolStripMenuItem5.Text = "All Events";
            toolStripMenuItem5.Click += viewEventsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(252, 44);
            toolStripMenuItem6.Text = "Add Event";
            toolStripMenuItem6.Click += addEventToolStripMenuItem_Click;
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
            // btnRegister
            // 
            btnRegister.Location = new Point(1015, 300);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(102, 34);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.Location = new Point(41, 66);
            label6.Name = "label6";
            label6.Size = new Size(94, 31);
            label6.TabIndex = 25;
            label6.Text = "Events";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1015, 203);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 34);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancelRegister
            // 
            btnCancelRegister.Location = new Point(1015, 349);
            btnCancelRegister.Name = "btnCancelRegister";
            btnCancelRegister.Size = new Size(102, 34);
            btnCancelRegister.TabIndex = 27;
            btnCancelRegister.Text = "Cancel";
            btnCancelRegister.UseVisualStyleBackColor = true;
            btnCancelRegister.Click += btnCancelRegister_Click;
            // 
            // dataGridEvents
            // 
            dataGridEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEvents.Location = new Point(41, 106);
            dataGridEvents.Name = "dataGridEvents";
            dataGridEvents.ReadOnly = true;
            dataGridEvents.RowHeadersWidth = 82;
            dataGridEvents.Size = new Size(930, 312);
            dataGridEvents.TabIndex = 28;
            // 
            // AllEvents
            // 
            AutoScaleDimensions = new SizeF(13F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 613);
            Controls.Add(dataGridEvents);
            Controls.Add(btnCancelRegister);
            Controls.Add(btnDelete);
            Controls.Add(label6);
            Controls.Add(btnRegister);
            Controls.Add(menuStrip2);
            Controls.Add(btnAddEvent);
            Controls.Add(btnEventAttendees);
            Controls.Add(btnEditEvent);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AllEvents";
            Text = "All Events";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEvents).EndInit();
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
        private Label label3;
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
        private Button btnRegister;
        private ToolStripMenuItem attendeeToolStripMenuItem;
        private ToolStripMenuItem myEventsToolStripMenuItem;
        private ToolStripMenuItem registForEventsToolStripMenuItem;
        private Label label6;
        private Button btnDelete;
        private Button btnCancelRegister;
        private DataGridView dataGridEvents;
        private TextBox txtBoxLocation;
    }
}