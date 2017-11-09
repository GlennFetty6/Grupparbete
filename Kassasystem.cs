using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DigitCashier
{
    class Kassasystem
    {
        List<Vara> kundVagn = new List<Vara>();// Skapar en lista för kundvagn
        private int totaltPris;
        private int totalAntalVaror; // Borde kunna räkna kundVagnens antal .Contains


        private string betalningsTyp;
        private Vara valdVara;

        public void Kassa()
        {
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
            Console.WriteLine("Vald vara är {0}", valdVara.Namn);
            VaraID(helTal); // Metodanrop av VaraID
            helTal = 0;
        }

        bool CheckList(int tal) // Tittar så ID-numret finns med i varuListan.
        {
            for (var i = 0; i < Inloggning.varuLista.Count; i++)
            {
                if (Inloggning.varuLista[i].Id == tal)
                {
                    valdVara = Inloggning.varuLista[i];
                    return true;
                }
            }
            return false;
        }

        void VaraID(int id)
        {
            bool okInput = true;
            int kostnad = 0;
            int antal = 0;
            int vikt = 0;
            string input1;

            do
            {
                if (valdVara.Kategori > 0)
                {
                    Console.Write("Ange varans vikt i kilogram: ");
                    input1 = Console.ReadLine();
                    okInput = true;

                    while (Int32.TryParse(input1, out vikt) == false || vikt <= 0)
                    {
                        Console.WriteLine("Koden måste bestå av ett giltigt tvåsiffrigt heltal. Försök igen: ");
                        input1 = Console.ReadLine();
                        okInput = true;
                    }
                    valdVara.LagerStatus -= vikt;
                    valdVara.Antal = vikt;
                    kostnad = vikt * valdVara.Pris;
                    totaltPris += kostnad;

                    Console.WriteLine("{0}kg {1} kostar totalt {2}kr", vikt, valdVara.Namn, kostnad);
                }

                else
                {
                    Console.Write("Ange antal av varan {0}: ", valdVara.Namn);
                    input1 = Console.ReadLine();

                    if (Int32.TryParse(input1, out antal) == false)
                    {
                        Console.WriteLine("Inkorrekt svar.");
                        okInput = false;
                    }
                    else if (antal > valdVara.LagerStatus)
                    {
                        Console.WriteLine("För stort antal. Det finns bara {0}st {1} kvar.", valdVara.LagerStatus, valdVara.Namn);
                        okInput = false;
                        // Här kan ett SystemWrite dokument skickas till Administratör om att köpa in fler av varan
                    }
                    else
                    {
                        Console.WriteLine("{0} paket {1} är tillagd i kundvagnen", input1, valdVara.Namn);
                        valdVara.LagerStatus -= antal;
                        valdVara.Antal = antal;
                        kostnad = antal * valdVara.Pris;
                        okInput = true;
                    }
                }
            } while (okInput == false);

            kundVagn.Add(valdVara); // Lägger i vald vara i kundvagnen
            totaltPris += kostnad;

            do
            {
                Console.Write("Fler varor? j/n:  ");
                string merVaror = Console.ReadLine();

                if (merVaror == "j")
                {
                    valdVara = null;
                    KöpVara();
                    okInput = true;
                }
                else if (merVaror == "n")
                {
                    Console.WriteLine("Totalbeloppet är {0}kr", totaltPris);
                    Kupong();
                    okInput = true;
                }
                else
                {
                    Console.WriteLine("Inkorrekt svar. skriv endast 'j' eller 'n' ");
                    okInput = false;
                }
            } while (okInput == false);
        }

        void Kupong()
        {
            bool okInput = true;
            int total;

            do
            {
                Console.Write("Har kunden någon kupong? j/n: ");
                string svar = Console.ReadLine();

                if (svar == "j")
                {
                    Console.Write("Hur mycket är kupongen värd? ");
                    string input = Console.ReadLine();
                    CalcChange();
                    okInput = true;

                    while (Int32.TryParse(input, out total) == false || total <= 0)
                    {
                        Console.Write("Ange hur mycket kunden betalade: ");
                        input = Console.ReadLine();
                        CalcChange();
                    }

                    totaltPris -= total;
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
                Console.Write("Betala med kort eller kontant: ");
                string svar1 = Console.ReadLine();
                betalningsTyp = svar1;

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

        string KategoriTyp(int k)
        {
            if (k == 1)
            {
                return "Grönsak";
            }
            else
            {
                return "Matvara";
            }
        }
        void skrivUtKvitto()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nSEWK's livs");
            Console.WriteLine("Kungsgatan 37, 441 50 Alingsås");
            Console.WriteLine("Org Nr: 556033-5696\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Styck   Namn    Kategori         Pris   Total");
            Console.WriteLine("------------------------------------------");
            foreach (Vara nr in kundVagn)
            {
                Console.WriteLine(nr.Antal + "        " + nr.Namn + "    " + KategoriTyp(nr.Kategori) + "       " + nr.Pris + "     " + (nr.Antal * nr.Pris));
                totalAntalVaror += nr.Antal;
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Total                            {0}", totaltPris);
            Console.WriteLine("Moms 12%                         {0}", (totaltPris * Inloggning.moms));
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Belningstyp: {0}", betalningsTyp);
            Random verfNr = new Random();
            int nr1 = verfNr.Next(100000, 999999);
            Console.WriteLine("Kvittonummer: ", nr1);
            Console.WriteLine(DateTime.Now);
            Console.ForegroundColor = ConsoleColor.Gray;
            RapportVaror();
            FlerKunder();
        }

        void FlerKunder()
        {
            Console.Write("\nFler kunder? j/n:  ");
            string merKunder = Console.ReadLine();

            if (merKunder == "j")
            {
                Console.WriteLine("Du loggas nu ut ur kassör och återvänder till inloggningen.");
                Kassa();
            }
            else if (merKunder == "n")
            {
                Inloggning.LoggaIn();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Inkorrekt svar. skriv endast 'j' eller 'n' ");
            }            
        }

        void RapportVaror()
        {
            string rapport = AppDomain.CurrentDomain.BaseDirectory;
            Directory.CreateDirectory(rapport + "\\Rapport\\");

            using (StreamWriter writer = new StreamWriter(rapport + "\\Rapport\\TotalPris.txt", true))
            {
                writer.WriteLine(totaltPris);
            }
            using (StreamWriter writer = new StreamWriter(rapport + "\\Rapport\\TotalaVaror.txt", true))
            {
                writer.WriteLine(totalAntalVaror);
            }
        }
    }
}

