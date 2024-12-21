namespace aero_quest.UserControls
{
    partial class FronPageNav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FronPageNav));
            this.btnAbout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnFlights = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHelp = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.CheckedState.Parent = this.btnAbout;
            this.btnAbout.HoverState.Parent = this.btnAbout;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageSize = new System.Drawing.Size(90, 24);
            this.btnAbout.Location = new System.Drawing.Point(291, 13);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.PressedState.Parent = this.btnAbout;
            this.btnAbout.Size = new System.Drawing.Size(90, 24);
            this.btnAbout.TabIndex = 0;
            // 
            // btnFlights
            // 
            this.btnFlights.CheckedState.Parent = this.btnFlights;
            this.btnFlights.HoverState.Parent = this.btnFlights;
            this.btnFlights.Image = global::aero_quest.Properties.Resources.flights_button;
            this.btnFlights.ImageSize = new System.Drawing.Size(90, 24);
            this.btnFlights.Location = new System.Drawing.Point(195, 13);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.PressedState.Parent = this.btnFlights;
            this.btnFlights.Size = new System.Drawing.Size(90, 24);
            this.btnFlights.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.CheckedState.Parent = this.btnHelp;
            this.btnHelp.HoverState.Parent = this.btnHelp;
            this.btnHelp.Image = global::aero_quest.Properties.Resources.help;
            this.btnHelp.ImageSize = new System.Drawing.Size(90, 24);
            this.btnHelp.Location = new System.Drawing.Point(99, 13);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.PressedState.Parent = this.btnHelp;
            this.btnHelp.Size = new System.Drawing.Size(90, 24);
            this.btnHelp.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = global::aero_quest.Properties.Resources.home_button;
            this.btnHome.ImageSize = new System.Drawing.Size(90, 24);
            this.btnHome.Location = new System.Drawing.Point(3, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedState.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(90, 24);
            this.btnHome.TabIndex = 0;
            // 
            // FronPageNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnFlights);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnHome);
            this.Name = "FronPageNav";
            this.Size = new System.Drawing.Size(398, 53);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnHome;
        private Guna.UI2.WinForms.Guna2ImageButton btnHelp;
        private Guna.UI2.WinForms.Guna2ImageButton btnFlights;
        private Guna.UI2.WinForms.Guna2ImageButton btnAbout;
    }
}
