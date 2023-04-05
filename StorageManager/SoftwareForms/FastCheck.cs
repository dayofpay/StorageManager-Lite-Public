using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace StorageManager.SoftwareForms
{
    public partial class FastCheck : Form
    {
        public FastCheck(bool checkDetailed)
        {
            InitializeComponent();
            isDetailed = checkDetailed;
        }
        public static bool isDetailed = false;
        private void FastCheck_Load(object sender, EventArgs e)
        {
            if(isDetailed == false)
            {
                MySqlCommand getInfo = new MySqlCommand($"SELECT * FROM items WHERE item_code = '{SoftwareForms.Main.productName}'", Databases.Project.projectDatabase.connection);
                using (MySqlDataReader readInfo = getInfo.ExecuteReader())
                {
                    if (readInfo.HasRows)
                    {
                        while (readInfo.Read())
                        {
                            infoGrid.Rows.Add(readInfo.GetString(3), readInfo.GetString(1), readInfo.GetString(2), readInfo.GetString(5), readInfo.GetString(6), readInfo.GetString(4));
                        }
                    }
                }
            }
            if(isDetailed==true)
            {
                MySqlCommand getInfo = new MySqlCommand($"SELECT * FROM items WHERE item_name = '{SoftwareForms.Main.prodName}' AND item_location='{SoftwareForms.Main.storageName}'", Databases.Project.projectDatabase.connection);
                using (MySqlDataReader readInfo = getInfo.ExecuteReader())
                {
                    if (readInfo.HasRows)
                    {
                        while (readInfo.Read())
                        {
                            infoGrid.Rows.Add(readInfo.GetString(3), readInfo.GetString(1), readInfo.GetString(2), readInfo.GetString(5), readInfo.GetString(6), readInfo.GetString(4));
                        }
                    }
                }
            }
        }

        private void storageEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
