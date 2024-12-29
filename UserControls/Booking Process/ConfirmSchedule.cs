using aero_quest.Objects;
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
        Flight selectedFlight;
        public ConfirmSchedule(List<string> schedule, Flight selectedFlight)
        {
            InitializeComponent();
            this.schedule = schedule;
            this.selectedFlight = selectedFlight;
            PopulateLabels();


        }

        private void PopulateLabels()
        {
            lblFrom.Text = selectedFlight.from;
            lblTo.Text = selectedFlight.to;
            lblDeparture.Text = selectedFlight.departureTime;
            lblArrival.Text = selectedFlight.arrivalTime;/*
            aircraft.Text = schedule[0].ToString();
            pasenger.Text = schedule[0].ToString();*/
            lblDate.Text = selectedFlight.date.ToString("yyyy-MM-dd");
            lblPrice.Text = selectedFlight.price.ToString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("confirmSchedule");

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new ConfirmIdentity(schedule, selectedFlight), "confirmIdentity");
        }
    }
}
