namespace EventManagementSystem
{
    partial class EventDetail
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
            richTextBoxEventDesc = new RichTextBox();
            label6 = new Label();
            txtEventOragnizer = new TextBox();
            txtEventCapacity = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimePickerEvent = new DateTimePicker();
            btnCancel = new Button();
            btnSave = new Button();
            label7 = new Label();
            comboBoxManager = new ComboBox();
            label8 = new Label();
            comboBoxValid = new ComboBox();
            txtBoxtLocation = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Tahoma", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eventsToolStripMenuItem, usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 2, 0, 2);
            menuStrip1.Size = new Size(1099, 42);
            menuStrip1.TabIndex = 1;
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
            loginToolStripMenuItem.Size = new Size(359, 44);
            loginToolStripMenuItem.Text = "Log off";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(359, 44);
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
            // txtEventName
            // 
            txtEventName.BorderStyle = BorderStyle.FixedSingle;
            txtEventName.Location = new Point(207, 89);
            txtEventName.Margin = new Padding(4, 3, 4, 3);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(265, 41);
            txtEventName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 34);
            label1.TabIndex = 5;
            label1.Text = "Event Name";
            // 
            // richTextBoxEventDesc
            // 
            richTextBoxEventDesc.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxEventDesc.Location = new Point(54, 400);
            richTextBoxEventDesc.Margin = new Padding(4, 3, 4, 3);
            richTextBoxEventDesc.Name = "richTextBoxEventDesc";
            richTextBoxEventDesc.Size = new Size(986, 172);
            richTextBoxEventDesc.TabIndex = 26;
            richTextBoxEventDesc.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 360);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(152, 34);
            label6.TabIndex = 25;
            label6.Text = "Description";
            // 
            // txtEventOragnizer
            // 
            txtEventOragnizer.BorderStyle = BorderStyle.FixedSingle;
            txtEventOragnizer.Location = new Point(755, 221);
            txtEventOragnizer.Margin = new Padding(4, 3, 4, 3);
            txtEventOragnizer.Name = "txtEventOragnizer";
            txtEventOragnizer.Size = new Size(265, 41);
            txtEventOragnizer.TabIndex = 24;
            // 
            // txtEventCapacity
            // 
            txtEventCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtEventCapacity.Location = new Point(755, 154);
            txtEventCapacity.Margin = new Padding(4, 3, 4, 3);
            txtEventCapacity.Name = "txtEventCapacity";
            txtEventCapacity.Size = new Size(265, 41);
            txtEventCapacity.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(589, 229);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 34);
            label5.TabIndex = 22;
            label5.Text = "Oragnizer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(589, 160);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(119, 34);
            label4.TabIndex = 21;
            label4.Text = "Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 229);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 34);
            label3.TabIndex = 19;
            label3.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 160);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 34);
            label2.TabIndex = 18;
            label2.Text = "Date / Time";
            // 
            // dateTimePickerEvent
            // 
            dateTimePickerEvent.Location = new Point(208, 154);
            dateTimePickerEvent.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerEvent.Name = "dateTimePickerEvent";
            dateTimePickerEvent.Size = new Size(264, 41);
            dateTimePickerEvent.TabIndex = 17;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Wheat;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(230, 604);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 49);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Wheat;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(58, 604);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 49);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(589, 91);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(123, 34);
            label7.TabIndex = 27;
            label7.Text = "Manager";
            label7.Click += label7_Click;
            // 
            // comboBoxManager
            // 
            comboBoxManager.FormattingEnabled = true;
            comboBoxManager.Location = new Point(755, 89);
            comboBoxManager.Margin = new Padding(4, 3, 4, 3);
            comboBoxManager.Name = "comboBoxManager";
            comboBoxManager.Size = new Size(264, 42);
            comboBoxManager.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 298);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 34);
            label8.TabIndex = 29;
            label8.Text = "Valid";
            // 
            // comboBoxValid
            // 
            comboBoxValid.FormattingEnabled = true;
            comboBoxValid.Items.AddRange(new object[] { "Y", "N" });
            comboBoxValid.Location = new Point(209, 295);
            comboBoxValid.Margin = new Padding(4, 3, 4, 3);
            comboBoxValid.Name = "comboBoxValid";
            comboBoxValid.Size = new Size(218, 42);
            comboBoxValid.TabIndex = 30;
            // 
            // txtBoxtLocation
            // 
            txtBoxtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtBoxtLocation.Location = new Point(208, 227);
            txtBoxtLocation.Margin = new Padding(4, 3, 4, 3);
            txtBoxtLocation.Name = "txtBoxtLocation";
            txtBoxtLocation.Size = new Size(265, 41);
            txtBoxtLocation.TabIndex = 31;
            // 
            // EventDetail
            // 
            AutoScaleDimensions = new SizeF(15F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1099, 702);
            Controls.Add(txtBoxtLocation);
            Controls.Add(comboBoxValid);
            Controls.Add(label8);
            Controls.Add(comboBoxManager);
            Controls.Add(label7);
            Controls.Add(richTextBoxEventDesc);
            Controls.Add(label6);
            Controls.Add(txtEventOragnizer);
            Controls.Add(txtEventCapacity);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePickerEvent);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Tahoma", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EventDetail";
            Text = "Event Detail";
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
        private RichTextBox richTextBoxEventDesc;
        private Label label6;
        private TextBox txtEventOragnizer;
        private TextBox txtEventCapacity;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePickerEvent;
        private Button btnCancel;
        private Button btnSave;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem allUsersToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private Label label7;
        private ComboBox comboBoxManager;
        private Label label8;
        private ComboBox comboBoxValid;
        private TextBox txtBoxtLocation;
    }
}