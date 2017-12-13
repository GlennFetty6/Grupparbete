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

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e) // Om man trycker på X sända man tillbaka till inloggning
        {
            Hide(); // AdminForm göms
            Inloggning.FormLogIn(); // FormLogIn öppnas
        }

        private void viewAllItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void quitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide(); // Göm AdminForm
            Inloggning.FormLogIn(); // Starta Login
        }

        private void createEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.ReadOnly = false;
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.state = 1;
            newEmployee.Show();  
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

        private void toolStripComboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var anstalld = toolStripComboBox2.SelectedText;
                ShowWorker(anstalld);
            }
        }

        private void FillMenus()
        {
            MenuChangeItemComboBox4.Items.Clear();
            MenuRemoveItemComboBox.Items.Clear();

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

            foreach( Vara a in Inloggning.varuLista)
            {
                MenuChangeItemComboBox4.Items.Add(a.Namn);
                MenuRemoveItemComboBox.Items.Add(a.Namn);
            }


        }

        private void employeeToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            //FillMenus();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxAmount.Text = "0";
            panel2.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Inloggning.varuLista.Add(new Vara(textboxName.Text,int.Parse(textboxPrice.Text), int.Parse(TextBoxCategory.Text), int.Parse(TextBoxID.Text), int.Parse(TextBoxStatus.Text), int.Parse(TextBoxAmount.Text)));
            // Inloggning.varuLista.Add(new Vara(namn, pris, kategori, idNr, lagerAntal, 0));// Ny vara läggs till i varuLista
            panel2.Hide();
        }


        private void menuToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            FillMenus();
        }

        private void MenuChangeItemComboBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var item = MenuChangeItemComboBox4.SelectedText;
                ChangeItemDetails(item);
            }
        }

        private void ChangeItemDetails(string itemName)
        {

            panel2.Show();
            
            foreach(Vara a in Inloggning.varuLista)
            {
                if(a.Namn == itemName)
                {
                    textboxName.Text = a.Namn;
                    textboxPrice.Text = a.Pris.ToString();
                    TextBoxAmount.Text = "0";
                    TextBoxCategory.Text = a.Kategori.ToString();
                    TextBoxID.Text = a.Id.ToString();
                    TextBoxStatus.Text = a.LagerStatus.ToString();
                }
            }
        }

        Vara remove;

        private void RemoveItem(string itemName)
        {

            foreach(Vara a in Inloggning.varuLista)
            {
                if(a.Namn == itemName)
                {
                    remove = a;
                }
            }

            if (Inloggning.varuLista.Contains(remove))
            {
                Inloggning.varuLista.Remove(remove);
            }

            menuToolStripMenuItem.HideDropDown();
            MenuRemoveItemComboBox.SelectedItem = null;
        }

        private void MenuRemoveItemComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var item = MenuRemoveItemComboBox.Text;
                RemoveItem(item);
            }
        }
    }
}
