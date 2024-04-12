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
            btnRegister = new Button();
            label6 = new Label();
            btnDelete = new Button();
            btnCancelRegister = new Button();
            dataGridEvents = new DataGridView();
            checkBoxMyEvents = new CheckBox();
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
            groupBox1.Location = new Point(49, 554);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(1312, 180);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Events";
            // 
            // txtBoxLocation
            // 
            txtBoxLocation.BackColor = SystemColors.Window;
            txtBoxLocation.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLocation.Location = new Point(185, 103);
            txtBoxLocation.Margin = new Padding(4, 3, 4, 3);
            txtBoxLocation.Name = "txtBoxLocation";
            txtBoxLocation.Size = new Size(264, 33);
            txtBoxLocation.TabIndex = 16;
            // 
            // btnCancelSearchEvent
            // 
            btnCancelSearchEvent.BackColor = Color.Wheat;
            btnCancelSearchEvent.FlatStyle = FlatStyle.Flat;
            btnCancelSearchEvent.Location = new Point(1118, 101);
            btnCancelSearchEvent.Margin = new Padding(4, 3, 4, 3);
            btnCancelSearchEvent.Name = "btnCancelSearchEvent";
            btnCancelSearchEvent.Size = new Size(143, 49);
            btnCancelSearchEvent.TabIndex = 15;
            btnCancelSearchEvent.Text = "Clear";
            btnCancelSearchEvent.UseVisualStyleBackColor = false;
            btnCancelSearchEvent.Click += btnCancelSearchEvent_Click;
            // 
            // txtEventName
            // 
            txtEventName.BackColor = SystemColors.Window;
            txtEventName.BorderStyle = BorderStyle.FixedSingle;
            txtEventName.Location = new Point(185, 49);
            txtEventName.Margin = new Padding(4, 3, 4, 3);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(264, 33);
            txtEventName.TabIndex = 8;
            // 
            // btnSearchEvent
            // 
            btnSearchEvent.BackColor = Color.Wheat;
            btnSearchEvent.FlatStyle = FlatStyle.Flat;
            btnSearchEvent.Location = new Point(1118, 39);
            btnSearchEvent.Margin = new Padding(4, 3, 4, 3);
            btnSearchEvent.Name = "btnSearchEvent";
            btnSearchEvent.Size = new Size(143, 49);
            btnSearchEvent.TabIndex = 14;
            btnSearchEvent.Text = "Search";
            btnSearchEvent.UseVisualStyleBackColor = false;
            btnSearchEvent.Click += btnSearchEvent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // txtEventCapacity
            // 
            txtEventCapacity.BackColor = SystemColors.Window;
            txtEventCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtEventCapacity.Location = new Point(756, 99);
            txtEventCapacity.Margin = new Padding(4, 3, 4, 3);
            txtEventCapacity.Name = "txtEventCapacity";
            txtEventCapacity.Size = new Size(264, 33);
            txtEventCapacity.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 7;
            label2.Text = "Date / Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(596, 101);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 12;
            label4.Text = "Capacity";
            // 
            // dateTimePickerEvent
            // 
            dateTimePickerEvent.Location = new Point(756, 45);
            dateTimePickerEvent.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerEvent.Name = "dateTimePickerEvent";
            dateTimePickerEvent.ShowCheckBox = true;
            dateTimePickerEvent.Size = new Size(263, 33);
            dateTimePickerEvent.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 106);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 10;
            label3.Text = "Location";
            // 
            // btnEventAttendees
            // 
            btnEventAttendees.BackColor = Color.Wheat;
            btnEventAttendees.FlatStyle = FlatStyle.Flat;
            btnEventAttendees.Location = new Point(1218, 303);
            btnEventAttendees.Margin = new Padding(4, 3, 4, 3);
            btnEventAttendees.Name = "btnEventAttendees";
            btnEventAttendees.Size = new Size(174, 49);
            btnEventAttendees.TabIndex = 19;
            btnEventAttendees.Text = "Attendees";
            btnEventAttendees.UseVisualStyleBackColor = false;
            btnEventAttendees.Click += btnEventAttendees_Click;
            // 
            // btnEditEvent
            // 
            btnEditEvent.BackColor = Color.Wheat;
            btnEditEvent.FlatStyle = FlatStyle.Flat;
            btnEditEvent.Location = new Point(1218, 183);
            btnEditEvent.Margin = new Padding(4, 3, 4, 3);
            btnEditEvent.Name = "btnEditEvent";
            btnEditEvent.Size = new Size(174, 49);
            btnEditEvent.TabIndex = 18;
            btnEditEvent.Text = "Edit Event";
            btnEditEvent.UseVisualStyleBackColor = false;
            btnEditEvent.Click += btnEditEvent_Click;
            // 
            // btnAddEvent
            // 
            btnAddEvent.BackColor = Color.Wheat;
            btnAddEvent.FlatStyle = FlatStyle.Flat;
            btnAddEvent.Location = new Point(1218, 123);
            btnAddEvent.Margin = new Padding(4, 3, 4, 3);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(174, 49);
            btnAddEvent.TabIndex = 20;
            btnAddEvent.Text = "Add Event";
            btnAddEvent.UseVisualStyleBackColor = false;
            btnAddEvent.Click += button3_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.Transparent;
            menuStrip2.Font = new Font("Tahoma", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip2.GripStyle = ToolStripGripStyle.Visible;
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem4, usersToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(6, 2, 0, 2);
            menuStrip2.Size = new Size(1428, 33);
            menuStrip2.TabIndex = 21;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(60, 29);
            toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(179, 34);
            toolStripMenuItem2.Text = "Log off";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(179, 34);
            toolStripMenuItem3.Text = "Exit";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5, toolStripMenuItem6 });
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(89, 29);
            toolStripMenuItem4.Text = "Events";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(210, 34);
            toolStripMenuItem5.Text = "All Events";
            toolStripMenuItem5.Click += viewEventsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(210, 34);
            toolStripMenuItem6.Text = "Add Event";
            toolStripMenuItem6.Click += addEventToolStripMenuItem_Click;
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
            // btnRegister
            // 
            btnRegister.BackColor = Color.Wheat;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Location = new Point(1218, 363);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(174, 49);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.Location = new Point(49, 75);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 31);
            label6.TabIndex = 25;
            label6.Text = "Events";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Wheat;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(1218, 243);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(174, 49);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancelRegister
            // 
            btnCancelRegister.BackColor = Color.Wheat;
            btnCancelRegister.FlatStyle = FlatStyle.Flat;
            btnCancelRegister.Location = new Point(1218, 423);
            btnCancelRegister.Margin = new Padding(4, 3, 4, 3);
            btnCancelRegister.Name = "btnCancelRegister";
            btnCancelRegister.Size = new Size(174, 49);
            btnCancelRegister.TabIndex = 27;
            btnCancelRegister.Text = "Cancel";
            btnCancelRegister.UseVisualStyleBackColor = false;
            btnCancelRegister.Click += btnCancelRegister_Click;
            // 
            // dataGridEvents
            // 
            dataGridEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEvents.Location = new Point(49, 120);
            dataGridEvents.Margin = new Padding(4, 3, 4, 3);
            dataGridEvents.Name = "dataGridEvents";
            dataGridEvents.ReadOnly = true;
            dataGridEvents.RowHeadersWidth = 82;
            dataGridEvents.Size = new Size(1116, 408);
            dataGridEvents.TabIndex = 28;
            dataGridEvents.CellContentClick += dataGridEvents_CellContentClick;
            // 
            // checkBoxMyEvents
            // 
            checkBoxMyEvents.AutoSize = true;
            checkBoxMyEvents.Location = new Point(1218, 490);
            checkBoxMyEvents.Name = "checkBoxMyEvents";
            checkBoxMyEvents.Size = new Size(131, 29);
            checkBoxMyEvents.TabIndex = 29;
            checkBoxMyEvents.Text = "My events";
            checkBoxMyEvents.UseVisualStyleBackColor = true;
            checkBoxMyEvents.CheckedChanged += checkBoxMyEvents_CheckedChanged;
            // 
            // AllEvents
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1428, 774);
            Controls.Add(checkBoxMyEvents);
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
            Font = new Font("Tahoma", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AllEvents";
            Text = "All Events";
            Load += AllEvents_Load;
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
        private Label label6;
        private Button btnDelete;
        private Button btnCancelRegister;
        private DataGridView dataGridEvents;
        private TextBox txtBoxLocation;
        private CheckBox checkBoxMyEvents;
    }
}