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
        private string filNamn = null;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filNamn)) // Om filNamn eller null eller tom
                return; // Avsluta metoden

            File.WriteAllText(filNamn, textBox1.Text); // Om filen redan finns skrivs den över
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // OK står för Öppna i dialogrutan
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName); // Läser upp allt i vald fil och visar det i textboxen
                filNamn = openFileDialog1.FileName; // FileName är filen som är vald
            }
        }
    }
}
