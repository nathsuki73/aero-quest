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
    public partial class VisayasExplorePage : UserControl
    {
        private List<Image> bgImages = new List<Image>
        {
            Properties.Resources.Visayas1,
            Properties.Resources.Visayas2,
            Properties.Resources.Visayas3
        };

        private void invisibleButtons()
        {
            bookBacolod.Visible = false;
            bookCebu.Visible = false;
            bookDumaguete.Visible = false;
            bookIloIlo.Visible = false;
            bookKalibo.Visible = false;
            bookTagbilaran.Visible = false;
            bookBoracay.Visible = false;
        }

        private int count = 0;

        public VisayasExplorePage()
        {
            InitializeComponent();
        }

        private void VisayasExplorePage_Load(object sender, EventArgs e)
        {
            invisibleButtons();
            exploreBtnLeft.Visible = false;
            this.BackgroundImage = bgImages[count];
            bookKalibo.Visible = true;
            bookDumaguete.Visible = true;
            bookCebu.Visible = true;
        }

        private void exploreBtnRight_Click(object sender, EventArgs e)
        {
            count++;
            invisibleButtons();
            if (count == 1)
            {
                bookBacolod.Visible = true;
                bookBoracay.Visible = true;
                this.BackgroundImage = bgImages[count];
                exploreBtnLeft.Visible = true;
            }
            else if (count == 2)
            {
                bookIloIlo.Visible = true;
                bookTagbilaran.Visible = true;
                this.BackgroundImage = bgImages[count];
                exploreBtnRight.Visible = false;
                exploreBtnLeft.Visible = true;
            }
        }

        private void exploreBtnLeft_Click(object sender, EventArgs e)
        {
            count--;
            invisibleButtons();
            if (count == 0)
            {
                exploreBtnLeft.Visible = false;
                exploreBtnRight.Visible = true;
                bookKalibo.Visible = true;
                bookDumaguete.Visible = true;
                bookCebu.Visible = true;
                this.BackgroundImage = bgImages[count];
            }
            else if (count == 1)
            {
                bookBacolod.Visible = true;
                bookBoracay.Visible = true;
                this.BackgroundImage = bgImages[count];
            }
            else if (count == 2)
            {
                bookIloIlo.Visible = true;
                bookTagbilaran.Visible = true;
                this.BackgroundImage = bgImages[count];
                exploreBtnRight.Visible = false;
            }
        }
    }
}
