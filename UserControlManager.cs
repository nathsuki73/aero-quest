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
        public static List<Control> _userControls = new List<Control>();
        public static Stack<Form> _userForms = new Stack<Form>();

        public static bool isInHome = false;
        public UserControlManager() { 
            _userForms.Push(new MainForm());
        }

        public static void RemoveControlByName(Control parent, string controlName)
        {
            Control controlToRemove = parent.Controls[controlName];
            if (controlToRemove != null)
            {
                parent.Controls.Remove(controlToRemove);
                controlToRemove.Dispose();
            }
        }

        public static void AddControl(Control control, String Name)
        {
            MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
            control.Name = Name;
            mainForm.Controls.Add(control);
            _userControls.Add(control);
            control.BringToFront();
        }

    }
}
