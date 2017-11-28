using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DigitCashier
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DigitLogin;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From EmployeeLogin where UserID= '" + textBox1.Text + "' and Password= '" + textBox2.Text + "'", connect);
            sda.Fill(ds);
            if (ds.Tables[0].Rows[0][0].ToString() == "1")
            {
                Hide();
                Inloggning.kodID = textBox1.Text;
                Inloggning.LoggaIn(textBox1.Text);
            }
            else
            {
                FelMeddelande(); // Anropar felmeddelande
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Stänger applikation
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int test;
            if (Int32.TryParse(textBox1.Text, out test) == false)
            {
                FelMeddelande();
                textBox1.Clear();
            }
        }

        private void FelMeddelande()
        {
            boxFelMedd.ReadOnly = true;
            boxFelMedd.ForeColor = Color.Red;
            boxFelMedd.Text = "Användar ID eller lösenord är inkorrekt. Var vänlig och försök igen.";
            boxFelMedd.Show();
            TimerTid();      // Anropar Timern för felmeddelandet       
        }

        private Timer tm; // Skapar timern
        private void TimerTid()
        {   
            tm = new Timer(); // Skapar instans av tm
            tm.Interval = 5000; // Sätter interval till 5sek och där efter anropar tm_Tick
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start(); // Startar timern
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop(); // Stoppar timern
            boxFelMedd.Clear(); // Tar bort felmeddelande
        }
    }
}
