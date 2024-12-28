namespace aero_quest.UserControls
{
    partial class AircraftsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AircraftsPage));
            this.ACBtnLeft = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ACBtnRight = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ACHomeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // ACBtnLeft
            // 
            this.ACBtnLeft.BackColor = System.Drawing.Color.Transparent;
            this.ACBtnLeft.CheckedState.Parent = this.ACBtnLeft;
            this.ACBtnLeft.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("ACBtnLeft.HoverState.Image")));
            this.ACBtnLeft.HoverState.ImageSize = new System.Drawing.Size(79, 77);
            this.ACBtnLeft.HoverState.Parent = this.ACBtnLeft;
            this.ACBtnLeft.Image = ((System.Drawing.Image)(resources.GetObject("ACBtnLeft.Image")));
            this.ACBtnLeft.ImageSize = new System.Drawing.Size(79, 77);
            this.ACBtnLeft.Location = new System.Drawing.Point(28, 341);
            this.ACBtnLeft.Name = "ACBtnLeft";
            this.ACBtnLeft.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("ACBtnLeft.PressedState.Image")));
            this.ACBtnLeft.PressedState.ImageSize = new System.Drawing.Size(79, 77);
            this.ACBtnLeft.PressedState.Parent = this.ACBtnLeft;
            this.ACBtnLeft.Size = new System.Drawing.Size(79, 77);
            this.ACBtnLeft.TabIndex = 0;
            this.ACBtnLeft.Click += new System.EventHandler(this.ACBtnLeft_Click);
            // 
            // ACBtnRight
            // 
            this.ACBtnRight.BackColor = System.Drawing.Color.Transparent;
            this.ACBtnRight.CheckedState.Parent = this.ACBtnRight;
            this.ACBtnRight.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("ACBtnRight.HoverState.Image")));
            this.ACBtnRight.HoverState.ImageSize = new System.Drawing.Size(79, 77);
            this.ACBtnRight.HoverState.Parent = this.ACBtnRight;
            this.ACBtnRight.Image = ((System.Drawing.Image)(resources.GetObject("ACBtnRight.Image")));
            this.ACBtnRight.ImageSize = new System.Drawing.Size(79, 77);
            this.ACBtnRight.Location = new System.Drawing.Point(1242, 349);
            this.ACBtnRight.Name = "ACBtnRight";
            this.ACBtnRight.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("ACBtnRight.PressedState.Image")));
            this.ACBtnRight.PressedState.ImageSize = new System.Drawing.Size(79, 77);
            this.ACBtnRight.PressedState.Parent = this.ACBtnRight;
            this.ACBtnRight.Size = new System.Drawing.Size(79, 77);
            this.ACBtnRight.TabIndex = 1;
            this.ACBtnRight.Click += new System.EventHandler(this.ACBtnRight_Click);
            // 
            // ACHomeBtn
            // 
            this.ACHomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.ACHomeBtn.CheckedState.Parent = this.ACHomeBtn;
            this.ACHomeBtn.HoverState.Parent = this.ACHomeBtn;
            this.ACHomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("ACHomeBtn.Image")));
            this.ACHomeBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.ACHomeBtn.Location = new System.Drawing.Point(28, 12);
            this.ACHomeBtn.Name = "ACHomeBtn";
            this.ACHomeBtn.PressedState.Parent = this.ACHomeBtn;
            this.ACHomeBtn.Size = new System.Drawing.Size(25, 25);
            this.ACHomeBtn.TabIndex = 2;
            this.ACHomeBtn.Click += new System.EventHandler(this.ACHomeBtn_Click);
            // 
            // AircraftsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::aero_quest.Properties.Resources._777;
            this.Controls.Add(this.ACHomeBtn);
            this.Controls.Add(this.ACBtnRight);
            this.Controls.Add(this.ACBtnLeft);
            this.Name = "AircraftsPage";
            this.Size = new System.Drawing.Size(1350, 739);
            this.Load += new System.EventHandler(this.AircraftsPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton ACBtnLeft;
        private Guna.UI2.WinForms.Guna2ImageButton ACBtnRight;
        private Guna.UI2.WinForms.Guna2ImageButton ACHomeBtn;
    }
}
