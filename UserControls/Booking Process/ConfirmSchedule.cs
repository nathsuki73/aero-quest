using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest.UserControls.Booking_Process
{
    public partial class ConfirmSchedule : UserControl
    {
        List<string> schedule;
        public ConfirmSchedule(List<string> schedule)
        {
            InitializeComponent();
            this.schedule = schedule;
            PopulateLabels();
        }

        private void PopulateLabels()
        {
            lblFrom.Text = schedule[0].ToString();
            lblTo.Text = schedule[1].ToString();
            lblDeparture.Text = schedule[2].ToString();
            lblArrival.Text = schedule[3].ToString();/*
            aircraft.Text = schedule[0].ToString();
            pasenger.Text = schedule[0].ToString();*/
            lblPrice.Text = schedule[6].ToString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("confirmSchedule");

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new ConfirmIdentity(schedule), "confirmIdentity");
        }
    }
}
