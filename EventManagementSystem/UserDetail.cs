using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static EventManagementSystem.AllUsers;

namespace EventManagementSystem
{
    public partial class UserDetail : Form
    {
        private MySqlConnection connection = Program.db.GetConnection();

        private ActionType actionType;
        
        // constructor for add new user
        public UserDetail(ActionType action)
        {
            InitializeComponent();
            this.actionType = action;

            // control the layout when load the page
            if(action == ActionType.Add)
            {
                this.Text = "Add User";
                // when add new user, the valid status locked to Y
                comboBoxValid.SelectedIndex = 0;
                comboBoxValid.Enabled = false;
            }

        }

        // constructor for edit user
        public UserDetail(ActionType action, DataGridViewRow row)
        {
            InitializeComponent();
            actionType = action;

            // control the layout when load the page
            if (action == ActionType.Edit)
            {
                // cannot change PK username
                this.Text = "Edit User";

                // get values from selected row and display in the fields
                String username = row.Cells["UserName"].Value.ToString();
                String password = row.Cells["Password"].Value.ToString();
                String roleName = row.Cells["RoleName"].Value.ToString();
                String dob = row.Cells["DateOfBirth"].Value.ToString();
                String email = row.Cells["Email"].Value.ToString();
                String phone = row.Cells["Phone"].Value.ToString();
                String valid = row.Cells["Valid"].Value.ToString();

                txtName.Text = username;
                txtName.ReadOnly = true;

                if (roleName == "Admin")
                {
                    adminRadioBtn.Checked = true;
                }
                if (roleName == "Manager")
                {
                    managerRadioBtn.Checked = true;
                }
                if (roleName == "Attendee")
                {
                    attendeeRadioBtn.Checked = true;
                }

                txtPassword.Text = password;
                dateTimePickerDoB.Value = DateTime.Parse(dob);
                txtEmail.Text = email;
                txtPhone.Text = phone;
                comboBoxValid.SelectedItem = valid;
            }
        }
        // menubar actions
        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents allEvents = new AllEvents();
            allEvents.Show();
            Hide();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventDetail eventDetail = new EventDetail();
            eventDetail.Show();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsers allUsers = new AllUsers();
            allUsers.Show();
            Hide();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetail userDetail = new UserDetail(ActionType.Add);
            userDetail.Show();
            Hide();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // save button action
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // validate 
            if (NameValidate() && PassWordValidate() && RoleValidate() && EmailValidate() && PhoneValidate() && ValidValidate())
            {
                // get field contents
                string userName = txtName.Text;
                string password = txtPassword.Text;

                int roleId = 0;
                if (adminRadioBtn.Checked)
                {
                    roleId = 1001;
                }
                if(managerRadioBtn.Checked)
                {
                    roleId = 1002;
                }
                if (attendeeRadioBtn.Checked)
                {
                    roleId = 1003;
                }

                string dob = dateTimePickerDoB.Value.ToString("yyyy-MM-dd");
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                char valid = char.Parse(comboBoxValid.Text);

                if (actionType == ActionType.Add)
                {
                    try
                    {
                        String qStr = $"INSERT INTO User VALUES ('{userName}','{password}',{roleId},'{dob}','{email}','{phone}','{valid}')";
                        MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                        mySqlCommand.ExecuteNonQuery();

                        MessageBox.Show(" New user added successfully!!!", "New User", MessageBoxButtons.OK);
                }
                    catch (Exception ex)
                    {
                    MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                }
            }

                if (actionType == ActionType.Edit)
                {
                    try
                    {
                        String qStr = $"UPDATE User SET Password = '{password}', RoleId = {roleId}, DateOfBirth = '{dob}', Email = '{email}', Phone = '{phone}', Valid = '{valid}' WHERE UserName = '{userName}'";
                        MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                        mySqlCommand.ExecuteNonQuery();

                        MessageBox.Show(" User updated!!!", "Edit User", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                    MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void myEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void registForEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void UserDetail_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        // method to validate name is not empty and not exceed 30
        private bool NameValidate()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtName.Text.Length > 30)
            {
                MessageBox.Show("Name length can't exceed 30!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // method to validate password is not empty and at least 4
        private bool PassWordValidate()
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPassword.Text.Length < 4)
            {
                MessageBox.Show("Password should be longer than 4!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // method to validate role is not empty
        private bool RoleValidate()
        {
            foreach (RadioButton rb in groupBoxRoles.Controls)
            {
                if (rb.Checked)
                {
                    return true;
                }
            }
            MessageBox.Show("Role can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        // method to validate email follow the rule of email
        private bool EmailValidate()
        {
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Invalid email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        // method to validate phone is number and not exceed 10
        private bool PhoneValidate()
        {
            if (!string.IsNullOrEmpty(txtPhone.Text))
            {
                int i;

                if (txtPhone.Text.Length > 10)
                {
                    MessageBox.Show("Phone can't be exceed 10 numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (!int.TryParse(txtPhone.Text, out i))
                {
                    MessageBox.Show("Input numbers for phone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        // method to validate valid is not empty
        private bool ValidValidate()
        {
            if (comboBoxValid.SelectedIndex != -1)
            {
                return true; 
            }
            else
            {
                MessageBox.Show("Valid can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
