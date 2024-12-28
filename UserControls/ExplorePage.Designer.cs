namespace aero_quest.UserControls
{
    partial class ExplorePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorePage));
            this.exploreBtnLuzon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.exploreBtnVisayas = new Guna.UI2.WinForms.Guna2ImageButton();
            this.exploreBtnMindanao = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // exploreBtnLuzon
            // 
            this.exploreBtnLuzon.BackColor = System.Drawing.Color.Transparent;
            this.exploreBtnLuzon.CheckedState.Parent = this.exploreBtnLuzon;
            this.exploreBtnLuzon.HoverState.Parent = this.exploreBtnLuzon;
            this.exploreBtnLuzon.Image = ((System.Drawing.Image)(resources.GetObject("exploreBtnLuzon.Image")));
            this.exploreBtnLuzon.ImageSize = new System.Drawing.Size(154, 51);
            this.exploreBtnLuzon.Location = new System.Drawing.Point(167, 605);
            this.exploreBtnLuzon.Name = "exploreBtnLuzon";
            this.exploreBtnLuzon.PressedState.Parent = this.exploreBtnLuzon;
            this.exploreBtnLuzon.Size = new System.Drawing.Size(154, 51);
            this.exploreBtnLuzon.TabIndex = 0;
            this.exploreBtnLuzon.Click += new System.EventHandler(this.exploreBtnLuzon_Click);
            // 
            // exploreBtnVisayas
            // 
            this.exploreBtnVisayas.BackColor = System.Drawing.Color.Transparent;
            this.exploreBtnVisayas.CheckedState.Parent = this.exploreBtnVisayas;
            this.exploreBtnVisayas.HoverState.Parent = this.exploreBtnVisayas;
            this.exploreBtnVisayas.Image = ((System.Drawing.Image)(resources.GetObject("exploreBtnVisayas.Image")));
            this.exploreBtnVisayas.ImageSize = new System.Drawing.Size(154, 51);
            this.exploreBtnVisayas.Location = new System.Drawing.Point(603, 605);
            this.exploreBtnVisayas.Name = "exploreBtnVisayas";
            this.exploreBtnVisayas.PressedState.Parent = this.exploreBtnVisayas;
            this.exploreBtnVisayas.Size = new System.Drawing.Size(154, 51);
            this.exploreBtnVisayas.TabIndex = 1;
            this.exploreBtnVisayas.Click += new System.EventHandler(this.exploreBtnVisayas_Click);
            // 
            // exploreBtnMindanao
            // 
            this.exploreBtnMindanao.BackColor = System.Drawing.Color.Transparent;
            this.exploreBtnMindanao.CheckedState.Parent = this.exploreBtnMindanao;
            this.exploreBtnMindanao.HoverState.Parent = this.exploreBtnMindanao;
            this.exploreBtnMindanao.Image = ((System.Drawing.Image)(resources.GetObject("exploreBtnMindanao.Image")));
            this.exploreBtnMindanao.ImageSize = new System.Drawing.Size(154, 51);
            this.exploreBtnMindanao.Location = new System.Drawing.Point(1041, 605);
            this.exploreBtnMindanao.Name = "exploreBtnMindanao";
            this.exploreBtnMindanao.PressedState.Parent = this.exploreBtnMindanao;
            this.exploreBtnMindanao.Size = new System.Drawing.Size(154, 51);
            this.exploreBtnMindanao.TabIndex = 2;
            this.exploreBtnMindanao.Click += new System.EventHandler(this.exploreBtnMindanao_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(43, 42);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1272, 21);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(43, 42);
            this.guna2ImageButton1.TabIndex = 3;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // ExplorePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.exploreBtnMindanao);
            this.Controls.Add(this.exploreBtnVisayas);
            this.Controls.Add(this.exploreBtnLuzon);
            this.Name = "ExplorePage";
            this.Size = new System.Drawing.Size(1350, 729);
            this.Load += new System.EventHandler(this.ExplorePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton exploreBtnLuzon;
        private Guna.UI2.WinForms.Guna2ImageButton exploreBtnVisayas;
        private Guna.UI2.WinForms.Guna2ImageButton exploreBtnMindanao;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}
