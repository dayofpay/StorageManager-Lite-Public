using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace StorageManager.API
{
    class checkLicense
    {
        public static void checkExisting(string licenseId)
        {
            MySqlCommand checkL = new MySqlCommand($"SELECT * FROM licenses WHERE license_code =@licenseId AND license_valid = true",Databases.Demo.demoDatabase.connection);
            checkL.Parameters.AddWithValue("licenseId", licenseId);
            using (MySqlDataReader readLicense = checkL.ExecuteReader())
            {
                while (readLicense.Read())
                {
                    if (readLicense.HasRows)
                    {
                        Info.validLicense = true;
                    }
                    else
                    {
                        Info.validLicense = false;
                    }
                }
                readLicense.Close();
            }
        }
    }
}
