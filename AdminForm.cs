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
        string malMapp = AppDomain.CurrentDomain.BaseDirectory; //Tar fram den mapp .exe körs ifrån. På det viset vi kör programmet är denna map debug.

        int state;

        private string fileEmp = null;
        private string fileItem = null; // Komma på ett bra sätt att ändra...
        public AdminForm()
        {
            InitializeComponent();
            SaveChangesBtn.Hide();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e) // Om man trycker på X sända man tillbaka till inloggning
        {
            Hide(); // AdminForm göms
            Inloggning.FormLogIn(); // FormLogIn öppnas
        }

        private void changeEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChangesBtn.Show();
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
            SaveChangesBtn.Hide();
            textBox.Clear();
            textBoxHeading.Clear();
            textBox.ReadOnly = true;
            textBoxHeading.Text = "Name" + "\t" + "  " + "Price" + "\t" + "Tax" + "\t" + "Status";

            foreach (Vara a in Inloggning.varuLista)
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Regular);
                textBox.Text += a.Namn;
                textBox.Text += "\t" + "  " + a.Pris.ToString();
                textBox.Text += "\t" + (a.Pris * (1 - Inloggning.moms)).ToString();
                textBox.Text += "\t" + a.LagerStatus.ToString() + Environment.NewLine;
            }
        }

        private void ChangeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChangesBtn.Hide();
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
            SaveChangesBtn.Hide();
            textBox.ReadOnly = false;
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.state = 1;
            newEmployee.Show();  
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileEmp)) // Om filNamn är null eller tom
                return; // Avsluta metoden

            File.WriteAllText(fileEmp, textBox.Text); // Om filen redan finns skrivs den över
        }


        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
    
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_Click_1(object sender, EventArgs e)
        {
           // var hej = toolStripComboBox2.SelectedText;

           // ShowWorker(hej);
        }

        private void ShowWorker(string name)
        {
            textBox.ReadOnly = true;
            textBox.Clear();
            string anstalldNamn;
            int arbTimmar;
            string befattning;
            int lon;

            if (File.Exists(malMapp + "\\Anstallda\\" + name) == true)
            {

                using (StreamReader reader = new StreamReader(malMapp + "\\Anstallda\\" + name)) // Läser upp informationen om den angivna anställda.
                {                 
                    anstalldNamn = reader.ReadLine();
                    arbTimmar = Int32.Parse(reader.ReadLine());
                    befattning = reader.ReadLine();
                    lon = Int32.Parse(reader.ReadLine());
                }

                textBoxHeading .Text = "Name" + "\t" + "\t" + "Hours" + "\t" + "\t" + "Role" + "\t" + "\t" + "Wage";
                textBox.Text += anstalldNamn + "\t" + arbTimmar + "\t" + "\t" + befattning + "\t" + lon;

            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                var hej = toolStripComboBox2.SelectedText;
                ShowWorker(hej);
            }
        }

        private void FillMenus()
        {
            toolStripComboBox2.Items.Clear();
            toolStripComboBox3.Items.Clear();
            toolStripComboBox1.Items.Clear();
            Anstallda ans = new Anstallda();
            var hej = ans.ListaAnstallda();

            foreach (string t in hej)
            {
                toolStripComboBox2.Items.Add(Path.GetFileName(t));
                toolStripComboBox3.Items.Add(Path.GetFileName(t));
                toolStripComboBox1.Items.Add(Path.GetFileName(t));

            }
        }

        private void employeeToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            FillMenus();
        }

        private void toolStripComboBox3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var hej3 = toolStripComboBox1.SelectedText;
                ChangeWorker(hej3);
            }
        }

        private void toolStripComboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var hej2 = toolStripComboBox3.SelectedText;
                RemoveWorker(hej2);
            }
        }

        private void RemoveWorker(string name)
        {
            File.Delete(malMapp + "\\Anstallda\\" + name + ".txt");
            Console.WriteLine("{0} är sparkad.", name);
        }

        private void ChangeWorker(string name)
        {
            string anstalldNamn;
            int arbTimmar;
            string befattning;
            int lon;

            using (StreamReader reader = new StreamReader(malMapp + "\\Anstallda\\" + name)) // Läser upp informationen om den angivna anställda.
            {
                anstalldNamn = reader.ReadLine();
                arbTimmar = Int32.Parse(reader.ReadLine());
                befattning = reader.ReadLine();
                lon = Int32.Parse(reader.ReadLine());
            }
                NewEmployee ne = new NewEmployee();
                ne.ChangeEmp(anstalldNamn, arbTimmar, befattning, lon);
                ne.ShowDialog();
        }

        private void uppdateraMomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            textBox1.Text = Inloggning.moms.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inloggning.moms = float.Parse(textBox1.Text);
            panel1.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float nr;
            if(float.TryParse(textBox1.Text, out nr) == false)
            {
                textBox1.Text = null;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRole_Click(object sender, EventArgs e)
        {

        }

        private void AddItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = 1;
            panel2.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(state == 1)
            {
                Inloggning.varuLista.Add(new Vara(textboxName.Text,int.Parse(textboxPrice.Text), int.Parse(Category.Text), int.Parse(ID.Text), int.Parse(Status.Text), int.Parse(Amount.Text)));
               // Inloggning.varuLista.Add(new Vara(namn, pris, kategori, idNr, lagerAntal, 0));// Ny vara läggs till i varuLista
            }
        }
    }
}
