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
    public partial class AircraftsPage : UserControl
    {
        private List<Image> bgImages = new List<Image>
        {
                Properties.Resources.A330,
                Properties.Resources.A320,
                Properties.Resources.A321_bg,
                Properties.Resources._777
        };

        private int clickCount = 0;

        public AircraftsPage()
        {
            InitializeComponent();
        }

        private void AircraftsPage_Load(object sender, EventArgs e)
        {
            ACBtnLeft.Visible = false;
            this.BackgroundImage = Properties.Resources.A330;
        }

        private void ACBtnRight_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount == 3)
            {
                ACBtnRight.Visible = false;
                ACBtnLeft.Visible = true;
            }
            else if (clickCount > 0 && clickCount < 3)
            {
                ACBtnLeft.Visible = true;
                ACBtnRight.Visible = true;
            }
            
            this.BackgroundImage = bgImages[clickCount];
        }

        private void ACBtnLeft_Click(object sender, EventArgs e)
        {
            clickCount--;
            if (clickCount == 0)
            {
                ACBtnLeft.Visible = false;
                ACBtnRight.Visible = true;
            }
            else if (clickCount > 0 && clickCount < 3)
            {
                ACBtnLeft.Visible = true;
                ACBtnRight.Visible = true;
            }

            this.BackgroundImage = bgImages[clickCount];
        }

        private void ACHomeBtn_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("aircraftsPage");
        }
    }
}
