using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{

    class Kassasystem
    {
        string[] namn = new string[5] { "Mjölk", "Kaffe", "Korv", "Ägg", "Tomat" };
        int[] varorID = new int[5] { 22, 33, 44, 55, 66 };
        int[] priser = new int[5] { 15, 70, 40, 20, 30 };
        int[] kategori = new int[5] { 0, 0, 0, 0, 1 };
        int totaltPris;

       // static void Main(string[] args)
      public void Kassa ()
        {
            AddVara();
        }

        public void VaraID(int id)
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

                totaltPris += kostnad;

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

                totaltPris += kostnad;

                Console.WriteLine("Varan kostar:" + kostnad + "kr");
                Console.WriteLine(name);
                bool okInput = true;
                do
                {
                    Console.WriteLine("Fler varor? y/n");

                    string mer = Console.ReadLine();

                    if (mer == "y")
                    {
                        AddVara();
                        okInput = true;
                    }
                    else if (mer == "n")
                    {
                        okInput = true;
                        Kupong();
                    }
                    else
                    {
                        
                        okInput = false;
                    }
                } while (okInput == false);

            }

        }

        void AddVara()
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

        void Kupong()
        {
            bool okInput = true;

            do
            {
                Console.WriteLine("Har kunden någon kupong?");

                string option = Console.ReadLine();

                if (option == "y")
                {
                    okInput = true;

                    Console.WriteLine("Hur mycket är kupongen värd?");

                    string input = Console.ReadLine();

                    int worth;

                    while (Int32.TryParse(input, out worth) == false || worth <= 0)
                    {
                        Console.WriteLine("Ange hur mycket kunden betalade");

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
            if (totaltPris < 0)
            {
                totaltPris = 0;
                Console.WriteLine("Kupongen täckte hela kostnaden. Kunden behöver inte betala något");
                //Här kör vi kvitto metoden.
                return;                          
            }

            else
            {
                Console.WriteLine("Dina prylar kostar" + totaltPris);
            }
      
            bool okInput = true;

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

            while (Int32.TryParse(payed, out betalt) == false || betalt <= 0)
            {
                Console.WriteLine("Ange hur mycket kunden betalade");

                payed = Console.ReadLine();
            }

                int change = betalt - totaltPris;
                Console.WriteLine("Kunden ska få " + change + "kr tillbaka i växel");

            //Här kör vi kvitto metoden.
        }
    }
}
