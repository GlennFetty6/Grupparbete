namespace DigitCashier
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.TaxPanel = new System.Windows.Forms.Panel();
            this.TaxCancelButton = new System.Windows.Forms.Button();
            this.TaxShowTax = new System.Windows.Forms.RichTextBox();
            this.TaxSaveButton = new System.Windows.Forms.Button();
            this.EmployeePanel = new System.Windows.Forms.Panel();
            this.EmpCancelButton = new System.Windows.Forms.Button();
            this.EmpRemoveButton = new System.Windows.Forms.Button();
            this.EmpLabelRole = new System.Windows.Forms.Label();
            this.EmpErrorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EmpShowName = new System.Windows.Forms.RichTextBox();
            this.EmpLabelHours = new System.Windows.Forms.Label();
            this.EmpLabelWage = new System.Windows.Forms.Label();
            this.EmpLabelName = new System.Windows.Forms.Label();
            this.EmpCashierRadioBtn = new System.Windows.Forms.RadioButton();
            this.EmpAdminRadioBtn = new System.Windows.Forms.RadioButton();
            this.EmpShowWage = new System.Windows.Forms.RichTextBox();
            this.EmpShowHours = new System.Windows.Forms.RichTextBox();
            this.EmpListBox = new System.Windows.Forms.ListBox();
            this.EmpSaveButton = new System.Windows.Forms.Button();
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.ItemLabelAmount = new System.Windows.Forms.Label();
            this.ItemsRemoveButton = new System.Windows.Forms.Button();
            this.ItemsCancelButton = new System.Windows.Forms.Button();
            this.ItemsWeightRadioButton = new System.Windows.Forms.RadioButton();
            this.ItemsCountRadioButton = new System.Windows.Forms.RadioButton();
            this.ItemLabelStatus = new System.Windows.Forms.Label();
            this.ItemsLabelId = new System.Windows.Forms.Label();
            this.ItemsLabelPrice = new System.Windows.Forms.Label();
            this.ItemsShowStatus = new System.Windows.Forms.RichTextBox();
            this.ItemsShowId = new System.Windows.Forms.RichTextBox();
            this.ItemsShowPrice = new System.Windows.Forms.RichTextBox();
            this.ItemsErrorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ItemsSaveButton = new System.Windows.Forms.Button();
            this.ItemsShowName = new System.Windows.Forms.RichTextBox();
            this.ItemsLabelName = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.LogoutButton = new ImageButton.CustomImageButton();
            this.UpdateTaxButton = new ImageButton.CustomImageButton();
            this.ItemsButton = new ImageButton.CustomImageButton();
            this.EmployeeButton = new ImageButton.CustomImageButton();
            this.TaxPanel.SuspendLayout();
            this.EmployeePanel.SuspendLayout();
            this.ItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTaxButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TaxPanel
            // 
            this.TaxPanel.BackColor = System.Drawing.Color.Moccasin;
            this.TaxPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TaxPanel.BackgroundImage")));
            this.TaxPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TaxPanel.Controls.Add(this.TaxCancelButton);
            this.TaxPanel.Controls.Add(this.TaxShowTax);
            this.TaxPanel.Controls.Add(this.TaxSaveButton);
            this.TaxPanel.Location = new System.Drawing.Point(183, 124);
            this.TaxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TaxPanel.Name = "TaxPanel";
            this.TaxPanel.Size = new System.Drawing.Size(840, 516);
            this.TaxPanel.TabIndex = 0;
            this.TaxPanel.Visible = false;
            this.TaxPanel.VisibleChanged += new System.EventHandler(this.TaxPanel_VisibleChanged);
            // 
            // TaxCancelButton
            // 
            this.TaxCancelButton.Location = new System.Drawing.Point(638, 286);
            this.TaxCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.TaxCancelButton.Name = "TaxCancelButton";
            this.TaxCancelButton.Size = new System.Drawing.Size(117, 43);
            this.TaxCancelButton.TabIndex = 3;
            this.TaxCancelButton.Text = "Cancel";
            this.TaxCancelButton.UseVisualStyleBackColor = true;
            this.TaxCancelButton.Click += new System.EventHandler(this.TaxCancelButton_Click);
            // 
            // TaxShowTax
            // 
            this.TaxShowTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxShowTax.Location = new System.Drawing.Point(498, 234);
            this.TaxShowTax.Margin = new System.Windows.Forms.Padding(4);
            this.TaxShowTax.Name = "TaxShowTax";
            this.TaxShowTax.Size = new System.Drawing.Size(257, 40);
            this.TaxShowTax.TabIndex = 1;
            this.TaxShowTax.Text = "";
            this.TaxShowTax.TextChanged += new System.EventHandler(this.TaxShowTax_TextChanged);
            // 
            // TaxSaveButton
            // 
            this.TaxSaveButton.Location = new System.Drawing.Point(498, 286);
            this.TaxSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.TaxSaveButton.Name = "TaxSaveButton";
            this.TaxSaveButton.Size = new System.Drawing.Size(117, 43);
            this.TaxSaveButton.TabIndex = 2;
            this.TaxSaveButton.Text = "Save";
            this.TaxSaveButton.UseVisualStyleBackColor = true;
            this.TaxSaveButton.Click += new System.EventHandler(this.TaxSaveButton_Click);
            // 
            // EmployeePanel
            // 
            this.EmployeePanel.BackColor = System.Drawing.Color.Transparent;
            this.EmployeePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmployeePanel.BackgroundImage")));
            this.EmployeePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmployeePanel.Controls.Add(this.EmpCancelButton);
            this.EmployeePanel.Controls.Add(this.EmpRemoveButton);
            this.EmployeePanel.Controls.Add(this.EmpLabelRole);
            this.EmployeePanel.Controls.Add(this.EmpErrorRichTextBox);
            this.EmployeePanel.Controls.Add(this.EmpShowName);
            this.EmployeePanel.Controls.Add(this.EmpLabelHours);
            this.EmployeePanel.Controls.Add(this.EmpLabelWage);
            this.EmployeePanel.Controls.Add(this.EmpLabelName);
            this.EmployeePanel.Controls.Add(this.EmpCashierRadioBtn);
            this.EmployeePanel.Controls.Add(this.EmpAdminRadioBtn);
            this.EmployeePanel.Controls.Add(this.EmpShowWage);
            this.EmployeePanel.Controls.Add(this.EmpShowHours);
            this.EmployeePanel.Controls.Add(this.EmpListBox);
            this.EmployeePanel.Controls.Add(this.EmpSaveButton);
            this.EmployeePanel.Location = new System.Drawing.Point(753, 147);
            this.EmployeePanel.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeePanel.Name = "EmployeePanel";
            this.EmployeePanel.Size = new System.Drawing.Size(840, 516);
            this.EmployeePanel.TabIndex = 4;
            this.EmployeePanel.Visible = false;
            // 
            // EmpCancelButton
            // 
            this.EmpCancelButton.Location = new System.Drawing.Point(516, 430);
            this.EmpCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.EmpCancelButton.Name = "EmpCancelButton";
            this.EmpCancelButton.Size = new System.Drawing.Size(100, 28);
            this.EmpCancelButton.TabIndex = 8;
            this.EmpCancelButton.Text = "Cancel";
            this.EmpCancelButton.UseVisualStyleBackColor = true;
            this.EmpCancelButton.Click += new System.EventHandler(this.EmpCancelButton_Click);
            // 
            // EmpRemoveButton
            // 
            this.EmpRemoveButton.Location = new System.Drawing.Point(394, 261);
            this.EmpRemoveButton.Margin = new System.Windows.Forms.Padding(4);
            this.EmpRemoveButton.Name = "EmpRemoveButton";
            this.EmpRemoveButton.Size = new System.Drawing.Size(95, 28);
            this.EmpRemoveButton.TabIndex = 7;
            this.EmpRemoveButton.Text = "Remove";
            this.EmpRemoveButton.UseVisualStyleBackColor = true;
            this.EmpRemoveButton.Click += new System.EventHandler(this.EmpRemoveButton_Click);
            // 
            // EmpLabelRole
            // 
            this.EmpLabelRole.AutoSize = true;
            this.EmpLabelRole.BackColor = System.Drawing.Color.Transparent;
            this.EmpLabelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLabelRole.Location = new System.Drawing.Point(215, 195);
            this.EmpLabelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpLabelRole.Name = "EmpLabelRole";
            this.EmpLabelRole.Size = new System.Drawing.Size(43, 20);
            this.EmpLabelRole.TabIndex = 15;
            this.EmpLabelRole.Text = "Role";
            // 
            // EmpErrorRichTextBox
            // 
            this.EmpErrorRichTextBox.Location = new System.Drawing.Point(237, 305);
            this.EmpErrorRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmpErrorRichTextBox.Name = "EmpErrorRichTextBox";
            this.EmpErrorRichTextBox.Size = new System.Drawing.Size(252, 109);
            this.EmpErrorRichTextBox.TabIndex = 17;
            this.EmpErrorRichTextBox.Text = "";
            this.EmpErrorRichTextBox.Visible = false;
            // 
            // EmpShowName
            // 
            this.EmpShowName.Location = new System.Drawing.Point(282, 82);
            this.EmpShowName.Margin = new System.Windows.Forms.Padding(4);
            this.EmpShowName.Name = "EmpShowName";
            this.EmpShowName.Size = new System.Drawing.Size(207, 26);
            this.EmpShowName.TabIndex = 1;
            this.EmpShowName.Text = "";
            this.EmpShowName.TextChanged += new System.EventHandler(this.EmpShowName_TextChanged);
            // 
            // EmpLabelHours
            // 
            this.EmpLabelHours.AutoSize = true;
            this.EmpLabelHours.BackColor = System.Drawing.Color.Transparent;
            this.EmpLabelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLabelHours.Location = new System.Drawing.Point(215, 128);
            this.EmpLabelHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpLabelHours.Name = "EmpLabelHours";
            this.EmpLabelHours.Size = new System.Drawing.Size(55, 20);
            this.EmpLabelHours.TabIndex = 14;
            this.EmpLabelHours.Text = "Hours";
            // 
            // EmpLabelWage
            // 
            this.EmpLabelWage.AutoSize = true;
            this.EmpLabelWage.BackColor = System.Drawing.Color.Transparent;
            this.EmpLabelWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLabelWage.Location = new System.Drawing.Point(215, 161);
            this.EmpLabelWage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpLabelWage.Name = "EmpLabelWage";
            this.EmpLabelWage.Size = new System.Drawing.Size(52, 20);
            this.EmpLabelWage.TabIndex = 13;
            this.EmpLabelWage.Text = "Wage";
            // 
            // EmpLabelName
            // 
            this.EmpLabelName.AutoSize = true;
            this.EmpLabelName.BackColor = System.Drawing.Color.Transparent;
            this.EmpLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLabelName.Location = new System.Drawing.Point(215, 88);
            this.EmpLabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpLabelName.Name = "EmpLabelName";
            this.EmpLabelName.Size = new System.Drawing.Size(53, 20);
            this.EmpLabelName.TabIndex = 12;
            this.EmpLabelName.Text = "Name";
            // 
            // EmpCashierRadioBtn
            // 
            this.EmpCashierRadioBtn.AutoSize = true;
            this.EmpCashierRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.EmpCashierRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpCashierRadioBtn.Location = new System.Drawing.Point(390, 195);
            this.EmpCashierRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EmpCashierRadioBtn.Name = "EmpCashierRadioBtn";
            this.EmpCashierRadioBtn.Size = new System.Drawing.Size(88, 24);
            this.EmpCashierRadioBtn.TabIndex = 5;
            this.EmpCashierRadioBtn.Text = "Cashier";
            this.EmpCashierRadioBtn.UseVisualStyleBackColor = false;
            // 
            // EmpAdminRadioBtn
            // 
            this.EmpAdminRadioBtn.AutoSize = true;
            this.EmpAdminRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.EmpAdminRadioBtn.Checked = true;
            this.EmpAdminRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAdminRadioBtn.Location = new System.Drawing.Point(300, 195);
            this.EmpAdminRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EmpAdminRadioBtn.Name = "EmpAdminRadioBtn";
            this.EmpAdminRadioBtn.Size = new System.Drawing.Size(77, 24);
            this.EmpAdminRadioBtn.TabIndex = 4;
            this.EmpAdminRadioBtn.TabStop = true;
            this.EmpAdminRadioBtn.Text = "Admin";
            this.EmpAdminRadioBtn.UseVisualStyleBackColor = false;
            // 
            // EmpShowWage
            // 
            this.EmpShowWage.Location = new System.Drawing.Point(282, 155);
            this.EmpShowWage.Margin = new System.Windows.Forms.Padding(4);
            this.EmpShowWage.Name = "EmpShowWage";
            this.EmpShowWage.Size = new System.Drawing.Size(207, 26);
            this.EmpShowWage.TabIndex = 3;
            this.EmpShowWage.Text = "";
            this.EmpShowWage.TextChanged += new System.EventHandler(this.EmpShowWage_TextChanged);
            // 
            // EmpShowHours
            // 
            this.EmpShowHours.Location = new System.Drawing.Point(282, 121);
            this.EmpShowHours.Margin = new System.Windows.Forms.Padding(4);
            this.EmpShowHours.Name = "EmpShowHours";
            this.EmpShowHours.Size = new System.Drawing.Size(207, 26);
            this.EmpShowHours.TabIndex = 2;
            this.EmpShowHours.Text = "";
            this.EmpShowHours.TextChanged += new System.EventHandler(this.EmpShowHours_TextChanged);
            // 
            // EmpListBox
            // 
            this.EmpListBox.FormattingEnabled = true;
            this.EmpListBox.ItemHeight = 16;
            this.EmpListBox.Location = new System.Drawing.Point(516, 82);
            this.EmpListBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmpListBox.Name = "EmpListBox";
            this.EmpListBox.Size = new System.Drawing.Size(276, 340);
            this.EmpListBox.TabIndex = 9;
            this.EmpListBox.SelectedIndexChanged += new System.EventHandler(this.EmpListBox_SelectedIndexChanged);
            // 
            // EmpSaveButton
            // 
            this.EmpSaveButton.Location = new System.Drawing.Point(286, 261);
            this.EmpSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.EmpSaveButton.Name = "EmpSaveButton";
            this.EmpSaveButton.Size = new System.Drawing.Size(95, 28);
            this.EmpSaveButton.TabIndex = 6;
            this.EmpSaveButton.Text = "Add";
            this.EmpSaveButton.UseVisualStyleBackColor = true;
            this.EmpSaveButton.Click += new System.EventHandler(this.EmpSave_Click);
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ItemsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ItemsPanel.BackgroundImage")));
            this.ItemsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ItemsPanel.Controls.Add(this.ItemLabelAmount);
            this.ItemsPanel.Controls.Add(this.ItemsRemoveButton);
            this.ItemsPanel.Controls.Add(this.ItemsCancelButton);
            this.ItemsPanel.Controls.Add(this.ItemsWeightRadioButton);
            this.ItemsPanel.Controls.Add(this.ItemsCountRadioButton);
            this.ItemsPanel.Controls.Add(this.ItemLabelStatus);
            this.ItemsPanel.Controls.Add(this.ItemsLabelId);
            this.ItemsPanel.Controls.Add(this.ItemsLabelPrice);
            this.ItemsPanel.Controls.Add(this.ItemsShowStatus);
            this.ItemsPanel.Controls.Add(this.ItemsShowId);
            this.ItemsPanel.Controls.Add(this.ItemsShowPrice);
            this.ItemsPanel.Controls.Add(this.ItemsErrorRichTextBox);
            this.ItemsPanel.Controls.Add(this.ItemsSaveButton);
            this.ItemsPanel.Controls.Add(this.ItemsShowName);
            this.ItemsPanel.Controls.Add(this.ItemsLabelName);
            this.ItemsPanel.Controls.Add(this.ItemsListBox);
            this.ItemsPanel.Location = new System.Drawing.Point(28, 205);
            this.ItemsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(840, 516);
            this.ItemsPanel.TabIndex = 5;
            this.ItemsPanel.Visible = false;
            // 
            // ItemLabelAmount
            // 
            this.ItemLabelAmount.AutoSize = true;
            this.ItemLabelAmount.BackColor = System.Drawing.Color.Transparent;
            this.ItemLabelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabelAmount.Location = new System.Drawing.Point(213, 225);
            this.ItemLabelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemLabelAmount.Name = "ItemLabelAmount";
            this.ItemLabelAmount.Size = new System.Drawing.Size(66, 20);
            this.ItemLabelAmount.TabIndex = 32;
            this.ItemLabelAmount.Text = "Amount";
            // 
            // ItemsRemoveButton
            // 
            this.ItemsRemoveButton.Location = new System.Drawing.Point(390, 293);
            this.ItemsRemoveButton.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsRemoveButton.Name = "ItemsRemoveButton";
            this.ItemsRemoveButton.Size = new System.Drawing.Size(99, 28);
            this.ItemsRemoveButton.TabIndex = 8;
            this.ItemsRemoveButton.Text = "Remove";
            this.ItemsRemoveButton.UseVisualStyleBackColor = true;
            this.ItemsRemoveButton.Click += new System.EventHandler(this.ItemsRemoveButton_Click);
            // 
            // ItemsCancelButton
            // 
            this.ItemsCancelButton.Location = new System.Drawing.Point(516, 430);
            this.ItemsCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsCancelButton.Name = "ItemsCancelButton";
            this.ItemsCancelButton.Size = new System.Drawing.Size(100, 28);
            this.ItemsCancelButton.TabIndex = 9;
            this.ItemsCancelButton.Text = "Cancel";
            this.ItemsCancelButton.UseVisualStyleBackColor = true;
            this.ItemsCancelButton.Click += new System.EventHandler(this.ItemsCancelButton_Click);
            // 
            // ItemsWeightRadioButton
            // 
            this.ItemsWeightRadioButton.AutoSize = true;
            this.ItemsWeightRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ItemsWeightRadioButton.Checked = true;
            this.ItemsWeightRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsWeightRadioButton.Location = new System.Drawing.Point(300, 225);
            this.ItemsWeightRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsWeightRadioButton.Name = "ItemsWeightRadioButton";
            this.ItemsWeightRadioButton.Size = new System.Drawing.Size(82, 24);
            this.ItemsWeightRadioButton.TabIndex = 5;
            this.ItemsWeightRadioButton.TabStop = true;
            this.ItemsWeightRadioButton.Text = "Weight";
            this.ItemsWeightRadioButton.UseVisualStyleBackColor = false;
            // 
            // ItemsCountRadioButton
            // 
            this.ItemsCountRadioButton.AutoSize = true;
            this.ItemsCountRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ItemsCountRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsCountRadioButton.Location = new System.Drawing.Point(415, 225);
            this.ItemsCountRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsCountRadioButton.Name = "ItemsCountRadioButton";
            this.ItemsCountRadioButton.Size = new System.Drawing.Size(74, 24);
            this.ItemsCountRadioButton.TabIndex = 6;
            this.ItemsCountRadioButton.Text = "Count";
            this.ItemsCountRadioButton.UseVisualStyleBackColor = false;
            // 
            // ItemLabelStatus
            // 
            this.ItemLabelStatus.AutoSize = true;
            this.ItemLabelStatus.BackColor = System.Drawing.Color.Transparent;
            this.ItemLabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabelStatus.Location = new System.Drawing.Point(213, 194);
            this.ItemLabelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemLabelStatus.Name = "ItemLabelStatus";
            this.ItemLabelStatus.Size = new System.Drawing.Size(57, 20);
            this.ItemLabelStatus.TabIndex = 31;
            this.ItemLabelStatus.Text = "Status";
            // 
            // ItemsLabelId
            // 
            this.ItemsLabelId.AutoSize = true;
            this.ItemsLabelId.BackColor = System.Drawing.Color.Transparent;
            this.ItemsLabelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsLabelId.Location = new System.Drawing.Point(213, 90);
            this.ItemsLabelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemsLabelId.Name = "ItemsLabelId";
            this.ItemsLabelId.Size = new System.Drawing.Size(22, 20);
            this.ItemsLabelId.TabIndex = 30;
            this.ItemsLabelId.Text = "Id";
            // 
            // ItemsLabelPrice
            // 
            this.ItemsLabelPrice.AutoSize = true;
            this.ItemsLabelPrice.BackColor = System.Drawing.Color.Transparent;
            this.ItemsLabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsLabelPrice.Location = new System.Drawing.Point(213, 160);
            this.ItemsLabelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemsLabelPrice.Name = "ItemsLabelPrice";
            this.ItemsLabelPrice.Size = new System.Drawing.Size(48, 20);
            this.ItemsLabelPrice.TabIndex = 28;
            this.ItemsLabelPrice.Text = "Price";
            // 
            // ItemsShowStatus
            // 
            this.ItemsShowStatus.Location = new System.Drawing.Point(282, 189);
            this.ItemsShowStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsShowStatus.Name = "ItemsShowStatus";
            this.ItemsShowStatus.Size = new System.Drawing.Size(207, 26);
            this.ItemsShowStatus.TabIndex = 4;
            this.ItemsShowStatus.Text = "";
            this.ItemsShowStatus.TextChanged += new System.EventHandler(this.ItemsShowStatus_TextChanged);
            // 
            // ItemsShowId
            // 
            this.ItemsShowId.Location = new System.Drawing.Point(282, 82);
            this.ItemsShowId.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsShowId.Name = "ItemsShowId";
            this.ItemsShowId.Size = new System.Drawing.Size(207, 26);
            this.ItemsShowId.TabIndex = 1;
            this.ItemsShowId.Text = "";
            this.ItemsShowId.TextChanged += new System.EventHandler(this.ItemsShowId_TextChanged);
            // 
            // ItemsShowPrice
            // 
            this.ItemsShowPrice.Location = new System.Drawing.Point(282, 155);
            this.ItemsShowPrice.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsShowPrice.Name = "ItemsShowPrice";
            this.ItemsShowPrice.Size = new System.Drawing.Size(207, 26);
            this.ItemsShowPrice.TabIndex = 3;
            this.ItemsShowPrice.Text = "";
            this.ItemsShowPrice.TextChanged += new System.EventHandler(this.ItemsShowPrice_TextChanged);
            // 
            // ItemsErrorRichTextBox
            // 
            this.ItemsErrorRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ItemsErrorRichTextBox.Location = new System.Drawing.Point(282, 339);
            this.ItemsErrorRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsErrorRichTextBox.Name = "ItemsErrorRichTextBox";
            this.ItemsErrorRichTextBox.Size = new System.Drawing.Size(207, 70);
            this.ItemsErrorRichTextBox.TabIndex = 22;
            this.ItemsErrorRichTextBox.Text = "";
            this.ItemsErrorRichTextBox.Visible = false;
            // 
            // ItemsSaveButton
            // 
            this.ItemsSaveButton.Location = new System.Drawing.Point(282, 293);
            this.ItemsSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsSaveButton.Name = "ItemsSaveButton";
            this.ItemsSaveButton.Size = new System.Drawing.Size(99, 28);
            this.ItemsSaveButton.TabIndex = 7;
            this.ItemsSaveButton.Text = "Add";
            this.ItemsSaveButton.UseVisualStyleBackColor = true;
            this.ItemsSaveButton.Click += new System.EventHandler(this.ItemsSaveButton_Click);
            // 
            // ItemsShowName
            // 
            this.ItemsShowName.Location = new System.Drawing.Point(282, 120);
            this.ItemsShowName.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsShowName.Name = "ItemsShowName";
            this.ItemsShowName.Size = new System.Drawing.Size(207, 26);
            this.ItemsShowName.TabIndex = 2;
            this.ItemsShowName.Text = "";
            // 
            // ItemsLabelName
            // 
            this.ItemsLabelName.AutoSize = true;
            this.ItemsLabelName.BackColor = System.Drawing.Color.Transparent;
            this.ItemsLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsLabelName.Location = new System.Drawing.Point(213, 126);
            this.ItemsLabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemsLabelName.Name = "ItemsLabelName";
            this.ItemsLabelName.Size = new System.Drawing.Size(53, 20);
            this.ItemsLabelName.TabIndex = 19;
            this.ItemsLabelName.Text = "Name";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(516, 82);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(276, 340);
            this.ItemsListBox.TabIndex = 10;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.Image = global::DigitCashier.Properties.Resources.Logout_Std;
            this.LogoutButton.ImageHover = global::DigitCashier.Properties.Resources.Logout_H;
            this.LogoutButton.ImageNormal = global::DigitCashier.Properties.Resources.Logout_Std;
            this.LogoutButton.Location = new System.Drawing.Point(1060, 15);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(288, 172);
            this.LogoutButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.TabStop = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click_1);
            // 
            // UpdateTaxButton
            // 
            this.UpdateTaxButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateTaxButton.Image = global::DigitCashier.Properties.Resources.Tax_Std;
            this.UpdateTaxButton.ImageHover = global::DigitCashier.Properties.Resources.Tax_H;
            this.UpdateTaxButton.ImageNormal = global::DigitCashier.Properties.Resources.Tax_Std;
            this.UpdateTaxButton.Location = new System.Drawing.Point(725, 15);
            this.UpdateTaxButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateTaxButton.Name = "UpdateTaxButton";
            this.UpdateTaxButton.Size = new System.Drawing.Size(288, 172);
            this.UpdateTaxButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpdateTaxButton.TabIndex = 8;
            this.UpdateTaxButton.TabStop = false;
            this.UpdateTaxButton.Click += new System.EventHandler(this.UpdateTaxButton_Click_1);
            // 
            // ItemsButton
            // 
            this.ItemsButton.BackColor = System.Drawing.Color.Transparent;
            this.ItemsButton.Image = global::DigitCashier.Properties.Resources.Items_Std;
            this.ItemsButton.ImageHover = global::DigitCashier.Properties.Resources.Items_H;
            this.ItemsButton.ImageNormal = global::DigitCashier.Properties.Resources.Items_Std;
            this.ItemsButton.Location = new System.Drawing.Point(407, 15);
            this.ItemsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ItemsButton.Name = "ItemsButton";
            this.ItemsButton.Size = new System.Drawing.Size(288, 172);
            this.ItemsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemsButton.TabIndex = 9;
            this.ItemsButton.TabStop = false;
            this.ItemsButton.Click += new System.EventHandler(this.ItemsButton_Click_1);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeButton.Image = global::DigitCashier.Properties.Resources.Emp_std;
            this.EmployeeButton.ImageHover = global::DigitCashier.Properties.Resources.Emp_H;
            this.EmployeeButton.ImageNormal = global::DigitCashier.Properties.Resources.Emp_std;
            this.EmployeeButton.InitialImage = global::DigitCashier.Properties.Resources.Emp_std;
            this.EmployeeButton.Location = new System.Drawing.Point(83, 15);
            this.EmployeeButton.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(288, 172);
            this.EmployeeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmployeeButton.TabIndex = 6;
            this.EmployeeButton.TabStop = false;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click_1);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::DigitCashier.Properties.Resources.Abstract_Background_with_Blue_Curves_Vector_Illustration;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1411, 826);
            this.Controls.Add(this.TaxPanel);
            this.Controls.Add(this.EmployeePanel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.UpdateTaxButton);
            this.Controls.Add(this.ItemsButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.ItemsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorForm_FormClosed);
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.TaxPanel.ResumeLayout(false);
            this.EmployeePanel.ResumeLayout(false);
            this.EmployeePanel.PerformLayout();
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateTaxButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel EmployeePanel;
        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.Panel TaxPanel;
        private System.Windows.Forms.Button EmpSaveButton;
        private System.Windows.Forms.ListBox EmpListBox;
        private System.Windows.Forms.RichTextBox EmpShowName;
        private System.Windows.Forms.RichTextBox EmpShowWage;
        private System.Windows.Forms.RichTextBox EmpShowHours;
        private System.Windows.Forms.RadioButton EmpCashierRadioBtn;
        private System.Windows.Forms.RadioButton EmpAdminRadioBtn;
        private System.Windows.Forms.Label EmpLabelHours;
        private System.Windows.Forms.Label EmpLabelWage;
        private System.Windows.Forms.Label EmpLabelName;
        private System.Windows.Forms.Label EmpLabelRole;
        private System.Windows.Forms.Button EmpRemoveButton;
        private System.Windows.Forms.RichTextBox EmpErrorRichTextBox;
        private System.Windows.Forms.Button EmpCancelButton;
        private System.Windows.Forms.RichTextBox ItemsErrorRichTextBox;
        private System.Windows.Forms.Button ItemsSaveButton;
        private System.Windows.Forms.RichTextBox ItemsShowName;
        private System.Windows.Forms.Label ItemsLabelName;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label ItemLabelStatus;
        private System.Windows.Forms.Label ItemsLabelId;
        private System.Windows.Forms.Label ItemsLabelPrice;
        private System.Windows.Forms.RichTextBox ItemsShowStatus;
        private System.Windows.Forms.RichTextBox ItemsShowId;
        private System.Windows.Forms.RichTextBox ItemsShowPrice;
        private System.Windows.Forms.RadioButton ItemsWeightRadioButton;
        private System.Windows.Forms.RadioButton ItemsCountRadioButton;
        private System.Windows.Forms.Button ItemsCancelButton;
        private System.Windows.Forms.Button ItemsRemoveButton;
        private System.Windows.Forms.RichTextBox TaxShowTax;
        private System.Windows.Forms.Button TaxSaveButton;
        private System.Windows.Forms.Button TaxCancelButton;
        private ImageButton.CustomImageButton EmployeeButton;
        private ImageButton.CustomImageButton LogoutButton;
        private ImageButton.CustomImageButton UpdateTaxButton;
        private ImageButton.CustomImageButton ItemsButton;
        private System.Windows.Forms.Label ItemLabelAmount;
    }
}