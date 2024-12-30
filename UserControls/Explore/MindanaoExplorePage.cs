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
    public partial class MindanaoExplorePage : UserControl
    {
        public MindanaoExplorePage()
        {
            InitializeComponent();
        }

        private List<Image> bgImages = new List<Image>()
        {
            Properties.Resources.Mindanao1,
            Properties.Resources.mindanao2
        };

        private int count = 0;

        private void clearAll()
        {
            bookCDO.Visible = false;
            bookDavao.Visible = false;
            bookGenSan.Visible = false;
            bookSiargao.Visible = false;
            bookZamboanga.Visible = false;
            priceCDO.Visible = false;
            priceDavao.Visible = false;
            priceGenSan.Visible = false;
            priceSiargao.Visible = false;
            priceZamboanga.Visible = false;
        }
        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("explorePage");
            UserControlManager.RemoveControlByName("mindanaoExplorePage");
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("mindanaoExplorePage");
        }

        private void MindanaoExplorePage_Load(object sender, EventArgs e)
        {
            clearAll();
            this.BackgroundImage = Properties.Resources.Mindanao1;
            btnLeft.Visible = false;
            bookDavao.Visible = true;
            bookSiargao.Visible = true;
            bookCDO.Visible = true;
            priceDavao.Visible = true;
            priceSiargao.Visible = true;
            priceCDO.Visible = true;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            clearAll();
            this.BackgroundImage = Properties.Resources.mindanao2;
            bookGenSan.Visible = true;
            bookZamboanga.Visible = true;
            priceGenSan.Visible = true;
            priceZamboanga.Visible = true;
            btnRight.Visible = false;
            btnLeft.Visible = true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            clearAll();
            this.BackgroundImage = Properties.Resources.Mindanao1;
            btnLeft.Visible = false;
            bookDavao.Visible = true;
            bookSiargao.Visible = true;
            bookCDO.Visible = true;
            priceDavao.Visible = true;
            priceSiargao.Visible = true;
            priceCDO.Visible = true;
            btnLeft.Visible = false;
            btnRight.Visible = true;
        }
    }
}
