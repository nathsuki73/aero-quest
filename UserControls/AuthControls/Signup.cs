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
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (UserControlManager.isInHome)
            {
                if (!User.isLoggedIn)
                {
                    HomePage.authPage.ShowControl(new Login());
                }
                
            }
            else
            {
                LandingPage.authPage.ShowControl(new Login());
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;//TODO: Add a methods that will return validated value
            string  email = txtEmail.Text;//TODO: Add a methods that will return validated value
            string password = txtPassword.Text;//TODO: Add a methods that will return validated value
            User newUser = new User(0, username, email, password);
            bool userIsAdded = SqlQueries.AddNewUser(newUser);
            if (userIsAdded)
            {
                //TODO: Show MessageBox Success here
                if (UserControlManager.isInHome)
                {
                    if (!User.isLoggedIn)
                    {
                        HomePage.authPage.ShowControl(new Login());
                    }

                }
                else
                {
                    LandingPage.authPage.ShowControl(new Login());
                }

            }
            /*TODO: Pachck ng bug, eevrytime kasi na pinipindot ko register, nagugulo resolution sakin,
             * nagbabago windows form size
            unless gawin kong 100% yung resolution sa mismong pc instead na 125%(recommended)*/


        }
    }
}
