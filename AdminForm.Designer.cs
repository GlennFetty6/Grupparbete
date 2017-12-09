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
            this.changeEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.SaveChangesBtn = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(850, 28);
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
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmpToolStripMenuItem,
            this.viewEmpToolStripMenuItem,
            this.changeEmpToolStripMenuItem,
            this.removeEmpToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // createEmpToolStripMenuItem
            // 
            this.createEmpToolStripMenuItem.Name = "createEmpToolStripMenuItem";
            this.createEmpToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.createEmpToolStripMenuItem.Text = "Create new";
            this.createEmpToolStripMenuItem.Click += new System.EventHandler(this.createEmpToolStripMenuItem_Click);
            // 
            // viewEmpToolStripMenuItem
            // 
            this.viewEmpToolStripMenuItem.Name = "viewEmpToolStripMenuItem";
            this.viewEmpToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.viewEmpToolStripMenuItem.Text = "View details";
            this.viewEmpToolStripMenuItem.Click += new System.EventHandler(this.viewEmpToolStripMenuItem_Click);
            // 
            // changeEmpToolStripMenuItem
            // 
            this.changeEmpToolStripMenuItem.Name = "changeEmpToolStripMenuItem";
            this.changeEmpToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.changeEmpToolStripMenuItem.Text = "Change details";
            this.changeEmpToolStripMenuItem.Click += new System.EventHandler(this.changeEmpToolStripMenuItem_Click);
            // 
            // removeEmpToolStripMenuItem
            // 
            this.removeEmpToolStripMenuItem.Name = "removeEmpToolStripMenuItem";
            this.removeEmpToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.removeEmpToolStripMenuItem.Text = "Remove";
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
            this.varorToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.varorToolStripMenuItem.Text = "Item";
            // 
            // AddItemToolStripMenuItem
            // 
            this.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem";
            this.AddItemToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.AddItemToolStripMenuItem.Text = "Add new";
            // 
            // viewAllItemsToolStripMenuItem
            // 
            this.viewAllItemsToolStripMenuItem.Name = "viewAllItemsToolStripMenuItem";
            this.viewAllItemsToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.viewAllItemsToolStripMenuItem.Text = "View all items";
            this.viewAllItemsToolStripMenuItem.Click += new System.EventHandler(this.viewAllItemsToolStripMenuItem_Click);
            // 
            // ChangeItemToolStripMenuItem
            // 
            this.ChangeItemToolStripMenuItem.Name = "ChangeItemToolStripMenuItem";
            this.ChangeItemToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ChangeItemToolStripMenuItem.Text = "Change details";
            this.ChangeItemToolStripMenuItem.Click += new System.EventHandler(this.ChangeItemToolStripMenuItem_Click);
            // 
            // printItemTagToolStripMenuItem
            // 
            this.printItemTagToolStripMenuItem.Name = "printItemTagToolStripMenuItem";
            this.printItemTagToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.printItemTagToolStripMenuItem.Text = "Print out price tag";
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.removeItemToolStripMenuItem.Text = "Remove";
            // 
            // uppdateraMomsToolStripMenuItem
            // 
            this.uppdateraMomsToolStripMenuItem.Name = "uppdateraMomsToolStripMenuItem";
            this.uppdateraMomsToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.uppdateraMomsToolStripMenuItem.Text = "Update tax";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(206, 26);
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
            this.textBox.Size = new System.Drawing.Size(700, 595);
            this.textBox.TabIndex = 1;
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
            this.textBoxHeading.Size = new System.Drawing.Size(688, 25);
            this.textBoxHeading.TabIndex = 2;
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.Location = new System.Drawing.Point(0, 32);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(94, 30);
            this.SaveChangesBtn.TabIndex = 3;
            this.SaveChangesBtn.Text = "Save";
            this.SaveChangesBtn.UseVisualStyleBackColor = true;
            this.SaveChangesBtn.Click += new System.EventHandler(this.SaveChangesBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(850, 655);
            this.Controls.Add(this.SaveChangesBtn);
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
        private System.Windows.Forms.Button SaveChangesBtn;
    }
}