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
    public partial class ConfirmIdentity : UserControl
    {
        List<string> schedule;
        Flight selectedFlight;
        public ConfirmIdentity(List<string> schedule, Flight selectedFlight)
        {
            InitializeComponent();
            this.schedule = schedule;
            PopulateProfile();
            this.selectedFlight = selectedFlight;
        }

        // Showing Profile Info for Confirmation
        private void PopulateProfile()
        {
            txtName.Text = User.profile.Name;
            birthDate.Value = User.profile.Birth;
            txtAge.Text = User.profile.Age.ToString();
            
            txtGender.Text = User.profile.Gender;
            txtEmail.Text = User.profile.Email;
            txtPhone.Text = User.profile.Phone;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("confirmIdentity");

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new ConfirmPayment(schedule, selectedFlight), "confirmPayment");

        }
    }
}
