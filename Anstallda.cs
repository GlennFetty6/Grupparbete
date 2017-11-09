using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DigitCashier
{
    class Anstallda
    { 
        string malMapp = AppDomain.CurrentDomain.BaseDirectory; //Tar fram den mapp .exe körs ifrån. På det viset vi kör programmet är denna map debug.
        public void LaggTillExempelAnstallda() //Skapar filer åt våra anställda
        {
            Directory.CreateDirectory(malMapp + "\\Anstallda\\"); //Skapar mappen där våra filer lägger sig.             
            using (StreamWriter writer = new StreamWriter(malMapp + "\\Anstallda\\Sara.txt", false)) // Skriver in information i Anställda
            {
                writer.WriteLine("Sara");
                writer.WriteLine("37");
                writer.WriteLine("Kassör");
                writer.WriteLine("119");
            }

            using (StreamWriter writer = new StreamWriter(malMapp + "\\Anstallda\\Arnold.txt", false))
            {
                writer.WriteLine("Arnold");
                writer.WriteLine("60");
                writer.WriteLine("Administratör");
                writer.WriteLine("170");
            }
        }

        public void GetAnstalld(string namn)
        {
            using (StreamReader reader = new StreamReader(malMapp + "\\Anstallda\\" + namn + ".txt")) // Läser upp informationen om den angivna anställda.
            {
                string anstalldNamn = reader.ReadLine();
                int arbTimmar = Int32.Parse(reader.ReadLine());
                string befattning = reader.ReadLine();
                int lon = Int32.Parse(reader.ReadLine());
                Console.WriteLine("Namn: {0}" , anstalldNamn);
                Console.WriteLine("Arbetade timmar: {0}" , arbTimmar);
                Console.WriteLine("Befattning: {0}" , befattning);
                Console.WriteLine("Lön: {0}kr" , lon);
            } 
        }

        public void ModifieraAnstalld(string namn, int arbTimmar, string befattning, int lon) // Lägger till en ny anställd
        {
            using (StreamWriter writer = new StreamWriter(malMapp + "\\Anstallda\\" + namn + ".txt", false))
            {
                writer.WriteLine(namn);
                writer.WriteLine(arbTimmar);
                writer.WriteLine(befattning);
                writer.WriteLine(lon);
                Console.WriteLine("Följande anställd är tillagd");
            }
        }

        public void TaBortAnstalld (string namn) // Tar bort den angivnes (namn) information - Sparkad.
        {
            File.Delete(malMapp + "\\Anstallda\\" + namn + ".txt");
            Console.WriteLine("{0} är sparkad." , namn);
        }

        public string[] ListaAnstallda()
        {
            string[] anstalldLista;
            anstalldLista = Directory.GetFiles(malMapp + "\\Anstallda\\");
            return anstalldLista;
        }
    }
}
