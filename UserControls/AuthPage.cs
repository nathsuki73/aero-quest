using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aero_quest.UserControls.AuthControls;

namespace aero_quest.UserControls
{
    public partial class AuthPage : UserControl
    {
        private Stack<UserControl> userControls = new Stack<UserControl>();
        public AuthPage()
        {
            InitializeComponent();
            ShowControl(new Login());
        }

        private void LoadTopControl()
        {
            UserControl topControl = userControls.Peek();
            topControl.Location = new Point(125, 88);
            this.Controls.Add(topControl);
        }

        public void ShowControl(UserControl newControl)
        {
            if (userControls.Count > 0)
            {
                userControls.Pop();
            } else
            {
                userControls.Push(newControl);
            }
            LoadTopControl();

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = UserControlManager._userForms[0] as MainForm;

            UserControlManager.RemoveControlByName(mainForm, "authPage");

        }
    }
}
