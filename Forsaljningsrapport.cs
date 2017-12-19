using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

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
        //int priset;
        //int varor;
        //bool okInput = false;
        //string rapport = AppDomain.CurrentDomain.BaseDirectory;

        //public void Forsaljningsrapport2()
        //{
            //const string format = "{0,-10}| {1,-10} | {2,-15} | {3,-15}";
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("\n#############################################################");
            //Console.WriteLine("Försäljningsrapport");
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine("-------------------------------------------------------------");
            //Console.WriteLine(String.Format(format, "Varunamn", "Styckpris", "Pris exkl moms", "Lagerstatus"));
            //Console.WriteLine("-------------------------------------------------------------");
            //foreach (Vara a in Inloggning.varuLista)
            //{
            //    Console.WriteLine(String.Format(format, a.Namn, a.Pris, (a.Pris * (1 - Inloggning.moms)), a.LagerStatus));
            //}
            //Console.WriteLine("-------------------------------------------------------------");
            //Console.WriteLine("Totala försäljningbeloppet: {0}kr", TotalPris());
            //Console.WriteLine("Totalt antal sålda varor: {0}st\n", TotalVaror());
            //AnstalldaInfo();
            //Console.WriteLine("###############################################################");
            //Console.ForegroundColor = ConsoleColor.Gray;

            //do
            //{
            //    Console.Write("\nVill du nollställa Försäljningsrapporten? j/n: ");
            //    string input = Console.ReadLine();

            //    if (input == "j")
            //    {
            //        Console.WriteLine("Rapporten är nu raderad");
            //        Console.WriteLine("Du loggas nu ut ur Rapportsystemet och återvänder till inloggningen.\n");
            //        File.Delete(rapport + "\\Rapport\\TotalPris.txt");// Raderar textfilen
            //        File.Delete(rapport + "\\Rapport\\TotalaVaror.txt");
            //        okInput = true;
            //    }
            //    else if (input == "n")
            //    {
            //        Console.WriteLine("Du loggas nu ut ur Rapportsystemet och återvänder till inloggningen.\n");
            //        okInput = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Inkorrekt svar. skriv endast 'j' eller 'n' ");
            //        okInput = false;
            //    }
            //} while (okInput == false);
            //Inloggning.FormLogIn();

        //}

        //public void FormRapport()
        //{
        //    Rapport rp = new Rapport();
        //    rp.SkrivUtRapport(Inloggning.varuLista, TotalPris(), TotalVaror());
        //    rp.ShowDialog();
        //}

        //public void ResetReport()
        //{
        //    File.Delete(rapport + "\\Rapport\\TotalPris.txt");// Raderar textfilen
        //    File.Delete(rapport + "\\Rapport\\TotalaVaror.txt");
        //}

        //int TotalPris()
        //{
        //    priset = 0;

        //    if ((File.Exists(rapport + "\\Rapport\\TotalPris.txt")) == true)
        //    {
        //        using (StreamReader reader = new StreamReader(rapport + "\\Rapport\\TotalPris.txt"))
        //        {
        //            string line;
        //            while ((line = reader.ReadLine()) != null)
        //            {
        //                int y = Convert.ToInt32(line);
        //                priset += y;
        //            }
        //        }
        //    }
        //    return priset;
        //}

        //int TotalVaror()
        //{
        //    varor = 0;
        //    if ((File.Exists(rapport + "\\Rapport\\TotalaVaror.txt")) == true)
        //    {
        //        using (StreamReader reader = new StreamReader(rapport + "\\Rapport\\TotalaVaror.txt"))
        //        {
        //            string line;
        //            while ((line = reader.ReadLine()) != null)
        //            {
        //                int y = Convert.ToInt32(line);
        //                varor += y;
        //            }
        //        }
        //    }
        //    return varor;
        //}
        //void AnstalldaInfo()
        //{
        //    Anstallda ans = new Anstallda();
        //    int i = 1;

        //    foreach (string file in ans.ListaAnstallda())
        //    {
        //        using (StreamReader reader = new StreamReader(file))
        //        {
        //            string anstalldNamn = reader.ReadLine();
        //            int arbTimmar = Int32.Parse(reader.ReadLine());
        //            Console.WriteLine("Anställd nr.{0}: {1}", i, anstalldNamn);
        //            Console.WriteLine("Arbetade timmar: {0}h", arbTimmar);
        //            i++;

        //        }
        //    }
        //}
    }
}
