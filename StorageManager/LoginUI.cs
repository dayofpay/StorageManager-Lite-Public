using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StorageManager
{
    public partial class LoginUI : Form
    {
        public static string setUsername
        {
            get; set;
        }
        public static string setPassword { get; set; }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public LoginUI()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            passwordBox.UseSystemPasswordChar = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.debugMode == true)
            {
                AllocConsole();
            }
            else
            {

            }
            MessageBox.Show($"Здравейте, {Environment.UserName}, радваме се да ви видим :) \r\n Напомяме ви, че това е демо версията на софтуера, и ако искате да си я закупите, може да го направите от бутона 'Закупи Лиценз' или от уебсайта ни, благодарим :)", "StorageManager | Съобщение");
        }
        public static void checkAccount()
        {
            LoginUI loginUI = new LoginUI();
            MySqlCommand checkAccount = new MySqlCommand("SELECT * FROM users WHERE username = @user AND password = @password", Databases.Project.projectDatabase.connection);
            checkAccount.Parameters.AddWithValue("@user", setUsername);
            checkAccount.Parameters.AddWithValue("@password", setPassword);
            using (MySqlDataReader readAccount = checkAccount.ExecuteReader())
            {
                if (readAccount.HasRows)
                {
                    while (readAccount.Read())
                    {
                        if (readAccount.GetBoolean(5) == true)
                        {

                            Console.WriteLine("[Login Form] | Login Success | Sending to PIN Form");
                            API.Info.requestUsername = setUsername;
                            API.Info.getPin = readAccount.GetInt32(6);
                            API.Info.pregetPersonName = readAccount.GetString(2);
                            API.Info.pregetPhoneNum = readAccount.GetString(3);
                            API.Info.pregetEmail = readAccount.GetString(4);
                            API.Info.adminRights = readAccount.GetBoolean(7);
                            Security.PinForm pinForm = new Security.PinForm();
                            readAccount.Close();
                            loginUI.Hide();
                            pinForm.ShowDialog();
                            Console.WriteLine(readAccount.IsClosed);


                        }
                        else
                        {
                            Console.WriteLine("[Login Form] | Login Success | Sending to Main FORM");
                            API.Info.getPersonName = readAccount.GetString(2);
                            API.Info.getPhoneNum = readAccount.GetString(3);
                            API.Info.getEmail = readAccount.GetString(4);
                            API.Info.adminRights = readAccount.GetBoolean(7);
                            API.Info.logUsername = setUsername;
                            SoftwareForms.Main mainForm = new SoftwareForms.Main();
                            readAccount.Close();
                            loginUI.Hide();
                            mainForm.ShowDialog();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("[Login-Form] | Грешна парола !");
                    readAccount.Close();
                    loginUI.alert.Show(loginUI, "Въвели сте неправилен username или парола !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            License.BuyForm.BuyLicense buyLicense = new License.BuyForm.BuyLicense();
            buyLicense.ShowDialog();


        }

        public void loginButton_Click(object sender, EventArgs e)
        {
            setUsername = usernameBox.Text;
            setPassword = passwordBox.Text;
            try
            {
                checkAccount();
            }
            catch (Exception error)
            {
                ErrorHandler.Handle.WriteError("[LOGIN Form | Критична грешка | " + error.Message);
                Console.WriteLine("Грешка във Form Login : " + error.Message);
                alert.Show(this, "Изглежда, че софтуера се натъкна на грешка, опитайте отново !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}