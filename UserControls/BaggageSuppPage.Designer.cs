namespace aero_quest.UserControls
{
    partial class BaggageSuppPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaggageSuppPage));
            this.rightBtnSupp = new Guna.UI2.WinForms.Guna2ImageButton();
            this.leftBtnSupp = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // rightBtnSupp
            // 
            this.rightBtnSupp.BackColor = System.Drawing.Color.Transparent;
            this.rightBtnSupp.CheckedState.Parent = this.rightBtnSupp;
            this.rightBtnSupp.HoverState.Parent = this.rightBtnSupp;
            this.rightBtnSupp.Image = ((System.Drawing.Image)(resources.GetObject("rightBtnSupp.Image")));
            this.rightBtnSupp.ImageSize = new System.Drawing.Size(48, 48);
            this.rightBtnSupp.Location = new System.Drawing.Point(1296, 388);
            this.rightBtnSupp.Name = "rightBtnSupp";
            this.rightBtnSupp.PressedState.Parent = this.rightBtnSupp;
            this.rightBtnSupp.Size = new System.Drawing.Size(48, 48);
            this.rightBtnSupp.TabIndex = 0;
            this.rightBtnSupp.Click += new System.EventHandler(this.rightBtnSupp_Click);
            // 
            // leftBtnSupp
            // 
            this.leftBtnSupp.BackColor = System.Drawing.Color.Transparent;
            this.leftBtnSupp.CheckedState.Parent = this.leftBtnSupp;
            this.leftBtnSupp.HoverState.Parent = this.leftBtnSupp;
            this.leftBtnSupp.Image = ((System.Drawing.Image)(resources.GetObject("leftBtnSupp.Image")));
            this.leftBtnSupp.ImageSize = new System.Drawing.Size(48, 48);
            this.leftBtnSupp.Location = new System.Drawing.Point(5, 379);
            this.leftBtnSupp.Name = "leftBtnSupp";
            this.leftBtnSupp.PressedState.Parent = this.leftBtnSupp;
            this.leftBtnSupp.Size = new System.Drawing.Size(48, 48);
            this.leftBtnSupp.TabIndex = 1;
            this.leftBtnSupp.Click += new System.EventHandler(this.leftBtnSupp_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(43, 42);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1265, 41);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(43, 42);
            this.guna2ImageButton1.TabIndex = 2;
            // 
            // BaggageSuppPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::aero_quest.Properties.Resources.lostAndFoundBg;
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.leftBtnSupp);
            this.Controls.Add(this.rightBtnSupp);
            this.Name = "BaggageSuppPage";
            this.Size = new System.Drawing.Size(1350, 729);
            this.Load += new System.EventHandler(this.BaggageSuppPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton rightBtnSupp;
        private Guna.UI2.WinForms.Guna2ImageButton leftBtnSupp;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}
