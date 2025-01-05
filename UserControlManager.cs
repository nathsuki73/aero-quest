﻿using aero_quest.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace aero_quest
{
    public class UserControlManager
    {
        // To compile instances of UserControls
        public static List<Control> _userControls = new List<Control>();

        // To compile instances of Form
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
            //TODO: MagstardewValley na kayooo nakasale pa hanggang Jan :)  <3
        }

        public static void RemoveControlByName(string controlName)
        {
            MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
            Control controlToRemove = mainForm.Controls[controlName];
            if (controlToRemove != null)
            {
                mainForm.Controls.Remove(controlToRemove);
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

        public static void PushForm(Form form)
        {
            _userForms.Push(form);
            ShowTopForm();
            
        }

        private static void ShowTopForm()
        {
            _userForms.Peek().ShowDialog();
        }
        
        public static void DisposeTopForm()
        {
            _userForms.Pop().Dispose();
        }




    }
}
