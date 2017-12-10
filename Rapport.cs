using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            textBox1.ReadOnly = true;
            textBox1.Text += DateTime.Now.ToString() + Environment.NewLine;
            textBox1.Text += " " + Environment.NewLine;
            textBox1.Text += "Name" + "\t" + "Price" + "\t" + "Excl. tax" + "\t"+ "  " + "Status" + Environment.NewLine;
            foreach (Vara a in varor)
            {
                textBox1.Text += a.Namn;
                textBox1.Text += "\t"+ a.Pris.ToString();
                textBox1.Text += "\t" + (a.Pris * (1 - Inloggning.moms)).ToString();
                textBox1.Text += "\t" + "  " + a.LagerStatus.ToString() + Environment.NewLine;
            }
            textBox1.Text += " " + Environment.NewLine;
            textBox1.Text += "Total number of items sold: ";
            textBox1.Text += tVaror.ToString() + " items" + Environment.NewLine;
            textBox1.Text += "Total sales in SEK: ";
            textBox1.Text += tPris.ToString() + " SEK" + Environment.NewLine;
        }

        private void Rapport_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show(this, "Would you like to reset the report?", "Report", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if(dialogResult == DialogResult.Yes)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
