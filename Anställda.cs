using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DigitCashier
{
    class Anställda
    { 
        string mal = AppDomain.CurrentDomain.BaseDirectory; //Tar fram den mapp .exe körs ifrån. På det viset vi kör programmet är denna map debug.
        public void LaggTillExempelAnstallda()     //Skapar filer åt våra anställda. Körs från Program.cs varje gång programmet startar. 
        {
            Directory.CreateDirectory(mal + "\\Anstallda\\"); //Skapar mappen där våra filer lägger sig. 
            //Console.WriteLine(mal); Testa denna för att se vilken folder metoden ovan hittar.
            using (StreamWriter writer = new StreamWriter(mal + "\\Anstallda\\Sara.txt", false)) //Skapar en fil för Sara i Anstalla mappen. Innehåller info om namn, arbetade timmar, befattning och timlön. 
            {                                                                                    
                writer.WriteLine("Sara");
                writer.WriteLine("32");
                writer.WriteLine("Kassör");
                writer.WriteLine("33000");
            }

            using (StreamWriter writer = new StreamWriter(mal + "\\Anstallda\\Arnold.txt", false)) //Skapar en fil för Arnold i Anstalla mappen. Innehåller info om namn, arbetade timmar, befattning och timlön. 
            {
                writer.WriteLine("Arnold");
                writer.WriteLine("70");
                writer.WriteLine("Administratör");
                writer.WriteLine("130000");
            }
        }

        public void GetAnstalld(string namn) //Kallas från Administrator.cs. Skriver ut info från den fil med samma namn som variabeln "namn".
        {
            using (StreamReader reader = new StreamReader(mal + "\\Anstallda\\" + namn + ".txt")) //Läser från .txt fil i Anstallda mappen. 
            {
                string anstalldNamn = reader.ReadLine();
                int arbTimmar = Int32.Parse(reader.ReadLine());
                string befattning = reader.ReadLine();
                int lon = Int32.Parse(reader.ReadLine());
                Console.WriteLine("Namn: " + anstalldNamn);
                Console.WriteLine("Arbetade timmar :" + arbTimmar);
                Console.WriteLine("Befattning: " + befattning);
                Console.WriteLine("Lön: " + lon);
            } 
        }

        public void SetAnstalld(string namn, int arbTimmar, string befattning, int lon) //Kallas från Administrator.cs. Används för att både ändra på och lägga till anställda. 
        {
            using (StreamWriter writer = new StreamWriter(mal + "\\Anstallda\\" + namn + ".txt", false)) //Sparar över/skapar .txt fil i mappen Anstallda. 
            {
                writer.WriteLine(namn);
                writer.WriteLine(arbTimmar);
                writer.WriteLine(befattning);
                writer.WriteLine(lon);

                Console.WriteLine("Följande anställd är tillagd");
            }
        }

        public void TaBortAnstalld (string namn) //Tar bort den fil med samma namn som "namn" i mappen Anstallda. 
        {
            File.Delete(mal + "\\Anstallda\\" + namn + ".txt");
        }

        public string[] ListaAnstallda() //Returnar en array med samtliga anställda. 
        {
            string[] anstalldLista;
            //Array[string] anstalldLista = anstalldLista = new List<string>();
            anstalldLista = Directory.GetFiles(mal + "\\Anstallda\\"); //Går in i mappen Anstallda och räknar antalet filer för att sen spara filnamn och fil path i en array. 
            return anstalldLista;
        }
    }
}
