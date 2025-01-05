namespace aero_quest.UserControls.Mail
{
    partial class MailRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailRecord));
            this.txtName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(51, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 19);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Booking Confirmation";
            this.txtName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtDate_MouseDoubleClick_1);
            this.txtName.MouseEnter += new System.EventHandler(this.txtName_MouseEnter);
            this.txtName.MouseLeave += new System.EventHandler(this.txtName_MouseLeave);
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(205, 6);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(449, 38);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "1234567890123456789012345678901234567890123456789012345\r\n\r\n";
            this.txtDescription.Click += new System.EventHandler(this.txtDescription_Click);
            this.txtDescription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDescription_MouseClick);
            this.txtDescription.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtDate_MouseDoubleClick_1);
            this.txtDescription.MouseEnter += new System.EventHandler(this.txtDescription_MouseEnter);
            this.txtDescription.MouseLeave += new System.EventHandler(this.txtDescription_MouseLeave);
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(664, 6);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(49, 19);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "label1";
            this.txtDate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtDate_MouseDoubleClick_1);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton2.Location = new System.Drawing.Point(790, 3);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageButton2.TabIndex = 2;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Location = new System.Drawing.Point(766, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.TabIndex = 2;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MailRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MailRecord";
            this.Size = new System.Drawing.Size(825, 30);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MailRecord_MouseDoubleClick);
            this.MouseEnter += new System.EventHandler(this.MailRecord_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MailRecord_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Label txtDate;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
    }
}
