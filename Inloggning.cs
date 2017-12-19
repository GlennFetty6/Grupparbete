﻿using DigitCashier;
using System;
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
            Anstallda anst = new Anstallda(); //Skapar en instans av klassen Anställda
            anst.LaggTillExempelAnstallda();

            varuLista = new List<Vara>(); // Skapar en list av Vara och kallar den varuLista

            varuLista.Add(new Vara("milk", 12, 0, 22, 10, 0));
            varuLista.Add(new Vara("coffee", 40, 0, 33, 10, 0));
            varuLista.Add(new Vara("butter", 28, 0, 44, 10, 0));
            varuLista.Add(new Vara("eggs", 22, 0, 55, 10, 0));
            varuLista.Add(new Vara("onions", 9, 1, 66, 10, 0));
            varuLista.Add(new Vara("tomatoes", 19, 1, 77, 10, 0));
            varuLista.Add(new Vara("potatoes", 8, 1, 88, 10, 0));

            //AddVaror tempAddVaror = new AddVaror(); //Skapar en instans av klassen AddVaror och kallar den tempAddVaror.
            //tempAddVaror.AddVaror2();               //Kör funktionen AddVaror2 i tempAddVaror som är en "kopia" av AddVaror.cs

            Application.Run(new LogInForm());
        }

        public static void LoggaIn(string userID)
        {
            int firstNr = Math.Abs(Int32.Parse(kodID));
            while (firstNr >= 10) //Delar med 10 så länge talet är större än 10. För att få fram första siffran i koden. 
                firstNr /= 10;

            switch (firstNr)
            {
                case 2:
                    Console.WriteLine("Inloggad som Kassör");
                    FormCashier(); // Ligger längst ner i denna kod
                    break;
                case 3:
                   AdministratorForm Admin = new AdministratorForm();
                   Admin.Show();
                    break;
                case 5:
                    Forsaljningsrapport Rapport = new Forsaljningsrapport();
                    Rapport.FormRapport();
                    break;
                case 0:
                    Console.WriteLine("Programmet kommer nu att stängas.");
                    Console.WriteLine("Tryck på valfri knapp för att avsluta.");
                    Console.ReadKey();
                    break;
                default: // Är denna menlös? Används ej.
                    Console.WriteLine("Du är ej behörig.");
                    break;
            }
        }
        public static void FormLogIn()
        {
            LogInForm lm = new LogInForm();
            lm.ShowDialog();
        }

        public static void FormCashier()
        {
            CashierForm kf = new CashierForm();
            kf.ShowDialog();
        }
    }
}
