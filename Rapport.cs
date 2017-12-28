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
        int totalPrice;
        int totalItems;
        string rapport = AppDomain.CurrentDomain.BaseDirectory;
        int quantityItems;
        int cost;
        int status;
        string employeeName;
        int hoursWorked;
        int totalHoursWorked;

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
            textboxReportEmp.Clear();
            textboxReportTotal.Clear();
            textboxReport.Clear();
            textboxReportEmpTotal.Clear();
            SkrivUtRapport(Inloggning.varuLista, TotalPris(), TotalVaror());
        }

        private void Rapport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();           
            Inloggning.FormLogIn();
        }

        public void SkrivUtRapport(List<Vara> varor, int tPris, int tVaror)
        {
            if (Directory.Exists(rapport + "\\Rapport\\" + year + "\\" + month + "\\") == false)
            {
                MessageBox.Show("There is no data saved for this month.");
                return;
            }

            const string format = "{0,-10} {1,-11} {2,-13} {3,5}";
            textboxReport.Text += Environment.NewLine;
            textboxReportHead.Text = (String.Format(format, "Item Name", "Purchased", "Sales Amount", "Status"));

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
                    int y = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        y += Convert.ToInt32(line);
                        
                    }
                    quantityItems = y;
                }

                foreach (Vara b in Inloggning.varuLista)
                {
                    if (b.Namn == fileName)
                    {
                        cost = quantityItems * b.Pris;
                    }
                }
                foreach (Vara a in Inloggning.varuLista)
                {
                    status = a.LagerStatus;
                }
                textboxReport.Text += (String.Format(format, fileName, quantityItems, cost, status)) + Environment.NewLine;
            }
            textboxReportTotal.Text += ("____________________________________________") + Environment.NewLine;
            textboxReportTotal.Text += (String.Format(format, "Total", tVaror.ToString(), tPris.ToString(), " "));
            EmployeeDetails();

        }


        private string[] SoldItems()
        {
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

        private void January_Click(object sender, EventArgs e)
        {
            month = 1;
            PrintReport();
        }

        private void February_Click(object sender, EventArgs e)
        {
            month = 2;
            PrintReport();
        }

        private void March_Click(object sender, EventArgs e)
        {
            month = 3;
            PrintReport();
        }

        private void April_Click(object sender, EventArgs e)
        {
            month = 4;
            PrintReport();
        }

        private void May_Click(object sender, EventArgs e)
        {
            month = 5;
            PrintReport();
        }

        private void June_Click(object sender, EventArgs e)
        {
            month = 6;
            PrintReport();
        }

        private void July_Click(object sender, EventArgs e)
        {
            month = 7;
            PrintReport();
        }

        private void August_Click(object sender, EventArgs e)
        {
            month = 8;
            PrintReport();
        }

        private void September_Click(object sender, EventArgs e)
        {
            month = 9;
            PrintReport();
        }

        private void October_Click(object sender, EventArgs e)
        {
            month = 10;
            PrintReport();
        }

        private void November_Click(object sender, EventArgs e)
        {
            month = 11;
            PrintReport();
        }

        private void December_Click(object sender, EventArgs e)
        {
            month = 12;
            PrintReport();
        }

        #endregion


        int TotalPris()
        {
            totalPrice = 0;
            if ((File.Exists(rapport + "\\Rapport\\" + year + "\\\\" + month + "\\TotalPris.txt")) == true)
            {
                using (StreamReader reader = new StreamReader(rapport + "\\Rapport\\" + year + "\\\\" + month + "\\TotalPris.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int y = Convert.ToInt32(line);
                        totalPrice += y;
                    }
                }
            }
            return totalPrice;
        }

        int TotalVaror()
        {
            totalItems = 0;
            if ((File.Exists(rapport + "\\Rapport\\" + year + "\\\\" + month + "\\TotalaVaror.txt")) == true)
            {
                using (StreamReader reader = new StreamReader(rapport + "\\Rapport\\" + year + "\\\\" + month + "\\TotalaVaror.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int y = Convert.ToInt32(line);
                        totalItems += y;
                    }
                }
            }
            return totalItems;
        }

        void EmployeeDetails()
        {
            const string format = "{0,-18} {1,-12}";
            textboxReportHeadEmp.Text = (String.Format(format, "Employee Name", "Hours")) + Environment.NewLine;
            AdministratorForm af = new AdministratorForm();

            foreach (string file in af.ListaAnstallda())
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    employeeName = reader.ReadLine();
                    hoursWorked = Int32.Parse(reader.ReadLine());
                }
                totalHoursWorked += hoursWorked;
                textboxReportEmp.Text += (String.Format(format, employeeName, hoursWorked)) + Environment.NewLine;               
            }
            textboxReportEmpTotal.Text += ("____________________________________________") + Environment.NewLine;
            textboxReportEmpTotal.Text += (String.Format(format, "Total", totalHoursWorked));
        }
    }
}
