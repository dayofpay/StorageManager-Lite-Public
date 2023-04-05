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
    public partial class Main : Form
    {
        public static string storageName = "";
        public static string prodName = "";
        public static string productName = "";
        public Main()
        {
            InitializeComponent();
            LoginUI loginUI = new LoginUI();
            loginUI.Hide();
        }

        private void panel_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            MySqlCommand checkTotalStorages = new MySqlCommand("SELECT * FROM storage_info", Databases.Project.projectDatabase.connection);
            using (MySqlDataReader readTotalStorages = checkTotalStorages.ExecuteReader())
            {
                if (readTotalStorages.HasRows)
                {
                    while (readTotalStorages.Read())
                    {
                        API.Info.storages.Add(readTotalStorages.GetString(1));
                        API.Info.totalStorages++;
                    }
                }
                readTotalStorages.Close();
            }
            MySqlCommand checkStorages = new MySqlCommand("SELECT * FROM storage_info", Databases.Project.projectDatabase.connection);
            using (MySqlDataReader readStorages = checkStorages.ExecuteReader())
            {
                if (readStorages.HasRows)
                {
                    while (readStorages.Read())
                    {
                        locationSklad.Items.Add(readStorages.GetString(1));
                    }
                    readStorages.Close();
                }
                else
                {
                    readStorages.Close();
                    locationSklad.Items.Add("Няма добавени складове, моля добавете !");
                }
            }
            API.Requests.CheckMainInfo(API.Info.logUsername);
            if(API.Info.loggedWithPin == true)
            {
                nameLabel.Text = API.Info.pregetPersonName;
                roleLabel.Text = API.Info.getRole;
                workplaceLabel.Text = API.Info.getWorkPlace;
            }
            else
            {
                nameLabel.Text = API.Info.getPersonName;
                roleLabel.Text = API.Info.getRole;
                workplaceLabel.Text = API.Info.getWorkPlace;
            }
            personalName.Text = API.Info.getPersonName;
            personalRole.Text = API.Info.getRole;
            personalSalary.Text = API.Info.getSalary.ToString() + " " + API.Info.salaryCurrency;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void productCheck_Click(object sender, EventArgs e)
        {
            pages.PageIndex = 1;
        }

        private void locationSklad_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand checkProducts = new MySqlCommand($"SELECT * FROM items WHERE item_location = '{locationSklad.Text}'", Databases.Project.projectDatabase.connection);
            using (MySqlDataReader readProducts = checkProducts.ExecuteReader())
            {
                //if (products.Items.Contains("Няма добавени продукти в този склад !"))
                //{
                // products.Items.Remove("Няма добавени продукти в този склад !");
                //}
                        try
                        {
                            foreach (string item in products.Items)
                            {
                                if (item != "Няма добавени продукти в този склад !")
                                {
                                    products.Items.Remove(item);
                                }
                            }
                        }catch(Exception error)
                        {
                    ErrorHandler.Handle.WriteError(error.Message);
                }
                if (readProducts.HasRows)
                {
                    if (products.Items.Contains("Няма добавени продукти в този склад !"))
                    {
                        products.Items.Remove("Няма добавени продукти в този склад !");
                    }
                        while (readProducts.Read())
                    {
                        if (products.Items.Contains($"{readProducts.GetString(4)} - {readProducts.GetString(1)}")){
                            break;
                        }
                        else
                        {
                            products.Items.Add(readProducts.GetString(4) + " - " + readProducts.GetString(1));
                        }
                    }
                    readProducts.Close();
                }
                else
                {
                    readProducts.Close();
                    if(products.Items.Contains("Няма добавени продукти в този склад !")){
                        foreach(string item in products.Items)
                        {
                            if(item != "Няма добавени продукти в този склад !")
                            {
                                products.Items.Remove(item);
                            }
                        }
                    }
                    else
                    {
                        products.Items.Add("Няма добавени продукти в този склад !");
                    }
                }
            }
        }

        private void fastCheck_Click(object sender, EventArgs e)
        {
            MySqlCommand checkValidProduct = new MySqlCommand($"SELECT item_code FROM items WHERE item_code = @itemCode", Databases.Project.projectDatabase.connection);
            checkValidProduct.Parameters.AddWithValue("@itemCode", productCode.Text);
            using (MySqlDataReader readData = checkValidProduct.ExecuteReader())
            {
                if (readData.HasRows)
                {
                    readData.Close();
                    productName = productCode.Text;
                    SoftwareForms.FastCheck fastCheck = new FastCheck(false);
                    fastCheck.ShowDialog();
                }
                else
                {
                    alert.Show(this, "Не е намерен продукт с такъв код", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
                readData.Close();
            }
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            int index = products.Text.LastIndexOf("- SKU-");
            if (index > 0)
            {
                prodName = products.Text.Substring(0, index);
            }
            storageName = locationSklad.Text;
            FastCheck nCheck = new FastCheck(true);
            nCheck.ShowDialog();
        }

        private void logGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void themeMode_CheckedChanged(object sender, EventArgs e)
        {
            if(themeMode.Checked == true)
            {
                mainPage.BackColor = Color.FromArgb(0,0,0);
                
                currentTheme.Text = "Текуща тема: Тъмна";
                frame1.BorderColor = System.Drawing.Color.Blue;
                frame2.BorderColor = System.Drawing.Color.Blue;
                frame3.BorderColor = System.Drawing.Color.Blue;
                myActivityLabel.ForeColor = Color.Khaki;
                myActivityLabel.BackColor = Color.FromArgb(0, 0, 0);
                personalRole.ForeColor = Color.Blue;
                personalName.ForeColor = Color.Blue;
                personalSalary.ForeColor = Color.Blue;
            }
            else
            {
                mainPage.BackColor = Color.FromArgb(73, 128, 245);
                frame1.BorderColor = Color.FromArgb(17,30,49);
                frame2.BorderColor = Color.FromArgb(17, 30, 49);
                frame3.BorderColor = Color.FromArgb(17, 30, 49);
                myActivityLabel.BackColor= Color.FromArgb(73,128,245);
                myActivityLabel.ForeColor = Color.Khaki;
                personalRole.ForeColor = Color.Blue;
                personalName.ForeColor = Color.Blue;
                personalSalary.ForeColor = Color.Blue;
                currentTheme.Text = "Текуща тема: Светла";
            }
        }

        private void currentTheme_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void staffEdit_Click(object sender, EventArgs e)
        {
            if(API.Info.adminRights == true)
            {
                // Deistvie
            }
            else
            {
                // Deistvie
            }
        }
    }
}
