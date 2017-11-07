using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{
    class Program
    {
        public static List<Vara> varuLista; // gör global

        public static float moms = 0.12f;

         static void Main(string[] args)
        {
            varuLista = new List<Vara>();

            AddVaror tempAddVaror = new AddVaror(); //Skapar en instance av klassen AddVaror och kallar den hej.
            tempAddVaror.AddVaror2();               //Kör funktionen AddVaror2 i hej som är en "kopia" av AddVaror.cs

            int[] koder = { 222, 333, 444, 555, 000 };
            int kod;

            Console.Write("Skriv in din tresiffriga kod (0 för att Avsluta): ");
            string input = Console.ReadLine();

            while (Int32.TryParse(input, out kod) == false || koder.Contains(kod) == false)
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
                    Console.WriteLine("Försäljningsrapport");
                    break;
                case 0:
                    Console.WriteLine("Kassan kommer nu stängas.");
                    Console.WriteLine("Tryck på valfri knapp för att avsluta.");
                    Console.ReadKey();
                    break;
                default: // Fått för mig att man måste ha en default... Tror Sattar nämnde det med. Onödigt här dock.
                    Console.WriteLine("Du är ej behörig.");
                    break;
            }
        }
    }
}
