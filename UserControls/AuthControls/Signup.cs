using aero_quest.Objects;
using aero_quest.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            string validationErrors = ValidateFields();

            if (!string.IsNullOrEmpty(validationErrors))
            {
                MessageBox.Show(validationErrors, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = txtUsername.Text;
            string  email = txtEmail.Text;
            string password = txtPassword.Text;

            User newUser = new User(0, username, email, password);
            bool userIsAdded = SqlQueries.AddNewUser(newUser);

            if (userIsAdded)
            {
                MessageBox.Show("Registration successful! Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateFields()
        {
            StringBuilder errors = new StringBuilder();

            string username = txtUsername.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                errors.AppendLine("• Username cannot be empty.");
            }

            string email = txtEmail.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                errors.AppendLine("• Email cannot be empty.");
            }
            else
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                if (!Regex.IsMatch(email, emailPattern))
                {
                    errors.AppendLine("• Please enter a valid email address.");
                }
            }

            string password = txtPassword.Text;
            string specialChars = @"!@#$%^&*()-_+=<>?";

            if (string.IsNullOrWhiteSpace(password))
            {
                errors.AppendLine("• Password cannot be empty.");
            }
            else if (password.Length < 8)
            {
                errors.AppendLine("• Password must be at least 8 characters long.");
            }
            else if (password.Length > 64)
            {
                errors.AppendLine("• Password must not exceed 64 characters.");
            }
            else if(!password.Any(char.IsUpper))
            {
                errors.AppendLine("• Password must contain at least one uppercase letter.");
            }
            else if(!password.Any(char.IsLower))
            {
                errors.AppendLine("• Password must contain at least one lowercase letter.");
            }/*
            else if(!password.Any(char.IsDigit))
            {
                errors.AppendLine("• Password must contain at least one number.");
            }
            else if (!password.Any(c => specialChars.Contains(c)))
            {
                errors.AppendLine("• Password must contain at least one special character (e.g., @, #, $, etc.).");
            }*/

            return errors.ToString();
        }
    }
}
