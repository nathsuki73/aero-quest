using aero_quest.Notice_Forms;
using aero_quest.Objects;
using aero_quest.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest.UserControls
{
    public partial class ProfilePage : UserControl
    {
        public ProfilePage()
        {
            InitializeComponent();
            PopulateProfile();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //TODO: code to update txtAge based on birthdate
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = UserControlManager._userForms.Peek() as MainForm;
            UserControlManager.RemoveControlByName(mainForm, "profilePage");
        }

        private void PopulateProfile()
        {

            txtName.Text = User.profile.Name;
            birthDate.Value = User.profile.Birth;
            txtAge.Text = User.profile.Age.ToString();
            txtGender.Text = User.profile.Gender;
            txtEmail.Text = User.profile.Email;
            txtPhone.Text = User.profile.Phone;
            profileImage.Image = ConvertBytesToImage(User.profile.ProfileImage);
        }
        public static void ShowNotice(Form control)
        {
            control.ShowDialog();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            User.profile.Name = txtName.Text;
            User.profile.Birth = birthDate.Value;
            User.profile.Age = Convert.ToInt32(txtAge.Text);
            User.profile.Gender = txtGender.Text;
            User.profile.Email = txtEmail.Text;
            User.profile.Phone = txtPhone.Text;
            User.profile.ProfileImage = ConvertImageToBytes(profileImage.Image);

            if (SqlQueries.UpdateProfile(User.profile))
            {
                //MessageBox.Show("ProfileUpdated");
                ShowNotice(new ProfileUpdatedPage());
            }
        }

        private static byte[] ConvertImageToBytes(Image image)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image), "Image cannot be null.");

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private static Image ConvertBytesToImage(byte[] bytee)
        {
            if (bytee == null || bytee.Length == 0)
                return Properties.Resources.Frame__1_;

            using (MemoryStream ms = new MemoryStream(bytee))
            {
                return Image.FromStream(ms);
            }
        }


        private void profile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a Profile Picture";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the selected image into a PictureBox (assuming you have one)
                        string selectedFilePath = openFileDialog.FileName;
                        profileImage.Image = Image.FromFile(selectedFilePath);

                        // Optionally convert the image to a byte array for database storage
                        byte[] imageBytes = File.ReadAllBytes(selectedFilePath);

                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
