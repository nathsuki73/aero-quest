using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using aero_quest.UserControls;
using Guna.UI2.WinForms;

namespace aero_quest.UserControls
{
    public partial class LoginStart : UserControl
    {
        private PictureBox loginPictureBox = new PictureBox();

        public LoginStart()
        {
            InitializeComponent();

           
            

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = (LandingPage)FormManager._formControls[0];
            landingPage.ChangeControlVisibility(false);
            loginPictureBox.Location = new Point(125, 88);
            loginPictureBox.Size = new Size(1107, 606);
            loginPictureBox.Image = Properties.Resources.loginBackground;
            landingPage.Controls.Add(loginPictureBox);
        }

        public void ChangeControlVisibility(Boolean i)
        {
            loginPictureBox.Visible = i;
        }

    }
}
