using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{
    class Kassasystem
    {
       
        List<Vara> kundVagn = new List<Vara>();
        private int totaltPris;

        private Vara valdVara;

        List<Vara> varuLista = new List<Vara>();

        private void ExempelVaror()
        {
            varuLista.Add(new Vara("Mjölk", 15, 0, 22, 10, 0));
            varuLista.Add(new Vara("Kaffe", 45, 0, 33, 10, 0));
            varuLista.Add(new Vara("Korv", 30, 0, 44, 10, 0));
            varuLista.Add(new Vara("Ägg", 22, 0, 55, 10, 0));
            varuLista.Add(new Vara("Tomater", 6, 1, 66, 10, 0));
        }

    
        public void Kassa()
        {
            ExempelVaror();
            AddVara();
        }

        void AddVara()
        {
            Console.WriteLine("Varans id?");

            string input = Console.ReadLine();

            int helTal;

            while (Int32.TryParse(input, out helTal) == false || helTal.ToString().Length != 2 || CheckList(helTal) == false)
            {
                Console.WriteLine("Koden måste bestå av ett giltigt tvåsiffrigt heltal");

                input = Console.ReadLine();
            }

            Console.WriteLine("Ett paket {0} är tillagd i vagnen", valdVara.Namn);
            kundVagn.Add(valdVara);
            VaraID(helTal); // Metodanrop av VaraID
            helTal = 0;

        }

        bool CheckList(int tal)
        {
            for (var i = 0; i < varuLista.Count; i++)
            {
                if (varuLista[i].Id == tal)
                {
                    valdVara = varuLista[i];
                    return true;
                }
            }
            return false;
        }

        void VaraID(int id)
        {

            int kostnad = 0;
            int antal = 0;

            if (valdVara.Kategori > 0)
            {
                int vikt;
                Console.Write("Ange varans vikt i kilogram: ");
                string input2 = Console.ReadLine();
                while (Int32.TryParse(input2, out vikt) == false || vikt <= 0)
                {
                    Console.WriteLine("Koden måste bestå av ett giltigt tvåsiffrigt heltal");
                    input2 = Console.ReadLine();
                }

                kostnad = vikt * valdVara.Pris;
                totaltPris += kostnad;

                Console.WriteLine("{0}kg {1} kostar totalt {2}kr", vikt, valdVara.Namn, kostnad);
            }
            else
            {
                Console.Write("Ange antal av varan: ");
                string input = Console.ReadLine();

                if (Int32.TryParse(input, out antal) == false)
                {
                    Console.Write("Inkorrekt svar. Ange antal: ");
                    input = Console.ReadLine();
                }
                else if (antal > valdVara.LagerStatus)
                {
                    Console.WriteLine("Varan är slut");
                }

            }

            valdVara.LagerStatus -= antal;
            valdVara.Antal = antal;
            kostnad = antal * valdVara.Pris;
            totaltPris += kostnad;

            Console.WriteLine("Fler varor? y/n");
            string mer = Console.ReadLine();

            if (mer == "y")
            {
                valdVara = null;
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
            foreach (Vara nr in kundVagn)
            {
                Console.WriteLine(nr.Antal +"     "+ nr.Namn+ "    "+ nr.Pris+"  " + (nr.Antal * nr.Pris));
                ;
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Total                            {0}", totaltPris);
            Console.WriteLine("Moms 12%                         {0}", (totaltPris * 0.12));
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

