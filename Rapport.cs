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
    }
}
