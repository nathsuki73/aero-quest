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
    public partial class HomePage4 : UserControl
    {
        public HomePage4()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("homePage4");
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new ContactPage(), "contactPage");
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new AboutUsPagecs(), "aboutUsPagecs");
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/pat.pajadan/");
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/aethr_pat/");
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://x.com/pajadan6825"); 
        }
    }
}
