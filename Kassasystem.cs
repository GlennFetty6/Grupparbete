using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{
    class Kassasystem
    {
        private string[] namn = { "mjölk", "kaffe", "korv", "ägg", "tomater" };
        private int[] varorID = { 22, 33, 44, 55, 66 };
        private int[] priser = { 15, 70, 40, 20, 30 };
        private int[] kategori = { 0, 0, 0, 0, 1 };
        private string[] kundVagn = new string[20];
        private int totaltPris;
        private int totalVaror = 0;

        public void Kassa()
        {
            AddVara();
        }

        public void VaraID(int id)
        {
            int index = Array.IndexOf(varorID, id);

            int pris = priser[index];
            int typ = kategori[index];
            string name = namn[index];
            int kostnad = 0;
            int antal = 0;


            if (typ > 0)
            {
                Console.Write("Ange varans vikt i kilogram: ");
                string input2 = Console.ReadLine();
                int vikt;
                while (Int32.TryParse(input2, out vikt) == false || vikt <= 0)
                {
                    Console.WriteLine("Koden måste bestå av ett giltigt tvåsiffrigt heltal");
                    input2 = Console.ReadLine();
                }

                kostnad = vikt * pris;
                totaltPris += kostnad;

                Console.WriteLine("{0}kg {1} kostar totalt {2}kr", vikt, name, pris);
                Console.ReadLine();
            }

            else
            {
                Console.Write("Ange antal av varan: ");
                string input = Console.ReadLine();

                while (Int32.TryParse(input, out antal) == false || antal <= 0)
                {
                    Console.Write("Inkorrekt svar. Ange antal: ");
                    input = Console.ReadLine();
                }
            }

            kostnad = antal * pris;
            totaltPris += kostnad;

            Console.WriteLine("Fler varor? y/n");
            string mer = Console.ReadLine();

            if (mer == "y")
            {
                AddVara();
            }
            else if (mer == "n")
            {
                skrivUtKvitto();
            }
            else
            {
                Console.WriteLine("Inkorrekt svar. skriv endast 'y' eller 'n' ");
            }
        }

        public void AddVara()
        {
            int idNr;
            bool inputOK = true;
            do
            {
                Console.Write("Ange varans ID-nummer: ");
                idNr = int.Parse(Console.ReadLine());
                switch (idNr)
                {
                    case 22:
                        Console.WriteLine("Ett paket {0} är tillagd i vagnen", namn[0]);
                        kundVagn[totalVaror] = namn[0]; //Vald vara läggs i korgen (vektorn)
                        totalVaror++;
                        VaraID(idNr); // Metodanrop av VaraID
                        break;
                    case 33:
                        Console.WriteLine("Ett paket {0} är tillagd i vagnen", namn[1]);
                        kundVagn[totalVaror] = namn[1];
                        totalVaror++;
                        VaraID(idNr);
                        break;
                    case 44:
                        Console.WriteLine("Ett paket {0} är tillagd i vagnen", namn[2]);
                        kundVagn[totalVaror] = namn[2];
                        totalVaror++;
                        VaraID(idNr);
                        break;
                    case 55:
                        Console.WriteLine("Ett paket {0} är tillagd i vagnen", namn[3]);
                        kundVagn[totalVaror] = namn[3];
                        totalVaror++;
                        VaraID(idNr);
                        break;
                    case 66:
                        Console.WriteLine("{0} är tillagd i vagnen", namn[4]);
                        kundVagn[totalVaror] = namn[4];
                        totalVaror++;
                        VaraID(idNr);
                        break;
                    default:
                        Console.WriteLine("Inkorrekt ID-nummer, försök igen.");
                        inputOK = false;
                        break;
                }
            } while (inputOK == false);
        }

        public void skrivUtKvitto()// Denna är absolut inte klar! utan la bara in något...
        {
            Console.WriteLine("SEWK's livs");
            Console.WriteLine("Kungsgatan 37, 441 50 Alingsås");
            Console.WriteLine("Org Nr: 556033-5696");
            Console.WriteLine("------------------------------------------");
            foreach (string varor in kundVagn)
            {
                Console.WriteLine(varor);
            }
            Console.WriteLine("------------------------------------------");

            //String Företagnamn
            //Int Verifikationsnr RandomNumber
            //Date/Time
            //varaNamn
            //varaAntal
            //vara*antal=pris
            //totalPris
            //Utgiftens Momsprocent
        }
    }
}
