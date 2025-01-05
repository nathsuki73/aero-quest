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
            this.txtPaymentMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFlightClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton2.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.HoverState.Image")));
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(204, 48);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(204, 48);
            this.guna2ImageButton2.Location = new System.Drawing.Point(1010, 590);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.PressedState.Image")));
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(204, 48);
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
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(204, 48);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(204, 48);
            this.guna2ImageButton1.Location = new System.Drawing.Point(120, 590);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.PressedState.Image")));
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(204, 48);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(204, 48);
            this.guna2ImageButton1.TabIndex = 4;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.txtPaymentMethod.BorderColor = System.Drawing.Color.Gray;
            this.txtPaymentMethod.BorderRadius = 15;
            this.txtPaymentMethod.BorderThickness = 2;
            this.txtPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPaymentMethod.FocusedColor = System.Drawing.Color.Empty;
            this.txtPaymentMethod.FocusedState.Parent = this.txtPaymentMethod;
            this.txtPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtPaymentMethod.FormattingEnabled = true;
            this.txtPaymentMethod.HoverState.Parent = this.txtPaymentMethod;
            this.txtPaymentMethod.ItemHeight = 30;
            this.txtPaymentMethod.Items.AddRange(new object[] {
            "Paypal",
            "Land Bank",
            "BDO",
            "China Bank",
            "Security Bank"});
            this.txtPaymentMethod.ItemsAppearance.Parent = this.txtPaymentMethod;
            this.txtPaymentMethod.Location = new System.Drawing.Point(557, 263);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.ShadowDecoration.Parent = this.txtPaymentMethod;
            this.txtPaymentMethod.Size = new System.Drawing.Size(216, 36);
            this.txtPaymentMethod.StartIndex = 1;
            this.txtPaymentMethod.TabIndex = 5;
            // 
            // txtFlightClass
            // 
            this.txtFlightClass.BackColor = System.Drawing.Color.Transparent;
            this.txtFlightClass.BorderColor = System.Drawing.Color.Gray;
            this.txtFlightClass.BorderRadius = 15;
            this.txtFlightClass.BorderThickness = 2;
            this.txtFlightClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtFlightClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFlightClass.FocusedColor = System.Drawing.Color.Empty;
            this.txtFlightClass.FocusedState.Parent = this.txtFlightClass;
            this.txtFlightClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFlightClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtFlightClass.FormattingEnabled = true;
            this.txtFlightClass.HoverState.Parent = this.txtFlightClass;
            this.txtFlightClass.ItemHeight = 30;
            this.txtFlightClass.Items.AddRange(new object[] {
            "Economy",
            "Business",
            "First Class"});
            this.txtFlightClass.ItemsAppearance.Parent = this.txtFlightClass;
            this.txtFlightClass.Location = new System.Drawing.Point(557, 378);
            this.txtFlightClass.Name = "txtFlightClass";
            this.txtFlightClass.ShadowDecoration.Parent = this.txtFlightClass;
            this.txtFlightClass.Size = new System.Drawing.Size(216, 36);
            this.txtFlightClass.StartIndex = 1;
            this.txtFlightClass.TabIndex = 5;
            this.txtFlightClass.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
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
            this.txtAccountNumber.ForeColor = System.Drawing.Color.Gray;
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
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalPrice.Location = new System.Drawing.Point(561, 440);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(71, 24);
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
            this.Controls.Add(this.txtFlightClass);
            this.Controls.Add(this.txtPaymentMethod);
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
        private Guna.UI2.WinForms.Guna2ComboBox txtPaymentMethod;
        private Guna.UI2.WinForms.Guna2ComboBox txtFlightClass;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumber;
        private System.Windows.Forms.Label txtTotalPrice;
    }
}
