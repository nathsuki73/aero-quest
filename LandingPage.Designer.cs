namespace aero_quest
{
    partial class LandingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.loginStart1 = new aero_quest.UserControls.LoginStart();
            this.fronPageNav1 = new aero_quest.UserControls.FronPageNav();
            this.pcbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // loginStart1
            // 
            this.loginStart1.BackColor = System.Drawing.Color.Transparent;
            this.loginStart1.Location = new System.Drawing.Point(410, 282);
            this.loginStart1.Name = "loginStart1";
            this.loginStart1.Size = new System.Drawing.Size(559, 333);
            this.loginStart1.TabIndex = 0;
            this.loginStart1.Load += new System.EventHandler(this.loginStart1_Load);
            // 
            // fronPageNav1
            // 
            this.fronPageNav1.BackColor = System.Drawing.Color.Transparent;
            this.fronPageNav1.Location = new System.Drawing.Point(923, 23);
            this.fronPageNav1.Name = "fronPageNav1";
            this.fronPageNav1.Size = new System.Drawing.Size(398, 53);
            this.fronPageNav1.TabIndex = 1;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(12, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.ShadowDecoration.Parent = this.pcbLogo;
            this.pcbLogo.Size = new System.Drawing.Size(97, 81);
            this.pcbLogo.TabIndex = 2;
            this.pcbLogo.TabStop = false;
            this.pcbLogo.UseTransparentBackground = true;
            this.pcbLogo.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(31, 28);
            this.btnBack.Location = new System.Drawing.Point(33, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(31, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseTransparentBackground = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.fronPageNav1);
            this.Controls.Add(this.loginStart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AeroQuest";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.LoginStart loginStart1;
        private UserControls.FronPageNav fronPageNav1;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
    }
}

