namespace DigitCashier
{
    partial class AdminForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.changeEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.removeEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.varorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printItemTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppdateraMomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxHeading = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxStatus = new System.Windows.Forms.TextBox();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.textboxPrice = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.labelWage = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.MenuChangeItemComboBox4 = new System.Windows.Forms.ToolStripComboBox();
            this.MenuRemoveItemComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(850, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.varorToolStripMenuItem,
            this.uppdateraMomsToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem1});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.DropDownOpened += new System.EventHandler(this.menuToolStripMenuItem_DropDownOpened);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmpToolStripMenuItem,
            this.viewEmpToolStripMenuItem,
            this.changeEmpToolStripMenuItem,
            this.removeEmpToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.DropDownOpened += new System.EventHandler(this.employeeToolStripMenuItem_DropDownOpened);
            // 
            // createEmpToolStripMenuItem
            // 
            this.createEmpToolStripMenuItem.Name = "createEmpToolStripMenuItem";
            this.createEmpToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.createEmpToolStripMenuItem.Text = "Create new";
            this.createEmpToolStripMenuItem.Click += new System.EventHandler(this.createEmpToolStripMenuItem_Click);
            // 
            // viewEmpToolStripMenuItem
            // 
            this.viewEmpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.viewEmpToolStripMenuItem.Name = "viewEmpToolStripMenuItem";
            this.viewEmpToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.viewEmpToolStripMenuItem.Text = "View details";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBox2_KeyDown);
            // 
            // changeEmpToolStripMenuItem
            // 
            this.changeEmpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.changeEmpToolStripMenuItem.Name = "changeEmpToolStripMenuItem";
            this.changeEmpToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.changeEmpToolStripMenuItem.Text = "Change details";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBox1_KeyDown);
            // 
            // removeEmpToolStripMenuItem
            // 
            this.removeEmpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.removeEmpToolStripMenuItem.Name = "removeEmpToolStripMenuItem";
            this.removeEmpToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.removeEmpToolStripMenuItem.Text = "Remove";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBox3_KeyDown);
            // 
            // varorToolStripMenuItem
            // 
            this.varorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItemToolStripMenuItem,
            this.viewAllItemsToolStripMenuItem,
            this.ChangeItemToolStripMenuItem,
            this.printItemTagToolStripMenuItem,
            this.removeItemToolStripMenuItem});
            this.varorToolStripMenuItem.Name = "varorToolStripMenuItem";
            this.varorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.varorToolStripMenuItem.Text = "Item";
            // 
            // AddItemToolStripMenuItem
            // 
            this.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem";
            this.AddItemToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.AddItemToolStripMenuItem.Text = "Add new";
            this.AddItemToolStripMenuItem.Click += new System.EventHandler(this.AddItemToolStripMenuItem_Click);
            // 
            // viewAllItemsToolStripMenuItem
            // 
            this.viewAllItemsToolStripMenuItem.Name = "viewAllItemsToolStripMenuItem";
            this.viewAllItemsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.viewAllItemsToolStripMenuItem.Text = "View all items";
            this.viewAllItemsToolStripMenuItem.Click += new System.EventHandler(this.viewAllItemsToolStripMenuItem_Click);
            // 
            // ChangeItemToolStripMenuItem
            // 
            this.ChangeItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuChangeItemComboBox4});
            this.ChangeItemToolStripMenuItem.Name = "ChangeItemToolStripMenuItem";
            this.ChangeItemToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ChangeItemToolStripMenuItem.Text = "Change details";
            // 
            // printItemTagToolStripMenuItem
            // 
            this.printItemTagToolStripMenuItem.Name = "printItemTagToolStripMenuItem";
            this.printItemTagToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.printItemTagToolStripMenuItem.Text = "Print out price tag";
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRemoveItemComboBox});
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.removeItemToolStripMenuItem.Text = "Remove";
            // 
            // uppdateraMomsToolStripMenuItem
            // 
            this.uppdateraMomsToolStripMenuItem.Name = "uppdateraMomsToolStripMenuItem";
            this.uppdateraMomsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.uppdateraMomsToolStripMenuItem.Text = "Update tax";
            this.uppdateraMomsToolStripMenuItem.Click += new System.EventHandler(this.uppdateraMomsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.quitToolStripMenuItem1.Text = "Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem1_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Silver;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(150, 60);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(688, 582);
            this.textBox.TabIndex = 1;
            this.textBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text Dokument|*.txt";
            // 
            // textBoxHeading
            // 
            this.textBoxHeading.BackColor = System.Drawing.Color.Silver;
            this.textBoxHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHeading.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeading.Location = new System.Drawing.Point(150, 32);
            this.textBoxHeading.Name = "textBoxHeading";
            this.textBoxHeading.Size = new System.Drawing.Size(688, 20);
            this.textBoxHeading.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(113, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 132);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 124);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(310, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 124);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TextBoxStatus);
            this.panel2.Controls.Add(this.TextBoxID);
            this.panel2.Controls.Add(this.TextBoxCategory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.TextBoxAmount);
            this.panel2.Controls.Add(this.textboxPrice);
            this.panel2.Controls.Add(this.textboxName);
            this.panel2.Controls.Add(this.labelWage);
            this.panel2.Controls.Add(this.labelRole);
            this.panel2.Controls.Add(this.labelHours);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Location = new System.Drawing.Point(241, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 484);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // TextBoxStatus
            // 
            this.TextBoxStatus.BackColor = System.Drawing.SystemColors.Info;
            this.TextBoxStatus.Location = new System.Drawing.Point(192, 304);
            this.TextBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxStatus.Name = "TextBoxStatus";
            this.TextBoxStatus.Size = new System.Drawing.Size(136, 24);
            this.TextBoxStatus.TabIndex = 37;
            // 
            // TextBoxID
            // 
            this.TextBoxID.BackColor = System.Drawing.SystemColors.Info;
            this.TextBoxID.Location = new System.Drawing.Point(192, 264);
            this.TextBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(136, 24);
            this.TextBoxID.TabIndex = 36;
            this.TextBoxID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.BackColor = System.Drawing.SystemColors.Info;
            this.TextBoxCategory.Location = new System.Drawing.Point(192, 227);
            this.TextBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(136, 24);
            this.TextBoxCategory.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Gray;
            this.cancelBtn.Location = new System.Drawing.Point(194, 411);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(138, 29);
            this.cancelBtn.TabIndex = 32;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gray;
            this.btnSave.Location = new System.Drawing.Point(194, 374);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 29);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.BackColor = System.Drawing.SystemColors.Info;
            this.TextBoxAmount.Location = new System.Drawing.Point(192, 187);
            this.TextBoxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.Size = new System.Drawing.Size(136, 24);
            this.TextBoxAmount.TabIndex = 30;
            // 
            // textboxPrice
            // 
            this.textboxPrice.BackColor = System.Drawing.SystemColors.Info;
            this.textboxPrice.Location = new System.Drawing.Point(192, 145);
            this.textboxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPrice.Name = "textboxPrice";
            this.textboxPrice.Size = new System.Drawing.Size(136, 24);
            this.textboxPrice.TabIndex = 25;
            // 
            // textboxName
            // 
            this.textboxName.BackColor = System.Drawing.SystemColors.Info;
            this.textboxName.Location = new System.Drawing.Point(192, 107);
            this.textboxName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(136, 24);
            this.textboxName.TabIndex = 23;
            // 
            // labelWage
            // 
            this.labelWage.AutoSize = true;
            this.labelWage.Location = new System.Drawing.Point(46, 227);
            this.labelWage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWage.Name = "labelWage";
            this.labelWage.Size = new System.Drawing.Size(72, 17);
            this.labelWage.TabIndex = 28;
            this.labelWage.Text = "Category";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(46, 187);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(64, 17);
            this.labelRole.TabIndex = 26;
            this.labelRole.Text = "Amount";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(46, 145);
            this.labelHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(40, 17);
            this.labelHours.TabIndex = 24;
            this.labelHours.Text = "Price";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(46, 107);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 17);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "Name";
            // 
            // MenuChangeItemComboBox4
            // 
            this.MenuChangeItemComboBox4.Name = "MenuChangeItemComboBox4";
            this.MenuChangeItemComboBox4.Size = new System.Drawing.Size(121, 23);
            this.MenuChangeItemComboBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuChangeItemComboBox4_KeyDown);
            // 
            // MenuRemoveItemComboBox
            // 
            this.MenuRemoveItemComboBox.Name = "MenuRemoveItemComboBox";
            this.MenuRemoveItemComboBox.Size = new System.Drawing.Size(121, 23);
            this.MenuRemoveItemComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuRemoveItemComboBox_KeyDown);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(850, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxHeading);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uppdateraMomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeEmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printItemTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox textBoxHeading;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox TextBoxAmount;
        private System.Windows.Forms.TextBox textboxPrice;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label labelWage;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.TextBox TextBoxStatus;
        private System.Windows.Forms.ToolStripComboBox MenuChangeItemComboBox4;
        private System.Windows.Forms.ToolStripComboBox MenuRemoveItemComboBox;
    }
}