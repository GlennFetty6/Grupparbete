namespace DigitCashier
{
    partial class SplashForm
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
            this.SplashScreenBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashScreenBox
            // 
            this.SplashScreenBox.BackgroundImage = global::DigitCashier.Properties.Resources.Splash;
            this.SplashScreenBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SplashScreenBox.Location = new System.Drawing.Point(-6, -6);
            this.SplashScreenBox.Name = "SplashScreenBox";
            this.SplashScreenBox.Size = new System.Drawing.Size(1087, 610);
            this.SplashScreenBox.TabIndex = 0;
            this.SplashScreenBox.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 598);
            this.Controls.Add(this.SplashScreenBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplashScreenBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashScreenBox;
    }
}