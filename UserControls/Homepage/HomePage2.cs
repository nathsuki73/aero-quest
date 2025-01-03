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
    public partial class HomePage2 : UserControl
    {
        public HomePage2()
        {
            InitializeComponent();
        }

        private void clearButtons()
        {
            bookBoracay.Visible = false;
            bookCebu.Visible = false;
            bookDavao.Visible = false;
            bookManila.Visible = false;
            bookPuerto.Visible = false;
            bookSiargao.Visible = false;
        }
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("homePage2");
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new HomePage3(), "homePage3");

        }

        private void HomePage2_Load(object sender, EventArgs e)
        {
            clearButtons();
        }

        private void manila_MouseEnter(object sender, EventArgs e)
        {
            bookManila.Visible = true;
        }

        private void manila_MouseLeave(object sender, EventArgs e)
        {
            clearButtons();
        }

        private void boracay_MouseEnter(object sender, EventArgs e)
        {
            bookBoracay.Visible = true;
        }

        private void boracay_MouseLeave(object sender, EventArgs e)
        {
            clearButtons();
        }

        private void cebu_MouseEnter(object sender, EventArgs e)
        {
            bookCebu.Visible = true;
        }

        private void cebu_MouseLeave(object sender, EventArgs e)
        {
            clearButtons();
        }

        private void siargao_MouseEnter(object sender, EventArgs e)
        {
            bookSiargao.Visible = true;
        }

        private void siargao_MouseLeave(object sender, EventArgs e)
        {
            clearButtons();
        }

        private void davao_MouseEnter(object sender, EventArgs e)
        {
            bookDavao.Visible = true;
        }

        private void davao_MouseLeave(object sender, EventArgs e)
        {
            clearButtons();
        }

        private void puerto_MouseEnter(object sender, EventArgs e)
        {
            bookPuerto.Visible = true;
        }

        private void puerto_MouseLeave(object sender, EventArgs e)
        {
            clearButtons();
        }

        private void bookManila_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void bookBoracay_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void bookCebu_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void bookSiargao_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void bookDavao_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void bookPuerto_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void manila_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void boracay_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void cebu_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void siargao_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void davao_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }

        private void puerto_Click(object sender, EventArgs e)
        {
            UserControlManager.AddControl(new BrowseFlightsPage(), "browseFlightsPage");
        }
    }
}
