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
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ella\Documents\LogInDetails.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where UserID= '" + textBox1.Text + "' and UserPassword= '" + textBox2.Text + "'", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Hide();
                Inloggning.kodID = textBox1.Text;
                Inloggning.LoggaIn(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Användar ID eller lösenord är inkorrekt. Var vänlig och försök igen.");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }
    }
}
