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
        string employeeName;
        int hoursWorked;

        public Rapport()
        {
            InitializeComponent();
        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            textBox1.Text = year.ToString();
        }

        void PrintReport()
        {
            textboxReport.Clear();
            textboxReportHead.Clear();
            SkrivUtRapport(Inloggning.varuLista, TotalPris(), TotalVaror());
        }

        private void Rapport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Inloggning.FormLogIn();
        }

        public void SkrivUtRapport(List<Vara> varor, int tPris, int tVaror)
        {
            const string format = "{0,-13} {1,-15} {2,0}";
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
                textboxReport.Text += (String.Format(format, fileName, antal, cost)) + Environment.NewLine;
            }

            textboxReportTotal.Text += (String.Format(format, "Total", tVaror.ToString(), tPris.ToString()));
            EmployeeDetails();
        }


        private string[] SoldItems()
        {
            if (Directory.Exists(rapport + "\\Rapport\\" + year + "\\\\" + month + "\\") == false)
            {
                Console.WriteLine("HEJHEJ");
                MessageBox.Show("There is no record of data saved for this month");
                return null;
            }
            string[] sold;
            sold = Directory.GetFiles(rapport + "\\Rapport\\" + year + "\\\\" + month);
            return sold;
        }


        #region Button Months

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
        #endregion


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

        void EmployeeDetails()
        {
            const string format = "{0,-18} {1,-12}";
            textboxReportHeadEmp.Text += (String.Format(format, "Employee Name", "Hours")) + Environment.NewLine;
            AdministratorForm af = new AdministratorForm();

            foreach (string file in af.ListaAnstallda())
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    employeeName = reader.ReadLine();
                    hoursWorked = Int32.Parse(reader.ReadLine());
                }
                textboxReportEmp.Text += (String.Format(format, employeeName, hoursWorked)) + Environment.NewLine;
            }
        }
    }
}
