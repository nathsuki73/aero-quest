namespace aero_quest.UserControls.Booking_Process
{
    partial class ConfirmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPayment));
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(204, 48);
            this.guna2ImageButton2.Location = new System.Drawing.Point(1010, 590);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(204, 48);
            this.guna2ImageButton2.TabIndex = 3;
            this.guna2ImageButton2.UseTransparentBackground = true;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(204, 48);
            this.guna2ImageButton1.Location = new System.Drawing.Point(120, 590);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(204, 48);
            this.guna2ImageButton1.TabIndex = 4;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.Transparent;
            this.txtGender.BorderColor = System.Drawing.Color.Gray;
            this.txtGender.BorderRadius = 15;
            this.txtGender.BorderThickness = 2;
            this.txtGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGender.FocusedColor = System.Drawing.Color.Empty;
            this.txtGender.FocusedState.Parent = this.txtGender;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtGender.FormattingEnabled = true;
            this.txtGender.HoverState.Parent = this.txtGender;
            this.txtGender.ItemHeight = 30;
            this.txtGender.Items.AddRange(new object[] {
            "Paypal",
            "Gcash",
            "LandBank"});
            this.txtGender.ItemsAppearance.Parent = this.txtGender;
            this.txtGender.Location = new System.Drawing.Point(557, 263);
            this.txtGender.Name = "txtGender";
            this.txtGender.ShadowDecoration.Parent = this.txtGender;
            this.txtGender.Size = new System.Drawing.Size(216, 36);
            this.txtGender.TabIndex = 5;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Gray;
            this.guna2ComboBox1.BorderRadius = 15;
            this.guna2ComboBox1.BorderThickness = 2;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Economy",
            "Business",
            "First Class"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(557, 380);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(216, 36);
            this.guna2ComboBox1.TabIndex = 5;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtAccountNumber.BorderColor = System.Drawing.Color.Gray;
            this.txtAccountNumber.BorderRadius = 15;
            this.txtAccountNumber.BorderThickness = 2;
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.DefaultText = "";
            this.txtAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.DisabledState.Parent = this.txtAccountNumber;
            this.txtAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.FocusedState.Parent = this.txtAccountNumber;
            this.txtAccountNumber.ForeColor = System.Drawing.Color.White;
            this.txtAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNumber.HoverState.Parent = this.txtAccountNumber;
            this.txtAccountNumber.Location = new System.Drawing.Point(557, 321);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.PlaceholderText = "XXXX-XXXX-XXXX-XXXX";
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.ShadowDecoration.Parent = this.txtAccountNumber;
            this.txtAccountNumber.Size = new System.Drawing.Size(216, 36);
            this.txtAccountNumber.TabIndex = 6;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = true;
            this.txtTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPrice.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalPrice.Location = new System.Drawing.Point(564, 446);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(61, 16);
            this.txtTotalPrice.TabIndex = 7;
            this.txtTotalPrice.Text = "label1";
            // 
            // ConfirmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2ImageButton1);
            this.Name = "ConfirmPayment";
            this.Size = new System.Drawing.Size(1350, 729);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ComboBox txtGender;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumber;
        private System.Windows.Forms.Label txtTotalPrice;
    }
}
