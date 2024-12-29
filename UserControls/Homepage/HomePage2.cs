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
    public partial class HomePage2 : UserControl
    {
        public HomePage2()
        {
            InitializeComponent();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("homePage2");
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new HomePage3(), "homePage3");

        }
    }
}
