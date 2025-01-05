using aero_quest.Notice_Forms;
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
using System.Text.RegularExpressions;

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
            txtTotalPrice.Text = selectedFlight.price.ToString();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("confirmPayment");

        }
        public static void ShowNotice(Form control)
        {
            control.ShowDialog();
        }

        // Booking Process
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            string seatId = selectedFlight.aircraft.GetAndUpdateAvailableSeat();
            string bookingReference = BookingReferenceGenerator.GenerateBookingReference();
            string accountNumberFormat = @"^\d{4}-\d{4}-\d{4}-\d{4}$";

            if (txtPaymentMethod.Text != null && txtFlightClass.Text != null && txtAccountNumber.Text != null)
            {
                if (Regex.IsMatch(txtAccountNumber.Text, accountNumberFormat))
                {
                    if (seatId != null)
                    {
                        SqlQueries.AddBookingSchedule(schedule, bookingReference, seatId);
                        SendMail(bookingReference);
                        ShowNotice(new BookedSuccessfullyPage());
                        UserControlManager.RemoveControlByName("confirmSchedule");
                        UserControlManager.RemoveControlByName("confirmPayment");
                        UserControlManager.RemoveControlByName("confirmIdentity");
                    }
                    else
                    {
                        MessageBox.Show("This flight is already fully booked.");
                    }
                }
                else
                {
                    ShowNotice(new InvalidAccountNumber());
                }
                
            }
            else
            {
                ShowNotice(new SignUpErrorPage());
            }
            

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFlightClass.SelectedIndex == 0)
            {
                txtTotalPrice.Text = Convert.ToDouble(selectedFlight.price).ToString("0.00");
            }
            else if (txtFlightClass.SelectedIndex == 1)
            {
                txtTotalPrice.Text = (Convert.ToDouble(selectedFlight.price) * 1.5).ToString("0.00");
            }
            else if (txtFlightClass.SelectedIndex == 2)
            {
                txtTotalPrice.Text = (Convert.ToDouble(selectedFlight.price) * 2).ToString("0.00");
            }
        }


        // Creating a new Mail
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
            mails.AccountNumber = txtAccountNumber.Text;
            mails.Price = txtTotalPrice.Text;
            mails.Class = txtFlightClass.Text;
            User._userMails.Add(mails); 
        }
    }
}
