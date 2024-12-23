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
    public partial class HomePage : UserControl
    {
        private Timer timer;
        private List<Image> images;
        private int currentImageIndex = 0;

        public HomePage()
        {
            InitializeComponent();
            InitializeImageChanger();
        }

        private void InitializeImageChanger()
        {
            // Initialize the list of images
            images = new List<Image>
            {
                Properties.Resources.Image1, // Replace with your image resource names or paths
                Properties.Resources.Image2,
                Properties.Resources.Image3
            };

            // Initialize the PictureBox
            pictureBox2.Image = images[currentImageIndex];
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;

            timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Move to the next image
            currentImageIndex = (currentImageIndex + 1) % images.Count;
            pictureBox2.Image = images[currentImageIndex];
        }
    }
}
