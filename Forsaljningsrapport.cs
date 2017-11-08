using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DigitCashier
{

    // Rapporten ska innehålla varansnamn, datum, antal sålda varor, försäljningen summa, namn och timmar på de arbetade anställda.
    // Rapporten Skall kunna sorteras med datum och tidsintervall
    // Identifiera lagerstatus för varje vara
    // Visa beställningspunkter för varje vara och leverantör namn
    // Generera prislistorna inklusive och exklusive moms
    // Generera en lista över varugruppsspecificerad struktur

    class Forsaljningsrapport
    {
        int priset;
        int varor;
        bool okInput = false;
        string rapport = AppDomain.CurrentDomain.BaseDirectory;

        public void Forsaljningsrapport2()
        {
            Console.WriteLine("######################################################################");
            Console.WriteLine("Försäljningsrapport");
            Console.WriteLine(DateTime.Now);

            foreach (Vara a in Inloggning.varuLista)
            {
                Console.WriteLine("Namn:{0} |Lagerstatus:{1} |Pris inkl.moms:{2}kr |Pris exkl.moms:{3}kr", a.Namn, a.LagerStatus, a.Pris, (a.Pris * (1 - Inloggning.moms)));
            }
            Console.WriteLine("Total försäljningbeloppet är {0}kr", TotalPris());
            Console.WriteLine("Totalt antal sålda varor är {0}st", TotalVaror());
            AnstalldaInfo();
            Console.WriteLine("######################################################################");


            do
            {
                Console.Write("\nVill du nollställa Försäljningsrapporten? j/n: ");
                string input = Console.ReadLine();

                if (input == "j")
                {
                    File.Delete(rapport + "\\Rapport\\TotalPris.txt");
                    File.Delete(rapport + "\\Rapport\\TotalaVaror.txt");
                  
                    okInput = true;
                }
                else if (input == "n")
                {
                    okInput = true;
                }
                else
                {
                    Console.WriteLine("Inkorrekt svar. skriv endast 'j' eller 'n' ");
                    okInput = false;
                }
            } while (okInput == false);
            Console.ReadKey();
            Inloggning.Inloggning2();

        }

        int TotalPris()
        {
            priset = 0;

            if ((File.Exists(rapport + "\\Rapport\\TotalPris.txt")) == true)
            {
                using (StreamReader reader = new StreamReader(rapport + "\\Rapport\\TotalPris.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int y = Convert.ToInt32(line);
                        priset += y;
                    }
                }
            }
            return priset;
        }

        int TotalVaror()
        {
            varor = 0;
            if ((File.Exists(rapport + "\\Rapport\\TotalaVaror.txt")) == true)
            {
                using (StreamReader reader = new StreamReader(rapport + "\\Rapport\\TotalaVaror.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int y = Convert.ToInt32(line);
                        varor += y;
                    }
                }
            }
            return varor;
        }
        void AnstalldaInfo()
        {
            Anstallda ans = new Anstallda();
            int i = 1;

            foreach (string file in ans.ListaAnstallda())
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string anstalldNamn = reader.ReadLine();
                    int arbTimmar = Int32.Parse(reader.ReadLine());
                    Console.WriteLine("Anställd nr.{0} {1}", i , anstalldNamn);
                    Console.WriteLine("Arbetade timmar: {0}", arbTimmar);
                    i++;
                 
                }
            }
        }
    }
}
