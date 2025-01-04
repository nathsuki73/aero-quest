using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest.UserControls
{
    public partial class HomePage2 : UserControl
    {
        public HomePage2()
        {
            InitializeComponent();
        }
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("homePage2");
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new HomePage3(), "homePage3");

        }

        private void manila_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage("Manila"), "browseFlightsPage");
        }

        private void boracay_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage("Boracay"), "browseFlightsPage");
        }

        private void cebu_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage("Cebu"), "browseFlightsPage");
        }

        private void siargao_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage("Siargao"), "browseFlightsPage");
        }

        private void davao_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage("Davao"), "browseFlightsPage");
        }

        private void puerto_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage("Puerto Prinsesa"), "browseFlightsPage");
        }
    }
}
