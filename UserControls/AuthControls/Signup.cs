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
using aero_quest.Notice_Forms;
using System.Net.Mail;
using System.Net;

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

        public static void ShowNotice(Form control)
        {
            control.ShowDialog();
        }

        private string ValidateFields()
        {
            StringBuilder errors = new StringBuilder();

            string username = txtUsername.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowNotice(new SignUpErrorPage());
            }

            string email = txtEmail.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                ShowNotice(new SignUpErrorPage());
            }
            else
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                if (!Regex.IsMatch(email, emailPattern))
                {
                    ShowNotice(new InvalidEmail());
                }
                else 
                { try 
                    { 
                        var mailAddress = new MailAddress(email); 
                        string host = mailAddress.Host; 
                        IPHostEntry hostEntry = Dns.GetHostEntry(host); 
                        if (hostEntry.AddressList.Length == 0) 
                        { 
                            ShowNotice(new InvalidEmail());
                        } 
                    } 
                    catch 
                    { 
                        ShowNotice(new InvalidEmail());
                    } 
                }
            }

            string password = txtPassword.Text;
            string specialChars = @"!@#$%^&*()-_+=<>?";

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowNotice(new InvalidEmail());

            }
            else if (password.Length < 8)
            {
                ShowNotice(new PasswordShort());

            }
            else if (password.Length > 64)
            {
                ShowNotice(new PasswordLong());
            }
            else if(!password.Any(char.IsUpper))
            {
                ShowNotice(new PasswordUppercase());
            }
            else if(!password.Any(char.IsLower))
            {
                ShowNotice(new PasswordLowercase());
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
