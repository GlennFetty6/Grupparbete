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
            this.textboxWage = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorMessageTxtbox = new System.Windows.Forms.TextBox();
            this.adminRadioBtn = new System.Windows.Forms.RadioButton();
            this.cashierRadioBtn = new System.Windows.Forms.RadioButton();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 44);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(23, 88);
            this.labelHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(127, 20);
            this.labelHours.TabIndex = 1;
            this.labelHours.Text = "Hours worked";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(23, 136);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(46, 20);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Role";
            // 
            // labelWage
            // 
            this.labelWage.AutoSize = true;
            this.labelWage.Location = new System.Drawing.Point(23, 202);
            this.labelWage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWage.Name = "labelWage";
            this.labelWage.Size = new System.Drawing.Size(56, 20);
            this.labelWage.TabIndex = 3;
            this.labelWage.Text = "Wage";
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(171, 41);
            this.textboxName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(136, 28);
            this.textboxName.TabIndex = 1;
            // 
            // textboxHours
            // 
            this.textboxHours.Location = new System.Drawing.Point(171, 85);
            this.textboxHours.Margin = new System.Windows.Forms.Padding(4);
            this.textboxHours.Name = "textboxHours";
            this.textboxHours.Size = new System.Drawing.Size(136, 28);
            this.textboxHours.TabIndex = 2;
            this.textboxHours.Validating += new System.ComponentModel.CancelEventHandler(this.textboxHours_Validating);
            // 
            // textboxWage
            // 
            this.textboxWage.Location = new System.Drawing.Point(171, 199);
            this.textboxWage.Margin = new System.Windows.Forms.Padding(4);
            this.textboxWage.Name = "textboxWage";
            this.textboxWage.Size = new System.Drawing.Size(136, 28);
            this.textboxWage.TabIndex = 5;
            this.textboxWage.Validating += new System.ComponentModel.CancelEventHandler(this.textboxWage_Validating);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gray;
            this.btnSave.Location = new System.Drawing.Point(171, 245);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorMessageTxtbox
            // 
            this.errorMessageTxtbox.BackColor = System.Drawing.Color.Silver;
            this.errorMessageTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorMessageTxtbox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageTxtbox.ForeColor = System.Drawing.Color.Transparent;
            this.errorMessageTxtbox.Location = new System.Drawing.Point(27, 319);
            this.errorMessageTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.errorMessageTxtbox.Multiline = true;
            this.errorMessageTxtbox.Name = "errorMessageTxtbox";
            this.errorMessageTxtbox.Size = new System.Drawing.Size(280, 45);
            this.errorMessageTxtbox.TabIndex = 20;
            this.errorMessageTxtbox.TabStop = false;
            // 
            // adminRadioBtn
            // 
            this.adminRadioBtn.AutoSize = true;
            this.adminRadioBtn.Checked = true;
            this.adminRadioBtn.Location = new System.Drawing.Point(171, 132);
            this.adminRadioBtn.Name = "adminRadioBtn";
            this.adminRadioBtn.Size = new System.Drawing.Size(86, 24);
            this.adminRadioBtn.TabIndex = 3;
            this.adminRadioBtn.TabStop = true;
            this.adminRadioBtn.Text = "Admin";
            this.adminRadioBtn.UseVisualStyleBackColor = true;
            this.adminRadioBtn.CheckedChanged += new System.EventHandler(this.adminRadioBtn_CheckedChanged);
            // 
            // cashierRadioBtn
            // 
            this.cashierRadioBtn.AutoSize = true;
            this.cashierRadioBtn.Location = new System.Drawing.Point(171, 163);
            this.cashierRadioBtn.Name = "cashierRadioBtn";
            this.cashierRadioBtn.Size = new System.Drawing.Size(94, 24);
            this.cashierRadioBtn.TabIndex = 4;
            this.cashierRadioBtn.Text = "Cashier";
            this.cashierRadioBtn.UseVisualStyleBackColor = true;
            this.cashierRadioBtn.CheckedChanged += new System.EventHandler(this.cashierRadioBtn_CheckedChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Gray;
            this.cancelBtn.Location = new System.Drawing.Point(169, 282);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(138, 29);
            this.cancelBtn.TabIndex = 21;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(342, 384);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.cashierRadioBtn);
            this.Controls.Add(this.adminRadioBtn);
            this.Controls.Add(this.errorMessageTxtbox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textboxWage);
            this.Controls.Add(this.textboxHours);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelWage);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewEmployee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Employee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewEmployee_FormClosed);
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
        private System.Windows.Forms.TextBox textboxWage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox errorMessageTxtbox;
        private System.Windows.Forms.RadioButton adminRadioBtn;
        private System.Windows.Forms.RadioButton cashierRadioBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}