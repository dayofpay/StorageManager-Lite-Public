using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager.License.BuyForm
{
    public partial class BuyLicense : Form
    {
        public BuyLicense()
        {
            InitializeComponent();
        }

        private void alreadyHave_Click(object sender, EventArgs e)
        {
            License.ValidateLicense.Validate validate = new ValidateLicense.Validate();
            validate.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuyLicense_Load(object sender, EventArgs e)
        {

        }
    }
}
