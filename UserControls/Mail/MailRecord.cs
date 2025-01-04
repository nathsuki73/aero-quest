using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aero_quest.Objects;

namespace aero_quest.UserControls.Mail
{
    public partial class MailRecord : UserControl
    {
        Mails mail;
        public MailRecord(Mails mail)
        {
            InitializeComponent();
            PopulateMail(mail);
            guna2ImageButton2.Visible = false;
            this.mail = mail;
        }

        public MailRecord(Mails mail, bool isTrash)
        {
            InitializeComponent();
            PopulateMail(mail);
            guna2ImageButton2.Visible = isTrash;
            this.mail = mail;
        }

        private void PopulateMail(Mails mail)
        {
            if (mail.IsRead)
            {
                pictureBox1.Image = Properties.Resources.readMail;
                ChangeDisplay(mail);

                txtName.ForeColor = System.Drawing.Color.Gray;
                txtDescription.ForeColor = System.Drawing.Color.Gray;
                txtDate.ForeColor = System.Drawing.Color.Gray;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.unreadMail;
                ChangeDisplay(mail);
                txtName.Font = new Font(txtName.Font, FontStyle.Bold);
                txtDescription.Font = new Font(txtDescription.Font, FontStyle.Bold);
                txtDate.Font = new Font(txtDate.Font, FontStyle.Bold);
            }
            txtDate.Text = mail.DateTime.ToString("yyyy/MM/dd");
        }

        private void ChangeDisplay(Mails mail)
        {
            if (mail.Type == "Booking Confirmation")
            {
                txtName.Text = "Booking Confirmation";
                string message = $"Hi {User.profile.Name.Split(' ')[0]}, Your booking from {mail.From} to {mail.To} has been confirmed. Thank you for using our service.";

                // Truncate the message to 44 characters (leaving space for '...')
                if (message.Length > 60)
                {
                    message = message.Substring(0, 59) + "...";
                }
                txtDescription.Text = message;
            }
            else
            {
                txtName.Text = "Flight Checked In";
                string message = $"Dear {User.profile.Name.Split(' ')[0]}, This email confirms your seat assigment and check-in for your AeroQuest flight.";
                if (message.Length > 60)
                {
                    message = message.Substring(0, 59) + "...";
                }
                txtDescription.Text = message;
            }
        }

        private void MailRecord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IsRead();
            Form form = new OpenedMailForm();
            Control control = null;
            if (mail.Type == "Booking Confirmation")
            {
                control = new BookingIDMail(mail);
            }
            else
            {
                control = new SeatIDMail(mail);
            }
            control.Dock = DockStyle.Fill;
            form.Controls.Add(control);
            control.BringToFront();
            UserControlManager.PushForm(form);

        }

     

        private void MailRecord_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;

        }

    

        private void txtDescription_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
        }

       

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;

        }

        private void txtDescription_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(213, 220, 236);
        }

        private void MailRecord_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(213, 220, 236);

        }

        private void txtName_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(213, 220, 236);

        }

        private void txtDescription_Click(object sender, EventArgs e)
        {
           

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            mail.IsDeleted = false;
            MailForm form = UserControlManager._userForms.Peek() as MailForm;
            form.ShowInbox(true);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (mail.IsDeleted)
            {
                MailForm form = UserControlManager._userForms.Peek() as MailForm;
                mail.IsPermanentlyDeleted = true;
                form.ShowInbox(true);
            } else
            {
                mail.IsDeleted = true;
                MailForm form = UserControlManager._userForms.Peek() as MailForm;
                form.ShowInbox();

            }

        }

        private void IsRead()
        {
            mail.IsRead = true;
            txtName.ForeColor = System.Drawing.Color.Gray;
            txtDescription.ForeColor = System.Drawing.Color.Gray;
            txtDate.ForeColor = System.Drawing.Color.Gray;
            pictureBox1.Image = Properties.Resources.readMail;
        }

        private void txtDescription_MouseClick(object sender, MouseEventArgs e)
        {
            IsRead();
        }

        private void txtDate_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IsRead() ;
        }

        private void txtName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IsRead();
        }
    }
}
