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
            this.loggaIn = new System.Windows.Forms.Button();
            this.loggaUt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boxFelMedd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loggaIn
            // 
            this.loggaIn.BackColor = System.Drawing.Color.PaleGreen;
            this.loggaIn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggaIn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loggaIn.Location = new System.Drawing.Point(52, 215);
            this.loggaIn.Name = "loggaIn";
            this.loggaIn.Size = new System.Drawing.Size(123, 35);
            this.loggaIn.TabIndex = 3;
            this.loggaIn.Text = "Logga In";
            this.loggaIn.UseVisualStyleBackColor = false;
            this.loggaIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // loggaUt
            // 
            this.loggaUt.BackColor = System.Drawing.Color.PaleGreen;
            this.loggaUt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.loggaUt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggaUt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loggaUt.Location = new System.Drawing.Point(202, 215);
            this.loggaUt.Name = "loggaUt";
            this.loggaUt.Size = new System.Drawing.Size(123, 35);
            this.loggaUt.TabIndex = 4;
            this.loggaUt.Text = "Logga Ut";
            this.loggaUt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(47, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Användar ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(47, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lösenord";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 2;
            // 
            // boxFelMedd
            // 
            this.boxFelMedd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.boxFelMedd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxFelMedd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFelMedd.ForeColor = System.Drawing.Color.Transparent;
            this.boxFelMedd.Location = new System.Drawing.Point(51, 278);
            this.boxFelMedd.Multiline = true;
            this.boxFelMedd.Name = "boxFelMedd";
            this.boxFelMedd.Size = new System.Drawing.Size(274, 65);
            this.boxFelMedd.TabIndex = 19;
            this.boxFelMedd.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(80, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 73);
            this.label3.TabIndex = 20;
            this.label3.Text = "Login";
            // 
            // LogInForm
            // 
            this.AcceptButton = this.loggaIn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.loggaUt;
            this.ClientSize = new System.Drawing.Size(374, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxFelMedd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loggaUt);
            this.Controls.Add(this.loggaIn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digit Cashier";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loggaIn;
        private System.Windows.Forms.Button loggaUt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox boxFelMedd;
        private System.Windows.Forms.Label label3;
    }
}