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
    public partial class BaggageSuppPage : UserControl
    {
        public BaggageSuppPage()
        {
            InitializeComponent();
        }

        private void BaggageSuppPage_Load(object sender, EventArgs e)
        {
            leftBtnSupp.Visible = false;
        }

        private void rightBtnSupp_Click(object sender, EventArgs e)
        {
            leftBtnSupp.Visible = true;
            rightBtnSupp.Visible = false;
            BackgroundImage = Properties.Resources.AllowanceBg;
        }

        private void leftBtnSupp_Click(object sender, EventArgs e)
        {
            leftBtnSupp.Visible = false;
            rightBtnSupp.Visible = true;
            BackgroundImage = Properties.Resources.lostAndFoundBg;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("baggageSuppPage");
        }
    }
}
