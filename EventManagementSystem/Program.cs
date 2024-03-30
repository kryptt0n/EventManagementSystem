using MySqlConnector;
namespace EventManagementSystem
{
    internal static class Program
    {
        public static Database db = Database.GetInstance("server", "port", "un", "pw", "db");

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginPage());

        }
    }
}