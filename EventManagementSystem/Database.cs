using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySqlConnector;

namespace EventManagementSystem
{
    
    public class Database
    {
        private static Database instance;
        private MySqlConnection connection;

        public String ServerAddress { get; set; }
        public String PortNumber { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String DatabaseName { get; set; }

        public Database(string serverAddress, string portNumber, string userName, string password, string databaseName)
        {
            ServerAddress = serverAddress;
            PortNumber = portNumber;
            UserName = userName;
            Password = password;
            DatabaseName = databaseName;

            InitializeConnection();
        }

        private void InitializeConnection()
        {
            string connStr = $"Server={ServerAddress};Port={PortNumber};User Id={UserName};Password={Password};Database={DatabaseName}";
            connection = new MySqlConnection(connStr);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Connecting to database" + ex.Message);
            }
        }

        public static Database GetInstance(string serverAddress, string portNumber, string userName, string password, string databaseName)
        {
            if (instance == null)
            {
                instance = new Database(serverAddress, portNumber, userName, password, databaseName);
            }
            return instance;
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
