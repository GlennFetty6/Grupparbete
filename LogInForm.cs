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
    public partial class LogInForm : Form // Partial tillåter att samma klass definieras i flera filer
    {
        public LogInForm() // Konstruktor som anropar metoden InitializeComponent
        {
            InitializeComponent();
        }

        private void SplashScreen()
        {
            SplashForm sp = new SplashForm();
            sp.Show();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
            //SqlConnection connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DigitLogin;Integrated Security=True");
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From EmployeeLogin where UserID= '" + userIDTxtbox.Text + "' and Password= '" + passwordTxtbox.Text + "'", connect);
            //sda.Fill(ds);

            //if (ds.Tables[0].Rows[0][0].ToString() == "1")
            //    if (10 < 100)
            {
                Hide();
                Inloggning.kodID = userIDTxtbox.Text;
                Inloggning.LoggaIn(userIDTxtbox.Text);
            }

            errorMessage(); // Anropar felmeddelande
        }

        private void errorMessage()
        {           
            labelError.Show();
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
            labelError.Hide();
        }

        private void passwordTxtbox_Click(object sender, EventArgs e)
        {
            passwordTxtbox.Clear(); // Rensar textboxen till tom
        }

        private void passwordTxtbox_TextChanged(object sender, EventArgs e)
        {
            passwordTxtbox.PasswordChar = '*'; // Lösenordet visas i ****       
        }

        private void userIDTxtbox_TextChanged(object sender, EventArgs e)
        {
            int test;
            if (userIDTxtbox.Text != "")
            {
                if (Int32.TryParse(userIDTxtbox.Text, out test) == false)
                {
                    errorMessage();
                    userIDTxtbox.Clear();
                }
            }
        }

        private void userIDTxtbox_Click(object sender, EventArgs e)
        {
            userIDTxtbox.Clear();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogIn_Click((object)sender, (EventArgs)e);
            }

        }
    }
}

