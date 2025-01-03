using aero_quest.Objects;
using aero_quest.UserControls.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
            ShowInbox();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            UserControlManager.DisposeTopForm();
        }

        private void txtGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox.SelectedIndex == 0)
            {
                ShowInbox();
            }
            else
            {
                ShowInbox(true);
            }
        }

        public void ShowInbox(bool isTrash)
        {
            panel1.Controls.Clear();
            HashSet<Mails> mails = User._userMails;

            int y = 0;
            foreach (Mails mail in mails) {

                if (!mail.IsDeleted)
                {
                    continue;
                }
                if (mail.IsPermanentlyDeleted)
                {
                    continue;
                }
                MailRecord record = new MailRecord(mail, true);
                record.Location = new Point(0, y);
                y += 30;
                panel1.Controls.Add(record);
            }

        }

        public void ShowInbox()
        {
            panel1.Controls.Clear();
            HashSet<Mails> mails = User._userMails;
            int y = 0;
            foreach (Mails mail in mails)
            {
                if (mail.IsDeleted)
                {
                    continue;
                }
                if (mail.IsPermanentlyDeleted)
                {
                    continue;
                }
                MailRecord record = new MailRecord(mail);
                record.Location = new Point(0, y);
                y += 30;
                panel1.Controls.Add(record);
            }

        }
    }
}
