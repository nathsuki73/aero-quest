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
    public partial class SeatIDMail : UserControl
    {
        Mails mails;
        public SeatIDMail(Mails mail)
        {
            InitializeComponent();
            this.mails = mail;
            Populate();
        }

        private void Populate()
        {
            lblDate.Text = mails.DateTime.ToString("ddd, MMM dd, yyyy, h:mm tt");
            lblName.Text = $"Dear {User.profile.Name.Split(' ')[0]},";
            lblbody.Text = $"This email confirms your seat assigment and check-in for your AeroQuest flight.\n" +
                $"Details:   \n" +
                $"From:      {mails.From}\n" +
                $"To:        {mails.To}";
            seatId.Text = $"{mails.Code}";
            lblgoodbye.Text = "We look forward to welcoming you on board!";
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            UserControlManager.DisposeTopForm();

        }
    }
}
