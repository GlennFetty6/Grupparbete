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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            
        }

        public void SkrivUtRapport(List<Vara> varor, int tPris, int tVaror)
        {
            textBox1.Enabled = false;
            textBox1.Text = "Rapport" + Environment.NewLine;
            textBox1.Text += DateTime.Now.ToString() + Environment.NewLine;

            foreach (Vara a in varor)
            {
                textBox1.Text += a.Namn + "   ";
                textBox1.Text += a.Pris.ToString() + "  ";
                textBox1.Text += (a.Pris * (1 - Inloggning.moms)).ToString () + "  ";
                textBox1.Text += a.LagerStatus.ToString() + Environment.NewLine;
               // Console.WriteLine(String.Format(format, a.Namn, a.Pris, (a.Pris * (1 - Inloggning.moms)), a.LagerStatus));
            }

            textBox1.Text += "Totalt antal sålda varor är ";
            textBox1.Text += tVaror.ToString() + Environment.NewLine;
            textBox1.Text += "Totala försäljningssumman är ";
            textBox1.Text += tPris.ToString() + Environment.NewLine;


        }

        
    }
}
