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
    public partial class BrowseFlightsPage : UserControl
    {
        public BrowseFlightsPage(String to)
        {
            InitializeComponent();
            txtTo.Text = to;
        }
        public BrowseFlightsPage()
        {
            InitializeComponent();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("browseFlightsPage");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            
            UserControlManager.AddControl(new FlightSchedule(txtFrom.Text, txtTo.Text, dtpDepart.Value, dtpArrive.Value), "flightSchedule");
        }
    }
}
