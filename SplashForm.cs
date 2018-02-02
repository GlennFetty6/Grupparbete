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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            tm = new Timer(); // Skapar instans av tm
            TopMost = true;
            TimerTime();
        }

        private Timer tm; // Skapar timern
        public static object Control { get; private set; }

        private void TimerTime()
        {
            Console.WriteLine("F");
            tm.Interval = 50; //20ggr/sek
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start(); // Startar timern
        }

        int i = 0;

        private void tm_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 60)
            {

                Opacity -= 0.10f;
                if (Opacity <= 0)
                {
                    tm.Stop();
                    Hide();
                    LogInForm lf = new LogInForm();
                    lf.ShowDialog();
                }
            }
        
        }
    }
}
