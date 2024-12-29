using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest.UserControls.Dropdown
{
    public partial class TravelInfoDropDown : UserControl
    {
        public TravelInfoDropDown()
        {
            InitializeComponent();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new AircraftsPage(), "aircraftsPage");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new FlightSchedule(), "flightSchedule");

        }
    }
}
