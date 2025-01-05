using aero_quest.Objects;
using aero_quest.Sql;
using aero_quest.UserControls.Notice_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest.UserControls.AuthControls
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (UserControlManager.isInHome)
            {
                if (!User.isLoggedIn)
                {
                    HomePage.authPage.ShowControl(new Signup());

                }
            }
            else
            {
                LandingPage.authPage.ShowControl(new Signup());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Getting email and password inputted
            string email = txtEmail.Text;
            string password = txtPasswordd.Text;

            //Creating a new user instance and putting the email and password
            User user = new User();
            user.Email = email;
            user.Password = password;

            user.Id = Sql.SqlQueries.VerifyUser(user) ?? -1;

            if (user.Id == -1)
            {
                // Invalid Id Message
                ShowNotice(new LoginFailedPage());
            }
            else
            {
                SqlQueries.UploadMails();

                User.currentLoggedInId = user.Id;
                User._userMails = SqlQueries.GetMails(user.Id);

                User.profile = SqlQueries.GetProfile(User.currentLoggedInId);

                // Show Successful login Message
                ShowNotice(new LoginSuccessPage());
                User.isLoggedIn = true;
                MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
                mainForm.Controls.Clear();
                HomePage homePage = new HomePage();
                homePage.Name = "homePage";
                mainForm.Controls.Add(homePage);
                homePage.BringToFront();
            }
        }

        public static void ShowNotice(Form control)
        {
            control.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
