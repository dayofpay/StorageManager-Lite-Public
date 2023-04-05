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
            Databases.Demo.demoDatabase.Connect();
            if(Databases.Demo.demoDatabase.connected == true)
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
