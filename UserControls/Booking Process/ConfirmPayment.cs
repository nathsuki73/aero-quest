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
        public ConfirmPayment(List<string> schedule)
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("confirmPayment");

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("suceessss");
        }
    }
}
