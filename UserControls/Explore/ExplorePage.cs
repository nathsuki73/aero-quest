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
    public partial class ExplorePage : UserControl
    {
        public ExplorePage()
        {
            InitializeComponent();
        }

        private void ExplorePage_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("explorePage");
        }

        private void exploreBtnLuzon_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new LuzonExplorePage(), "luzonExplorePage");

        }

        private void exploreBtnVisayas_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new VisayasExplorePage(), "visayasExplorePage");

        }

        private void exploreBtnMindanao_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new MindanaoExplorePage(), "mindanaoExplorePage");

        }
    }
}
