namespace aero_quest.UserControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.btnAbout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnFlights = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHelp = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.CheckedState.Parent = this.btnAbout;
            this.btnAbout.HoverState.Parent = this.btnAbout;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageSize = new System.Drawing.Size(90, 24);
            this.btnAbout.Location = new System.Drawing.Point(1202, 30);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.PressedState.Parent = this.btnAbout;
            this.btnAbout.Size = new System.Drawing.Size(90, 24);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.UseTransparentBackground = true;
            // 
            // btnFlights
            // 
            this.btnFlights.BackColor = System.Drawing.Color.Transparent;
            this.btnFlights.CheckedState.Parent = this.btnFlights;
            this.btnFlights.HoverState.Parent = this.btnFlights;
            this.btnFlights.Image = global::aero_quest.Properties.Resources.flights_button;
            this.btnFlights.ImageSize = new System.Drawing.Size(90, 24);
            this.btnFlights.Location = new System.Drawing.Point(1106, 30);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.PressedState.Parent = this.btnFlights;
            this.btnFlights.Size = new System.Drawing.Size(90, 24);
            this.btnFlights.TabIndex = 0;
            this.btnFlights.UseTransparentBackground = true;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.CheckedState.Parent = this.btnHelp;
            this.btnHelp.HoverState.Parent = this.btnHelp;
            this.btnHelp.Image = global::aero_quest.Properties.Resources.help;
            this.btnHelp.ImageSize = new System.Drawing.Size(90, 24);
            this.btnHelp.Location = new System.Drawing.Point(1010, 30);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.PressedState.Parent = this.btnHelp;
            this.btnHelp.Size = new System.Drawing.Size(90, 24);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.UseTransparentBackground = true;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = global::aero_quest.Properties.Resources.home_button;
            this.btnHome.ImageSize = new System.Drawing.Size(90, 24);
            this.btnHome.Location = new System.Drawing.Point(914, 30);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedState.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(90, 24);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseTransparentBackground = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(200, 40);
            this.guna2ImageButton1.Location = new System.Drawing.Point(576, 530);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(200, 40);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnFlights);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.btnHome);
            this.Name = "LandingPage";
            this.Size = new System.Drawing.Size(1350, 729);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnHome;
        private Guna.UI2.WinForms.Guna2ImageButton btnHelp;
        private Guna.UI2.WinForms.Guna2ImageButton btnFlights;
        private Guna.UI2.WinForms.Guna2ImageButton btnAbout;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}
