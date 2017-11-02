using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{
    class Kassasystem
    {
        private string[] varuNamn = { "mjölk", "kaffe", "korv", "ägg", "tomater" };
        private int[] varuID = { 22, 33, 44, 55, 66 };
        private int[] stPris = { 15, 70, 40, 20, 30 };
        private int[] kategori = { 0, 0, 0, 0, 1 };
        private int[] antalVaror = { 1, 1, 1, 1, 1 };
        List<int> kundVagn2 = new List<int>();
        private int totaltPris;
        private int idNr2;

        public void Kassa()
        {
            AddVara();
        }

        void VaraID(int id)
        {
            int index = Array.IndexOf(varuID, id);

            int pris = stPris[index];
            int typ = kategori[index];
            string name = varuNamn[index];
            int kostnad = 0;
            int antal = 0;

            if (typ > 0)
            {
                int vikt;
                Console.Write("Ange varans vikt i kilogram: ");
                string input2 = Console.ReadLine();
                while (Int32.TryParse(input2, out vikt) == false || vikt <= 0)
                {
                    Console.WriteLine("Koden måste bestå av ett giltigt tvåsiffrigt heltal");
                    input2 = Console.ReadLine();
                }

                kostnad = vikt * pris;
                totaltPris += kostnad;

                Console.WriteLine("{0}kg {1} kostar totalt {2}kr", vikt, name, kostnad);
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

            antalVaror[index] = antal;
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
                Kupong();
            }
            else
            {
                Console.WriteLine("Inkorrekt svar. skriv endast 'y' eller 'n' ");
            }
        }

        void AddVara()
        {
            int idNr;
            bool inputOK = true;
            do
            {
                Console.Write("Ange varans ID-nummer: ");
                idNr = int.Parse(Console.ReadLine());

                int i = -1;
                
                foreach(int nr in varuID)
                {
                    i++;
                    if(idNr == varuID[i])
                    {
                        idNr2 = i;
                    }
                }

                switch (idNr)
                {
                    case 22:
                        Console.WriteLine("Ett paket {0} är tillagd i vagnen", varuNamn[0]);
                        kundVagn2.Add(idNr2);
                        VaraID(idNr); // Metodanrop av VaraID
                        break;
                    case 33:
                        Console.WriteLine("Ett paket {0} är tillagd i vagnen", varuNamn[1]);
                        kundVagn2.Add(idNr2);
                        VaraID(idNr);
                        break;
                    case 44:
                        Console.WriteLine("Ett paket {0} är tillagd i vagnen", varuNamn[2]);
                        kundVagn2.Add(idNr2);
                        VaraID(idNr);
                        break;
                    case 55:
                        Console.WriteLine("Ett paket {0} är tillagd i vagnen", varuNamn[3]);
                        kundVagn2.Add(idNr2);
                        VaraID(idNr);
                        break;
                    case 66:
                        Console.WriteLine("{0} är tillagd i vagnen", varuNamn[4]);
                        kundVagn2.Add(idNr2);
                        VaraID(idNr);
                        break;
                    default:
                        Console.WriteLine("Inkorrekt ID-nummer, försök igen.");
                        inputOK = false;
                        break;
                }
            } while (inputOK == false);
        }

        void Kupong()
        {
            bool okInput = true;
            int worth;

            do
            {
                Console.Write("Har kunden någon kupong? y/n ");
                string option = Console.ReadLine();

                if (option == "y")
                {
                    okInput = true;

                    Console.Write("Hur mycket är kupongen värd? ");
                    string input = Console.ReadLine();

                    while (Int32.TryParse(input, out worth) == false || worth <= 0)
                    {
                        Console.Write("Ange hur mycket kunden betalade. ");
                        input = Console.ReadLine();
                    }

                    totaltPris -= worth;
                    Betalning();
                }
                else if (option == "n")
                {
                    okInput = true;
                    Betalning();
                }
                else
                {
                    okInput = false;
                }
            } while (okInput == false);
        }

        void Betalning()
        {
            bool okInput = true;
            if (totaltPris < 0)
            {
                totaltPris = 0;
                Console.WriteLine("Kupongen täckte hela kostnaden. Kunden behöver inte betala något mer.");
                skrivUtKvitto();
                return;
            }

            else
            {
                Console.WriteLine(totaltPris + "kr kvar att betala");
            }

            do
            {
                Console.WriteLine("Vill kunden betala kontant eller med kort?");

                string option = Console.ReadLine();

                if (option == "kontant")
                {
                    okInput = true;
                    CalcChange();
                }
                else if (option == "kort")
                {
                    okInput = true;
                    CalcChange();
                }
                else
                {
                    okInput = false;
                }
            } while (okInput == false);
        }

        void CalcChange()
        {
            Console.WriteLine("Hur mycket betalade kunden?");
            string payed = Console.ReadLine();
            int betalt;

            while (Int32.TryParse(payed, out betalt) == false || betalt <= 0 || betalt < totaltPris)
            {
                Console.WriteLine("Summan räcker inte till. Försök igen:");
                payed = Console.ReadLine();
            }

            int change = betalt - totaltPris;
            Console.WriteLine("Kunden får tillbaka " + change + "kr i växel.");
            skrivUtKvitto();
        }

        void skrivUtKvitto()
        {
            Console.WriteLine("\nSEWK's livs");
            Console.WriteLine("Kungsgatan 37, 441 50 Alingsås");
            Console.WriteLine("Org Nr: 556033-5696\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Styck   Namn             Pris   Total");
            Console.WriteLine("------------------------------------------");
            foreach (int nr in kundVagn2)
            {
                Console.WriteLine(antalVaror[nr] + "       " + varuNamn[nr] + "               " + " " + stPris[nr] + "     " + (antalVaror[nr]*stPris[nr]) );
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Total                            {0}", totaltPris);
            Console.WriteLine("Moms 12%                         {0}", (totaltPris*0.12));
            Console.WriteLine("------------------------------------------");
            Random verfNr = new Random();
            int nr1 = verfNr.Next(100000, 999999);
            Console.WriteLine("Kvittonummer: ", nr1);
            Console.WriteLine(DateTime.Now);

            //String FöretagnamnKLAR
            //Int Verifikationsnr RandomNumber
            //Date/TimeKLAR
            //varaNamnKLAR
            //varaAntalKLAR
            //vara*antal=prisKLAR
            //totalPrisKLAR
            //Utgiftens MomsprocentKLAR
        }
    }
}
