﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitCashier
{
    class Inloggning
    {
        /*
         * Static använder man för symbolisera att det finns ett värde som tillhör klassen men INTE objekten.
         * Static är ett sätt för en att ändra på beteendet variabler/metodrar/egenskaper. (Allt inom en klassdeklaration)
         * Man måste INTE skapa ett objekt för att kunna jobba med dom medlemmarna inom den klassen
         * Man måste använda klassnamnet "Inloggning.varuLista" för att komma åt den statiska medlemmen 
        */

        public static List<Vara> varuLista; // Gör  listan global
        public static float moms = 0.12f;   // Gör momssatsen global
        public static string kodID;

       [STAThread] // Måste ha denna för att kunna öppna filer i AdminForm
        static void Main(string[] args)
        {
            Application.EnableVisualStyles(); // Ska tydligen få skiten att se snyggare ut. Kanske fungerar på din VS 2017
            Application.SetCompatibleTextRenderingDefault(false);

            varuLista = new List<Vara>(); // Skapar en list av Vara och kallar den varuLista

            AdministratorForm Ad = new AdministratorForm();
            Ad.Items();
            Ad.LaggTillExempelAnstallda();

            Application.Run(new SplashForm());
        }

        public static void LoggaIn(string userID)
        {
            int firstNr = Math.Abs(Int32.Parse(kodID));
            while (firstNr >= 10) //Delar med 10 så länge talet är större än 10. För att få fram första siffran i koden. 
                firstNr /= 10;

            switch (firstNr)
            {
                case 2:
                    CashierForm kf = new CashierForm();
                    kf.ShowDialog();
                    break;
                case 3:
                    AdministratorForm Admin = new AdministratorForm();
                    Admin.Show();                   
                    break;
                case 5:
                    ReportForm Report = new ReportForm();
                    Report.Show();
                    break;
                case 0:
                    break;
                default:
                    throw new NotFiniteNumberException();
            }
        }
        public static void FormLogIn()
        {
            LogInForm lm = new LogInForm();
            lm.ShowDialog();
        }
    }
}
