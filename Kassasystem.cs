using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{

    class Kassasystem
    {
        static string[] namn = new string[5] { "Mjölk", "Kaffe", "Korv", "Ägg", "Tomat" };
        static int[] varorID = new int[5] { 22, 33, 44, 55, 66 };
        static int[] priser = new int[5] { 15, 70, 40, 20, 30 };
        static int[] kategori = new int[5] { 0, 0, 0, 0, 1 };
        static int totaltPris;

       // static void Main(string[] args)
      public static void Kassa ()
        {
            Console.WriteLine("Varans id?");

            string input = Console.ReadLine();

            int helTal;

            while (Int32.TryParse(input, out helTal) == false || helTal.ToString().Length != 2 || varorID.Contains(helTal) == false)
            {
                Console.WriteLine("Koden måste bestå av ett giltigt tvåsiffrigt heltal");

                input = Console.ReadLine();
            }

            VaraID(helTal);
        }

        public static void VaraID(int id)
        {
            int index = Array.IndexOf(varorID, id);

            int pris = priser[index];
            int typ = kategori[index];
            string name = namn[index];

            if (typ > 0)
            {
                Console.WriteLine("Vikt?");
                string input2 = Console.ReadLine();
                int vikt;
                while (Int32.TryParse(input2, out vikt) == false || vikt <= 0)
                {
                    Console.WriteLine("Koden måste bestå av ett giltigt tvåsiffrigt heltal");

                    input2 = Console.ReadLine();
                }

                int kostnad = vikt * pris;

                Console.WriteLine("Varan kostar:" + kostnad + "kr");
                Console.WriteLine(name);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Hur många?");

                string input = Console.ReadLine();

                int antal;

                while (Int32.TryParse(input, out antal) == false || antal <= 0)
                {
                    Console.WriteLine("Ange antal");

                    input = Console.ReadLine();
                }

                int kostnad = antal * pris;

                Console.WriteLine("Varan kostar:" + kostnad + "kr");
                Console.WriteLine(name);
                Console.ReadLine();
            }

            // Console.WriteLine(antal);
            // Console.WriteLine("Varan kostar:" + kostnad +"kr");
            // Console.WriteLine(name);
            // Console.ReadLine();

        }
    }
}
