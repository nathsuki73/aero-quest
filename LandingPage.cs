using aero_quest.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace aero_quest
{
    public partial class LandingPage : Form
    {
        
        public LandingPage()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginStart1_Load(object sender, EventArgs e)
        {

        }

        public void ChangeControlVisibility(Boolean i)
        {
            fronPageNav1.Visible = i;
            loginStart1.Visible = i;
            pcbLogo.Visible = i;
            btnBack.Visible = !i;

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChangeControlVisibility(true);

        }
    }
}
