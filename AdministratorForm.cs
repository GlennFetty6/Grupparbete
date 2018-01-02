using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DigitCashier
{
    public partial class AdministratorForm : Form
    {

        string malMapp = AppDomain.CurrentDomain.BaseDirectory; //Tar fram den mapp .exe körs ifrån. På det viset vi kör programmet är denna map debug.

        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1080, 715);
            this.StartPosition = FormStartPosition.CenterScreen;

            ItemsPanel.Size = new Size(910, 464);
            EmployeePanel.Size = new Size(910, 464);
            TaxPanel.Size = new Size(910, 464);
            ItemsPanel.Location = new Point(78, 161);
            EmployeePanel.Location = new Point(78, 161);
            TaxPanel.Location = new Point(78, 161);
            ShowIcon = true;
        
            EmpUpdateList();
            ItemUpdateList();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #region MainMenu

        private void EmployeeButton_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Employee");
            EmployeePanel.SuspendLayout();
            ItemsPanel.SuspendLayout();
            TaxPanel.SuspendLayout();

            if (EmployeePanel.Visible == false)
            {
                EmployeePanel.Show();
            }

            else
            {
                EmployeePanel.Hide();
            }

            TaxPanel.Hide();
            ItemsPanel.Hide();

            EmployeePanel.ResumeLayout();
            ItemsPanel.SuspendLayout();
            TaxPanel.SuspendLayout();
        }

        private void ItemsButton_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Items");
            EmployeePanel.SuspendLayout();
            ItemsPanel.SuspendLayout();
            TaxPanel.SuspendLayout();

            if (ItemsPanel.Visible == false)
            {
                ItemsPanel.Show();
            }

            else
            {
                ItemsPanel.Hide();
            }

            EmployeePanel.Hide();
            TaxPanel.Hide();

            EmployeePanel.ResumeLayout();
            ItemsPanel.SuspendLayout();
            TaxPanel.SuspendLayout();

            //EmployeePanel.SuspendLayout();
            //ItemsPanel.ResumeLayout();
            //TaxPanel.SuspendLayout();
        }

        private void UpdateTaxButton_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Tax");
            EmployeePanel.SuspendLayout();
            ItemsPanel.SuspendLayout();
            TaxPanel.SuspendLayout();

            if (TaxPanel.Visible == false)
            {
                TaxPanel.Show();
            }

            else
            {
                TaxPanel.Hide();
            }

            EmployeePanel.Hide();
            ItemsPanel.Hide();

            EmployeePanel.ResumeLayout();
            ItemsPanel.SuspendLayout();
            TaxPanel.SuspendLayout();

            //EmployeePanel.SuspendLayout();
            //ItemsPanel.SuspendLayout();
            //TaxPanel.ResumeLayout();
        }

        private void LogoutButton_Click_1(object sender, EventArgs e)
        {
            Hide();
            Inloggning.FormLogIn();
        }
        private void AdministratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            Inloggning.FormLogIn();
        }

        #endregion

        #region Employee

        private void EmpUpdateList()
        {
            EmpListBox.Items.Clear();

            var empList = ListaAnstallda();

            foreach (string t in empList)
            {
                string s = Path.GetFileNameWithoutExtension(t);
                EmpListBox.Items.Add(s);
            }
        }

        private void EmpListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name;
            int hoursWorked;
            string role;
            int wage;
            
            if(EmpListBox.SelectedItem == null)
            {
                EmpSaveButton.Text = "Add";
                return;
            }

            if(EmpOmNamnFinns(EmpListBox.SelectedItem.ToString()) == true)
            {
                using (StreamReader reader = new StreamReader(malMapp + "\\Anstallda\\" + EmpListBox.SelectedItem.ToString() + ".txt")) // Läser upp informationen om den angivna anställda.
                {
                    name = reader.ReadLine();
                    hoursWorked = Int32.Parse(reader.ReadLine());
                    role = reader.ReadLine();
                    wage = Int32.Parse(reader.ReadLine());
                }

                EmpShowName.Text = name;
                EmpShowHours.Text = hoursWorked.ToString();         
                EmpShowWage.Text = wage.ToString();
                if(role == "Admin")
                {
                    EmpAdminRadioBtn.Select();
                }

                else if(role == "Cashier")
                {
                    EmpCashierRadioBtn.Select();
                }
            }
        }

        bool EmpOmNamnFinns(string inNamn) //Jämför om det namn som skickas in i metoden finns i en array med de anställda som kommer från Anställda.cs Returnar true om namnet existerar i arrayen.
        {

            foreach (string fil in ListaAnstallda())
            {
                if ((inNamn + ".txt") == Path.GetFileName(fil)) //ans.listaAnstallda innehåller info om path till filerna. Denna metod hittar namnet på filen så att vi kan jämföra det med inNamn.
                {
                    return true;
                }
            }

            return false;
        }

        public void ModifieraAnstalld(string namn, float arbTimmar, string befattning, float lon) //Anropas från Administrator.cs. Används för att både ändra på och lägga till anställda.
        {
            using (StreamWriter writer = new StreamWriter(malMapp + "\\Anstallda\\" + namn + ".txt", false)) //Sparar över/skapar .txt i mappen Anstallda. 
            {
                writer.WriteLine(namn);
                writer.WriteLine(arbTimmar);
                writer.WriteLine(befattning);
                writer.WriteLine(lon);
            }

            EmpUpdateList();

            if (EmpOmNamnFinns(EmpShowName.Text) == true)
            {
                EmpSaveButton.Text = "Update";
            }
            else
            {
                EmpSaveButton.Text = "Add";
            }
        }

        string role;

        private void EmpSave_Click(object sender, EventArgs e)
        {

            if (EmpShowName.Text.Length > 0 && EmpShowHours.Text.Length > 0 && EmpShowWage.Text.Length > 0 && (EmpAdminRadioBtn.Checked == true || EmpCashierRadioBtn.Checked == true))
            {

                if (EmpAdminRadioBtn.Checked == true)
                {
                    role = "Admin";
                    ModifieraAnstalld(EmpShowName.Text, float.Parse(EmpShowHours.Text), role, float.Parse(EmpShowWage.Text));
                }

                else if (EmpCashierRadioBtn.Checked == true)
                {
                    role = "Cashier";
                    ModifieraAnstalld(EmpShowName.Text, float.Parse(EmpShowHours.Text), role, float.Parse(EmpShowWage.Text));
                }
            }

            else
            {
                EmpErrorRichTextBox.Text = "All fields must have a value";
                TimerTime();
            }
        }

        private void EmpShowName_TextChanged(object sender, EventArgs e)
        {
            if(EmpOmNamnFinns(EmpShowName.Text) == true)
            {
                EmpSaveButton.Text = "Update";
            }
            else
            {
                EmpSaveButton.Text = "Add";
            }
        }

        private void EmpRemoveButton_Click(object sender, EventArgs e)
        {
            if (EmpOmNamnFinns(EmpShowName.Text) == true)
            {
                File.Delete(malMapp + "\\Anstallda\\" + EmpShowName.Text + ".txt");
            }

            EmpShowName_TextChanged(sender, e);

            EmpUpdateList();
        }

        private Timer tm; // Skapar timern
        public static object Control { get; private set; }

        private void TimerTime()
        {
            tm = new Timer(); // Skapar instans av tm
            tm.Interval = 5000; // Sätter interval till 5sek och där efter anropar tm_Tick
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start(); // Startar timern
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop(); // Stoppar timern
            EmpErrorRichTextBox.Clear();
            ItemsErrorRichTextBox.Clear();
        }

        private void EmpCancelButton_Click(object sender, EventArgs e)
        {
            EmployeePanel.Hide();
        }

        public string[] ListaAnstallda() //Skickar tillbaka en array med sökväg till samtliga anställdas filer. 
        {
            string[] anstalldLista;
            anstalldLista = Directory.GetFiles(malMapp + "\\Anstallda\\"); //Går in i mappen Anstallda för att sen spara samtliga filers sökväg i en array.
            return anstalldLista;
        }

        public void LaggTillExempelAnstallda() //Skapar filer åt våra anställda
        {
            Directory.CreateDirectory(malMapp + "\\Anstallda\\"); //Skapar mappen där våra filer lägger sig.             
            using (StreamWriter writer = new StreamWriter(malMapp + "\\Anstallda\\Sara.txt", false)) //Skapar en fil för Sara i Anstalla mappen. Innehåller info om namn, arbetade timmar, befattning och timlön. 
            {
                writer.WriteLine("Sara");
                writer.WriteLine("140");
                writer.WriteLine("Cashier");
                writer.WriteLine("119");
            }

            using (StreamWriter writer = new StreamWriter(malMapp + "\\Anstallda\\Arnold.txt", false)) //Skapar en fil för Arnold i Anstalla mappen. Innehåller info om namn, arbetade timmar, befattning och timlön. 
            {
                writer.WriteLine("Arnold");
                writer.WriteLine("168");
                writer.WriteLine("Admin");
                writer.WriteLine("170");
            }
        }

        private void EmpShowHours_TextChanged(object sender, EventArgs e)
        {
            int nr;

            if (Int32.TryParse(EmpShowHours.Text, out nr) == false)
            {
                if (EmpShowHours.Text.Length > 0)
                {
                    EmpShowHours.Text = EmpShowHours.Text.Remove(EmpShowHours.Text.Length - 1);
                }
            }
        }

        private void EmpShowWage_TextChanged(object sender, EventArgs e)
        {
            int nr;

            if (Int32.TryParse(EmpShowWage.Text, out nr) == false)
            {
                if (EmpShowWage.Text.Length > 0)
                {
                    EmpShowWage.Text = EmpShowWage.Text.Remove(EmpShowWage.Text.Length - 1);
                }
            }
        }

        #endregion

        #region Items

        private void ItemUpdateList()
        {
            ItemsListBox.Items.Clear();

            var itemList = Inloggning.varuLista;

            foreach (Vara t in itemList)
            {
                ItemsListBox.Items.Add(t.Namn);
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                ItemsSaveButton.Text = "Add";
                return;
            }

            foreach(Vara t in Inloggning.varuLista)
            {
                if (ItemsListBox.SelectedItem.ToString() == t.Namn)
                {
                    ItemsShowName.Text = t.Namn;
                    ItemsShowPrice.Text = t.Pris.ToString();
                    ItemsShowId.Text = t.Id.ToString();
                    ItemsShowStatus.Text = t.LagerStatus.ToString();

                    if(t.Kategori == 1)
                    {
                        ItemsWeightRadioButton.Select();
                    }

                    else if (t.Kategori == 0)
                    {
                        ItemsCountRadioButton.Select();
                    }
                }
            }
        }

        bool ItemsIfInList(int nr)
        {
            foreach(Vara t in Inloggning.varuLista)
            {
                if(t.Id == nr)
                {
                    return true;
                }
            }

            return false;
        }

        private void ItemsShowId_TextChanged(object sender, EventArgs e)
        {
            int nr;

            if(Int32.TryParse(ItemsShowId.Text, out nr) == false){
                if(ItemsShowId.Text.Length > 0)
                {
                    ItemsShowId.Text = ItemsShowId.Text.Remove(ItemsShowId.Text.Length - 1);
                }
            }

            if (Int32.TryParse(ItemsShowId.Text, out nr) == true)
            {
                if (ItemsIfInList(Int32.Parse(ItemsShowId.Text)) == true)
                {
                    ItemsSaveButton.Text = "Update";
                    ItemsRemoveButton.Enabled = true;
                }

                else
                {
                    ItemsSaveButton.Text = "Add";
                    ItemsRemoveButton.Enabled = false;
                }
            }
        }

        Vara removal;

        private void ItemsSaveButton_Click(object sender, EventArgs e)
        {

            if (ItemsShowName.Text.Length > 0 && ItemsShowPrice.Text.Length > 0 && ItemsShowStatus.Text.Length > 0 && ItemsShowId.Text.Length > 0)
            {

                if (ItemsIfInList(Int32.Parse(ItemsShowId.Text)) == true)
                {
                    foreach (Vara t in Inloggning.varuLista)
                    {
                        if (t.Id == Int32.Parse(ItemsShowId.Text))
                        {
                            removal = t;
                        }
                    }

                    if (removal != null)
                    {
                        Inloggning.varuLista.Remove(removal);
                    }
                }


                if (ItemsWeightRadioButton.Checked)
                {
                    Inloggning.varuLista.Add(new Vara(ItemsShowName.Text, Int32.Parse(ItemsShowPrice.Text), 1, Int32.Parse(ItemsShowId.Text), Int32.Parse(ItemsShowStatus.Text), 0));
                }

                else if (ItemsCountRadioButton.Checked)
                {
                    Inloggning.varuLista.Add(new Vara(ItemsShowName.Text, Int32.Parse(ItemsShowPrice.Text), 0, Int32.Parse(ItemsShowId.Text), Int32.Parse(ItemsShowStatus.Text), 0));
                }

            }

            else
            {
                ItemsErrorRichTextBox.Text = "All fields must have a value";
                TimerTime();
            }

            ItemUpdateList();
            ItemsShowId_TextChanged(sender, e);
            removal = null;
        }

        private void ItemsRemoveButton_Click(object sender, EventArgs e)
        {
            foreach (Vara t in Inloggning.varuLista)
            {
                if (t.Id == Int32.Parse(ItemsShowId.Text))
                {
                    removal = t;
                }
            }

            if (removal != null)
            {
                Inloggning.varuLista.Remove(removal);
            }

            removal = null;
            ItemUpdateList();
            ItemsShowId_TextChanged(sender, e);
        }

        private void ItemsCancelButton_Click(object sender, EventArgs e)
        {
            ItemsPanel.Hide();
        }

        public void Items() 
        {
            Inloggning.varuLista.Add(new Vara("Milk", 12, 0, 22, 10, 0));
            Inloggning.varuLista.Add(new Vara("Coffee", 40, 0, 33, 10, 0));
            Inloggning.varuLista.Add(new Vara("Butter", 28, 0, 44, 10, 0));
            Inloggning.varuLista.Add(new Vara("Eggs", 22, 0, 55, 10, 0));
            Inloggning.varuLista.Add(new Vara("Tomatoes", 23, 1, 66, 10, 0));
        }

        private void ItemsShowPrice_TextChanged(object sender, EventArgs e)
        {
            int nr;

            if (Int32.TryParse(ItemsShowPrice.Text, out nr) == false)
            {
                if (ItemsShowPrice.Text.Length > 0)
                {
                    ItemsShowPrice.Text = ItemsShowPrice.Text.Remove(ItemsShowPrice.Text.Length - 1);
                }
            }
        }

        private void ItemsShowStatus_TextChanged(object sender, EventArgs e)
        {
            int nr;

            if (Int32.TryParse(ItemsShowStatus.Text, out nr) == false)
            {
                if (ItemsShowStatus.Text.Length > 0)
                {
                    ItemsShowStatus.Text = ItemsShowStatus.Text.Remove(ItemsShowStatus.Text.Length - 1);
                }
            }
        }

        #endregion

        #region Tax

        private void TaxPanel_VisibleChanged(object sender, EventArgs e)
        {
            TaxShowTax.Text = Inloggning.moms.ToString();
        }

        private void TaxSaveButton_Click(object sender, EventArgs e)
        {
            Inloggning.moms = float.Parse(TaxShowTax.Text);
        }

        private void TaxShowTax_TextChanged(object sender, EventArgs e)
        {
            float nr;

            if(float.TryParse(TaxShowTax.Text, out nr) == true)
            {
                if (nr <= 1 && nr >= 0)
                {
                    TaxSaveButton.Enabled = true;
                }

                else
                {
                    TaxSaveButton.Enabled = false;
                }
            }

            else
            {
                TaxSaveButton.Enabled = false;
            }
        }

        private void TaxCancelButton_Click(object sender, EventArgs e)
        {
            TaxPanel.Hide();
        }


        #endregion

    }
}
