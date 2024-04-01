using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlConnector;
using Mysqlx.Crud;
using System.Collections.Generic;
using MySqlConnection = MySqlConnector.MySqlConnection;
using MySqlCommand = MySqlConnector.MySqlCommand;
using MySqlDataReader = MySqlConnector.MySqlDataReader;
using MySqlException = MySqlConnector.MySqlException;


namespace EventManagementSystem
{
    public partial class AllUsers : Form
    {
        MySqlConnection connection = Program.db.GetConnection();
        public AllUsers()
        {
            InitializeComponent();
            LoadAlldata();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsers allUsers = new AllUsers();
            allUsers.Show();
            this.Close();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserDetail form = new UserDetail(ActionType.Add);
            form.Show();
        }

        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEvents form = new AllEvents();
            form.Show();
            Hide();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventDetail form = new EventDetail();
            form.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            OpenUserDetailFormAdd(ActionType.Add);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridUsers.SelectedRows[0];
                OpenUserDetailFormEdit(ActionType.Edit, row);

            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method to open add user detail
        private void OpenUserDetailFormAdd(ActionType action)
        {
            UserDetail userDetail = new UserDetail(action);
            userDetail.Show();
        }

        // method to open edit user detail
        private void OpenUserDetailFormEdit(ActionType action, DataGridViewRow row)
        {
            UserDetail userDetail = new UserDetail(action, row);
            userDetail.Show();
        }

        private void attendeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(" Are you Sure?", "Exit Application", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                if (dataGridUsers.SelectedRows.Count > 0)
                {
                    try
                    {
                        // Get the selected row
                        DataGridViewRow selectedRow = dataGridUsers.SelectedRows[0];
                        string username = (string)selectedRow.Cells["UserName"].Value;
                        string qStr = $"DELETE FROM User WHERE Username = '{username}'";
                        MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                        mySqlCommand.ExecuteNonQuery();
                        MessageBox.Show(" User Deleted successfully!!!", "Delete User", MessageBoxButtons.OK);

                        // refresh the datagridview
                        LoadAlldata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($" Error in Database Operation : {ex.Message}", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void LoadAlldata()
        {
            try
            {
                String qStr = "SELECT User.UserName, " +
                                    "User.Password, " +
                                    "Role.RoleName, " +
                                    "User.DateOfBirth, " +
                                    "User.Email, " +
                                    "User.Phone, " +
                                    "User.Valid " +
                              "FROM User, Role " +
                              "WHERE User.RoleId = Role.RoleId";
                MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridUsers.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
            }

        }

        // clear button action
        private void btnCancelSearchEvent_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            adminRadioBtn.Checked = false;
            managerRadioBtn.Checked = false;
            attendeeRadioBtn.Checked = false;
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            try
            {
                String qStr = "SELECT User.UserName, " +
                                    "User.Password, " +
                                    "Role.RoleName, " +
                                    "User.DateOfBirth, " +
                                    "User.Email, " +
                                    "User.Phone, " +
                                    "User.Valid " +
                              "FROM User, Role " +
                              "WHERE User.RoleId = Role.RoleId "; ;
                if (!string.IsNullOrEmpty(txtSearchName.Text))
                {
                    // partial and case insensitive search
                    qStr += $"AND LOWER(UserName) LIKE '%{txtSearchName.Text.ToLower()}%'";
                }
                if(adminRadioBtn.Checked == true)
                {
                    qStr += $"AND RoleId = 1001";
                }
                if (managerRadioBtn.Checked == true)
                {
                    qStr += $"AND RoleId = 1002";
                }
                if (attendeeRadioBtn.Checked == true)
                {
                    qStr += $"AND RoleId = 1003";
                }

                MySqlCommand mySqlCommand = new MySqlCommand(qStr, connection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(mySqlDataReader);
                dataGridUsers.DataSource = dataTable;
            }
            catch(MySqlException mse)
            {
                MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(" Error in System", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
