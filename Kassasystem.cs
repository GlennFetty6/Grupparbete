using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{
    class Kassasystem
    {
       
        List<Vara> kundVagn = new List<Vara>();// Skapar en lista för kundvagn
        List<Vara> varuLista = new List<Vara>();// Skapar en lista med alla varor
        private int totaltPris;

        private Vara valdVara;

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
            KöpVara();
        }

        void KöpVara()
        {
            Console.Write("Skriv in varans Id-nummer: ");
            string input = Console.ReadLine();
            int helTal;

            while (Int32.TryParse(input, out helTal) == false || helTal.ToString().Length != 2 || CheckList(helTal) == false)
            {
                Console.Write("Koden måste bestå av ett giltigt tvåsiffrigt heltal. Försök igen: ");
                input = Console.ReadLine();
            }
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
                string input1 = Console.ReadLine();
                while (Int32.TryParse(input1, out vikt) == false || vikt <= 0)
                {
                    Console.WriteLine("Koden måste bestå av ett giltigt tvåsiffrigt heltal");
                    input1 = Console.ReadLine();
                }

                kostnad = vikt * valdVara.Pris;
                totaltPris += kostnad;

                Console.WriteLine("{0}kg {1} kostar totalt {2}kr", vikt, valdVara.Namn, kostnad);
            }
            else
            {
                Console.Write("Ange antal av varan: ");
                string input2 = Console.ReadLine();

                if (Int32.TryParse(input2, out antal) == false)
                {
                    Console.Write("Inkorrekt svar. Ange antal: ");
                    input2 = Console.ReadLine();
                }
                else if (antal > valdVara.LagerStatus)
                {
                    Console.WriteLine("Varan är slut. Det finns bara {0}st {1} kvar.", valdVara.LagerStatus, valdVara.Namn);
                    // Här skall ett SystemWrite dokument skickas till Administratör om att köpa in fler av varan
                }
                Console.WriteLine("Ett paket {0} är tillagd i kundvagnen", valdVara.Namn);
                kundVagn.Add(valdVara); // Lägger i vald vara i kundvagnen
            }

            valdVara.LagerStatus -= antal;
            valdVara.Antal = antal;
            kostnad = antal * valdVara.Pris;
            totaltPris += kostnad;

            Console.Write("Fler varor? y/n:  ");
            string mer = Console.ReadLine();

            if (mer == "y")
            {
                valdVara = null;
                KöpVara();
            }
            else if (mer == "n")
            {
                Console.WriteLine("Totalbeloppet är {0}kr", totaltPris);
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
                Console.Write("Har kunden någon kupong? y/n: ");
                string svar = Console.ReadLine();

                if (svar == "y")
                {
                    Console.Write("Hur mycket är kupongen värd? ");
                    string input = Console.ReadLine();
                    okInput = true;

                    while (Int32.TryParse(input, out worth) == false || worth <= 0)
                    {
                        Console.Write("Ange hur mycket kunden betalade. ");
                        input = Console.ReadLine();
                    }

                    totaltPris -= worth;
                    Betalning();
                }
                else if (svar == "n")
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
            }

            else
            {
                Console.WriteLine("{0}kr att betala", totaltPris);               
            }

            do
            {
                Console.Write("Vill kunden betala kontant eller med kort? ");
                string svar1 = Console.ReadLine();

                if (svar1 == "kontant")
                {
                    okInput = true;
                    CalcChange();
                }
                else if (svar1 == "kort")
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
            Console.Write("Hur mycket betalade kunden: ");
            string payed = Console.ReadLine();
            int betalt;

            while (Int32.TryParse(payed, out betalt) == false || betalt <= 0 || betalt < totaltPris)
            {
               totaltPris -= betalt;
                Console.WriteLine("Summan räcker inte till. {0}kr kvar att betala.", totaltPris);
                payed = Console.ReadLine();
            }

            int växel = betalt - totaltPris;
            Console.WriteLine("{0}kr i växel.", växel);
            skrivUtKvitto();
        }

        void skrivUtKvitto()
        {
            // KRAVSPEC att ha med kategori av vara och betalningssätt...
            Console.WriteLine("\nSEWK's livs");
            Console.WriteLine("Kungsgatan 37, 441 50 Alingsås");
            Console.WriteLine("Org Nr: 556033-5696\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Styck   Namn             Pris   Total");
            Console.WriteLine("------------------------------------------");
            foreach (Vara nr in kundVagn)
            {
                Console.WriteLine(nr.Antal +"     "+ nr.Namn+ "    "+ nr.Pris+"  " + (nr.Antal * nr.Pris));                
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Total                            {0}", totaltPris);
            Console.WriteLine("Moms 12%                         {0}", (totaltPris * 0.12));
            Console.WriteLine("------------------------------------------");
            Random verfNr = new Random();
            int nr1 = verfNr.Next(100000, 999999);
            Console.WriteLine("Kvittonummer: ", nr1);
            Console.WriteLine(DateTime.Now);
        }
    }
}

