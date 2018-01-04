namespace DigitCashier
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.userIDTxtbox = new System.Windows.Forms.TextBox();
            this.passwordTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonLogIn = new ImageButton.CustomImageButton();
            this.buttonLogOut = new ImageButton.CustomImageButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // userIDTxtbox
            // 
            this.userIDTxtbox.AccessibleName = "";
            this.userIDTxtbox.BackColor = System.Drawing.Color.White;
            this.userIDTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userIDTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userIDTxtbox.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTxtbox.ForeColor = System.Drawing.Color.Gray;
            this.userIDTxtbox.Location = new System.Drawing.Point(0, 6);
            this.userIDTxtbox.Multiline = true;
            this.userIDTxtbox.Name = "userIDTxtbox";
            this.userIDTxtbox.Size = new System.Drawing.Size(259, 47);
            this.userIDTxtbox.TabIndex = 1;
            this.userIDTxtbox.Text = "User ID";
            this.userIDTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userIDTxtbox.Click += new System.EventHandler(this.userIDTxtbox_Click);
            this.userIDTxtbox.TextChanged += new System.EventHandler(this.userIDTxtbox_TextChanged);
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.BackColor = System.Drawing.Color.White;
            this.passwordTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtbox.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbox.ForeColor = System.Drawing.Color.Gray;
            this.passwordTxtbox.Location = new System.Drawing.Point(0, 6);
            this.passwordTxtbox.Multiline = true;
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(259, 47);
            this.passwordTxtbox.TabIndex = 2;
            this.passwordTxtbox.Text = "Password";
            this.passwordTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTxtbox.Click += new System.EventHandler(this.passwordTxtbox_Click);
            this.passwordTxtbox.TextChanged += new System.EventHandler(this.passwordTxtbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(88, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 97);
            this.label3.TabIndex = 20;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.userIDTxtbox);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(58, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 53);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.passwordTxtbox);
            this.panel2.Location = new System.Drawing.Point(58, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 53);
            this.panel2.TabIndex = 22;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(54, 455);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(318, 44);
            this.labelError.TabIndex = 23;
            this.labelError.Text = "Invalid user ID or password.\r\nPlease try again!";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelError.Visible = false;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogIn.ErrorImage = null;
            this.buttonLogIn.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogIn.Image")));
            this.buttonLogIn.ImageHover = ((System.Drawing.Image)(resources.GetObject("buttonLogIn.ImageHover")));
            this.buttonLogIn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("buttonLogIn.ImageNormal")));
            this.buttonLogIn.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonLogIn.InitialImage")));
            this.buttonLogIn.Location = new System.Drawing.Point(42, 296);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(288, 72);
            this.buttonLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonLogIn.TabIndex = 26;
            this.buttonLogIn.TabStop = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogOut.ErrorImage = null;
            this.buttonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.Image")));
            this.buttonLogOut.ImageHover = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.ImageHover")));
            this.buttonLogOut.ImageNormal = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.ImageNormal")));
            this.buttonLogOut.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.InitialImage")));
            this.buttonLogOut.Location = new System.Drawing.Point(42, 370);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(288, 72);
            this.buttonLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonLogOut.TabIndex = 25;
            this.buttonLogOut.TabStop = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 529);
            this.ControlBox = false;
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogInForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLogOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userIDTxtbox;
        private System.Windows.Forms.TextBox passwordTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelError;
        private ImageButton.CustomImageButton buttonLogOut;
        private ImageButton.CustomImageButton buttonLogIn;
    }
}