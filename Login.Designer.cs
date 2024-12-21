namespace aero_quest
{
    partial class Login
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
            this.loginStart1 = new aero_quest.UserControls.LoginStart();
            this.SuspendLayout();
            // 
            // loginStart1
            // 
            this.loginStart1.Location = new System.Drawing.Point(410, 282);
            this.loginStart1.Name = "loginStart1";
            this.loginStart1.Size = new System.Drawing.Size(559, 333);
            this.loginStart1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::aero_quest.Properties.Resources.landing_page;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.loginStart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AeroQuest";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.LoginStart loginStart1;
    }
}

