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
                SendMail(bookingReference);
                MessageBox.Show("Booked sucessfully.");
                UserControlManager.RemoveControlByName("confirmSchedule");
                UserControlManager.RemoveControlByName("confirmPayment");
                UserControlManager.RemoveControlByName("confirmIdentity");
            }
            else
            {
                MessageBox.Show("This flight is already fully booked.");
            }

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 0)
            {
                lblPrice.Text = Convert.ToDouble(selectedFlight.price).ToString("0.00");
            }
            else if (guna2ComboBox1.SelectedIndex == 1)
            {
                lblPrice.Text = (Convert.ToDouble(selectedFlight.price) * 1.5).ToString("0.00");
            }
            else if (guna2ComboBox1.SelectedIndex == 2)
            {
                lblPrice.Text = (Convert.ToDouble(selectedFlight.price) * 2).ToString("0.00");
            }
        }

        private void SendMail(string reference)
        {
            Guid id = Guid.NewGuid();
            Mails mails = new Mails();
            mails.Id = id;
            mails.Type = "Booking Confirmation";
            mails.From = selectedFlight.from;
            mails.To = selectedFlight.to;
            mails.Code = reference;
            mails.DateTime = DateTime.Now;
            mails.IsRead = false;
            mails.IsDeleted = false;
            mails.IsPermanentlyDeleted = false;
            User._userMails.Add(mails); 
        }
    }
}
