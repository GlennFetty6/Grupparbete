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
            if (string.IsNullOrEmpty(fileName)) // Om filNamn är null eller tom
                return; // Avsluta metoden

            File.WriteAllText(fileName, textBox.Text); // Om filen redan finns skrivs den över
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) // OK står för Öppna i dialogrutan
            {
                textBox.ReadOnly = false; // Ändring tillåtet
                textBox.Text = File.ReadAllText(openFileDialog.FileName); // Läser upp allt i vald fil och visar det i textboxen
                fileName = openFileDialog.FileName; // FileName är filen som är vald
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e) // Om man trycker på X sända man tillbaka till inloggning
        {
            Hide(); // AdminForm göms
            Inloggning.FormLogIn(); // FormLogIn öppnas
        }
    }
}
