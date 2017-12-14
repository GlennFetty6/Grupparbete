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
            this.logInBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.userIDTxtbox = new System.Windows.Forms.TextBox();
            this.passwordTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorMessageTxtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.Color.DimGray;
            this.logInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logInBtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.ForeColor = System.Drawing.Color.Black;
            this.logInBtn.Location = new System.Drawing.Point(58, 302);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(259, 53);
            this.logInBtn.TabIndex = 3;
            this.logInBtn.Text = "Log in";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.DimGray;
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutBtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logOutBtn.Location = new System.Drawing.Point(58, 380);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(259, 53);
            this.logOutBtn.TabIndex = 4;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // userIDTxtbox
            // 
            this.userIDTxtbox.AccessibleName = "";
            this.userIDTxtbox.BackColor = System.Drawing.Color.Silver;
            this.userIDTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userIDTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userIDTxtbox.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTxtbox.ForeColor = System.Drawing.Color.Gray;
            this.userIDTxtbox.Location = new System.Drawing.Point(0, 6);
            this.userIDTxtbox.Multiline = true;
            this.userIDTxtbox.Name = "userIDTxtbox";
            this.userIDTxtbox.Size = new System.Drawing.Size(259, 44);
            this.userIDTxtbox.TabIndex = 1;
            this.userIDTxtbox.Text = "User ID";
            this.userIDTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userIDTxtbox.Click += new System.EventHandler(this.userIDTxtbox_Click);
            this.userIDTxtbox.TextChanged += new System.EventHandler(this.userIDTxtbox_TextChanged);
            // 
            // passwordTxtbox
            // 
            this.passwordTxtbox.BackColor = System.Drawing.Color.Silver;
            this.passwordTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtbox.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbox.ForeColor = System.Drawing.Color.Gray;
            this.passwordTxtbox.Location = new System.Drawing.Point(0, 7);
            this.passwordTxtbox.Multiline = true;
            this.passwordTxtbox.Name = "passwordTxtbox";
            this.passwordTxtbox.Size = new System.Drawing.Size(259, 46);
            this.passwordTxtbox.TabIndex = 2;
            this.passwordTxtbox.Text = "Password";
            this.passwordTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTxtbox.Click += new System.EventHandler(this.passwordTxtbox_Click);
            this.passwordTxtbox.TextChanged += new System.EventHandler(this.passwordTxtbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Verdana", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(83, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 101);
            this.label3.TabIndex = 20;
            this.label3.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.userIDTxtbox);
            this.panel1.Location = new System.Drawing.Point(58, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 53);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.passwordTxtbox);
            this.panel2.Location = new System.Drawing.Point(58, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 53);
            this.panel2.TabIndex = 22;
            // 
            // errorMessageTxtbox
            // 
            this.errorMessageTxtbox.BackColor = System.Drawing.Color.Gray;
            this.errorMessageTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorMessageTxtbox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageTxtbox.ForeColor = System.Drawing.Color.Transparent;
            this.errorMessageTxtbox.Location = new System.Drawing.Point(58, 450);
            this.errorMessageTxtbox.Multiline = true;
            this.errorMessageTxtbox.Name = "errorMessageTxtbox";
            this.errorMessageTxtbox.Size = new System.Drawing.Size(259, 65);
            this.errorMessageTxtbox.TabIndex = 19;
            this.errorMessageTxtbox.TabStop = false;
            // 
            // LogInForm
            // 
            this.AcceptButton = this.logInBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.logOutBtn;
            this.ClientSize = new System.Drawing.Size(374, 553);
            this.ControlBox = false;
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorMessageTxtbox);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.TextBox userIDTxtbox;
        private System.Windows.Forms.TextBox passwordTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox errorMessageTxtbox;
    }
}