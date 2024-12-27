using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest.UserControls
{
    public partial class LandingPage : UserControl
    {
        public static AuthPage authPage;
        public LandingPage()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
            authPage = new AuthPage();
            authPage.Name = "authPage";
            mainForm.Controls.Add(authPage);
            authPage.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
            mainForm.Controls.Clear();
            HomePage homePage = new HomePage();
            homePage.Name = "homePage";
            mainForm.Controls.Add(homePage);

            UserControlManager.isInHome = true;
            homePage.BringToFront();
        }
    }
}
