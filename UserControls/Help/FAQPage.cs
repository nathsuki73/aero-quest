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
    public partial class FAQPage : UserControl
    {
        public FAQPage()
        {
            InitializeComponent();
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            BtnLeft.Visible = true;
            BtnRight.Visible = false;

            FAQ.Image = Properties.Resources.FAQSecond;
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            BtnLeft.Visible = false;
            BtnRight.Visible = true;

            FAQ.Image = Properties.Resources.FAQFirst;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("faqPage");
        }
    }
}
