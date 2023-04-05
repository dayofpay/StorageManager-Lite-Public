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
        public static bool isDetailed = false; // Default Value - <boolean> false
        private void FastCheck_Load(object sender, EventArgs e)
        {
            if(isDetailed == false)
            {
                //{SoftwareForms.Main.productName}
                MySqlCommand getInfo = new MySqlCommand($"SELECT * FROM items WHERE item_code = @itemCode", Databases.Project.projectDatabase.connection);
                getInfo.Parameters.AddWithValue("@itemCode", SoftwareForms.Main.productName);
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
            else if(isDetailed)
            {
                // {SoftwareForms.Main.prodName}
                // SoftwareForms.Main.storageName
                MySqlCommand getInfo = new MySqlCommand($"SELECT * FROM items WHERE item_name = @itemName AND item_location=@itemLocation", Databases.Project.projectDatabase.connection);
                getInfo.Parameters.AddWithValue("@itemName", SoftwareForms.Main.prodName);
                getInfo.Parameters.AddWithValue("@itemLocation", SoftwareForms.Main.storageName);
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
