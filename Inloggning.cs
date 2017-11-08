using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static List<Vara> varuLista; // gör global
        public static float moms = 0.12f;

        static void Main(string[] args)
        {
            Anstallda ans = new Anstallda(); //Skapar en instans av klassen Anställda
            ans.LaggTillExempelAnstallda();

            varuLista = new List<Vara>();

            AddVaror tempAddVaror = new AddVaror(); //Skapar en instans av klassen AddVaror och kallar den tempAddVaror.
            tempAddVaror.AddVaror2();               //Kör funktionen AddVaror2 i tempAddVaror som är en "kopia" av AddVaror.cs

           Inloggning2();
        }

        public static void Inloggning2()
        {
            int[] koder = { 222, 333, 444, 555, 000 }; // Inloggningskoder
            int kod;
            Console.Write("Skriv in din tresiffriga kod (0 för att Avsluta): ");
            string input = Console.ReadLine();

            while (Int32.TryParse(input, out kod) == false || koder.Contains(kod) == false) //Kontrollerar så kod är en int samt om kod matchar ngn av koder.
            {
                Console.Write("Kod ej giltig. Försök igen: ");
                input = Console.ReadLine();
            }

            int firstNr = Math.Abs(kod);
            while (firstNr >= 10)
                firstNr /= 10;

            switch (firstNr)
            {
                case 2:
                    Console.WriteLine("Inloggad som Kassör");
                    Kassasystem KasstSystem = new Kassasystem();
                    KasstSystem.Kassa();
                    break;
                case 3:
                    Console.WriteLine("Inloggad som Administratör");
                    Administrator Admin = new Administrator();
                    Admin.Administration();
                    break;
                case 5:
                    Forsaljningsrapport Rapport = new Forsaljningsrapport();
                    Rapport.Forsaljningsrapport2();
                    break;
                case 0:
                    Console.WriteLine("Kassan kommer nu stängas.");
                    Console.WriteLine("Tryck på valfri knapp för att avsluta.");
                    Console.ReadKey();
                    break;
                default: // Är denna menlös? Används ej.
                    Console.WriteLine("Du är ej behörig.");
                    break;
            }
        }
    }
}
