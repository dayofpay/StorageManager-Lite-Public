using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace StorageManager.Databases.Demo
{
    class demoDatabase
    {
        public static MySqlConnection connection { get; set; }
        public static string server { get; set; }
        public static string database { get; set; }
        public static string user { get; set; }
        public static string password { get; set; }
        public static string port { get; set; }
        public static string connectionString { get; set; }
        public static string sslM { get; set; }
        public static string conString { get; set; }
        public static bool connected { get; set; }
        public static void Connect()
        {
            server = "localhost";
            database = "vdevsonl_storagemanager_demo";
            user = "root";
            password = "";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4};", server, port, user, password, database, sslM);
            conString = connectionString;
            try
            {
                connection = new MySqlConnection(conString);
                connection.Open();
                connected = true;
            }
            catch(Exception error)
            {
                Console.WriteLine("[Database Connection] | Неуспешна връзка към базата данни | Database Error" + Environment.NewLine + "Info: " + error.Message);
                MessageBox.Show($"Изглежда, че имаше грешка при опита за връзка към сървъра на V-DEVS. \r\n Моля, свържете се с екипа ни за да ви съдействаме. {error.Message}","V-DEVS | StorageManager");
                connected = false;
                ErrorHandler.Handle.WriteError("Грешка с връзката към сървъра");
            }
        }
    }
}