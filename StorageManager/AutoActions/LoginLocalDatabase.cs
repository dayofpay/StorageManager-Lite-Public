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
            Databases.Project.projectDatabase.Connect();
            if (Databases.Project.projectDatabase.connected == true)
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
    }
}
