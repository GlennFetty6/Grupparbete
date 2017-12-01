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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printItemTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppdateraMomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(850, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open file";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save file";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.varorToolStripMenuItem,
            this.uppdateraMomsToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmpToolStripMenuItem,
            this.changeEmpToolStripMenuItem,
            this.viewEmpToolStripMenuItem,
            this.removeEmpToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // createEmpToolStripMenuItem
            // 
            this.createEmpToolStripMenuItem.Name = "createEmpToolStripMenuItem";
            this.createEmpToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.createEmpToolStripMenuItem.Text = "Create new";
            // 
            // changeEmpToolStripMenuItem
            // 
            this.changeEmpToolStripMenuItem.Name = "changeEmpToolStripMenuItem";
            this.changeEmpToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.changeEmpToolStripMenuItem.Text = "Change details";
            // 
            // viewEmpToolStripMenuItem
            // 
            this.viewEmpToolStripMenuItem.Name = "viewEmpToolStripMenuItem";
            this.viewEmpToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.viewEmpToolStripMenuItem.Text = "View details";
            // 
            // removeEmpToolStripMenuItem
            // 
            this.removeEmpToolStripMenuItem.Name = "removeEmpToolStripMenuItem";
            this.removeEmpToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.removeEmpToolStripMenuItem.Text = "Remove";
            // 
            // varorToolStripMenuItem
            // 
            this.varorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItemToolStripMenuItem,
            this.ChangeItemToolStripMenuItem,
            this.printItemTagToolStripMenuItem,
            this.removeItemToolStripMenuItem});
            this.varorToolStripMenuItem.Name = "varorToolStripMenuItem";
            this.varorToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.varorToolStripMenuItem.Text = "Item";
            // 
            // AddItemToolStripMenuItem
            // 
            this.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem";
            this.AddItemToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.AddItemToolStripMenuItem.Text = "Add";
            // 
            // ChangeItemToolStripMenuItem
            // 
            this.ChangeItemToolStripMenuItem.Name = "ChangeItemToolStripMenuItem";
            this.ChangeItemToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.ChangeItemToolStripMenuItem.Text = "Change details";
            // 
            // printItemTagToolStripMenuItem
            // 
            this.printItemTagToolStripMenuItem.Name = "printItemTagToolStripMenuItem";
            this.printItemTagToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.printItemTagToolStripMenuItem.Text = "Print out price tag";
            // 
            // uppdateraMomsToolStripMenuItem
            // 
            this.uppdateraMomsToolStripMenuItem.Name = "uppdateraMomsToolStripMenuItem";
            this.uppdateraMomsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.uppdateraMomsToolStripMenuItem.Text = "Update tax";
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Gray;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(150, 28);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(700, 627);
            this.textBox.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text Dokument|*.txt";
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.removeItemToolStripMenuItem.Text = "Remove";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(850, 655);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
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
    }
}