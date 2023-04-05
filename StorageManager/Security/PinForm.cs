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

namespace StorageManager.Security
{
    public partial class PinForm : Form
    {
        public PinForm()
        {
            InitializeComponent();
            LoginUI loginUI = new LoginUI();
        }

        private void pinBox_TextChanged(object sender, EventArgs e)
        {
            pinBox.UseSystemPasswordChar = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkPin_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(pinBox.Text) == API.Info.getPin)
                {
                    
                    Console.WriteLine("[Login Form] | Вход успешен | PIN Потвърден | Изпращане към Main формата");
                    API.Info.loggedWithPin = true;
                    API.Info.logUsername = API.Info.requestUsername;
                    API.Info.getPersonName = API.Info.pregetPersonName;
                    API.Info.getPhoneNum = API.Info.pregetPhoneNum;
                    API.Info.getEmail = API.Info.pregetEmail;

                    SoftwareForms.Main mainForm = new SoftwareForms.Main();
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else
                {
                    Console.WriteLine("[Login Form] | Вход неуспешен | Грешен Пин");
                    alert.Show(this, "Въвели сте грешен пин код,опитайте отновно !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            catch(Exception throwError)
            {
                Console.WriteLine("[Login Form] | Грешка | " +  Environment.NewLine +"ИНФО:" + throwError.Message);
                alert.Show(this, "Грешка: Моля,опитайте отново !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                ErrorHandler.Handle.WriteError(throwError.Message);
            }
        }

        private void PinForm_Load(object sender, EventArgs e)
        {
        }
    }
    }
