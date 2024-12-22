using aero_quest.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest
{
    public class UserControlManager
    {
        public static List<UserControl> _userControls = new List<UserControl>();
        public static List<Form> _userForms = new List<Form>();

        public UserControlManager() { 
            _userForms.Add(new MainForm());
        }

        public static void RemoveControlByName(Control parent, string controlName)
        {
            Control controlToRemove = parent.Controls[controlName];
            if (controlToRemove != null)
            {
                parent.Controls.Remove(controlToRemove);
                controlToRemove.Dispose();
            }
            else
            {
                MessageBox.Show($"Control with name '{controlName}' not found.");
            }
        }

    }
}
