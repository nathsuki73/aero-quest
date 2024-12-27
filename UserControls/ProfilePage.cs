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
    public partial class ProfilePage : UserControl
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //TODO: code to update txtAge based on birthdate
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
            UserControlManager.RemoveControlByName(mainForm, "profilePage");
        }
    }
}
