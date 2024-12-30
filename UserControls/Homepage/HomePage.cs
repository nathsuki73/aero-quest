using aero_quest.Objects;
using aero_quest.UserControls.AuthControls;
using aero_quest.UserControls.Dropdown;
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
    public partial class HomePage : UserControl
    {
        public static AuthPage authPage;

        private Timer timer;
        private List<Image> images;
        private int currentImageIndex = 0;

        public HomePage()
        {
            InitializeComponent();
            InitializeImageChanger();
            HideManageIfNotLoggedIn();
        }

        private void HideManageIfNotLoggedIn()
        {
            if (!User.isLoggedIn)
            {
                mngeBtn.Visible = false;
            }
            else
            {
                mngeBtn.Visible = true;
            }
        }

        private void InitializeImageChanger()
        {
            // Initialize the list of images
            images = new List<Image>
            {
                Properties.Resources.Image1, // Replace with your image resource names or paths
                Properties.Resources.Image2,
                Properties.Resources.Image3
            };

            // Initialize the PictureBox
            pictureBox2.Image = images[currentImageIndex];
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;

            timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Move to the next image
            currentImageIndex = (currentImageIndex + 1) % images.Count;
            pictureBox2.Image = images[currentImageIndex];
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (!User.isLoggedIn)
            {
                MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
                authPage = new AuthPage();
                authPage.Name = "authPage";
                mainForm.Controls.Add(authPage);
                authPage.BringToFront();
            }
            else
            {
                MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
                ProfilePage profilePage = new ProfilePage();
                profilePage.Name = "profilePage";
                mainForm.Controls.Add(profilePage);
                profilePage.BringToFront();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
            mainForm.Controls.Clear();
            mainForm.Controls.Add(new LandingPage());
            UserControlManager.isInHome = false;
        }



        private void mngeBtn_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName(pictureBox2, "dropdown");
            MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
            ManageDropDown manageDropDown = new ManageDropDown();
            manageDropDown.Location = new Point(770, 0);
            manageDropDown.Name = "dropdown";
            mainForm.Controls.Add(manageDropDown);
            manageDropDown.BringToFront();
            manageDropDown.Parent = pictureBox2;

        }


        private void trvlinfoBtn_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName(pictureBox2, "dropdown");
            MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
            TravelInfoDropDown manageDropDown = new TravelInfoDropDown();
            manageDropDown.Location = new Point(890, 0);
            manageDropDown.Name = "dropdown";
            mainForm.Controls.Add(manageDropDown);
            manageDropDown.BringToFront();
            manageDropDown.Parent = pictureBox2;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName(pictureBox2, "dropdown");
            MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
            ExploreDropDown manageDropDown = new ExploreDropDown();
            manageDropDown.Location = new Point(1020, 0);
            manageDropDown.Name = "dropdown";
            mainForm.Controls.Add(manageDropDown);
            manageDropDown.BringToFront();
            manageDropDown.Parent = pictureBox2;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName(pictureBox2, "dropdown");
            MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
            HelpDropDown manageDropDown = new HelpDropDown();
            manageDropDown.Location = new Point(1090, 0);
            manageDropDown.Name = "dropdown";
            mainForm.Controls.Add(manageDropDown);
            manageDropDown.BringToFront();
            manageDropDown.Parent = pictureBox2;
        }

        private void HomePage_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void HomePage_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            UserControlManager.RemoveControlByName(pictureBox2, "dropdown");
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            UserControlManager.RemoveControlByName(pictureBox2, "dropdown");
        }

        private void guna2Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            UserControlManager.RemoveControlByName(pictureBox2, "dropdown");
        }

        private void guna2ImageButton1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UserControlManager.AddControl(new ExplorePage(), "explorePage");
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new HomePage2(), "homePage2");
        }
    }
}
