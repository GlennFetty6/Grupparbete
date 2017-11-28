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
            this.SuspendLayout();
            // 
            // loggaIn
            // 
            this.loggaIn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggaIn.Location = new System.Drawing.Point(113, 101);
            this.loggaIn.Name = "loggaIn";
            this.loggaIn.Size = new System.Drawing.Size(92, 35);
            this.loggaIn.TabIndex = 13;
            this.loggaIn.Text = "Logga In";
            this.loggaIn.UseVisualStyleBackColor = true;
            this.loggaIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // loggaUt
            // 
            this.loggaUt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggaUt.Location = new System.Drawing.Point(231, 101);
            this.loggaUt.Name = "loggaUt";
            this.loggaUt.Size = new System.Drawing.Size(100, 35);
            this.loggaUt.TabIndex = 14;
            this.loggaUt.Text = "Logga Ut";
            this.loggaUt.UseVisualStyleBackColor = true;
            this.loggaUt.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Användar ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lösenord";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 18;
            // 
            // boxFelMedd
            // 
            this.boxFelMedd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.boxFelMedd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxFelMedd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFelMedd.ForeColor = System.Drawing.Color.Transparent;
            this.boxFelMedd.Location = new System.Drawing.Point(57, 150);
            this.boxFelMedd.Multiline = true;
            this.boxFelMedd.Name = "boxFelMedd";
            this.boxFelMedd.Size = new System.Drawing.Size(274, 42);
            this.boxFelMedd.TabIndex = 19;
            // 
            // LogInForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(372, 204);
            this.Controls.Add(this.boxFelMedd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loggaUt);
            this.Controls.Add(this.loggaIn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digit Cashier";
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
    }
}