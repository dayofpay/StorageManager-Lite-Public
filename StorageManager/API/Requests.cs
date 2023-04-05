using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace StorageManager.API
{
    class Requests
    {
        public static void CheckMainInfo(string username)
        {
            List<BaseNumberConverter> productGroups = new System.Collections.Generic.List<BaseNumberConverter>();
            MySqlCommand checkMainInfo = new MySqlCommand($"SELECT * FROM users_details WHERE user = @username", Databases.Project.projectDatabase.connection);
            checkMainInfo.Parameters.AddWithValue("@username", username);
            try
            {
                using(MySqlDataReader readInfo = checkMainInfo.ExecuteReader())
                {
                    if (readInfo.HasRows)
                    {
                        while (readInfo.Read())
                        {
                            API.Info.getWorkPlace = readInfo.GetString(1);
                            API.Info.getRole = readInfo.GetString(2);
                            API.Info.getSalary = readInfo.GetDouble(3);
                            API.Info.canEditItems = readInfo.GetBoolean(4);
                            API.Info.salaryCurrency = readInfo.GetString(5);
                        }
                        readInfo.Close();
                    }
                    readInfo.Close();
                }
            }catch(MySqlException error)
            {
                // Snackbar // MessageBox > WindowsAPI известия ??
                LoginUI loginUI = new LoginUI();

                loginUI.alert.Show(loginUI,$"Грешка при опит за въвеждане на SQL код... свържете се със екипа \r\n {error.Message}",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }
        public static void insertLog()
        {

        }
        public static void ipRequest()
        {
            try
            {
                WebRequest request2 = WebRequest.Create("https://v-devs.online/api.php?getip");
                WebResponse response2 = request2.GetResponse();
                Stream dataStream2 = response2.GetResponseStream();
                StreamReader reader2 = new StreamReader(dataStream2);
                string responseFromServer2 = reader2.ReadToEnd();
                API.Info.sessionIp = responseFromServer2;
            }catch(Exception webOffline)
            {
                WebRequest request2 = WebRequest.Create("https://ipinfo.io/ip");
                WebResponse response2 = request2.GetResponse();
                Stream dataStream2 = response2.GetResponseStream();
                StreamReader reader2 = new StreamReader(dataStream2);
                string responseFromServer2 = reader2.ReadToEnd();
                API.Info.sessionIp = responseFromServer2;
                ErrorHandler.Handle.WriteError(webOffline.Message);
            }
        }
        public static void getHostName()
        {
            try
            {
                WebRequest hostRequest = WebRequest.Create("http://ip-api.com/line/?fields=isp");
                WebResponse responseRequest = hostRequest.GetResponse();
                Stream dataSteamResponse = responseRequest.GetResponseStream();
                StreamReader readerStream = new StreamReader(dataSteamResponse);
                string responseData = readerStream.ReadToEnd();
                API.Info.getHostname = responseData;
            }
            catch(Exception error)
            {
                ErrorHandler.Handle.WriteError(error.Message);
            }
        }
    }
}
