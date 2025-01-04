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

namespace aero_quest.UserControls.Mail
{
    public partial class BookingIDMail : UserControl
    {
        Mails mails;
        public BookingIDMail(Mails mail)
        {
            InitializeComponent();
            this.mails = mail;
            Populate();
        }

        private void Populate()
        {
            label1.Text = mails.DateTime.ToString("ddd, MMM dd, yyyy, h:mm tt");
            label2.Text = $"Dear {User.profile.Name.Split(' ')[0]},";
            label3.Text = $"Your booking from {mails.From} to {mails.To} has been confirmed. \n" +
                $"Flight Class: {mails.Class}  \n" +
                $"From:      {mails.From}\n" +
                $"To:        {mails.To}";
            label5.Text = $"{mails.Code}";
            label4.Text = $"₱{mails.Price} will be deducted from this account number: {mails.AccountNumber}\n" +
                "We look forward to welcoming you on board!";
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            UserControlManager.DisposeTopForm();

        }
    }
}
