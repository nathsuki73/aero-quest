namespace aero_quest.UserControls.Mail
{
    partial class SeatIDMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatIDMail));
            this.lblDate = new System.Windows.Forms.Label();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.seatId = new System.Windows.Forms.Label();
            this.lblgoodbye = new System.Windows.Forms.Label();
            this.lblbody = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(516, 124);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label1";
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton3.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.HoverState.Image")));
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(25, 23);
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(25, 23);
            this.guna2ImageButton3.Location = new System.Drawing.Point(49, 33);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.PressedState.Image")));
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(25, 23);
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(25, 23);
            this.guna2ImageButton3.TabIndex = 3;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // seatId
            // 
            this.seatId.AutoSize = true;
            this.seatId.BackColor = System.Drawing.Color.Transparent;
            this.seatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatId.Location = new System.Drawing.Point(306, 430);
            this.seatId.Name = "seatId";
            this.seatId.Size = new System.Drawing.Size(83, 55);
            this.seatId.TabIndex = 17;
            this.seatId.Text = "A5";
            this.seatId.Click += new System.EventHandler(this.seatId_Click);
            // 
            // lblgoodbye
            // 
            this.lblgoodbye.AutoSize = true;
            this.lblgoodbye.BackColor = System.Drawing.Color.Transparent;
            this.lblgoodbye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgoodbye.Location = new System.Drawing.Point(71, 605);
            this.lblgoodbye.Name = "lblgoodbye";
            this.lblgoodbye.Size = new System.Drawing.Size(51, 20);
            this.lblgoodbye.TabIndex = 16;
            this.lblgoodbye.Text = "label4";
            // 
            // lblbody
            // 
            this.lblbody.AutoSize = true;
            this.lblbody.BackColor = System.Drawing.Color.Transparent;
            this.lblbody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbody.Location = new System.Drawing.Point(57, 282);
            this.lblbody.Name = "lblbody";
            this.lblbody.Size = new System.Drawing.Size(51, 20);
            this.lblbody.TabIndex = 15;
            this.lblbody.Text = "label3";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(57, 249);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "label2";
            // 
            // SeatIDMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.seatId);
            this.Controls.Add(this.lblgoodbye);
            this.Controls.Add(this.lblbody);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.guna2ImageButton3);
            this.Controls.Add(this.lblDate);
            this.Name = "SeatIDMail";
            this.Size = new System.Drawing.Size(715, 990);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private System.Windows.Forms.Label seatId;
        private System.Windows.Forms.Label lblgoodbye;
        private System.Windows.Forms.Label lblbody;
        private System.Windows.Forms.Label lblName;
    }
}
