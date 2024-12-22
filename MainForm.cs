using aero_quest.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace aero_quest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UserControlManager._userControls.Add(new LandingPage());
            this.Controls.Add(UserControlManager._userControls[0] as LandingPage);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void ClearAllControls()
        {
            this.Controls.Clear();
        }

     
      

      

    

        
    }
}
