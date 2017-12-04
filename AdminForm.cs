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
        private string fileEmp = null;
        private string fileItem = null; // Komma på ett bra sätt att ändra...

        public AdminForm()
        {
            InitializeComponent();
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileEmp)) // Om filNamn är null eller tom
                return; // Avsluta metoden

            File.WriteAllText(fileEmp, textBox.Text); // Om filen redan finns skrivs den över
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

            textBox.ReadOnly = true;
            textBox.Clear();
            textBoxHeading.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK) // OK står för Öppna i dialogrutan
            {
                textBoxHeading.Text += "Name" + "\t" + "Hours" + "\t" + "Role" + "\t" + "Wage" + "\t";
                textBox.Text += File.ReadAllText(openFileDialog.FileName); // Läser upp allt i vald fil och visar det i textboxen
                fileEmp = openFileDialog.FileName; // FileName är filen som är vald
            }
        }

        private void changeEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.ReadOnly = false;
            textBoxHeading.Clear();
            textBox.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK) // OK står för Öppna i dialogrutan
            {
                textBoxHeading.Text += "Name" + "\t" + "Hours" + "\t" + "Role" + "\t" + "Wage" + "\t";
                textBox.Text += File.ReadAllText(openFileDialog.FileName); // Läser upp allt i vald fil och visar det i textboxen
                fileEmp = openFileDialog.FileName; // FileEmp är filen som är vald                
            }
        }

        private void viewAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            textBoxHeading.Clear();
            textBox.ReadOnly = true;
            textBoxHeading.Text = "Name" + "\t" + "Price" + "\t" + "Tax" + "\t" + "Status";

            foreach (Vara a in Inloggning.varuLista)
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Regular);
                textBox.Text += a.Namn;
                textBox.Text += "\t" + a.Pris.ToString();
                textBox.Text += "\t" + (a.Pris * (1 - Inloggning.moms)).ToString();
                textBox.Text += "\t" + a.LagerStatus.ToString() + Environment.NewLine;
            }
        }

        private void ChangeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.ReadOnly = false;
            textBoxHeading.Clear();
            textBox.Clear();
            textBoxHeading.Text = "Name" + "\t" + "Price" + "\t" + "Tax" + "\t" + "Status";
            foreach (Vara a in Inloggning.varuLista)
            {
                textBox.Text += a.Namn;
                textBox.Text += "\t" + a.Pris.ToString();
                textBox.Text += "\t" + (a.Pris * (1 - Inloggning.moms)).ToString();
                textBox.Text += "\t" + a.LagerStatus.ToString() + Environment.NewLine;
            }
        }

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide(); // Göm AdminForm
            Inloggning.FormLogIn(); // Starta Login
        }

        private void createEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.ReadOnly = false;
            textBoxHeading.Text += "Name" + "\t" + "Hours" + "\t" + "Role" + "\t" + "Wage" + "\t";            
        }
    }
}
