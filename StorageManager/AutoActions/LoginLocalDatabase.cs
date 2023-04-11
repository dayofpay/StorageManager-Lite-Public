using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.AutoActions
{
    public partial class LoginLocalDatabase : Form
    {
        public LoginLocalDatabase()
        {
            InitializeComponent();
        }

        private void LoginLocalDatabase_Load(object sender, EventArgs e)
        {
            try
            {
                Databases.Project.projectDatabase.Connect();
                if (Databases.Project.projectDatabase.connected)
                {
                    LoginUI loginUI = new LoginUI();
                    this.Hide();
                    loginUI.ShowDialog();
                }
                else
                {
                    exitButton.Visible = true;
                }
            }
            catch (MySqlException mySqlException)
            {
                Console.WriteLine("[Database Connection] | Неуспешна връзка към базата данни | Database Error" + Environment.NewLine + "Info: " + mySqlException.Message);
                alert.Show(this, "Няма връзка с базата данни, опитайте отново !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }
    }
}
