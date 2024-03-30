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

        private AllUsers.ActionType actionType;
        public UserDetail(ActionType action)
        {
            InitializeComponent();
            this.actionType = action;

            if(action == AllUsers.ActionType.Add)
            {
                this.Text = "Add User";

            }
            if(action == AllUsers.ActionType.Edit)
            {
                this.Text = "Edit User";
                txtName.ReadOnly = true;
            }
        }

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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (NameValidate() && PassWordValidate() && RoleValidate() && EmailValidate() && PhoneValidate() && ValidValidate())
            {
                string userName = txtName.Text;
                string password = txtPassword.Text;
                int roleId = 1003;
                string dob = dateTimePickerDoB.Value.ToString("yyyy-MM-dd");
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                char valid = char.Parse(comboBoxValid.Text);

                if (actionType == ActionType.Add)
                {
                    /*try
                    {*/
                        String qStr = $"INSERT INTO User VALUES ('{userName}','{password}',{roleId},'{dob}','{email}','{phone}','{valid}')";
                        MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                        mySqlCommand.ExecuteNonQuery();

                        MessageBox.Show(" New user added successfully!!!", "New User", MessageBoxButtons.OK);
                    /*}
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                    }*/
                }

                if (actionType == ActionType.Edit)
                {
                    try
                    {
                        String qStr = $"UPDATE TABLE User SET Password = '{password}', RoleId = {roleId}, Email = '{email}', Phone = '{phone}', Valid = '{valid}' WHERE UserName = '{userName}'";
                        MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                        mySqlCommand.ExecuteNonQuery();

                        MessageBox.Show(" User updated!!!", "Edit User", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
                    }
                }


                //MessageBox.Show("Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.None);
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
