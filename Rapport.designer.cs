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
            this.SuspendLayout();
            // 
            // textboxReport
            // 
            this.textboxReport.BackColor = System.Drawing.Color.Silver;
            this.textboxReport.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxReport.Location = new System.Drawing.Point(199, 30);
            this.textboxReport.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textboxReport.Multiline = true;
            this.textboxReport.Name = "textboxReport";
            this.textboxReport.Size = new System.Drawing.Size(825, 633);
            this.textboxReport.TabIndex = 0;
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DigitCashier.Properties.Resources.Abstract_Background_with_Blue_Curves_Vector_Illustration;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 862);
            this.Controls.Add(this.textboxReport);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Rapport";
            this.ShowIcon = false;
            this.Text = "Rapport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rapport_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rapport_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxReport;
    }
}