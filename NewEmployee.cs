using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitCashier
{
    public partial class NewEmployee : Form
    {
        public int state = 0;
        public NewEmployee()
        {
            InitializeComponent();
        }

        Anstallda newEmp = new Anstallda(); //Skapar ett objekt av klassen Anställda

        string name = "";
        float hours = 0;
        string role = "";
        float wage = 0;

        string role2;

        public void CreateNewEmployee()
        {
            name = textboxName.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                //if (name == "" || hours == 0 || role == "" || wage == 0)
                //{
                //    errorMessage();
                //}
               // else
                {
                    CreateNewEmployee();
                    newEmp.ModifieraAnstalld(name, hours, role, wage);
                    NewEmployee.ActiveForm.Close(); // NewEmployeeForm stängs ner
                }
            }

            if(state == 2)
            {
                newEmp.ModifieraAnstalld(textboxName.Text,float.Parse(textboxHours.Text), role2,float.Parse(textboxWage.Text));
            }
        }
        private void errorMessage()
        {
            errorMessageTxtbox.ReadOnly = true;
            errorMessageTxtbox.ForeColor = Color.Red;
            errorMessageTxtbox.Text = "Invalid input";
            errorMessageTxtbox.Show();
            TimerTime();      // Anropar Timern för felmeddelandet       
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
            errorMessageTxtbox.Clear(); // Tar bort felmeddelande
        }

        private void textboxHours_Validating(object sender, CancelEventArgs e)
        {
            if (float.TryParse(textboxHours.Text, out hours) == false || hours < 0)
            {
                errorMessage();
                textboxHours.Clear();
            }
        }

        private void textboxWage_Validating(object sender, CancelEventArgs e)
        {
            if (float.TryParse(textboxWage.Text, out wage) == false || wage < 0)
            {
                errorMessage();
                textboxWage.Clear();
            }
        }

        private void adminRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            role = "Admin";
        }

        private void cashierRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            role = "Cashier";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Hide(); // Göm NewEmployee     
        }

        private void NewEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void textboxName_TextChanged(object sender, EventArgs e)
        {

        }

        public void ChangeEmp(string name, int h, string role, int pay)
        {
            state = 2;
            textboxName.Text = name;
            textboxHours.Text = h.ToString();
            Console.WriteLine(role);
            if (role == "Admin")
            {
                adminRadioBtn.Checked = true;
                role2 = "Admin";
            }
            else if(role == "Cashier")
            {
                cashierRadioBtn.Checked = true;
                role2 = "Cashier";
            }
            textboxWage.Text = pay.ToString();
        }
    }
}
