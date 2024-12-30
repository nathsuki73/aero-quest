using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aero_quest.UserControls.Manage;
namespace aero_quest.UserControls.Dropdown
{
    public partial class ManageDropDown : UserControl
    {
        public ManageDropDown()
        {
            InitializeComponent();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new ManageBookings(), "manageBookings");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new OnlineCheckIn(), "onlineCheckIn");

        }
    }
}
