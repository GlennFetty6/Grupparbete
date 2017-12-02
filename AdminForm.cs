using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitCashier
{
    public partial class AdminForm : Form
    {
        private string fileName = null;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            textBox.ReadOnly = true; // Ändring ej tillåtet
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide(); // Göm AdminForm
            Inloggning.FormLogIn(); // Starta Login
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(@"C:\Users\Ella\Desktop\DigitCashierUI\DigitCashier\bin\Debug\Anstallda")) // Om filNamn är null eller tom
                return; // Avsluta metoden

            File.WriteAllText(@"C:\Users\Ella\Desktop\DigitCashierUI\DigitCashier\bin\Debug\Anstallda", textBox.Text); // Om filen redan finns skrivs den över
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) // OK står för Öppna i dialogrutan
            {
                textBox.Text += "Name" + "\t" + "Hours" + "\t" + "Role" + "\t" + "Wage" + "\t" + Environment.NewLine;
                textBox.Text += Environment.NewLine + File.ReadAllText(openFileDialog.FileName); // Läser upp allt i vald fil och visar det i textboxen
                fileName = openFileDialog.FileName; // FileName är filen som är vald
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e) // Om man trycker på X sända man tillbaka till inloggning
        {
            Hide(); // AdminForm göms
            Inloggning.FormLogIn(); // FormLogIn öppnas
        }

        private void viewEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// Visar bara notepad och inte i textboxen
            //System.Diagnostics.Process.Start(@"C:\Users\Ella\Desktop\DigitCashierUI\DigitCashier\bin\Debug\Anstallda");
            textBox.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK) // OK står för Öppna i dialogrutan
            {
                textBox.Text += "Name" + "\t" + "Hours" + "\t" + "Role" + "\t" + "Wage" + "\t" + Environment.NewLine;
                textBox.Text += Environment.NewLine + File.ReadAllText(openFileDialog.FileName); // Läser upp allt i vald fil och visar det i textboxen
                fileName = openFileDialog.FileName; // FileName är filen som är vald
            }
        }
    }
}
