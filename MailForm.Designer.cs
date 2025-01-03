namespace aero_quest
{
    partial class MailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailForm));
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cmbBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 23);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(25, 23);
            this.guna2ImageButton1.Location = new System.Drawing.Point(873, 24);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.PressedState.Image")));
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(25, 23);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(46, 45);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // cmbBox
            // 
            this.cmbBox.BackColor = System.Drawing.Color.Transparent;
            this.cmbBox.BorderColor = System.Drawing.Color.Gray;
            this.cmbBox.BorderRadius = 15;
            this.cmbBox.BorderThickness = 2;
            this.cmbBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBox.FocusedState.Parent = this.cmbBox;
            this.cmbBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.HoverState.Parent = this.cmbBox;
            this.cmbBox.ItemHeight = 30;
            this.cmbBox.Items.AddRange(new object[] {
            "Inbox",
            "Trash"});
            this.cmbBox.ItemsAppearance.Parent = this.cmbBox;
            this.cmbBox.Location = new System.Drawing.Point(678, 67);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.ShadowDecoration.Parent = this.cmbBox;
            this.cmbBox.Size = new System.Drawing.Size(140, 36);
            this.cmbBox.StartIndex = 0;
            this.cmbBox.TabIndex = 4;
            this.cmbBox.SelectedIndexChanged += new System.EventHandler(this.txtGender_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(63, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 393);
            this.panel1.TabIndex = 5;
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(958, 655);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBox;
        private System.Windows.Forms.Panel panel1;
    }
}