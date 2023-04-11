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
    public partial class LoginAction : Form
    {
        public LoginAction()
        {
            InitializeComponent();
        }

        private void LoginAction_Load(object sender, EventArgs e)
        {
            try
            {
                Databases.Demo.demoDatabase.Connect();
                if (Databases.Demo.demoDatabase.connected)
                {
                    LoginLocalDatabase localLogin = new LoginLocalDatabase();
                    this.Hide();
                    localLogin.ShowDialog();
                }
                else
                {
                    exitButton.Visible = true;
                }
            }
            catch(MySqlException mySqlException)
            {
                Console.WriteLine("[Database Connection] | Неуспешна връзка към базата данни | Database Error" + Environment.NewLine + "Info: " + mySqlException.Message);
                alert.Show(this, "Няма връзка с базата данни, опитайте отново !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
