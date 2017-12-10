namespace DigitCashier
{
    partial class NewEmployee
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelWage = new System.Windows.Forms.Label();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxHours = new System.Windows.Forms.TextBox();
            this.textboxRole = new System.Windows.Forms.TextBox();
            this.textboxWage = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(40, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(40, 78);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(95, 17);
            this.labelHours.TabIndex = 1;
            this.labelHours.Text = "Hours worked";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(40, 117);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(37, 17);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Role";
            // 
            // labelWage
            // 
            this.labelWage.AutoSize = true;
            this.labelWage.Location = new System.Drawing.Point(40, 158);
            this.labelWage.Name = "labelWage";
            this.labelWage.Size = new System.Drawing.Size(45, 17);
            this.labelWage.TabIndex = 3;
            this.labelWage.Text = "Wage";
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(202, 37);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(100, 22);
            this.textboxName.TabIndex = 4;
            // 
            // textboxHours
            // 
            this.textboxHours.Location = new System.Drawing.Point(202, 73);
            this.textboxHours.Name = "textboxHours";
            this.textboxHours.Size = new System.Drawing.Size(100, 22);
            this.textboxHours.TabIndex = 5;
            // 
            // textboxRole
            // 
            this.textboxRole.Location = new System.Drawing.Point(202, 112);
            this.textboxRole.Name = "textboxRole";
            this.textboxRole.Size = new System.Drawing.Size(100, 22);
            this.textboxRole.TabIndex = 6;
            // 
            // textboxWage
            // 
            this.textboxWage.Location = new System.Drawing.Point(202, 153);
            this.textboxWage.Name = "textboxWage";
            this.textboxWage.Size = new System.Drawing.Size(100, 22);
            this.textboxWage.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 438);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textboxWage);
            this.Controls.Add(this.textboxRole);
            this.Controls.Add(this.textboxHours);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelWage);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelName);
            this.Name = "NewEmployee";
            this.Text = "NewEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelWage;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxHours;
        private System.Windows.Forms.TextBox textboxRole;
        private System.Windows.Forms.TextBox textboxWage;
        private System.Windows.Forms.Button btnSave;
    }
}