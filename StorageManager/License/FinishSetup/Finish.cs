﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace StorageManager.License.FinishSetup
{
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
        }

        private void Finish_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finishSetup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(myProjectBox.Text) && !string.IsNullOrWhiteSpace(myNameBox.Text) && !string.IsNullOrWhiteSpace(personPhoneNumBox.Text) && !string.IsNullOrWhiteSpace(personEmailBox.Text) && personEmailBox.Text.Contains("@"))
            {
                API.Requests.ipRequest();
                Random randomRecovery = new Random();
                API.Info.recoveryCode = randomRecovery.Next(10000, 99999);
                MySqlCommand insertRequest = new MySqlCommand($"INSERT INTO customers_info(projectName,projectBanned,projectBanReason,projectPersonIp,personContactName,personPcName,personPhoneNumber,personMail,recoveryCode)VALUES('{myProjectBox.Text}',false,'null','{API.Info.sessionIp}','{myNameBox.Text}','{Environment.UserName}','{personPhoneNumBox.Text}','{personEmailBox.Text}','{API.Info.recoveryCode}');", Databases.Demo.demoDatabase.connection);
                MySqlCommand updateLicense = new MySqlCommand($"UPDATE licenses set license_valid = false WHERE license_code = @licenseCode", Databases.Demo.demoDatabase.connection);
                updateLicense.Parameters.AddWithValue("@licenseCode", API.Info.sessionLicense);
                try
                {
                    insertRequest.ExecuteScalar();
                    updateLicense.ExecuteScalar();
                    MessageBox.Show($"Вие успешно приключихте конфигурирането на StorageManager, очаквайте да получите програмата до 24 часа на E-Mail {personEmailBox.Text} ! \r\n ВАЖНО: {API.Info.recoveryCode} е вашият таен ключ, който може да използвате, в случай, че се случи нещо със софтуера.","V-DEVS | Успешна регистрация на софтуер");
                    this.Close();
                }
                catch (MySqlException sqlError)
                {
                    MessageBox.Show($"Изглежда, че има грешка със заявката ! Моля, уведомете екипа ни за тази грешка !! \r\n Код на грешката: vd#304", "V-DEVS | SQL Грешка");
                }
            }
            else
            {
                MessageBox.Show("Моля, попълнете липсващите полета !", "V-DEVS | Грешка");
            }
        }
    }
}
