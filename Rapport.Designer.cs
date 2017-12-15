namespace DigitCashier
{
    partial class Rapport
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
            this.textboxReport = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textboxReport
            // 
            this.textboxReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxReport.BackColor = System.Drawing.Color.Silver;
            this.textboxReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxReport.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textboxReport.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxReport.Location = new System.Drawing.Point(189, 0);
            this.textboxReport.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textboxReport.Multiline = true;
            this.textboxReport.Name = "textboxReport";
            this.textboxReport.ReadOnly = true;
            this.textboxReport.Size = new System.Drawing.Size(605, 948);
            this.textboxReport.TabIndex = 0;
            this.textboxReport.TabStop = false;
            this.textboxReport.Text = "\r\n\r\nSales Report\r\n";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(790, 948);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textboxReport);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Rapport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rapport_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rapport_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxReport;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button btnPrint;
    }
}