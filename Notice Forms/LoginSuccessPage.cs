using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest.UserControls.Notice_Forms
{
    public partial class LoginSuccessPage : Form
    {
        public LoginSuccessPage()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            // Close the form after setting the DialogResult
            this.Close();
        }
    }
}
