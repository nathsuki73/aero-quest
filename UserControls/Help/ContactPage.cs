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
    public partial class ContactPage : UserControl
    {
        public ContactPage()
        {
            InitializeComponent();
            fixDesign();
        }

        private void ContactPage_Load(object sender, EventArgs e)
        {
            
        }

        private void fixDesign()
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("contactPage");
        }
    }
}
