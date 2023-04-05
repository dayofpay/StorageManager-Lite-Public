using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.License.ValidateLicense
{
    public partial class Validate : Form
    {
        public Validate()
        {
            InitializeComponent();
        }

        private void con_Click(object sender, EventArgs e)
        {

            if (API.checkLicense.checkExisting(lic1.Text + lic2.Text + lic3.Text + lic4.Text))
            {
                API.Info.sessionLicense = lic1.Text + lic2.Text + lic3.Text + lic4.Text;
                License.FinishSetup.Finish finishSetup = new FinishSetup.Finish();
                finishSetup.ShowDialog();
            }
            else
            {
                MessageBox.Show("Лицензовият ключ, който предоставихте, изглежда е грешен или изтекъл ! Моля, свържете се с екипа ни !", "V-DEVS Bulgaria | Грешка");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Validate_Load(object sender, EventArgs e)
        {

        }
    }
}
