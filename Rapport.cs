using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace DigitCashier
{
    public partial class Rapport : Form
    {
        public Rapport()
        {
            InitializeComponent();
        }

        public void SkrivUtRapport(List<Vara> varor, int tPris, int tVaror)
        {
            const string format = "{0,-8} {1,-11} {2,0}";
            textboxReport.ReadOnly = true;
            textboxReport.Text += DateTime.Now.ToString() + Environment.NewLine;
            textboxReport.Text += Environment.NewLine;
            textboxReport.Text += (String.Format(format, "Name", "Price","Excl. tax", "Status")) + Environment.NewLine;
            foreach (Vara a in varor)
            {
                textboxReport.Text += (String.Format(format, a.Namn, a.Pris.ToString(), (a.Pris * (1 - Inloggning.moms)).ToString(), a.LagerStatus.ToString()))+ Environment.NewLine;
            }
            textboxReport.Text += Environment.NewLine;
            textboxReport.Text += "Total number of items sold: ";
            textboxReport.Text += tVaror.ToString() + " items" + Environment.NewLine;
            textboxReport.Text += "Total sales in SEK: ";
            textboxReport.Text += tPris.ToString() + " SEK" + Environment.NewLine;
            
        }

        private void Rapport_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hide(); // Kommentera bort koden nedan då den inte skall finnas...

            var dialogResult = MessageBox.Show(this, "Would you like to reset the report?", "Report", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                Forsaljningsrapport Rapport = new Forsaljningsrapport();
                Rapport.ResetReport();
                Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                Hide();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Rapport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inloggning.FormLogIn();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        int year = DateTime.Now.Year;
        string month;
        private void button1_Click(object sender, EventArgs e)
        {
            year++;
            textBox1.Text = year.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            year--;
            textBox1.Text = year.ToString();
        }

        private void January_CheckedChanged(object sender, EventArgs e)
        {
            month = "January";
        }

        private void February_CheckedChanged(object sender, EventArgs e)
        {
            month = "February";
        }

        private void Mars_CheckedChanged(object sender, EventArgs e)
        {
            month = "Mars";
        }

        private void April_CheckedChanged(object sender, EventArgs e)
        {
            month = "April";
        }

        private void May_CheckedChanged(object sender, EventArgs e)
        {
            month = "May";
        }

        private void June_CheckedChanged(object sender, EventArgs e)
        {
            month = "June";
        }

        private void July_CheckedChanged(object sender, EventArgs e)
        {
            month = "July";
        }

        private void August_CheckedChanged(object sender, EventArgs e)
        {
            month = "August";
        }

        private void September_CheckedChanged(object sender, EventArgs e)
        {
            month = "September";
        }

        private void October_CheckedChanged(object sender, EventArgs e)
        {
            month = "October";
        }

        private void November_CheckedChanged(object sender, EventArgs e)
        {
            month = "November";
        }

        private void December_CheckedChanged(object sender, EventArgs e)
        {
            month = "December";
        }
    }
}
