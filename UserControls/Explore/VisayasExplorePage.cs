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
            Properties.Resources.visayas2FINAL,
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

        private void invisiblePrices()
        {
            bacolodPrice.Visible = false;
            cebuPrice.Visible = false;
            dumaguetePrice.Visible = false;
            iloiloPrice.Visible = false;
            kaliboPrice.Visible = false;
            tagbilaranPrice.Visible = false;
            boracayPrice.Visible = false;
        }

        private int count = 0;

        public VisayasExplorePage()
        {
            InitializeComponent();
        }

        private void VisayasExplorePage_Load(object sender, EventArgs e)
        {
            invisibleButtons();
            invisiblePrices();
            exploreBtnLeft.Visible = false;
            this.BackgroundImage = bgImages[count];
            bookKalibo.Visible = true;
            bookDumaguete.Visible = true;
            bookCebu.Visible = true;
            kaliboPrice.Visible = true;
            dumaguetePrice.Visible = true;
            cebuPrice.Visible = true;
        }

        private void exploreBtnRight_Click(object sender, EventArgs e)
        {
            count++;
            invisibleButtons();
            invisiblePrices();
            if (count == 1)
            {
                bookBacolod.Visible = true;
                bookBoracay.Visible = true;
                this.BackgroundImage = bgImages[count];
                exploreBtnLeft.Visible = true;
                bacolodPrice.Visible = true;
                boracayPrice.Visible = true;
            }
            else if (count == 2)
            {
                bookIloIlo.Visible = true;
                bookTagbilaran.Visible = true;
                this.BackgroundImage = bgImages[count];
                exploreBtnRight.Visible = false;
                exploreBtnLeft.Visible = true;
                iloiloPrice.Visible = true;
                tagbilaranPrice.Visible = true;
            }
        }

        private void exploreBtnLeft_Click(object sender, EventArgs e)
        {
            count--;
            invisibleButtons();
            invisiblePrices();
            if (count == 0)
            {
                exploreBtnLeft.Visible = false;
                exploreBtnRight.Visible = true;
                bookKalibo.Visible = true;
                bookDumaguete.Visible = true;
                bookCebu.Visible = true;
                this.BackgroundImage = bgImages[count];
                kaliboPrice.Visible = true;
                dumaguetePrice.Visible = true;
                cebuPrice.Visible = true;
            }
            else if (count == 1)
            {
                bookBacolod.Visible = true;
                bookBoracay.Visible = true;
                this.BackgroundImage = bgImages[count];
                exploreBtnRight.Visible = true;
                bacolodPrice.Visible = true;
                boracayPrice.Visible = true;
            }
            else if (count == 2)
            {
                bookIloIlo.Visible = true;
                bookTagbilaran.Visible = true;
                this.BackgroundImage = bgImages[count];
                exploreBtnRight.Visible = false;
                iloiloPrice.Visible = true;
                tagbilaranPrice.Visible = true;
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("explorePage");
            UserControlManager.RemoveControlByName("visayasExplorePage");
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("visayasExplorePage");
        }

        private void bookKalibo_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void bookIloIlo_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void bookDumaguete_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void bookTagbilaran_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void bookCebu_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void bookBoracay_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void bookBacolod_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }
    }
}
