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
    public partial class LuzonExplorePage : UserControl
    {
        public LuzonExplorePage()
        {
            InitializeComponent();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("explorePage");
            UserControlManager.RemoveControlByName("luzonExplorePage");
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("luzonExplorePage");
        }
    }
}
