namespace aero_quest.UserControls
{
    partial class FAQPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAQPage));
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.FAQ = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnRight = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnLeft = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.FAQ)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(43, 42);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(43, 42);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1275, 25);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.PressedState.Image")));
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(43, 42);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(43, 42);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // FAQ
            // 
            this.FAQ.BackColor = System.Drawing.Color.Transparent;
            this.FAQ.Image = global::aero_quest.Properties.Resources.FAQFirst;
            this.FAQ.Location = new System.Drawing.Point(45, 147);
            this.FAQ.Name = "FAQ";
            this.FAQ.ShadowDecoration.Parent = this.FAQ;
            this.FAQ.Size = new System.Drawing.Size(1262, 514);
            this.FAQ.TabIndex = 1;
            this.FAQ.TabStop = false;
            // 
            // BtnRight
            // 
            this.BtnRight.BackColor = System.Drawing.Color.Transparent;
            this.BtnRight.CheckedState.Parent = this.BtnRight;
            this.BtnRight.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("BtnRight.HoverState.Image")));
            this.BtnRight.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnRight.HoverState.Parent = this.BtnRight;
            this.BtnRight.Image = ((System.Drawing.Image)(resources.GetObject("BtnRight.Image")));
            this.BtnRight.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnRight.Location = new System.Drawing.Point(673, 677);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("BtnRight.PressedState.Image")));
            this.BtnRight.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnRight.PressedState.Parent = this.BtnRight;
            this.BtnRight.Size = new System.Drawing.Size(48, 48);
            this.BtnRight.TabIndex = 2;
            this.BtnRight.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.BackColor = System.Drawing.Color.Transparent;
            this.BtnLeft.CheckedState.Parent = this.BtnLeft;
            this.BtnLeft.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("BtnLeft.HoverState.Image")));
            this.BtnLeft.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnLeft.HoverState.Parent = this.BtnLeft;
            this.BtnLeft.Image = ((System.Drawing.Image)(resources.GetObject("BtnLeft.Image")));
            this.BtnLeft.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnLeft.Location = new System.Drawing.Point(623, 677);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("BtnLeft.PressedState.Image")));
            this.BtnLeft.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnLeft.PressedState.Parent = this.BtnLeft;
            this.BtnLeft.Size = new System.Drawing.Size(48, 48);
            this.BtnLeft.TabIndex = 3;
            this.BtnLeft.Visible = false;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // FAQPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.FAQ);
            this.Controls.Add(this.guna2ImageButton1);
            this.Name = "FAQPage";
            this.Size = new System.Drawing.Size(1350, 729);
            ((System.ComponentModel.ISupportInitialize)(this.FAQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2PictureBox FAQ;
        private Guna.UI2.WinForms.Guna2ImageButton BtnRight;
        private Guna.UI2.WinForms.Guna2ImageButton BtnLeft;
    }
}
