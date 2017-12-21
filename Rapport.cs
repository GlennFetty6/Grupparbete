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
using System.IO;

namespace DigitCashier
{
    public partial class Rapport : Form
    {
        int priset;
        int varor;
        string rapport = AppDomain.CurrentDomain.BaseDirectory;
        int antal;
        int cost;

        public Rapport()
        {
            InitializeComponent();
        }

        public void SkrivUtRapport(List<Vara> varor, int tPris, int tVaror)
        {
            const string format = "{0,-13} {1,-15} {2,0}";
            textboxReport.ReadOnly = true;
            textboxReport.Text += Environment.NewLine;
            textboxReportHead.Text = (String.Format(format, "Item Name", "Quantity", "Amount"));
            foreach (string s in SoldItems())
            {
                string fileName = Path.GetFileNameWithoutExtension(s); // Tar in filnamn utan endelsen .txt
                if (fileName == "TotalaVaror" || fileName == "TotalPris")
                {
                    continue;
                }             
                    
                    using (StreamReader reader = new StreamReader(s))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            int y = Convert.ToInt32(line);
                            antal += y;
                        }
                    }

                    foreach (Vara b in Inloggning.varuLista)
                    {
                        if (b.Namn == fileName)
                        {
                            cost = antal * b.Pris;
                        }
                    }
                textboxReport.Text += (String.Format(format, fileName , antal , cost)) + Environment.NewLine;
            }

            textboxReport.Text += Environment.NewLine;
            textboxReport.Text += (String.Format(format, "Total", tVaror.ToString(), tPris.ToString()));
        }


        private void Rapport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Inloggning.FormLogIn();
        }

        int year = DateTime.Now.Year;
        int month;

        private void button1_Click(object sender, EventArgs e)
        {
            year--;
            textBox1.Text = year.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            year++;
            textBox1.Text = year.ToString();
        }

        private void January_CheckedChanged(object sender, EventArgs e)
        {           
            month = 1;
            PrintReport();
        }

        private void February_CheckedChanged(object sender, EventArgs e)
        {
            month = 2;
            PrintReport();
        }

        private void Mars_CheckedChanged(object sender, EventArgs e)
        {
            month = 3;
            PrintReport();
        }

        private void April_CheckedChanged(object sender, EventArgs e)
        {
            month = 4;
            PrintReport();
        }

        private void May_CheckedChanged(object sender, EventArgs e)
        {
            month = 5;
            PrintReport();
        }

        private void June_CheckedChanged(object sender, EventArgs e)
        {
            month = 6;
            PrintReport();
        }

        private void July_CheckedChanged(object sender, EventArgs e)
        {
            month = 7;
            PrintReport();
        }

        private void August_CheckedChanged(object sender, EventArgs e)
        {
            month = 8;
            PrintReport();
        }

        private void September_CheckedChanged(object sender, EventArgs e)
        {
            month = 9;
            PrintReport();
        }

        private void October_CheckedChanged(object sender, EventArgs e)
        {
            month = 10;
            PrintReport();
        }

        private void November_CheckedChanged(object sender, EventArgs e)
        {
            month = 11;
            PrintReport();
        }

        private void December_CheckedChanged(object sender, EventArgs e)
        {
            month = 12;
            PrintReport();
        }

        int TotalPris()
        {
            priset = 0;
            if ((File.Exists(rapport + "\\Rapport\\" + year + "\\\\" + month + "\\TotalPris.txt")) == true)
            {
                using (StreamReader reader = new StreamReader(rapport + "\\Rapport\\" + year + "\\\\" + month + "\\TotalPris.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int y = Convert.ToInt32(line);
                        priset += y;
                    }
                }
            }
            return priset;
        }

        int TotalVaror()
        {
            varor = 0;
            if ((File.Exists(rapport + "\\Rapport\\" + year + "\\\\" + month + "\\TotalaVaror.txt")) == true)
            {
                using (StreamReader reader = new StreamReader(rapport + "\\Rapport\\" + year + "\\\\" + month + "\\TotalaVaror.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int y = Convert.ToInt32(line);
                        varor += y;
                    }
                }
            }
            return varor;
        }
        void AnstalldaInfo()
        {
            AdministratorForm af = new AdministratorForm();
            //Anstallda ans = new Anstallda();
            int i = 1;

            foreach (string file in af.ListaAnstallda())
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string anstalldNamn = reader.ReadLine();
                    int arbTimmar = Int32.Parse(reader.ReadLine());
                    i++;
                }
            }
        }

        void PrintReport()
        {
            textboxReport.Clear();
            textboxReportHead.Clear();
            SkrivUtRapport(Inloggning.varuLista, TotalPris(), TotalVaror());
        }

        private string[] SoldItems()
        {
            string[] sold;
            sold = Directory.GetFiles(rapport + "\\Rapport\\" + year + "\\\\"+ month);
            return sold;
        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            textBox1.Text = year.ToString();
        }
    }
}
