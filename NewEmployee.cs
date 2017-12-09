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
        public NewEmployee()
        {
            InitializeComponent();
        }

        Anstallda newEmp = new Anstallda(); //Skapar ett objekt av klassen Anställda

        string name = "";
        int hours = 0;
        string role = "";
        int wage = 0;

        public void CreateNewEmployee()
        {
           
            name = textboxName.Text;
            hours = int.Parse(textboxHours.Text);
            role = textboxRole.Text;
            wage = int.Parse(textboxWage.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newEmp.ModifieraAnstalld(name, hours, role, wage);
            NewEmployee.ActiveForm.Close(); // NewEmployeeForm stängs ner
        }
    }
}
