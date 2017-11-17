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
        private int totalPris;
        private int totaltBelopp; // totalPris på kvittot stämde ej då en splittade notan kupong/kort därav totaltBelopp
        private int totalAntalVaror; // Borde kunna räkna kundVagnens antal .Contains - Jaaaaa.... det kan en säkerligen

        private string betalningsTyp;
        private Vara valdVara;

        public void Kassa()
        {
            HandlaVara();
        }

        void HandlaVara()
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
                    
                    if (Int32.TryParse(input1, out vikt) == false || vikt <= 0)
                    {
                        Console.WriteLine("Koden måste bestå av ett giltigt tvåsiffrigt heltal.");
                        okInput = false;
                    }
                    else if (vikt > valdVara.LagerStatus)
                    {
                        Console.WriteLine("För stort antal. Det finns bara {0}kg {1} kvar.", valdVara.LagerStatus, valdVara.Namn);
                        okInput = false;
                    }
                    else
                    {
                        valdVara.LagerStatus -= vikt;
                        valdVara.Antal = vikt;
                        kostnad = vikt * valdVara.Pris;
                        totalPris += kostnad;
                        totaltBelopp += kostnad;
                        Console.WriteLine("{0}kg {1} kostar totalt {2}kr", vikt, valdVara.Namn, kostnad);
                        okInput = true;
                    }        
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
                    }
                    else
                    {
                        Console.WriteLine("{0} paket {1} är tillagd i kundvagnen", input1, valdVara.Namn);
                        valdVara.LagerStatus -= antal;
                        valdVara.Antal = antal;
                        kostnad = antal * valdVara.Pris;
                        totalPris += kostnad;
                        totaltBelopp += kostnad;
                        okInput = true;
                    }
                }
            } while (okInput == false);

            kundVagn.Add(valdVara); // Lägger i vald vara i kundvagnen

            do
            {
                Console.Write("Fler varor? j/n:  ");
                string merVaror = Console.ReadLine();

                if (merVaror == "j")
                {
                    valdVara = null;
                    HandlaVara();
                    okInput = true;
                }
                else if (merVaror == "n")
                {
                    Console.WriteLine("Totalbeloppet är {0}kr", totaltBelopp);
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

                   while (Int32.TryParse(input, out total) == false || total <= 0)
                    {
                        Console.Write("Hur mycket är kupongen värd? ");
                        input = Console.ReadLine();
                    }
                    totaltBelopp -= total;
                    Betalning();
                }
                else if (svar == "n")
                {
                    Betalning();
                    okInput = true;
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
            if (totaltBelopp < 0)
            {
                totaltBelopp = 0;
                Console.WriteLine("Kupongen täckte hela kostnaden. Kunden behöver inte betala något mer.");
                SkrivUtKvitto();
            }
            else
            {
                Console.WriteLine("Belopp att betala: {0}kr", totaltBelopp);
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

            while (Int32.TryParse(payed, out betalt) == false || betalt <= 0 || betalt < totaltBelopp)
            {
               totaltBelopp -= betalt;
                Console.WriteLine("Summan räcker inte till.");
                Betalning();
                payed = Console.ReadLine();
            }

            int växel = betalt - totaltBelopp;
            Console.WriteLine("{0}kr i växel.", växel);
            SkrivUtKvitto();
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
        void SkrivUtKvitto()
        {
            const string format = "{0,-8}| {1,-8} | {2,-10} | {3,-8}";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n#########################################");
            Console.WriteLine("SEWK's livs");
            Console.WriteLine("Kungsgatan 37, 441 50 Alingsås");
            Console.WriteLine("Org Nr: 556033-5696\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(String.Format(format, "Styck","Namn","Kategori","Pris","Total"));
            Console.WriteLine("------------------------------------------");
            foreach (Vara nr in kundVagn)
            {
                Console.WriteLine(String.Format(format, nr.Antal, nr.Namn, KategoriTyp(nr.Kategori), nr.Pris, (nr.Antal * nr.Pris)));
                totalAntalVaror += nr.Antal;
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Total                             {0}", totalPris);
            Console.WriteLine("Moms {0}%                          {1}",(Inloggning.moms*100), (totalPris * Inloggning.moms));
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Belningstyp: {0}", betalningsTyp);
            Random verfNr = new Random();
            int nr1 = verfNr.Next(100000, 999999);
            Console.WriteLine("Kvittonummer: {0}", nr1);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("#########################################");
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
                totaltBelopp = 0; //Måste nollställa värden för att inte få med föregående kunds varor på nästa kunds kvitto. 
                totalPris = 0;
                kundVagn.Clear();

               // Console.WriteLine("Du loggas nu ut ur kassör och återvänder till inloggningen."); Denna ska inte vara här?
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
                writer.WriteLine(totalPris);
            }
            using (StreamWriter writer = new StreamWriter(rapport + "\\Rapport\\TotalaVaror.txt", true))
            {
                writer.WriteLine(totalAntalVaror);
            }
        }
    }
}

