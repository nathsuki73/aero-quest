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
            string email = txtEmail.Text;
            string password = txtPasswordd.Text;
            User user = new User();
            user.Email = email;
            user.Password = password;
            user.Id = Sql.SqlQueries.VerifyUser(user) ?? -1;
            if (user.Id == -1)
            {
                //TODO: message box of failed log in
                     MessageBox.Show("not sucesssssssssssss");

            }
            else
            {
                User.currentLoggedInId = user.Id;
                User.profile = SqlQueries.GetProfile(User.currentLoggedInId);
                if (User.profile != null)
                {
                    Console.WriteLine("Profile Information:");
                    Console.WriteLine($"User ID: {User.profile.Id}");
                    Console.WriteLine($"Name: {User.profile.Name ?? "N/A"}");
                    Console.WriteLine($"Birthdate: {User.profile.Birth.ToString("yyyy-MM-dd") ?? "N/A"}");
                    Console.WriteLine($"Age: {User.profile.Age.ToString() ?? "N/A"}");
                    Console.WriteLine($"Gender: {User.profile.Gender ?? "N/A"}");
                    Console.WriteLine($"Email: {User.profile.Email ?? "N/A"}");
                    Console.WriteLine($"Phone: {User.profile.Phone ?? "N/A"}");

                    if (User.profile.ProfileImage != null && User.profile.ProfileImage.Length > 0)
                    {
                        Console.WriteLine("Profile Picture: [BLOB data exists]");
                    }
                    else
                    {
                        Console.WriteLine("Profile Picture: Not available");
                    }

                    
                }
                else
                {
                    Console.WriteLine("No profile data found.");
                }

                //TODO: message box successful log in
                MessageBox.Show("sucesssssssssssss");
                User.isLoggedIn = true;
                MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
                mainForm.Controls.Clear();
                HomePage homePage = new HomePage();
                homePage.Name = "homePage";
                mainForm.Controls.Add(homePage);
                homePage.BringToFront();
            }
        }
    }
}
