using aero_quest.Objects;
using aero_quest.Sql;
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
    public partial class ConfirmPayment : UserControl
    {
        Flight selectedFlight;
        List<string> schedule;
        public ConfirmPayment(List<string> schedule, Flight selectedFlight)
        {
            InitializeComponent();
            this.selectedFlight = selectedFlight;
            this.schedule = schedule;
            lblPrice.Text = selectedFlight.price.ToString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("confirmPayment");

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            string seatId = selectedFlight.aircraft.GetAndUpdateAvailableSeat();
            string bookingReference = BookingReferenceGenerator.GenerateBookingReference();
            if (seatId != null)
            {
                SqlQueries.AddBookingSchedule(schedule, bookingReference, seatId);
                MessageBox.Show("{suceessss}");
            }
            
        }
    }
}
